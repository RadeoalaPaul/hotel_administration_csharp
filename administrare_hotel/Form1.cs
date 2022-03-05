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
            Database database = new Database();
            if (!database.connection()) db_status.Text += " not connected";
            else { db_status.Text += " connected successfully"; database.conn.Close(); }
        }

        private void buton_Iesire_Click(object sender, EventArgs e)
        {
            DialogResult mesaj;
            mesaj = MessageBox.Show("Doresti sa inchizi aplicatia?", "Iesire", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mesaj == DialogResult.Yes) Application.Exit();
            else { };
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
