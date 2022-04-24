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
    public partial class modificaClienti : Form
    {
        public modificaClienti()
        {
            InitializeComponent();
        }

        public string connection_string = @"server = localhost; port = 3306; database = hotel_database; user = root; password =";
        public string ID;

        Clienti main = new Clienti();
        MySqlConnection conn = new MySqlConnection();

        public void data(string data, string camp)
        {
            switch (camp)
            {
                case "ID":
                    {
                        ID = data;
                        break;
                    }
                case "nume":
                    {
                        text_modificaClienti_nume.Text = data;
                        break;
                    }
                case "prenume":
                    {
                        text_modificaClienti_prenume.Text = data;
                        break;
                    }
                case "telefon":
                    {
                        text_modificaClienti_telefon.Text = data;
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
            if (text == "")
            {
                MessageBox.Show("Campul \"" + camp.ToUpper() + "\" nu poate fi gol.", "Modifica client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OK = false;
            }
            else if (text == text_modificaClienti_telefon.Text)
            {
                for (i = 0; i < caractere.Length; i++)
                {
                    if (!(caractere[i] >= '0' && caractere[i] <= '9'))
                    {
                        MessageBox.Show("Numarul de telefon trebuie sa contina doar cifre.", "Modifica client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        OK = false;
                        break;
                    }
                }
                if (OK)
                {
                    if (text.Length != 10)
                    {
                        MessageBox.Show("Telefonul trebuie sa aiba fix 10 cifre.", "Modifica client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        OK = false;
                    }
                }
            }
            else
            {
                if (text.Length < 3)
                {
                    MessageBox.Show("Campul \"" + camp.ToUpper() + "\" trebuie sa aibe minim 3 litere.", "Modifica client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OK = false;
                }
                if (OK)
                {
                    for (i = 0; i < caractere.Length; i++)
                    {
                        if (!(caractere[0] >= 'A' && caractere[0] <= 'Z'))
                        {
                            MessageBox.Show(camp + " trebuie sa inceapa cu majuscula.", "Modifica client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            OK = false;
                            break;
                        }
                    }
                    for (i = 1; i < caractere.Length; i++)
                    {
                        if (!OK) break;
                        if (caractere[i] >= '0' && caractere[i] <= '9')
                        {
                            MessageBox.Show(camp + " nu trebuie sa contina cifre.", "Modifica client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            OK = false;
                            break;
                        }
                        if (caractere[i] >= 'A' && caractere[i] <= 'Z')
                        {
                            MessageBox.Show(camp + " nu trebuie sa contina alte majuscule in afara de prima litera.", "Modifica client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            OK = false;
                            break;
                        }
                        if ((caractere[i] != 32 && caractere[i - 1] == 32) || (caractere[i] >= 33 && caractere[i] <= 47) || (caractere[i] >= 58 && caractere[i] <= 64) || (caractere[i] >= 91 && caractere[i] <= 96) || (caractere[i] >= 123 && caractere[i] <= 126))
                        {
                            MessageBox.Show(camp + " nu trebuie sa contina simboluri.", "Modifica client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            OK = false;
                            break;
                        }
                        else OK = true;
                    }
                }
            }
            if (OK) return true;
            else return false;
        }

        private void buton_modificaClientiSalvare_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = connection_string;
            if (VerificaText(text_modificaClienti_nume.Text, "Numele"))
            {
                if (VerificaText(text_modificaClienti_prenume.Text, "Prenumele"))
                {
                    if (VerificaText(text_modificaClienti_telefon.Text, "Telefonul"))
                    {
                            try
                            {
                                string query = "UPDATE clienti SET Nume ='" + text_modificaClienti_nume.Text + "',Prenume ='" + text_modificaClienti_prenume.Text + "',Telefon='" + text_modificaClienti_telefon.Text + "' WHERE ID_Client ='" + ID + "'";
                                MySqlCommand cmd = new MySqlCommand(query, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                MessageBox.Show("Informatiile au fost modificate cu succes.", "Modifica client", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void buton_IesiremodificaClienti_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Doresti sa inchizi aceasta fereastra?", "Iesire", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                main.Show();
            }
        }

        private void modificaClienti_Load(object sender, EventArgs e)
        {

        }
    }
}
