using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharpLab1WindowsForm
{
    public partial class Form1 : Form
    {
        private string name;

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try 
            { 
                Inventory inv = new Inventory { number = int.Parse(numbertxt.Text), date =  dateTimePicker1.Text, objectName=objecttxt.Text,count = int.Parse(counttxt.Text),price = double.Parse(pricetxt.Text),invonumber = int.Parse(IvNumbertxt.Text) };
                MessageBox.Show($"user add {inv.number}");
            }catch(FormatException ex) 
            { 
                MessageBox.Show(ex.Message);
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
