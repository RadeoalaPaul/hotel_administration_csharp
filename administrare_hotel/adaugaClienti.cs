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
    public partial class adaugaClienti : Form
    {
        public adaugaClienti()
        {
            InitializeComponent();
        }

        Clienti main = new Clienti();
        MySqlConnection conn = new MySqlConnection();
        public string connection_string = @"server = localhost; port = 3306; database = hotel_database; user = root; password =";

        public bool Verifica_nume_prenume(string nume, string prenume)
        {
            conn.ConnectionString = connection_string;
            bool OK = true;
            string nume_input = null, prenume_input = null;
            int i = 0;
            string query_nume = "SELECT Nume FROM clienti WHERE Nume='" + text_adaugaClienti_nume.Text + "'";
            string query_prenume = "SELECT Prenume FROM clienti WHERE Prenume ='" + text_adaugaClienti_prenume.Text + "'";
            MySqlCommand cmd_nume = new MySqlCommand(query_nume, conn);
            MySqlCommand cmd_prenume = new MySqlCommand(query_prenume, conn);
            conn.Open();
            MySqlDataReader reader_nume = cmd_nume.ExecuteReader();
            while (reader_nume.Read())
            {
                if (reader_nume[i].ToString() == text_adaugaClienti_nume.Text)
                {
                    nume_input = reader_nume[i].ToString();
                    break;
                }
                else i++;
            }
            i = 0;
            reader_nume.Close();
            MySqlDataReader reader_prenume = cmd_prenume.ExecuteReader();
            while (reader_prenume.Read())
            {
                if (reader_prenume[i].ToString() == text_adaugaClienti_prenume.Text)
                {
                    prenume_input = reader_prenume[i].ToString();
                    break;
                }
                else i++;
            }
            reader_prenume.Close();
            conn.Close();
            if (nume_input != null && prenume_input != null)
            {
                MessageBox.Show("Aceasta persoana este inregistrata in baza de date.", "Adauga client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OK = false;
            }
            if (OK) return true;
            else return false;
        }
        public bool VerificaText(string text, string camp)
        {
            char[] caractere = text.ToCharArray();
            bool OK = true;
            int i;
            conn.ConnectionString = connection_string;
            if (text == "")
            {
                MessageBox.Show("Campul \"" + camp.ToUpper() + "\" nu poate fi gol.", "Adauga client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OK = false;
            }
            else if (text == text_adaugaClienti_telefon.Text)
            {
                for (i = 0; i < caractere.Length; i++)
                {
                    if (!(caractere[i] >= '0' && caractere[i] <= '9'))
                    {
                        MessageBox.Show("Telefonul trebuie sa contina doar cifre sau sa nu fie nul.", "Adauga client", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show("Campul \"" + camp.ToUpper() + "\" trebuie sa aibe minim 3 litere.", "Adauga angajat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OK = false;
                }
                if (OK)
                {
                    for (i = 0; i < caractere.Length; i++)
                    {
                        if (!(caractere[0] >= 'A' && caractere[0] <= 'Z'))
                        {
                            MessageBox.Show(camp + " trebuie sa inceapa cu majuscula.", "Adauga client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            OK = false;
                            break;
                        }
                    }
                    for (i = 1; i < caractere.Length; i++)
                    {
                        if (!OK) break;
                        if (caractere[i] >= '0' && caractere[i] <= '9')
                        {
                            MessageBox.Show(camp + " nu trebuie sa contina cifre.", "Adauga client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            OK = false;
                            break;
                        }
                        if (caractere[i] >= 'A' && caractere[i] <= 'Z')
                        {
                            MessageBox.Show(camp + " nu trebuie sa contina alte majuscule in afara de prima litera.", "Adauga client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            OK = false;
                            break;
                        }
                        if ((caractere[i] != 32 && caractere[i - 1] == 32) || (caractere[i] >= 33 && caractere[i] <= 47) || (caractere[i] >= 58 && caractere[i] <= 64) || (caractere[i] >= 91 && caractere[i] <= 96) || (caractere[i] >= 123 && caractere[i] <= 126))
                        {
                            MessageBox.Show(camp + " nu trebuie sa contina simboluri.", "Adauga client", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public bool verificaCNP(string text)
        {
            char[] caractere = text.ToCharArray();
            bool OK = true;
            conn.ConnectionString = connection_string;
            string query = "SELECT CNP FROM clienti WHERE CNP ='" + text + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader[0].ToString() == text)
                {
                    MessageBox.Show("Acest CNP este prezent in baza de date.", "Adauga client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OK = false;
                    break;
                }
                else break;
            }
            conn.Close();
            if (OK)
            {
                if (text == "") MessageBox.Show("Campul 'CNP' nu poate fi gol.", "Adauga client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int i;
                for (i = 0; i < caractere.Length; i++)
                {
                    if (!(caractere[i] >= '0' && caractere[i] <= '9'))
                    {
                        MessageBox.Show("CNP-ul trebuie sa contina doar cifre.", "Salvare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
                if (text.Count() == 13)
                {
                    int[] c = { 2, 7, 9, 1, 4, 6, 3, 5, 8, 2, 7, 9 };
                    int sum = 0, cf;
                    for (i = 0; i < caractere.Length; i++)
                    {
                        for (i = 0; i < caractere.Length - 1; i++)
                        {
                            sum += Convert.ToInt32(caractere[i] - '0') * c[i];
                        }
                    }
                    if (sum % 11 >= 10) cf = 1;
                    else cf = sum % 11;
                    if (cf == (caractere[12] - '0')) OK = true;
                    else { MessageBox.Show("CNP-ul nu este valid.", "Salvare", MessageBoxButtons.OK, MessageBoxIcon.Information); OK = false; }
                }
                else { MessageBox.Show("CNP-ul trebuie sa fie format din 13 cifre.", "Salvare", MessageBoxButtons.OK, MessageBoxIcon.Information); OK = false; }
            }
            if (OK) return true;
            else return false;
        }

        private void buton_adaugaClientiSalvare_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = connection_string;
            if (VerificaText(text_adaugaClienti_nume.Text, "Numele"))
            {
                if (VerificaText(text_adaugaClienti_prenume.Text, "Prenumele"))
                {
                    if (Verifica_nume_prenume(text_adaugaClienti_nume.Text, text_adaugaClienti_prenume.Text))
                    {
                        if (VerificaText(text_adaugaClienti_telefon.Text, "Telefonul"))
                        {
                            if (verificaCNP(text_adaugaClienti_cnp.Text))
                            {
                                try
                                {
                                    string query = "INSERT INTO clienti (Nume, Prenume, Telefon, CNP) VALUES ('" + text_adaugaClienti_nume.Text + "','" + text_adaugaClienti_prenume.Text + "','" + text_adaugaClienti_telefon.Text + "','" + text_adaugaClienti_cnp.Text + "')";
                                    MySqlCommand cmd = new MySqlCommand(query, conn);
                                    conn.Open();
                                    cmd.ExecuteNonQuery();
                                    conn.Close();
                                    MessageBox.Show("Informatiile au fost inregistrate cu succes.", "Adauga client", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void buton_IesireadaugaClienti_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Doresti sa inchizi aceasta fereastra?", "Iesire", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                main.Show();
            }
        }
    }
}
