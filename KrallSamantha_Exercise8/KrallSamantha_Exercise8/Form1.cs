using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KrallSamantha_Exercise8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double FatCalories(double fatGrams)
        {
            return fatGrams * 9;
        }
        public double CarbCalories(double carbGrams)
        {
            return carbGrams * 4;
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            double fat;
            double calories;
            if(double.TryParse(fatTB.Text, out fat))
            {
                calories = FatCalories(fat);
                fatResultTB.Text = calories.ToString("n1");
            }
            else
            {
                MessageBox.Show("Invalid entry for fat calories.");
            }
            double carb;
            if(double.TryParse(carbTB.Text, out carb))
            {
                calories = CarbCalories(carb);
                carbResultTB.Text = calories.ToString("n1");
            }
            else
            {
                MessageBox.Show("Invalid entry for carbohydrdate calories");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
