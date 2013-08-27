using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    using CustomExtensions;
    public class Class1:Panel
    {
        public MyList<string> _lista = new MyList<string>();

        public MyList<string> _visiveis = new MyList<string>();

        [Browsable(false)]
        private Dictionary<string,RadioButton> _radios = new Dictionary<string,RadioButton>();

       [Browsable(false)]
        [DesignerSerializationVisibility(
            DesignerSerializationVisibility.Hidden)]
        public Dictionary<string, RadioButton> Radios
        {
            get
            {
                return _radios;
            }

            set
            {
                _radios = value;

            }
        }

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
                InitializeComponent(); ;
               
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
                InitializeComponent();
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
            //Console.WriteLine("InitializeComponent");
           

            //listVis.Clear();
            Radios = new Dictionary<string,RadioButton>();

            if (_lista.Count == 0)
            {
                return;
            }
            this.SuspendLayout();

            this.Controls.Clear();
            int w = 104;
            int h = 24;

            for (int i = 0; i < _lista.Count; i++)
            {
                string posString = String.Format("{0}", i + 1);
                Point p = new System.Drawing.Point(0, 0);
                Size s = new System.Drawing.Size(w, h);
                string name = String.Format("RadioButton{0}", i + 1);
                RadioButton rb = criarRadioButton(name, _lista.ElementAt<string>(i), p, s);
                _radios.Add(posString, rb);
            }


            //if (_visiveis.Count == 0)
            //{
            //    for (int i = 1; i <= _lista.Count; i++)
            //    {
            //        _visiveis.Add(i.ToString());
            //    }
            //}

            for (int i = 0; i < _visiveis.Count; i++)
            {
                //string posString = String.Format("{0}",i+1);

                string[] part = _visiveis[i].Split("-".ToCharArray());
               
                RadioButton rb = _radios[_visiveis[i]];

                if (i > 0)
                {
                    h = _radios[_visiveis[i-1]].Size.Height;
                }

                Point p = new System.Drawing.Point(0, i * h);
              
                rb.Location = p;
                
                
                this.Controls.Add(rb);

                if (part.Length > 1)
                {
                    Point pT = new System.Drawing.Point(rb.Size.Width + 15, i * h);
                    this.Controls.Add(criarTextBox(String.Format("TextBox{0}", i + 1), "", pT, new Size(this.Size.Width - rb.Size.Width, h)));
               
                }
               
            }
            this.PerformLayout();
            this.ResumeLayout(true);

        }

        private RadioButton criarRadioButton(string name,string text,Point point ,Size size)
        {
            RadioButton radioButton1 = new System.Windows.Forms.RadioButton();
            radioButton1.MaximumSize = new Size(this.Size.Width, 0);
            radioButton1.Location = point;
            radioButton1.Name = name;
            radioButton1.Size = size;
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = text;
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.AutoSize = true;
            return radioButton1;
        }

        private TextBox criarTextBox(string name, string text, Point point, Size size)
        {
            TextBox radioButton1 = new System.Windows.Forms.TextBox();
            //radioButton1.AutoSize = true;
            
            radioButton1.Location = point;
            radioButton1.Name = name;
            radioButton1.Size = size;
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = text;
            //radioButton1.UseVisualStyleBackColor = true;
            return radioButton1;
        }

     
       
    }
   
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

