using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuteDucksAdoption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double qtt = 0, aTPay;

        private void btnMore_Click(object sender, EventArgs e)
        {
            qtt += 1;
            lblQuantity.Text = "Quantity: " + qtt;
            changeValue();
        }

        private void btnLess_Click(object sender, EventArgs e)
        {
            if(qtt != 0)
            {
                qtt -= 1;
                lblQuantity.Text = "Quantity: " + qtt;
                changeValue();
            }
        }
        private void changeValue()
        {
            aTPay = 13.99 * qtt;
            lblAmountToPay.Text = "Amount to pay U$: " +aTPay;
        }
    }
}
