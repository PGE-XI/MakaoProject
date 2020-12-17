using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakaoCart
{
    public partial class Beverages : Form
    {
        public static double S3 = 0;//The value in which we store the sum of the checked products.
        public Beverages()
        {
            InitializeComponent();
        }
        // A button which we use for going back to the Entrance form.
        private void Button1_Click(object sender, EventArgs e)
        {
            Entrance entrance = new Entrance();
            entrance.Show();
            this.Hide();
        }
        //Evaluating every product and if a checkbox is checked ,S3 gets the value of every product thats checked 
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            double CocaCola = 1.29;
            S3 = S3 + CocaCola;
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            double MilkOlinpus = 3.05;
            S3 = S3 + MilkOlinpus;
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            double Nestea = 1.15;
            S3 = S3 + Nestea;
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            double AloeVera = 1.99;
            S3 = S3 + AloeVera;
        }

        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            double Hell = 0.99;
            S3 = S3 + Hell;
        }

        private void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            double Fanta = 1.29;
            S3 = S3 + Fanta;
        }
    }
}
