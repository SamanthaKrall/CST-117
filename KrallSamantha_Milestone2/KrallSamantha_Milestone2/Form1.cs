using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
 * Author: Samantha Krall
 * CST-117
 * Milestone 2
 *
 */ 
namespace KrallSamantha_Milestone2
{
    public partial class InventoryManagement : Form
    {
        static List<int> vanilla = new List<int>();
        static List<int> chocolate = new List<int>();
        static List<int> cherry = new List<int>();
        static List<int> pb = new List<int>();
        static List<int> coffee = new List<int>();
        static List<int> caramel = new List<int>();

        public InventoryManagement()
        {
            InitializeComponent();
        }

        private void vanTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(vanTB.TextLength > 0)
            {
                vanilla.Add(int.Parse(vanTB.Text));
                vanTB.Text = " ";
            }
            if(chocTB.TextLength > 0)
            {
                chocolate.Add(int.Parse(chocTB.Text));
                chocTB.Text = "";
            }
            if(cherTB.TextLength > 0)
            {
                cherry.Add(int.Parse(cherTB.Text));
                cherTB.Text = "";
            }
            if(cofTB.TextLength > 0)
            {
                coffee.Add(int.Parse(cofTB.Text));
                cofTB.Text = "";
            }
            if(carTB.TextLength > 0)
            {
                caramel.Add(int.Parse(carTB.Text));
                carTB.Text = "";
            }
            if(pbTB.TextLength > 0)
            {
                pb.Add(int.Parse(pbTB.Text));
                pbTB.Text = "";
            }
            inventoryTB.Text = "";

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if(vanTB.TextLength > 0)
            {
                int vanNeg = (int.Parse(vanTB.Text) * (-1));
                vanilla.Add(vanNeg);
                vanTB.Text = "";
            }
            if (chocTB.TextLength > 0)
            {
                int chocNeg = (int.Parse(chocTB.Text) * (-1));
                chocolate.Add(chocNeg);
                chocTB.Text = "";
            }
            if (cherTB.TextLength > 0)
            {
                int cherNeg = (int.Parse(cherTB.Text) * (-1));
                cherry.Add(cherNeg);
                cherTB.Text = "";
            }
            if (cofTB.TextLength > 0)
            {
                int cofNeg = (int.Parse(cofTB.Text) * (-1));
                coffee.Add(cofNeg);
                cofTB.Text = "";
            }
            if (carTB.TextLength > 0)
            {
                int carNeg = (int.Parse(carTB.Text) * (-1));
                caramel.Add(carNeg);
                carTB.Text = "";
            }
            if (pbTB.TextLength > 0)
            {
                int pbNeg = (int.Parse(pbTB.Text) * (-1));
                pb.Add(pbNeg);
                pbTB.Text = "";
            }
            inventoryTB.Text = "";
        }

        private void restockButton_Click(object sender, EventArgs e)
        {
            if (vanTB.TextLength > 0)
            {
                vanilla.Add(int.Parse(vanTB.Text));
                vanTB.Text = " ";
            }
            if (chocTB.TextLength > 0)
            {
                chocolate.Add(int.Parse(chocTB.Text));
                chocTB.Text = "";
            }
            if (cherTB.TextLength > 0)
            {
                cherry.Add(int.Parse(cherTB.Text));
                cherTB.Text = "";
            }
            if (cofTB.TextLength > 0)
            {
                coffee.Add(int.Parse(cofTB.Text));
                cofTB.Text = "";
            }
            if (carTB.TextLength > 0)
            {
                caramel.Add(int.Parse(carTB.Text));
                carTB.Text = "";
            }
            if (pbTB.TextLength > 0)
            {
                pb.Add(int.Parse(pbTB.Text));
                pbTB.Text = "";
            }
            inventoryTB.Text = " ";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchInventory f2 = new SearchInventory();
            f2.ShowDialog(this);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inventoryTB_TextChanged(object sender, EventArgs e)
        {
            inventoryTB.Text = "You have the following in inventory: "
                + "\r\nVanilla " + vanilla.Sum() + "\r\nChocolate " + chocolate.Sum()
                + "\r\nCherry " + cherry.Sum() + "\r\nCoffee " + coffee.Sum()
                + "\r\nCaramel " + caramel.Sum() + "\r\nPeanut Butter " + pb.Sum();
        }
        public int VanSum
        {
            get
            {
                return vanilla.Sum();
            }
        }
        public int ChocSum
        {
            get
            {
                return chocolate.Sum();
            }
        }
        public int CherSum
        {
            get
            {
                return cherry.Sum();
            }
        }
        public int CofSum
        {
            get
            {
                return coffee.Sum();
            }
        }
        public int CarSum
        {
            get
            {
                return caramel.Sum();
            }
        }
        public int PBSum
        {
            get
            {
                return pb.Sum();
            }
        }
    }
}
