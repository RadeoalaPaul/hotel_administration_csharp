using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
