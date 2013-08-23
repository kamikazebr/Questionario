using System;
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
        public List<string> _lista = new List<string>();

        public List<string> _visiveis = new List<string>();

        public Dictionary<string,RadioButton> Radios {get;set;}


        [Editor(@"System.Windows.Forms.Design.StringCollectionEditor," +
        "System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
       typeof(System.Drawing.Design.UITypeEditor))]
        [DesignerSerializationVisibility(
            DesignerSerializationVisibility.Content)]
        public List<string> Lista
        {
            get
            {
                return _lista;
            }
            
            set{
                _lista = value;
                InitializeComponent();
            }
        }

        [Editor(@"System.Windows.Forms.Design.StringCollectionEditor," +
        "System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
       typeof(System.Drawing.Design.UITypeEditor))]
        [DesignerSerializationVisibility(
            DesignerSerializationVisibility.Content)]
        public List<string> Visiveis
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


            //foreach (string vis in _visiveis)
            //{
            //    int inteiro = Int16.Parse(vis);
            //    if (inteiro > 0)
            //    {
            //        inteiro--;
            //    }

            //    listVis.Add(_lista.ElementAt(inteiro));
            //}

            //if (_visiveis == null)
            //{
            //    listVis = _lista;
            //}

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

        void service_ComponentChanged(object sender, ComponentChangedEventArgs e)
        {
            InitializeComponent();       
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
}
