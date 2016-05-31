using MySql.Data.MySqlClient;
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
    public partial class RegisterUser : Form
    {
        public RegisterUser()
        {
            InitializeComponent();
        }

        private MySqlConnection mConn;

        private void buttonSave_Click(object sender, EventArgs e)
        {


            try
            {

                //Iniciar a ligação//
                mConn = new MySqlConnection("Persist Security Info=False; server=localhost;database=mds;uid=root");
                mConn.Open();

                //Query SQL//
                MySqlCommand command = new MySqlCommand("INSERT INTO Utilizador (Username,Password,Gender,Name,Address)" +
                "VALUES('" + textBoxUsername.Text + "','" + textBoxPassword.Text + "','" + textBoxGender.Text + "','" + textBoxName.Text + "','" + textBoxAddress.Text + "')", mConn);

                //Executa a Query SQL
                command.ExecuteNonQuery();

                //Fecha a ligação
                mConn.Close();

                textBoxUsername.Clear();
                textBoxPassword.Clear();
                textBoxAddress.Clear();
                textBoxName.Clear();
                textBoxGender.Clear();

                MessageBox.Show("Client Added");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }



            

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {

            this.Hide();

            Form1 f1 = new Form1();

            f1.Show();

        }
    }
}
