using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQLdataAdapterApp
{
    public partial class invulForm : Form
    {
        mainForm mf =  new mainForm();
        int stock;
        bool beschikbaar = false;

        public invulForm(mainForm mainForm)
        {
            InitializeComponent();
            this.mf = mainForm;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (int.TryParse(StockTextBox.Text, out stock))
            {
                mf.productNaam = ProductNaamBox.Text;
                mf.stock = stock;
                mf.beschikbaar = beschikbaar;
                this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Geen tekst in stock!");
            
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void BeschikbaarCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (BeschikbaarCheckBox.Checked)
            {
                beschikbaar = true;
            }
            else
                beschikbaar = false;
        }

     
    }
}
