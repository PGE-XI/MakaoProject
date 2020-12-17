using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MakaoCart
{
    public partial class Snacks : Form
    {
        public static double S1 = 0;//The value in which we store the sum of the checked products.
        public Snacks()
        {
            InitializeComponent();
           
        }
        
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            double Rice_up = 1.55;
            S1 = S1 + Rice_up;
            
        }
        // A button which we use for going back to the Entrance form.
        private void Button1_Click(object sender, EventArgs e)
        {
            Entrance entrance = new Entrance();
            entrance.Show();
            this.Hide();

        }
        //Evaluating every product and if a checkbox is checked ,S1 gets the value of every product thats checked 
        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            double Chips = 2.39;
            S1 = S1 + Chips;
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            double Griski = 0.59;
            S1 = S1 + Griski;
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            double KitKat = 0.99;
            S1 = S1 + KitKat;
        }

        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            double VaflaMura = 0.65;
            S1 = S1 + VaflaMura;
        }

        private void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            double Soleti = 0.35;
            S1 = S1 + Soleti;
           
        }
        
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            S1 = S1 * comboBox1.SelectedIndex;
        }

        private void Snacks_Load(object sender, EventArgs e)
        {
            int a=comboBox1.Items.Add("2");
            int b =comboBox1.Items.Add("3");
            int c=comboBox1.Items.Add("4");
            int d = comboBox1.SelectedIndex;
            S1 = S1 * d;
        }
    }
}
