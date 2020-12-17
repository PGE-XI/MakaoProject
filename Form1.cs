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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Entrance entrance = new Entrance();//Creates an object for entrance
            entrance.Show();//Shows tab - Entrance
            this.Hide();//Hides the previous tab upon click, preventing too many tabs
        }
    }
}
