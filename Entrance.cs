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
    public partial class Entrance : Form
    {
        double S_Snacks = Snacks.S1;//Connecting the value of S1 to S_Snacks
        double S_ReadyToEat = ReadyToEat.S2;//Connecting the value of S2 to S_ReadyToEat
        double S_Beverages = Beverages.S3;//Connecting the value of S3 to S_Beverages
        
        public Entrance()
        {
            InitializeComponent();
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Beverages beverages_Panel = new Beverages();//Makes connection with windows form "Beverages"
            beverages_Panel.Show();//Shows "Beverages"
            this.Hide();//Hides "Entrance" 
        }
        //Same again for Button2 where we make a connection with windows form "Snacks"
        private void Button2_Click(object sender, EventArgs e)
        {
            Snacks snacks_Panel = new Snacks();
            snacks_Panel.Show();
            this.Hide();

        }
        //Same again for Button3 where we make a connection with windows form "ReadyToEat"
        private void Button3_Click(object sender, EventArgs e)
        {
            ReadyToEat readyToEat_Panel = new ReadyToEat();
            readyToEat_Panel.Show();
            this.Hide();
        }
        //Button4 is used for showing the values in the cart of each type of products chosen.
        private void Button4_Click(object sender, EventArgs e)
        {

            this.textBox1.Text = S_Snacks.ToString("R");//Shows the value of S_Snacks in textBox1
            this.textBox3.Text = S_Beverages.ToString("R");//Shows the value of S_Beverages in textBox3
            this.textBox4.Text = S_ReadyToEat.ToString("R");//Shows the value of S_ReadyToEat in textBox2

        }

        private void Entrance_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //Button5 is used for showing the sum of all products chosen
        private void Button5_Click(object sender, EventArgs e)
        {
            double S = S_Snacks + S_Beverages + S_ReadyToEat;
            this.textBox2.Text = S.ToString("R");//Shows the value of S in textBox2
        }
    }
}
