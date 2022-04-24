using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace administrare_hotel
{
    public partial class modificaRezervari : Form
    {
        public modificaRezervari()
        {
            InitializeComponent();
        }

        Rezervari main = new Rezervari();
        MySqlConnection conn = new MySqlConnection();
        public string connection_string = @"server = localhost; port = 3306; database = hotel_database; user = root; password =";
        public string ID, camera_precedenta, query;

        public void data(string data, string camp)
        {
            switch (camp)
            {
                case "ID":
                    {
                        ID = data;
                        break;
                    }
                case "numar":
                    {
                        text_modificaRezervari_numar_camera.Text = data;
                        camera_precedenta = data;
                        break;
                    }
            }
        }

        public bool VerificaText(string text, string camp)
        {
            char[] caractere = text.ToCharArray();
            bool OK = true;
            int i;
            conn.ConnectionString = connection_string;
            for (i = 0; i < caractere.Length; i++)
            {
                if (caractere[0] == '0')
                {
                    MessageBox.Show("Campul \"" + camp.ToUpper() + "\" nu poate fi nul.", "Adauga rezervare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OK = false;
                    break;
                }
                if (!(caractere[i] >= '0' && caractere[i] <= '9'))
                {
                    MessageBox.Show("Campul \"" + camp.ToUpper() + "\" nu poate contine litere/simboluri.", "Adauga rezervare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OK = false;
                    break;
                }
            }
            if (text == "")
            {
                MessageBox.Show("Campul \"" + camp.ToUpper() + "\" nu poate fi gol.", "Adauga angajat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OK = false;
            }
            else
            {
                if (OK)
                {
                    bool camera_existenta = false;
                    i = 0;
                    query = "SELECT Numar FROM camere WHERE Numar='" + text_modificaRezervari_numar_camera.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader[i].ToString() == text_modificaRezervari_numar_camera.Text)
                        {
                            camera_existenta = true;
                            break;
                        }
                        else i++;
                    }
                    conn.Close();
                    if (!camera_existenta)
                    {
                        MessageBox.Show("Aceasta camera nu este inregistrata.", "Modifica rezervare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        OK = false;
                    }
                    else
                    {
                        if (text_modificaRezervari_numar_camera.Text == camera_precedenta)
                        {
                            OK = true;
                        }
                        else
                        {
                            bool camera_rezervata = false;
                            query = "SELECT Rezervat FROM camere WHERE Numar='" + text_modificaRezervari_numar_camera.Text + "'";
                            MySqlCommand cmd2 = new MySqlCommand(query, conn);
                            conn.Open();
                            MySqlDataReader reader2 = cmd2.ExecuteReader();
                            while (reader2.Read())
                            {
                                if (reader2[0].ToString() == "da")
                                {
                                    MessageBox.Show("Aceasta camera este rezervata.", "Modifica rezervare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    camera_rezervata = true;
                                    break;
                                }
                            }
                            conn.Close();
                            if (camera_rezervata) OK = false;
                            else
                            {
                                query = "UPDATE camere SET Rezervat='nu' WHERE Numar='" + camera_precedenta + "'";
                                MySqlCommand cmd3 = new MySqlCommand(query, conn);
                                conn.Open();
                                cmd3.ExecuteNonQuery();
                                conn.Close();
                                OK = true;
                            }
                        }
                    }
                }
            }
            if (OK) return true;
            else return false;
        }

        private void buton_IesireModificaRezervari_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Doresti sa inchizi aceasta fereastra?", "Iesire", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                main.Show();
            }
        }

        private void buton_modificaRezervariSalvare_Click(object sender, EventArgs e)
        {
            if (VerificaText(text_modificaRezervari_numar_camera.Text, "Numar camera"))
            {
                try
                {
                    string query;
                    query = "UPDATE rezervari SET Numar_Camera='" + text_modificaRezervari_numar_camera.Text + "' WHERE ID_Client ='" + ID + "'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    query = "UPDATE camere SET Rezervat='da' WHERE Numar ='" + text_modificaRezervari_numar_camera.Text + "'";
                    MySqlCommand cmd2 = new MySqlCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Informatiile au fost inregistrate cu succes.", "Adauga rezervare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    main.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
