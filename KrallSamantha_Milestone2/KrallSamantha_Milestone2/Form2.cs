using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KrallSamantha_Milestone2
{
    
    public partial class SearchInventory : Form
    {
        InventoryManagement f1 = new InventoryManagement();

        public SearchInventory()
        {
            InitializeComponent();
        }

        private void searchFlavorButton_Click(object sender, EventArgs e)
        {
            if (vanRB.Checked)
            {
                MessageBox.Show("You have " + f1.VanSum + " Vanilla.");                
            }
            if (chocRB.Checked)
            {
                MessageBox.Show("You have " + f1.ChocSum + " Chocolate.");
            }
            if (cherRB.Checked)
            {
                MessageBox.Show("You have " + f1.CherSum + " Cherry.");
            }
            if (cofRB.Checked)
            {
                MessageBox.Show("You have " + f1.CofSum + " Coffee.");
            }
            if (carRB.Checked)
            {
                MessageBox.Show("You have " + f1.CarSum + " Caramel.");
            }
            if (pbRB.Checked)
            {
                MessageBox.Show("You have " + f1.PBSum + " Peanut Butter.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calcLowInvButton_Click(object sender, EventArgs e)
        {
            if (f1.VanSum <= 5)
            {

                lowInventoryTB.Text = f1.VanSum + " Vanilla";
                if (f1.ChocSum <= 5)
                {
                    lowInventoryTB.Text += Environment.NewLine;
                    lowInventoryTB.Text += f1.ChocSum + " Chocolate";
                    if (f1.CherSum <= 5)
                    {
                        lowInventoryTB.Text += Environment.NewLine;
                        lowInventoryTB.Text += f1.CherSum + " Cherry";
                        if (f1.CarSum <= 5)
                        {
                            lowInventoryTB.Text += Environment.NewLine;
                            lowInventoryTB.Text += f1.CarSum + " Caramel";
                            if (f1.CofSum <= 5)
                            {
                                lowInventoryTB.Text += Environment.NewLine;
                                lowInventoryTB.Text += f1.CofSum + " Coffee";
                                if (f1.PBSum <= 5)
                                {
                                    lowInventoryTB.Text += Environment.NewLine;
                                    lowInventoryTB.Text += f1.PBSum + " Peanut Butter";
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
