using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number_System_Converter
{
    public partial class Form3 : Form
    {
        int number;
        int quotient;
        public Form3()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes and end the program application
            this.Close();
        }

        private void btnConvertDecimal_Click(object sender, EventArgs e)
        {
            //Conversion of Decimal Number to Octal Number
            //Condition to check if the textbox for Decimal Number is empty
            if (txtDecimal.Text == "")
            {
                MessageBox.Show("INPUT DECIMAL NUMBER"); 
            }
            //If the textbox of Decimal Number is not empty, the conversion takes place
            else
            {
                string remainder = "";
                number = int.Parse(txtDecimal.Text);
                //While loop is to perform successive division to the Decimal Number 
                //The Decimal Number will be divided into 8 until the number to be converted is equal to zero
                while (number != 0)
                {
                    quotient = number / 8;
                    remainder += (number % 8).ToString();
                    number = quotient;
                }
                //For loop is used in displaying the string identifier, 'remainder' to get the equivalent Octal Number
                //Starting from the last digit added to the string identifier, 'remainder' to satisfy the placement of MSB and LSB
                //This for loop will stop when i < 0 which means that all the digits are displayed already
                for (int i = remainder.Length - 1; i >= 0; i--)
                {
                    txtOctal.Text = txtOctal.Text + remainder[i];
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Bringing the form to its initial state where there isn't anything inputted
            txtOctal.Clear();
            txtDecimal.Clear();
            txtDecimal.Enabled = true;
            txtOctal.Enabled = true;
        }

        private void btnConvertOctal_Click(object sender, EventArgs e)
        {
            //Conversion of Octal Number to Decimal Number
            //Condition to check if the textbox for Octal Number is empty
            if (txtOctal.Text == "")
            {
                MessageBox.Show("INPUT OCTAL NUMBER");
            }
            else
            {
                int remainder, dec = 0, power = 1;

                number = int.Parse(txtOctal.Text);
                //While loop is to perform the method of multiplying each digit in the Octal Number to its positional value.
                //Then adding it to its previous value
                //The Octal Number will be divided into 10 until the number to be converted is equal to zero
                while (number != 0)
                {
                    quotient = number / 10;
                    remainder = number % 10;
                    dec = dec + (remainder * power);
                    number = quotient;
                    power = power * 8; //We'll be dealing with the number system that has the base number 8
                }
                txtDecimal.Text = dec.ToString();//Displaying the last value accumulated in integer identifier 'dec' which is the equivalent Decimal Number of the inputted Octal Number
            }
        }

        private void txtDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            //User can't use anything but digits and the backspace function in inputting the Decimal Number
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch !=8)
            {
                e.Handled = true;
            }
        }

        private void txtOctal_KeyPress(object sender, KeyPressEventArgs e)
        {
            //User can only use the numbers 0-7 and the backspace function in inputting the Octal Number
            e.Handled = !("\b01234567".Contains(e.KeyChar));
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Directing User to the Main Menu
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void txtDecimal_TextChanged(object sender, EventArgs e)
        {
            //The Octal Number's textbox can't receive any input from the user since we'll be dealing with Decimal Number
            if (txtDecimal.Text != "")
            {
                txtOctal.Enabled = false; 
            }
        }

        private void txtOctal_TextChanged(object sender, EventArgs e)
        {
            //The Decimal Number's textbox can't receive any input from the user since we'll be dealing with Octal Number
            if (txtOctal.Text != "")
            {
                txtDecimal.Enabled = false; 
            }
        }
    }
}
