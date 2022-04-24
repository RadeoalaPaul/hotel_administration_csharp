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
    public partial class modificaAngajati : Form
    {
        public modificaAngajati()
        {
            InitializeComponent();
        }

        
        public string connection_string = @"server = localhost; port = 3306; database = hotel_database; user = root; password =";
        public string ID;

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
                        text_modificaAngajati_nume.Text = data;
                        break;
                    }
                case "prenume":
                    {
                        text_modificaAngajati_prenume.Text = data;
                        break;
                    }
                case "functie":
                    {
                        text_modificaAngajati_functie.Text = data;
                        break;
                    }
                case "salariu":
                    {
                        text_modificaAngajati_salariu.Text = data;
                        break;
                    }
            }
        }

        Angajati main = new Angajati();
        MySqlConnection conn = new MySqlConnection();

        public bool VerificaText(string text, string camp)
        {
            char[] caractere = text.ToCharArray();
            bool OK = true;
            int i;
            conn.ConnectionString = connection_string;
            if (text == "")
            {
                MessageBox.Show("Campul \"" + camp.ToUpper() + "\" nu poate fi gol.", "Modifica angajat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OK = false;
            }
            else if (text == text_modificaAngajati_salariu.Text)
            {
                if (text.Length < 3)
                {
                    MessageBox.Show("Salariul trebuie sa aibe minim 3 cifre si sa nu fie nul.", "Adauga angajat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OK = false;
                }
                else
                {
                    for (i = 0; i < caractere.Length; i++)
                    {
                        if (!(caractere[i] >= '1' && caractere[i] <= '9'))
                        {
                            MessageBox.Show("Salariul trebuie sa contina doar cifre si sa nu fie nul.", "Adauga angajat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            OK = false;
                            break;
                        }
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
                            MessageBox.Show(camp + " trebuie sa inceapa cu majuscula.", "Modifica angajat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            OK = false;
                            break;
                        }
                    }
                    for (i = 1; i < caractere.Length; i++)
                    {
                        if (!OK) break;
                        if (caractere[i] >= '0' && caractere[i] <= '9')
                        {
                            MessageBox.Show(camp + " nu trebuie sa contina cifre.", "Modifica angajat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            OK = false;
                            break;
                        }
                        if (caractere[i] >= 'A' && caractere[i] <= 'Z')
                        {
                            MessageBox.Show(camp + " nu trebuie sa contina alte majuscule in afara de prima litera.", "Modifica angajat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            OK = false;
                            break;
                        }
                        if ((caractere[i] != 32 && caractere[i - 1] == 32) || (caractere[i] >= 33 && caractere[i] <= 47) || (caractere[i] >= 58 && caractere[i] <= 64) || (caractere[i] >= 91 && caractere[i] <= 96) || (caractere[i] >= 123 && caractere[i] <= 126))
                        {
                            MessageBox.Show(camp + " nu trebuie sa contina simboluri.", "Modifica angajat", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void buton_modificaAngajatiSalvare_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = connection_string;
            if (VerificaText(text_modificaAngajati_nume.Text, "Numele"))
            {
                if (VerificaText(text_modificaAngajati_prenume.Text, "Prenumele"))
                {
                    if (VerificaText(text_modificaAngajati_functie.Text, "Functia"))
                    {
                        if (VerificaText(text_modificaAngajati_salariu.Text, "Salariul"))
                        {
                                try
                                {
                                    string query = "UPDATE angajati SET Nume ='" + text_modificaAngajati_nume.Text + "',Prenume ='" + text_modificaAngajati_prenume.Text + "',Functie='" + text_modificaAngajati_functie.Text + "',Salariu ='" + text_modificaAngajati_salariu.Text +"' WHERE ID ='"+ID+"'";
                                    MySqlCommand cmd = new MySqlCommand(query, conn);
                                    conn.Open();
                                    cmd.ExecuteNonQuery();
                                    conn.Close();
                                    MessageBox.Show("Informatiile au fost modificate cu succes.", "Modifica angajat", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void buton_IesireModificaAngajati_Click(object sender, EventArgs e)
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
