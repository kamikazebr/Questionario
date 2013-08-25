using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections;
using System.ComponentModel.Design;
using System.Diagnostics;

using System.Drawing.Design;

using System.Reflection;
using System.Runtime.Serialization;

using System.Windows.Forms.Design;
using System.Windows.Forms.Design.Behavior;
namespace WindowsFormsControlLibrary1
{
    [DesignerAttribute(typeof(UserControlDesign))]
    public partial class UserControl1 : Control
    {

        public BindingList<string> _lista = new BindingList<string>();
        public BindingList<string> _visiveis = new BindingList<string>();

 

        [Editor(@"System.Windows.Forms.Design.StringCollectionEditor," +
        "System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
       typeof(System.Drawing.Design.UITypeEditor))]
        [DesignerSerializationVisibility(
            DesignerSerializationVisibility.Content)]
        [Category("Data")]
        [Browsable(true)]
        public BindingList<string> Lista
        {
            get
            {
                return _lista;
            }

            set
            {
                MessageBox.Show("Teste");
                _lista = value;
                //InitializeComponent();
            }
        }

        [Editor(@"System.Windows.Forms.Design.StringCollectionEditor," +
        "System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
       typeof(System.Drawing.Design.UITypeEditor))]
        [DesignerSerializationVisibility(
            DesignerSerializationVisibility.Content)]
        public BindingList<string> Visiveis
        {
            get
            {
                return _visiveis;
            }

            set
            {
                _visiveis = value;
                //Invalidate();
                //InitializeComponent();
            }
        }
        public UserControl1()
        {
            InitializeComponent();
            Lista.ListChanged += new ListChangedEventHandler(Lista_ListChanged);
            Visiveis.ListChanged += new ListChangedEventHandler(Lista_ListChanged);
        }

        void Lista_ListChanged(object sender, ListChangedEventArgs e)
        {
            InitializeComponent();
        }

        protected override void OnInvalidated(InvalidateEventArgs e)
        {
            base.OnInvalidated(e);
            
            //InitializeComponent();
        }
    }



    public class UserControlDesign : ControlDesigner
    {
        private IComponentChangeService changeService = null;

        public UserControlDesign()
        {

            // Acquire a reference to IComponentChangeService. 
            this.changeService =
                GetService(typeof(IComponentChangeService))
                as IComponentChangeService;

            // Hook the IComponentChangeService events. 
            if (this.changeService != null)
            {
                this.changeService.ComponentChanged +=
                    new ComponentChangedEventHandler(
                    ChangeService_ComponentChanged);

                this.changeService.ComponentAdded +=
                    new ComponentEventHandler(
                    ChangeService_ComponentAdded);

                this.changeService.ComponentRemoved +=
                    new ComponentEventHandler(
                    changeService_ComponentRemoved);
            }
        }

        void ChangeService_ComponentChanged(
        object sender,
        ComponentChangedEventArgs e)
        {
            string msg = String.Format(
                "{0}, {1}", e.Component, e.Member);

            MessageBox.Show(msg, "ComponentChanged");
        }

        void ChangeService_ComponentAdded(
            object sender,
            ComponentEventArgs e)
        {
            MessageBox.Show(
                e.Component.ToString(),
                "ComponentAdded");
        }

        void changeService_ComponentRemoved(
            object sender,
            ComponentEventArgs e)
        {
            MessageBox.Show(
                e.Component.ToString(),
                "ComponentRemoved");
        }
    }
}
