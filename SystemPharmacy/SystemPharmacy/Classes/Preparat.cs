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
    public partial class Preparat : Form
    {
        public Preparat()
        {
            InitializeComponent();
        }

        private void Preparat_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.preparatDGV". При необходимости она может быть перемещена или удалена.
           // this.preparatDGVTableAdapter.Fill(this.myDBDataSet.preparatDGV);


        }

        private void BTN_del_Click(object sender, EventArgs e)
        {/*
            preparatDGVBindingSource.RemoveCurrent();
            preparatDGVBindingSource.EndEdit();
            preparatDGVTableAdapter.Update(this.myDBDataSet.preparatDGV);*/
        }

        private void BTN_add_Click(object sender, EventArgs e)
        {/*
            ADD_Preparat add_pr = new ADD_Preparat();
            preparatDGVBindingSource.AddNew();
            add_pr.preparatBindingSource.DataSource = preparatDGVBindingSource;
            add_pr.preparatBindingSource.Position = preparatDGVBindingSource.Position;
            if (add_pr.ShowDialog() == DialogResult.OK)
            { preparatDGVTableAdapter.Update(myDBDataSet.preparatDGV);
            this.preparatDGVTableAdapter.Fill(this.myDBDataSet.preparatDGV);
            }*/
        }

        private void BTN_upd_Click(object sender, EventArgs e)
        {/*
            ADD_Preparat add_pr = new ADD_Preparat();
            add_pr.preparatBindingSource.DataSource = preparatDGVBindingSource;
            add_pr.preparatBindingSource.Position = preparatDGVBindingSource.Position;
            if (add_pr.ShowDialog() == DialogResult.OK)
            {
                preparatDGVTableAdapter.Update(myDBDataSet.preparatDGV);
                this.preparatDGVTableAdapter.Fill(this.myDBDataSet.preparatDGV);
            }*/
        }
    }
}
