using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors;
using System.ComponentModel;

namespace NewProject
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindingList<MyObject> source = CreateDataSource();

            PopupContainerEditHelper helper1 = new PopupContainerEditHelper(popupContainerEdit1.Properties);
            helper1.DataSource = source;
            helper1.DisplayMember = "Name";
            helper1.ValueMember = "Age";
            popupContainerEdit1.Properties.EditValueChanged += new EventHandler(popupContainerEdit1Properties_EditValueChanged);


            PopupContainerEditHelper helper2 = new PopupContainerEditHelper(popupContainerEdit2.Properties);
            for (int j = 0; j < source.Count; j++)
            {
                helper2.Items.Add(source[j]);
                helper2.Items[j].Description = String.Format("Item {0}", j);
            }
            popupContainerEdit2.Properties.EditValueChanged += new EventHandler(Properties_EditValueChanged);

        }

        void Properties_EditValueChanged(object sender, EventArgs e)
        {
            PopupContainerEdit popupContainerEdit = sender as PopupContainerEdit;
            listBox2.DataSource = popupContainerEdit.EditValue;
        }

        void popupContainerEdit1Properties_EditValueChanged(object sender, EventArgs e)
        {
            PopupContainerEdit popupContainerEdit = sender as PopupContainerEdit;
            listBox1.DataSource = popupContainerEdit.EditValue;
        }

        private BindingList<MyObject> CreateDataSource()
        {
            BindingList<MyObject> source = new BindingList<MyObject>();

            for (int i = 0; i < 10; i++)
                source.Add(new MyObject()
                {
                    Name = String.Format("Name {0}", i),
                    Age = i,
                });

            return source;
        }
    }
}
