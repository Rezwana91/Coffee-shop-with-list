using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cofee_Shop
{
    public partial class Cofee_Shop : Form
    {

        List <int> price = new List<int> {} ;
        List <string> name = new List<string>{};
        List<string> number = new List<string> { } ;
        List<string> address = new List<string> { } ;
        List<string> order = new List<string> { } ;
        List<string> quantity = new List<string> {};
        List<int> Quantity = new List<int> { };
        List<int> Order = new List<int> { };


        int i = 0;
        int j = 0;

        

        public Cofee_Shop()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (customernameTextBox.Text != "" && contactnumberTextBox.Text != "" && addressTextBox.Text != "" &&
               orderComboBox.Text != "" && quantityTextBox.Text != "")
                {

                    name.Add(customernameTextBox.Text);
                    number.Add(contactnumberTextBox.Text);
                    address.Add(addressTextBox.Text);
                    quantity.Add(quantityTextBox.Text);
                    order.Add(orderComboBox.Text);

                    j = Convert.ToInt32(quantityTextBox.Text);
                    Quantity.Add(j);


                    displayRichTextBox.Text = " ";

                    if (orderComboBox.Text == "Black")
                    {
                        AddPrice(j, 120);

                    }


                    else if (orderComboBox.Text == "Cold")
                    {
                        AddPrice(j, 100);

                    }

                    else if (orderComboBox.Text == "Hot")
                    {
                        AddPrice(j, 90);
                    }

                    else if (orderComboBox.Text == "Regular")
                    {
                        AddPrice(j, 80);
                    }
                    else
                    {
                        MessageBox.Show("Please fill the Order option");
                    }

                    displayRichTextBox.SelectedText = Environment.NewLine + "Customer Name :" + name[i];
                    displayRichTextBox.SelectedText = Environment.NewLine + "Contact Number:" + number[i];
                    displayRichTextBox.SelectedText = Environment.NewLine + "Address             :" + address[i];
                    displayRichTextBox.SelectedText = Environment.NewLine + "Order                 :" + order[i];
                    displayRichTextBox.SelectedText = Environment.NewLine + "Quantity            :" + quantity[i];
                    displayRichTextBox.SelectedText = Environment.NewLine + "Price                 :" + price[i] + "Tk.";
                    displayRichTextBox.SelectedText = Environment.NewLine + " ";

                    MessageBox.Show("All data is saved");

                }
                else
                {
                    MessageBox.Show("Please fillup all options");

                }


                customernameTextBox.Text = "";
                contactnumberTextBox.Text = "";
                addressTextBox.Text = "";
                orderComboBox.Text = "";
                quantityTextBox.Text = "";

                i++;

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return;
            }
           
        }

        private void AddPrice(int quan, int ord)
        {

                int k = 0;
                k = quan * ord;
           
                price.Add(k);

                MessageBox.Show("The bill is " + price[i] + "Tk.");
          
        }




        private void showButton_Click(object sender, EventArgs e)
        {
            try
            {
                displayRichTextBox.Text = " ";

                string mes = "";
                for (int m = 0; m < name.Count; m++)
                {
                    mes += "Customer Name :" + name[m] + "\n" + "Contact Number:" + number[m] + "\n" +
                           "Address             :" + address[m] + "\n" + "Order                 :"
                           + order[m] + "\n" + "Quantity            :" + quantity[m] + "\n" +
                           "Price                 :" + price[m] + "Tk." + "\n";

                }

                displayRichTextBox.SelectedText = Environment.NewLine + mes + " ";
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return;
            }
            

        }
    }
}
