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
    public partial class ReadyToEat : Form
    {
        public static double S2 = 0;//The value in which we store the sum of the checked products.
        public ReadyToEat()
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
        //Evaluating every product and if a checkbox is checked ,S2 gets the value of every product thats checked 
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            double Kebabche = 0.99;
            S2 = S2 + Kebabche;
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            double Kufte = 0.99;
            S2 = S2 + Kufte;
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            double Makaroni = 2.95;
            S2 = S2 + Makaroni;
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            double Cheese = 1.69;
            S2 = S2 + Cheese;
        }
    }
}
