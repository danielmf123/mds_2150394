using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRegisterUser_Click(object sender, EventArgs e)
        {

            this.Hide();
            RegisterUser ru = new RegisterUser();

            ru.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {


            this.Hide();
            UpdateUser us = new UpdateUser();

            us.Show();



        
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();

            SuspendUser su = new SuspendUser();
            su.Show();


        }
    }
}
