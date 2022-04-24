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
    public partial class modificaCamere : Form
    {
        public modificaCamere()
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
                case "frigider":
                    {
                        text_modificaCamere_frigider.Text = data;
                        break;
                    }
                case "Pat dublu":
                    {
                        text_modificaCamere_pat_dublu.Text = data;
                        break;
                    }
            }
        }

        Camere main = new Camere();
        MySqlConnection conn = new MySqlConnection();

        public bool VerificaText(string text, string camp)
        {
            char[] caractere = text.ToCharArray();
            bool OK = true;
            conn.ConnectionString = connection_string;
            if (text == "")
            {
                MessageBox.Show("Campul \"" + camp.ToUpper() + "\" nu poate fi gol.", "Modifica camera", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OK = false;
            }
            if(text == "da" || text == "nu")
            {
             
            }
            else
            {
                MessageBox.Show("Campul \"" + camp.ToUpper() + "\" accepta doar valorile \"da\" sau \"nu\".", "Modifica camera", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OK = false;
            }
            if (OK) return true;
            else return false;
        }

        private void buton_modificaCamereSalvare_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = connection_string;
            if (VerificaText(text_modificaCamere_frigider.Text, "Frigider"))
            {
                if (VerificaText(text_modificaCamere_pat_dublu.Text, "Pat dublu"))
                {
                    try
                    {
                        string query = "UPDATE camere SET Frigider ='" + text_modificaCamere_frigider.Text + "',Pat_Dublu ='" + text_modificaCamere_pat_dublu.Text + "' WHERE Numar ='" + ID + "'";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Informatiile au fost modificate cu succes.", "Modifica camera", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void buton_IesireModificaCamere_Click(object sender, EventArgs e)
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
