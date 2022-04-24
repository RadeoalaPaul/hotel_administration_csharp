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
    public partial class Angajati : Form
    {

        Form1 principal = new Form1();
        MySqlConnection conn = new MySqlConnection();
        public string data;

        public Angajati()
        {
            InitializeComponent();
        }

        public void Conexiune()
        {
            string connection_string = @"server = localhost; port = 3306; database = hotel_database; user = root; password =";
            conn.ConnectionString = connection_string;
            conn.Open();
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
            Conexiune();
            try
            {
                DataTable tabel_date_angajati = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM angajati", conn);
                adapter.Fill(tabel_date_angajati);
                date_angajati.DataSource = tabel_date_angajati;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void nav_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Titlu aplicatie: 'Administrare hotel'\nLimbaje folosite: MySQL & C#\nElev: Radeoala Paul\nProfesor coordonator: Babutia Teodora", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void nav_angajati_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In aceasta sectiune poti adauga/modifica/sterge date despre angajatii hotelului", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buton_adaugaAngajati_Click(object sender, EventArgs e)
        {
            adaugaAngajati adauga = new adaugaAngajati();
            this.Close();
            adauga.Show();
        }

        private void buton_stergeAngajati_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < date_angajati.Rows.Count; i++)
            {
                if (date_angajati.Rows[i].Selected == true)
                {
                    try
                    {
                        Conexiune();
                        string query = "DELETE FROM `angajati` WHERE CNP = '"+date_angajati.Rows[i].Cells[5].FormattedValue.ToString() + "';";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        DataTable tabel_date_angajati = new DataTable();
                        MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM angajati", conn);
                        adapter.Fill(tabel_date_angajati);
                        date_angajati.DataSource = tabel_date_angajati;
                        MessageBox.Show("Ati sters aceasta inregistrare din baza de date.", "Stergere", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void buton_modificaAngajati_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < date_angajati.Rows.Count; i++)
            {
                if (date_angajati.Rows[i].Selected == true)
                {
                    modificaAngajati modifica = new modificaAngajati();
                    modifica.data(date_angajati.Rows[i].Cells[0].FormattedValue.ToString(), "ID");
                    modifica.data(date_angajati.Rows[i].Cells[1].FormattedValue.ToString(), "nume");
                    modifica.data(date_angajati.Rows[i].Cells[2].FormattedValue.ToString(), "prenume");
                    modifica.data(date_angajati.Rows[i].Cells[3].FormattedValue.ToString(), "functie");
                    modifica.data(date_angajati.Rows[i].Cells[4].FormattedValue.ToString(), "salariu");
                    this.Close();
                    modifica.Show();
                }
            }
        }
    }
}
