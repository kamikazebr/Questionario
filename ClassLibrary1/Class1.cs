﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public class Class1:Panel
    {
        public MyList<string> _lista = new MyList<string>();

        public MyList<string> _visiveis = new MyList<string>();

        public Dictionary<string,RadioButton> Radios {get;set;}


        [Editor(@"System.Windows.Forms.Design.StringCollectionEditor," +
        "System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
       typeof(System.Drawing.Design.UITypeEditor))]
        [DesignerSerializationVisibility(
            DesignerSerializationVisibility.Content)]
        public MyList<string> Lista
        {
            get
            {
                return _lista;
            }
            
            set{
                _lista = value;
               
            }
        }

        [Editor(@"System.Windows.Forms.Design.StringCollectionEditor," +
        "System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
       typeof(System.Drawing.Design.UITypeEditor))]
        [DesignerSerializationVisibility(
            DesignerSerializationVisibility.Content)]
        public MyList<string> Visiveis
        {
            get
            {
                return _visiveis;
            }

            set
            {
                _visiveis = value;
            
            }
        }


        [DesignerSerializationVisibility(
           DesignerSerializationVisibility.Hidden)]
        List<string> listVis = new List<string>();

        public Class1():base()
        {
            Init();
            Lista.ListChanged += new ListChangedEventHandler(Lista_ListChanged);
            Visiveis.ListChanged += new ListChangedEventHandler(Lista_ListChanged);
        }

        void Lista_ListChanged(object sender, ListChangedEventArgs e)
        {
            InitializeComponent();
        }

     

        public void Init(){
            //IComponentChangeService service = GetService(typeof(IComponentChangeService)) as IComponentChangeService;
            
            //service.ComponentChanged +=  new ComponentChangedEventHandler(service_ComponentChanged);

            InitializeComponent();
        }

        private void InitializeComponent()
        {

          
            Console.WriteLine("InitializeComponent");
            this.SuspendLayout();
            
            this.Controls.Clear();

            //listVis.Clear();
            Radios = new Dictionary<string,RadioButton>();

            int w = 104;
            int h = 24;

            for (int i = 0; i < _lista.Count; i++)
            {
                string posString = String.Format("{0}", i + 1);
                Point p = new System.Drawing.Point(0, 0);
                Size s = new System.Drawing.Size(w, h);
                string name = String.Format("RadioButton{0}", i + 1);
                RadioButton rb = criarRadioButton(name, _lista.ElementAt<string>(i), p, s);
                Radios.Add(posString, rb);
            }


            for (int i = 0; i < _visiveis.Count; i++)
            {
                //string posString = String.Format("{0}",i+1);
                Point p = new System.Drawing.Point(0, i * h);
                RadioButton rb = Radios[_visiveis[i]];
                rb.Location = p;
                this.Controls.Add(rb);
            }
            this.PerformLayout();
            this.ResumeLayout(true);

        }

        private RadioButton criarRadioButton(string name,string text,Point point ,Size size)
        {
            RadioButton radioButton1 = new System.Windows.Forms.RadioButton();
            radioButton1.AutoSize = true;
            radioButton1.Location = point;
            radioButton1.Name = name;
            radioButton1.Size = size;
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = text;
            radioButton1.UseVisualStyleBackColor = true;
            return radioButton1;
        }


     
       
    }
    using CustomExtensions;
    public class MyList<T> : BindingList<T>
    {

        public void AddRange(T[] p)
        {
            for (int i = 0; i < p.Length; i++)
            {
                base.Add(p[i]);
            }
        }
       
    }
}

namespace CustomExtensions
{
    public static class MyExtensions
    {
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = ThreadSafeRandom.ThisThreadsRandom.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public static class ThreadSafeRandom
        {
            [ThreadStatic]
            private static Random Local;

            public static Random ThisThreadsRandom
            {
                get { return Local ?? (Local = new Random(unchecked(Environment.TickCount * 31 + Thread.CurrentThread.ManagedThreadId))); }
            }
        }
    }
}

