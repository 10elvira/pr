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
    public partial class Postavchik : Form
    {
        public Postavchik()
        {
            InitializeComponent();
        }

        private void Postavchik_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.Postavchik". При необходимости она может быть перемещена или удалена.
            this.postavchikTableAdapter.Fill(this.myDBDataSet.Postavchik);
        }

        private void BTN_del_Click(object sender, EventArgs e)
        {
            postavchikBindingSource.RemoveCurrent();
            postavchikBindingSource.EndEdit();
                postavchikTableAdapter.Update(this.myDBDataSet.Postavchik);
        }

        private void BTN_add_Click(object sender, EventArgs e)
        {
           ADD_Postavchik add_post = new ADD_Postavchik();
            postavchikBindingSource.AddNew();
            add_post.postavchikBindingSource.DataSource = postavchikBindingSource;
            add_post.postavchikBindingSource.Position = postavchikBindingSource.Position;
            if (add_post.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                postavchikTableAdapter.Update(this.myDBDataSet.Postavchik);
        }

        private void BTN_upd_Click(object sender, EventArgs e)
        {
            ADD_Postavchik add_post = new ADD_Postavchik();
            add_post.postavchikBindingSource.DataSource = postavchikBindingSource;
            add_post.postavchikBindingSource.Position = postavchikBindingSource.Position;
            if (add_post.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                postavchikTableAdapter.Update(this.myDBDataSet.Postavchik);
        }
    }
}
