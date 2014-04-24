using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SystemPharmacy
{
    public partial class Group : Form
    {
        public Group()
        {
            InitializeComponent();
        }

        private void Group_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.Group". При необходимости она может быть перемещена или удалена.
            this.groupTableAdapter.Fill(this.myDBDataSet.Group);
        }

        private void BTN_del_Click(object sender, EventArgs e)
        {
            groupBindingSource.RemoveCurrent();
            groupBindingSource.EndEdit();
            groupTableAdapter.Update(this.myDBDataSet.Group);
        }

        private void BTN_add_Click(object sender, EventArgs e)
        {
            ADD_group group = new ADD_group();
            groupBindingSource.AddNew();
            group.groupBindingSource.DataSource = groupBindingSource;
            group.groupBindingSource.Position = groupBindingSource.Position;
            if (group.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                groupTableAdapter.Update(this.myDBDataSet.Group);
        }

        private void BTN_upd_Click(object sender, EventArgs e)
        {
            ADD_group group = new ADD_group();
            group.groupBindingSource.DataSource = groupBindingSource;
            group.groupBindingSource.Position = groupBindingSource.Position;
            if (group.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                groupTableAdapter.Update(this.myDBDataSet.Group);
        }
    }
}
