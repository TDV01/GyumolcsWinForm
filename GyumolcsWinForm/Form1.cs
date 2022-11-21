using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GyumolcsWinForm
{
    public partial class Form1 : Form
    {
        MySqlConnection connection;
        MySqlCommand command;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "gyumolcsok";
            connection = new MySqlConnection(builder.ConnectionString);
            try
            {
                connection.Open();
                command = connection.CreateCommand();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + "Program leáll!");
                Environment.Exit(0);

            }
            finally
            { 
             connection.Close();
            }
            Gyumolcs_Update();
        }

        private void Gyumolcs_Update()
        {
         listBox_Gyumolcsok.Items.Clear();
            try
            {
                command.CommandText = "SELECT `id`,`nev`,`ar`,`db`,`datum` FROM `gyumolcs` WHERE 1;";
                if (connection.State==ConnectionState.Closed)
                {
                    connection.Open();
                }

                using (MySqlDataReader dr=command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        //--beolvasás
                        Gyumolcs olvas = new Gyumolcs(dr.GetInt32("id"),dr.GetString("nev"),dr.GetInt32("ar"),dr.GetInt32("db"),dr.GetDateTime("datum"));
                        listBox_Gyumolcsok.Items.Add(olvas);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally 
            {
                connection.Close();
            }
        }
        private void listBox_Gyumolcsok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Gyumolcsok.SelectedIndex < 0)
            {
                return;
            }
            Gyumolcs kivalasztottGyumolcs = (Gyumolcs)listBox_Gyumolcsok.SelectedItem;

            textBox_azonsosito.Text = kivalasztottGyumolcs.Id.ToString();
            textBox_nev.Text = kivalasztottGyumolcs.Nev;
            textBox_ar.Text = kivalasztottGyumolcs.Ar.ToString();
            numericUpDown_db.Value = kivalasztottGyumolcs.Db;
            dateTimePicker_datum.Text = Convert.ToString(kivalasztottGyumolcs.Datum);
        }


        private void button_add_Click(object sender, EventArgs e)
        {
            if (!adatok())
            {
                return;
            }
            command.CommandText = "INSERT INTO `gyumolcs`(`id`, `nev`, `ar`, `db`, `datum`) VALUES (NULL, @nev, @ar, @db, @datum)";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("nev", textBox_nev.Text);
            command.Parameters.AddWithValue("ar", textBox_ar.Text);
            command.Parameters.AddWithValue("db", numericUpDown_db.Value);
            command.Parameters.AddWithValue("datum", dateTimePicker_datum.Value);
            connection.Open();
            if (command.ExecuteNonQuery()==1)
            {
                MessageBox.Show("Sikeres rögzítés!");
                textBox_azonsosito.Text = "";
                textBox_nev.Text = "";
                textBox_ar.Text = "";
                numericUpDown_db.Value =numericUpDown_db.Minimum;
                dateTimePicker_datum.Text = "";
                connection.Close();
                Gyumolcs_Update();
            }
            else
            {
                MessageBox.Show("Sikertelen rögzítés!");
            }
        }

        private bool adatok()
        {
            if (string.IsNullOrEmpty(textBox_nev.Text))
            {
                MessageBox.Show("Nem adott meg gyümölcsnevet!");
                textBox_nev.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textBox_ar.Text))
            {
                MessageBox.Show("Nem adott meg árat!");
                textBox_ar.Focus();
                return false;
            }
            if (numericUpDown_db.Value<1)
            {
                MessageBox.Show("Nem adott meg darabszámot!");
                numericUpDown_db.Focus();
                return false;
            }
            if (dateTimePicker_datum.Text=="")
            {
                MessageBox.Show("Nem adott meg dátumot!");
                dateTimePicker_datum.Focus();
                return false;
            }
            return true;
        }

        private void button_modify_Click(object sender, EventArgs e)
        {
            if (!adatok())
            {
                return;
            }
            command.CommandText = "UPDATE `gyumolcs` SET `nev`=@nev,`ar`=@ar,`db`=@db,`datum`=@datum WHERE `id`=@id";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nev", textBox_nev.Text);
            command.Parameters.AddWithValue("@ar", textBox_ar.Text);
            command.Parameters.AddWithValue("@db", numericUpDown_db.Value);
            command.Parameters.AddWithValue("@datum", dateTimePicker_datum.Value);
            command.Parameters.AddWithValue("@id", textBox_azonsosito.Text);
            connection.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Sikeres módosítás!");
                textBox_azonsosito.Text = "";
                textBox_nev.Text = "";
                textBox_ar.Text = "";
                numericUpDown_db.Value = numericUpDown_db.Minimum;
                dateTimePicker_datum.Text = "";
                connection.Close();
                Gyumolcs_Update();
            }
            else
            {
                MessageBox.Show("Sikertelen módosítás!");
            }
            connection.Close();
        }
        
        private void button_delete_Click(object sender, EventArgs e)
        {
            /*
            if (!adatok())
            {
                return;
            }
            command.CommandText = "DELETE FROM `gyumolcs` WHERE id=@id";
            command.Parameters.Clear();
            command.Parameters.Add("@id", MySqlDbType.Int32).Value= textBox_azonsosito.Text;
            command.Parameters.Remove(textBox_nev.Text);
            command.Parameters.Remove(textBox_ar.Text);
            command.Parameters.Remove(numericUpDown_db.Value);
            command.Parameters.Remove(dateTimePicker_datum.Value);
            connection.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Sikeres törlés!");
                textBox_azonsosito.Text = "";
                textBox_nev.Text = "";
                textBox_ar.Text = "";
                numericUpDown_db.Value = numericUpDown_db.Minimum;
                dateTimePicker_datum.Text = "";
                connection.Close();
                Gyumolcs_Update();
            }
            else
            {
                MessageBox.Show("Sikertelen törlés!");
            }
            connection.Close();
        */
        }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

       
    }
}
