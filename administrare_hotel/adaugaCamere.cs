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
    public partial class adaugaCamere : Form
    {
        public adaugaCamere()
        {
            InitializeComponent();
        }

        Camere main = new Camere();
        MySqlConnection conn = new MySqlConnection();
        public string connection_string = @"server = localhost; port = 3306; database = hotel_database; user = root; password =";

        private void buton_IesireAdaugaCamere_Click(object sender, EventArgs e)
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
            if (text == "")
            {
                MessageBox.Show("Campul \"" + camp.ToUpper() + "\" nu poate fi gol.", "Adauga camera", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OK = false;
            }
            if (text != text_adaugaCamere_numar.Text)
            {
                if (text == "da" || text == "nu")
                {
                    OK = true;
                }
                else
                {
                    MessageBox.Show("Campul \"" + camp.ToUpper() + "\" accepta doar valorile \"da\" sau \"nu\".", "Adauga camera", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OK = false;
                }
            }
            else
            {
                string query = "SELECT Numar FROM camere WHERE Numar ='" + text_adaugaCamere_numar.Text + "'";
                conn.ConnectionString = connection_string;
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    if(reader[0].ToString() == text_adaugaCamere_numar.Text)
                    {
                        MessageBox.Show("Acest numar de camera este deja prezent in baza de date.", "Adauga camera", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        OK = false;
                        break;
                    }
                }
                conn.Close();
                if (OK)
                {
                    for (i = 0; i < caractere.Length; i++)
                    {
                        if (!(caractere[i] >= '1' && caractere[i] <= '9'))
                        {
                            OK = false;
                            MessageBox.Show("Campul \"" + camp.ToUpper() + "\" nu poate contine litere/simboluri.", "Adauga camera", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            if (OK) return true;
            else return false;
        }

        private void adaugaCamere_Load(object sender, EventArgs e)
        {

        }

        private void buton_adaugaCamereSalvare_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = connection_string;
            if (VerificaText(text_adaugaCamere_numar.Text, "Numar"))
            {
                if (VerificaText(text_adaugaCamere_frigider.Text, "Frigider"))
                {
                    if (VerificaText(text_adaugaCamere_balcon.Text, "Balcon"))
                    {
                        if (VerificaText(text_adaugaCamere_pat_dublu.Text, "Pat_Dublu"))
                        {
                            try
                            {
                                string query = "INSERT INTO camere (Numar, Frigider, Balcon, Pat_Dublu) VALUES ('" + text_adaugaCamere_numar.Text + "','" + text_adaugaCamere_frigider.Text + "','" + text_adaugaCamere_balcon.Text + "','" + text_adaugaCamere_pat_dublu.Text + "')";
                                MySqlCommand cmd = new MySqlCommand(query, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                MessageBox.Show("Informatiile au fost inregistrate cu succes.", "Adauga camera", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

    }
}
