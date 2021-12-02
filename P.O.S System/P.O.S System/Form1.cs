using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P.O.S_System
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }
        int price;
        private void PatetesCB_CheckedChanged(object sender, EventArgs e)
        {
            if (PatetesCB.Checked)
                PatatesStock.Enabled = true;
            else
                PatatesStock.Enabled = false;
        }
        int i = 0;
        private void HamburgerCB_CheckedChanged(object sender, EventArgs e)
        {
            if (HamburgerCB.Checked)
                HamburgerStock.Enabled = true;
            else
                HamburgerStock.Enabled = false;
        }

        private void PizzaCB_CheckedChanged(object sender, EventArgs e)
        {
            if (PizzaCB.Checked)
                PizzaStock.Enabled = true;
            else
                PizzaStock.Enabled = false;
        }

        private void TavukCB_CheckedChanged(object sender, EventArgs e)
        {
            if (TavukCB.Checked)
                TavukStock.Enabled = true;
            else
                TavukStock.Enabled = false;
        }

        private void EtCB_CheckedChanged(object sender, EventArgs e)
        {
            if (EtCB.Checked)
                EtStock.Enabled = true;
            else
                EtStock.Enabled = false;
        }

        private void SalataCB_CheckedChanged(object sender, EventArgs e)
        {
            if (SalataCB.Checked)
                SalataStock.Enabled = true;
            else
                SalataStock.Enabled = false;
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            if (PatetesCB.Checked)
            {
                TableofSelected.Rows.Add(PatatesStock.Text, "Patates", 20 * Int32.Parse(PatatesStock.Text));
                price += 20* Int32.Parse(PatatesStock.Text);
                i++;
                PatetesCB.Checked = false;
                PatatesStock.Text = "0";
            }
            if (SalataCB.Checked)
            {
                TableofSelected.Rows.Add(SalataStock.Text, "Salata", 20 * Int32.Parse(SalataStock.Text));
                price += 20 * Int32.Parse(SalataStock.Text);
                i++;
                SalataCB.Checked = false;
                SalataStock.Text = "0";
            }
            if (HamburgerCB.Checked)
            {
                TableofSelected.Rows.Add(HamburgerStock.Text, "Hamburger", 20 * Int32.Parse(HamburgerStock.Text));
                price += 20 * Int32.Parse(HamburgerStock.Text);
                i++;
                HamburgerCB.Checked = false;
                HamburgerStock.Text = "0";
            }
            if (EtCB.Checked)
            {
                TableofSelected.Rows.Add(EtStock.Text, "Et", 20 * Int32.Parse(EtStock.Text));
                price += 20 * Int32.Parse(EtStock.Text);
                i++;
                EtCB.Checked = false;
                EtStock.Text = "0";
            }
            if (PizzaCB.Checked)
            {

                TableofSelected.Rows.Add(PizzaStock.Text, "Pizza", 20 * Int32.Parse(PizzaStock.Text));
                price += 20 * Int32.Parse(PizzaStock.Text);
          
                i++;
                PizzaCB.Checked = false;
                PizzaStock.Text = "0";
            }
            if (TavukCB.Checked)
            {

                TableofSelected.Rows.Add(TavukStock.Text, "Tavuk", 20 * Int32.Parse(TavukStock.Text));
                price += 20 * Int32.Parse(TavukStock.Text);
                i++;
                TavukCB.Checked = false;
                TavukStock.Text = "0";
            }
            Calculate();
        }
        private void Calculate()
        {
            Total.Text = "Total: " + price;
        }
        private void Reset_Click(object sender, EventArgs e)
        {
            TableofSelected = null;
            price = 0;
            Calculate();
        }
    }
}
