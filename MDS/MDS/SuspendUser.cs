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
    public partial class SuspendUser : Form
    {
        public SuspendUser()
        {
            InitializeComponent();
        }

        private MySqlConnection mConn;

        private void buttonSuspend_Click(object sender, EventArgs e)
        {

            if(comboBoxClient.SelectedItem == null)
            {

                MessageBox.Show("No client selected");

            }
            else
            {

                try
                {

                    //Iniciar a ligação//
                    mConn = new MySqlConnection("Persist Security Info=False; server=localhost;database=mds;uid=root");
                    mConn.Open();

                    //Query SQL//
                    MySqlCommand command = new MySqlCommand("DELETE FROM Utilizador WHERE Username = '" + comboBoxClient.SelectedItem + "'" , mConn);

                    //Executa a Query SQL
                    command.ExecuteNonQuery();

                    //Fecha a ligação
                    mConn.Close();

                    MessageBox.Show("Client Suspended");

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

        private void SuspendUser_Load(object sender, EventArgs e)
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

        private void buttonBack_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();

        }
    }
}
