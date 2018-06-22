using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KrallSamantha_PP2
{
    public partial class pizzaForm : Form
    {
        public pizzaForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            string selected;
            selected = shapeLB.SelectedItem.ToString();
            string pSmall;
            string pMed;
            string pLg;
            string xCheese;
            string xSauce;
            string pep;
            string sausage;
            string pineapple;
            string gPep;
            string shroom;
            string olives;
            if (smallButton.Checked)
            {
                pSmall = " Small ";
            }
            else
            {
                pSmall = null;
            }
            if (medButton.Checked)
            {
                pMed = " Medium ";
            }
            else
            {
                pMed = null;
            }
            if (lgButton.Checked)
            {
                pLg = " Large ";
            }
            else
            {
                pLg = null;
            }
            if (xchsCB.Checked)
            {
                xCheese = " Extra Cheese ";
            }
            else
            {
                xCheese = null;
            }
            if (xsauseCB.Checked)
            {
                xSauce = " Extra Sauce ";
            }
            else
            {
                xSauce = null;
            }
            if (pepCB.Checked)
            {
                pep = " Pepperoni ";
            }
            else
            {
                pep = null;
            }
            if (sausageCB.Checked)
            {
                sausage = " Sausage ";
            }
            else
            {
                sausage = null;
            }
            if (pineappleCB.Checked)
            {
                pineapple = " Pineapple ";
            }
            else
            {
                pineapple = null;
            }
            if (gpCB.Checked)
            {
                gPep = " Green Peppers ";
            }
            else
            {
                gPep = null;
            }
            if (shroomCB.Checked)
            {
                shroom = " Mushrooms ";
            }
            else
            {
                shroom = null;
            }
            if (oliveCB.Checked)
            {
                olives = " Olives ";
            }
            else
            {
                olives = null;
            }
            MessageBox.Show("You have ordered a " + pSmall + pMed + pLg
                + " " + selected + " with the following toppings: " + xCheese
                + xSauce + pep + sausage + pineapple + gPep + shroom + olives);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            smallButton.Checked = false;
            medButton.Checked = false;
            lgButton.Checked = false;
            xchsCB.Checked = false;
            xsauseCB.Checked = false;
            pepCB.Checked = false;
            sausageCB.Checked = false;
            pineappleCB.Checked = false;
            gpCB.Checked = false;
            shroomCB.Checked = false;
            oliveCB.Checked = false;
        }

        private void smallButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
