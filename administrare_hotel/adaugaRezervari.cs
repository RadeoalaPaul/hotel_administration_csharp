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
    public partial class adaugaRezervari : Form
    {
        public adaugaRezervari()
        {
            InitializeComponent();
        }

        Rezervari main = new Rezervari();
        MySqlConnection conn = new MySqlConnection();
        public string connection_string = @"server = localhost; port = 3306; database = hotel_database; user = root; password =";
        public string query;

        private void buton_IesireAdaugaRezervari_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Doresti sa inchizi aceasta fereastra?", "Iesire", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                main.Show();
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
                MessageBox.Show("Campul \"" + camp.ToUpper() + "\" nu poate fi gol.", "Adauga rezervare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OK = false;
            }
            else
            {
                if (OK)
                {
                    if(text == text_adaugaRezervari_id_client.Text)
                    {
                        bool client_existent = false;
                        i = 0;
                        query = "SELECT ID_Client FROM clienti WHERE ID_Client='" + text_adaugaRezervari_id_client.Text + "'";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        conn.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            if(reader[i].ToString() == text_adaugaRezervari_id_client.Text)
                            {
                                client_existent = true;
                            }
                            else i++;
                        }
                        conn.Close();
                        if(client_existent)
                        {
                            bool rezervare = false;
                            i = 0;
                            query = "SELECT Rezervare FROM clienti WHERE ID_Client='" + text_adaugaRezervari_id_client.Text + "'";
                            MySqlCommand cmd2 = new MySqlCommand(query, conn);
                            conn.Open();
                            MySqlDataReader reader2 = cmd2.ExecuteReader();
                            while (reader2.Read())
                            {
                                if (reader2[i].ToString() == "da")
                                {
                                    rezervare = true;
                                }
                                else i++;
                            }
                            conn.Close();
                            if (rezervare)
                            {
                                MessageBox.Show("Exista o rezervare inregistrata pentru acest ID.", "Adauga rezervare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                OK = false;
                            }
                            else OK = true;
                        }
                        else 
                        {
                            MessageBox.Show("Acest ID nu este inregistrat.", "Adauga rezervare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            OK = false;
                        }
                        
                    }
                    if (text == text_adaugaRezervari_numar_camera.Text)
                    {
                        bool camera_existenta = false;
                        i = 0;
                        query = "SELECT Numar FROM camere WHERE Numar='" + text_adaugaRezervari_numar_camera.Text + "'";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        conn.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            if (reader[i].ToString() == text_adaugaRezervari_numar_camera.Text)
                            {
                                camera_existenta = true;
                                break;
                            }
                            else i++;
                        }
                        conn.Close();
                        if (!camera_existenta)
                        {
                            MessageBox.Show("Aceasta camera nu este inregistrata.", "Adauga rezervare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            OK = false;
                        }
                        else
                        {
                            bool camera_rezervata = false;
                            query = "SELECT Rezervat FROM camere WHERE Numar='" + text_adaugaRezervari_numar_camera.Text + "'";
                            MySqlCommand cmd2 = new MySqlCommand(query, conn);
                            conn.Open();
                            MySqlDataReader reader2 = cmd2.ExecuteReader();
                            while (reader2.Read())
                            {
                                if (reader2[0].ToString() == "da")
                                {
                                    MessageBox.Show("Aceasta camera este rezervata.", "Adauga rezervare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    camera_rezervata = true;
                                    break;
                                }
                            }
                            conn.Close();
                            if (camera_rezervata) OK = false;
                        }
                    }
    
                }
            }
            if (OK) return true;
            else return false;
        }

        private void buton_adaugaRezervariSalvare_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = connection_string;
            if (VerificaText(text_adaugaRezervari_id_client.Text, "ID Client"))
            {
                if (VerificaText(text_adaugaRezervari_numar_camera.Text, "Numar camera"))
                {
                    try
                    {
                        string query = "INSERT INTO rezervari (ID_Client, Numar_Camera) VALUES ('" + text_adaugaRezervari_id_client.Text + "','" + text_adaugaRezervari_numar_camera.Text + "')";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        query = "UPDATE camere SET Rezervat='da' WHERE Numar ='" + text_adaugaRezervari_numar_camera.Text + "'";
                        MySqlCommand cmd2 = new MySqlCommand(query, conn);
                        query = "UPDATE clienti SET Rezervare='da' WHERE ID_Client='" + text_adaugaRezervari_id_client.Text + "'";
                        MySqlCommand cmd3 = new MySqlCommand(query, conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                        cmd3.ExecuteNonQuery();
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
}
