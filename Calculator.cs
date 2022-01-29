using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1._0
{
    public partial class Calculator : Form
    {
        double cashValue = 0;
        string operation = "";
        bool isOperationPerformed = false;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Bt_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if ((tbResult.Text == "0") || (isOperationPerformed))
            {
                //tbResult.Text = "";
                tbResult.Clear();
            }
            if (button.Text == ",")
            {
                if (!tbResult.Text.Contains(","))
                    tbResult.Text += ",";
            } else 
                tbResult.Text += button.Text;
            isOperationPerformed = false;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            //tbResult.Text = "";
            if (cashValue != 0)
            {
                BtEq.PerformClick();
                //cashValue = Double.Parse(tbResult.Text);
                operation = bt.Text;
                isOperationPerformed = true;
                label1.Text = cashValue + " " + operation;
            }
            else
            {
                cashValue = Double.Parse(tbResult.Text);
                operation = bt.Text;
                isOperationPerformed = true;
                label1.Text = cashValue + " " + operation;
            }
        }

        private void BtEq_Click(object sender, EventArgs e)
        {
            label1.Text += tbResult.Text;
            switch (operation)
            {
                case "+": tbResult.Text = (cashValue + Double.Parse(tbResult.Text)).ToString(); break;
                case "-": tbResult.Text = (cashValue - Double.Parse(tbResult.Text)).ToString(); break;
                case "*": tbResult.Text = (cashValue * Double.Parse(tbResult.Text)).ToString(); break;
                case "/": tbResult.Text = (cashValue / Double.Parse(tbResult.Text)).ToString(); break;
                default: break;
            }
            cashValue = Double.Parse(tbResult.Text);
            //label1.Text = "";
        }

        private void BtCE_Click(object sender, EventArgs e)
        {
            tbResult.Text = "0";
        }

        private void BtC_Click(object sender, EventArgs e)
        {
            tbResult.Text = "0";
            cashValue = 0;
            label1.Text = "";
        }
    }
}
