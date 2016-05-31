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
    public partial class UpdateUser : Form
    {
        public UpdateUser()
        {
            InitializeComponent();
        }

        private MySqlConnection mConn;

        private void buttonBack_Click(object sender, EventArgs e)
        {

            this.Hide();

            Form1 f1 = new Form1();
            f1.Show();

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            if (comboBoxClient.SelectedItem == null)
            {

                MessageBox.Show("No Client selected");

            }
            else
            {

                try
                {

                    //Iniciar a ligação//
                    mConn = new MySqlConnection("Persist Security Info=False; server=localhost;database=mds;uid=root");
                    mConn.Open();

                    //Query SQL//
                    MySqlCommand command = new MySqlCommand("UPDATE Utilizador SET Username = '" + textBoxUsername.Text + "' , Password = '" + textBoxPassword.Text + "' , Gender = '" + textBoxGender.Text + "' , Name = '" + textBoxName.Text + "', Address = '" + textBoxAddress.Text + "' WHERE Username = '" + comboBoxClient.SelectedItem + "' " , mConn);

                    //Executa a Query SQL
                    command.ExecuteNonQuery();

                    //Fecha a ligação
                    mConn.Close();

                    textBoxUsername.Clear();
                    textBoxPassword.Clear();
                    textBoxAddress.Clear();
                    textBoxName.Clear();
                    textBoxGender.Clear();

                    MessageBox.Show("Client Updated");

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }
                finally
                {

                    showUsers();

                }

            }

        }

        private void UpdateUser_Load(object sender, EventArgs e)
        {

            showUsers();


        }

        private void showUsers()
        {

            try
            {

                mConn = new MySqlConnection("Persist Security Info=False; server=localhost;database=mds;uid=root");
                mConn.Open();

                //Query SQL//
                MySqlCommand command = new MySqlCommand("SELECT Username FROM Utilizador", mConn);
                

                //Executa a Query SQL
                MySqlDataReader reader = command.ExecuteReader();

                //Limpar qualquer possivel valor na combobox//
                comboBoxClient.Items.Clear();

                //preenche o dataset através do adapter
                while (reader.Read())
                {

                    comboBoxClient.Items.Add(reader.GetString(0));

                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }

        private void comboBoxClient_SelectedIndexChanged(object sender, EventArgs e)
        {

            showInfoUsers(Convert.ToString(comboBoxClient.SelectedItem));

        }

        private void showInfoUsers(String Username)
        {

            try
            {

                mConn = new MySqlConnection("Persist Security Info=False; server=localhost;database=mds;uid=root");
                mConn.Open();

                //Query SQL//
                MySqlCommand command = new MySqlCommand("SELECT Username,Password,Gender,Name,Address FROM Utilizador WHERE Username = '" + Username + "'", mConn);

                //Executa a Query SQL
                MySqlDataReader reader = command.ExecuteReader();

                //preenche o dataset através do adapter
                while (reader.Read())
                {

                    textBoxUsername.Text = reader.GetString(0);
                    textBoxPassword.Text = reader.GetString(1);
                    textBoxGender.Text = reader.GetString(2);
                    textBoxName.Text = reader.GetString(3);
                    textBoxAddress.Text = reader.GetString(4);


                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }


    }
}
