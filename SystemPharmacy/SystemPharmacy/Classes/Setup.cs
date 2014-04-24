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
    public partial class Setup : Form
    {
        public Setup()
        {
            InitializeComponent();
        }

        private void Setup_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.PreparatSetupDGV". При необходимости она может быть перемещена или удалена.
            this.preparatSetupTableAdapter.Fill(this.myDBDataSet.PreparatSetupDGV);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.Setup". При необходимости она может быть перемещена или удалена.
            this.setupTableAdapter.Fill(this.myDBDataSet.Setup);
        }

        private void BTN_del_Click(object sender, EventArgs e)
        {
          setupBindingSource.RemoveCurrent();
            setupBindingSource.EndEdit();
            setupTableAdapter.Update(this.myDBDataSet.Setup);
        }

        private void BTN_add_Click(object sender, EventArgs e)
        {
           ADD_setup add_set = new ADD_setup();
            setupBindingSource.AddNew();
            add_set.setupBindingSource.DataSource = setupBindingSource;
            add_set.setupBindingSource.Position = setupBindingSource.Position;
            if (add_set.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                setupTableAdapter.Update(this.myDBDataSet.Setup);
        }

        private void BTN_upd_Click(object sender, EventArgs e)
        {
            ADD_setup add_set = new ADD_setup();
            add_set.setupBindingSource.DataSource = setupBindingSource;
            add_set.setupBindingSource.Position = setupBindingSource.Position;
            if (add_set.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                setupTableAdapter.Update(this.myDBDataSet.Setup);
        }

        private void BTN_add1_Click(object sender, EventArgs e)
        {
            ADD_preparat_setup pr = new ADD_preparat_setup();
            preparatSetupDGVBindingSource.AddNew();
            pr.preparatBindingSource.DataSource = preparatSetupDGVBindingSource;
            pr.preparatBindingSource.Position = preparatSetupDGVBindingSource.Position;
            if (pr.ShowDialog() == DialogResult.OK)
            {
                preparatSetupTableAdapter.Update(myDBDataSet.PreparatSetupDGV);
                this.preparatSetupTableAdapter.Fill(this.myDBDataSet.PreparatSetupDGV);
            }
        }

        private void DTN_upd1_Click(object sender, EventArgs e)
        {
            ADD_preparat_setup pr = new ADD_preparat_setup();
            pr.preparatBindingSource.DataSource = preparatSetupDGVBindingSource;
            pr.preparatBindingSource.Position = preparatSetupDGVBindingSource.Position;
            if (pr.ShowDialog() == DialogResult.OK)
            {
                preparatSetupTableAdapter.Update(myDBDataSet.PreparatSetupDGV);
                this.preparatSetupTableAdapter.Fill(this.myDBDataSet.PreparatSetupDGV);
            }
        }

        private void BTN_del1_Click(object sender, EventArgs e)
        {
            preparatSetupDGVBindingSource.RemoveCurrent();

            preparatSetupDGVBindingSource.EndEdit();
            this.preparatSetupTableAdapter.Fill(this.myDBDataSet.PreparatSetupDGV);
        }
    }
}
