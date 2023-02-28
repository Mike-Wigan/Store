using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class Form1 : Form
    {
        double shirts, pants, sweaters, subtotal, tax, total, tendered, Change = 0.00;

        double sweaterPrice = 60.00;
        double shirtPrice = 25.00;
        double pantsPrice = 60.00;
       
        public Form1()
        {
            InitializeComponent(); 
            printReceiptbutton.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                shirts = Convert.ToDouble(shirttextbox.Text); //declaring numbers for text boxes as variables 
                sweaters = Convert.ToDouble(sweaterstextbox.Text);
                pants = Convert.ToDouble(pantstextbox.Text);

                subtotal = (shirtPrice * shirts) + (pants * pantsPrice) + (sweaters * sweaterPrice); //doin some math
                tax = subtotal * 0.13;
                total = subtotal + tax;

                subtotallabel.Text = subtotal.ToString("C");
                taxlabel.Text = tax.ToString("C");
                totallabel.Text = total.ToString("C");
                printReceiptbutton.Enabled = true;
            }
            catch
            {

            }

        }
        private void printReceiptbutton_Click(object sender, EventArgs e)
        {
            printReceiptbutton.Enabled = false;
            Receipt.Text += $"             Store Recipt";
            Receipt.Text += "\n\nShirts";
            Receipt.Text += $"                  x{shirts}";
            Receipt.Text += $"    ${shirts * shirtPrice}";
            Receipt.Text += $"\n\nPants";
            Receipt.Text += $"                  x{pants}";
            Receipt.Text += $"    ${pants * pantsPrice}";
            Receipt.Text += $"\n\nSweaters";
            Receipt.Text += $"            x{sweaters}";
            Receipt.Text += $"    ${sweaters * sweaterPrice}";
            Receipt.Text += $"\n\n\nSubtotal";
            Receipt.Text += $"                      ${subtotal}";
            Receipt.Text += $"\n\nTax";
            Receipt.Text += $"                             ${tax}";
            Receipt.Text += $"\n\nTotal";
            Receipt.Text += $"\n${total}";
            Receipt.Text += $"\n\n\n         Have a Nice Day";
        }
        
    }
}
