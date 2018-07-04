using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KrallSamantha_PP5
{
    public partial class luckyNumbersForm : Form
    {
        public luckyNumbersForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void luckyButton_Click(object sender, EventArgs e)
        {
            if (yearComboBox.SelectedIndex >= 0)
            {
                if (monthComboBox.SelectedIndex >= 0)
                {
                    if (dayComboBox.SelectedIndex >= 0)
                    {
                        if (colorComboBox.SelectedIndex >= 0)
                        {
                            resultsForm f2 = new resultsForm();
                            f2.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Please enter a color!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a date!");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a month!");
                }
            }
            else
            {
                MessageBox.Show("Please enter a year!");
            }
        }
    }
}
