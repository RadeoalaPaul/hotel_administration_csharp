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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Conexiune()) { db_status.ForeColor = Color.Green; db_status.Text += " successfully connected"; }
            else
            {
                db_status.Text += " not connected";
                db_status.ForeColor = Color.Red;
                foreach (var button in this.Controls.OfType<Button>())
                {
                    button.Enabled = false;
                    if (button.Text == "Iesire") button.Enabled = true;
                }
            }
        }

        public bool Conexiune()
        {
            MySqlConnection conn = new MySqlConnection();
            string connection_string = @"server = localhost; port = 3306; database = hotel_database; user = root; password =";
            conn.ConnectionString = connection_string;
            try
            {
                conn.Open();
                conn.Close();
                return true;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);  
                return false; 
            }
        }

        private void buton_Iesire_Click(object sender, EventArgs e)
        {
            DialogResult mesaj;
            mesaj = MessageBox.Show("Doresti sa inchizi aplicatia?", "Iesire", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mesaj == DialogResult.Yes) Application.Exit();
        }

        private void buton_Angajati_Click(object sender, EventArgs e)
        {
            Angajati angajati = new Angajati();
            angajati.Show();
            this.Hide();
        }

        private void buton_Clienti_Click(object sender, EventArgs e)
        {
            Clienti clienti = new Clienti();
            clienti.Show();
            this.Hide();
        }

        private void buton_Rezervari_Click(object sender, EventArgs e)
        {
            Rezervari rezervari = new Rezervari();
            rezervari.Show();
            this.Hide();
        }

        private void buton_Camere_Click(object sender, EventArgs e)
        {
            Camere camere = new Camere();
            camere.Show();
            this.Hide();
        }

        private void nav_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Titlu aplicatie: 'Administrare hotel'\nLimbaje folosite: MySQL & C#\nElev: Radeoala Paul\nProfesor coordonator: Babutia Teodora", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void nav_main_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta aplicatie este conceputa cu scopul de a usura administrarea unui hotel\nApasa pe una dintre sectiuni pentru a adauga/modifica/sterge date", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
