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

namespace WinForm_jatek
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = null;
        MySqlCommand cmd = null;
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
            builder.Database = "jatekok";
            conn = new MySqlConnection(builder.ConnectionString);

            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + "A program le fog állni!!!!");
                Environment.Exit(0);
            }
            finally
            {
                conn.Close();
            }
        }
        private void jatekok_update()
        {
            listBox_jatekok.Items.Clear();
            cmd.CommandText = "SELECT `id`,`nev`,`datum`,`mufaj` FROM `jatek` WHERE 1;";
            conn.Open();
            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    Jatek uj = new Jatek(dr.GetInt32("id"), dr.GetString("nev"), dr.GetDateTime("datum"), dr.GetString("mufaj"));
                    listBox_jatekok.Items.Add(uj);
                }
            }
            conn.Close();
        }

        private void inert_button_Click(object sender, EventArgs e)
        {
            if (nincs_adat())
            {
                return;
            }
            cmd.CommandText = "INSERT INTO `jatek` (`id`,`nev`,`datum`,`mufaj`) VALUES (NULL, @nev, @datum, @mufaj)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@nev", textBox_nev.Text);
            cmd.Parameters.AddWithValue("@datum", dateTimePicker_datum.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@mufaj", textBox_mufaj.Text);
            conn.Open();
            try
            {
                if (cmd.ExecuteNonQuery()==1)
                {
                    MessageBox.Show("Sikeresen rögzítettük adatait!");
                    textBox_id.Text = "";
                    textBox_nev.Text = "";
                    dateTimePicker_datum.ResetText();
                    textBox_mufaj.Text = "";
                }
                else
                {
                    MessageBox.Show("Sikertelen volt az adatok rögzítése!");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Sikertelen!");
            }
            conn.Close();
            jatekok_update();
        }

        private bool nincs_adat()
        {
            if (string.IsNullOrEmpty(textBox_nev.Text))
            {
                MessageBox.Show("Adjon meg egy játék nevet!");
                textBox_nev.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(textBox_mufaj.Text))
            {
                MessageBox.Show("Adja meg a játék műfaját!");
                textBox_mufaj.Focus();
                return true;
            }
            return false;
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            if (listBox_jatekok.SelectedIndex < 0)
            {
                return;
            }
            Jatek kivalasztottjatek = (Jatek)listBox_jatekok.SelectedItem;
            cmd.CommandText = "UPDATE `jatekok` SET `nev` = @nev, `datum` = @datum, `mufaj`= @mufaj WHERE `id` = @id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", textBox_id.Text);
            cmd.Parameters.AddWithValue("@nev", textBox_nev.Text);
            cmd.Parameters.AddWithValue("@datum", dateTimePicker_datum.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@mufaj", textBox_mufaj.Text.ToString());
            conn.Open();

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Az adatok módosítása sikeres volt!");
                conn.Close();
                textBox_id.Text = "";
                textBox_nev.Text = "";
                dateTimePicker_datum.ResetText();
                textBox_mufaj.Text = "";
                jatekok_update();
            }
            else
            {
                MessageBox.Show("Az adatok módosítása sikertelen volt!");
            }
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (listBox_jatekok.SelectedIndex < 0)
            {
                return;
            }
            cmd.CommandText = "DELETE FROM `jatekok` WHERE `id` = @id;";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", textBox_id.Text);
            conn.Open();

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Az adatok törlése sikeres volt!","Sikeres!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                conn.Close();
                textBox_id.Text = "";
                textBox_nev.Text = "";
                dateTimePicker_datum.ResetText();
                textBox_mufaj.Text = "";
                jatekok_update();
            }
            else
            {
                MessageBox.Show("Az adatok törlése sikertelen volt!");
            }
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void listBox_jatekok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_jatekok.SelectedIndex < 0)
            {
                return;
            }
            Jatek kivalasztottjatek = (Jatek)listBox_jatekok.SelectedItem;
            textBox_id.Text = kivalasztottjatek.Id.ToString();
            textBox_nev.Text = kivalasztottjatek.Nev;
            dateTimePicker_datum.Value = kivalasztottjatek.Datum;
            textBox_mufaj.Text = kivalasztottjatek.Mufaj.ToString();
        }
    }
}
