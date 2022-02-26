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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertDecimal_Click(object sender, EventArgs e)
        {

        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes and end the program application
            this.Close();
        }
        
        private void btnBTD_Click(object sender, EventArgs e)
        {
            //Directs user to the second form where they can convert decimal number and binary number to one another
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void btnOTD_Click(object sender, EventArgs e)
        {
            //Directs user to the second form where they can convert decimal number and octal number to one another
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }
    }
}
