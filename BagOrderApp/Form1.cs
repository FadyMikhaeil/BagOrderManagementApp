using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BagOrderApp
{
    public partial class Form1 : Form
    {
        private const double BEADEDED_PRICE = 45, DECORATIVE = 50, FRINGED = 25; 
        private const double PLAIN = 20, LEATHER = 80, PIRATE = 40;
        private double price;
        private int quanitiy;
        private double subTotal;
        private string bagType;
        private double shippingCharge;
        private double totalCost;
        private string orderDetails = ""; 
        private double grandTotal = 0; 



        public Form1()
        {
            InitializeComponent();
        }

        private void displayOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            string orderSummary = orderDetails + $"Grand total: {grandTotal.ToString("C2")}";

            MessageBox.Show(orderSummary, "Order Summary");
        }

        private void resetOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            designTypeListBox.SelectedIndex = -1;
            unitPriceTextBox.Text = "";
            quantityTextBox.Text = "";
            overnightRadioButton.Checked = false;
            threeDayRadioButton.Checked = false;
            standardRadioButton.Checked = false;

            orderDetails = "";
            grandTotal = 0;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            designTypeListBox.SelectedIndex = -1;
            unitPriceTextBox.Text = "";
            quantityTextBox.Text = "";
            overnightRadioButton.Checked = false;
            threeDayRadioButton.Checked = false;
            standardRadioButton.Checked = false;
        }

       

        private void designTypeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        
            switch (designTypeListBox.SelectedIndex)
            {
                case 0:
                    price = BEADEDED_PRICE;
                    bagType = "Beaded";
                    break;
                case 1:
                    price = DECORATIVE;
                    bagType = "Decorative";
                    break;
                case 2:
                    price = FRINGED;
                    bagType = "Fringed";
                    break;
                case 3:
                    price = LEATHER;
                    bagType = "Leather";
                    break;
                case 4:
                    price = PIRATE;
                    bagType = "Pirate";
                    break;
                case 5:
                    price = PLAIN;
                    bagType = "Plain";
                    break;
            }

            unitPriceTextBox.Text = Convert.ToString(price);




        }
      

        private void overnightRadioButton_CheckedChanged(object sender, EventArgs e)
        {
      
        }

        private void addToOrderButton_Click(object sender, EventArgs e)
        {
            if (designTypeListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a design type.");
            }
           

            if (!int.TryParse(quantityTextBox.Text, out quanitiy) || quanitiy <= 0)
            {
                MessageBox.Show("Please enter a valid, positive quantity.");
                return;
            }
            quanitiy = int.Parse(quantityTextBox.Text);
            subTotal = price * quanitiy;
            
            

            if (overnightRadioButton.Checked)
            {
                shippingCharge = subTotal * 0.10; 
            }
            else if (threeDayRadioButton.Checked)
            {
                shippingCharge = subTotal * 0.07; 
            }
            else
            {
                shippingCharge = subTotal * 0.05; 
            }

            totalCost = subTotal + shippingCharge;
            grandTotal += totalCost;

            orderDetails += $"Item to Order\n--------------\nBag Type: {bagType}" +
                $"\nQuantity: {quanitiy}\nShipping Charge: {shippingCharge.ToString("C2")}" +
                $"\nTotal Cost: {totalCost.ToString("C2")}\n\n";




            string orderMessage;
            orderMessage = "Item to Order\n_ _ _ _ _ _ _\nBag Type: "
                + bagType + "\nQuanitiy: " + quanitiy
                + "\nShipping Charge: " + shippingCharge.ToString("C2") + 
                "\nTotal Cost: " + totalCost.ToString("C2");
            MessageBox.Show(orderMessage);

        }

    }
}
