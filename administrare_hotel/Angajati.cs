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
    public partial class Angajati : Form
    {

        Form1 principal = new Form1();

        public Angajati()
        {
            InitializeComponent();
        }

        private void buton_iesireAngajati_Click(object sender, EventArgs e)
        { 
            DialogResult mesaj;
            mesaj = MessageBox.Show("Doresti sa iesi din sectiunea Angajati?", "Iesire",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (mesaj == DialogResult.Yes)
            {
                principal.Show();
                this.Close();
            }
            else { };
        }

        private void Angajati_Load(object sender, EventArgs e)
        {
            
        }

        private void nav_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Titlu aplicatie: 'Administrare hotel'\nLimbaje folosite: MySQL & C#\nElev: Radeoala Paul\nProfesor coordonator: Babutia Teodora", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void nav_angajati_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In aceasta sectiune poti adauga/modifica/sterge date despre angajatii hotelului", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void date_angajati_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buton_adaugaAngajati_Click(object sender, EventArgs e)
        {
            Angajati_Adauga adauga = new Angajati_Adauga();
            this.Hide();
            adauga.Show();
        }
    }
}
