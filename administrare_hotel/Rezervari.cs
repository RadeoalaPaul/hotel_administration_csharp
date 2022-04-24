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

    public partial class Rezervari : Form
    {

        Form1 principal = new Form1();

        public Rezervari()
        {
            InitializeComponent();
        }

        MySqlConnection conn = new MySqlConnection();

        public void Conexiune()
        {
            string connection_string = @"server = localhost; port = 3306; database = hotel_database; user = root; password =";
            conn.ConnectionString = connection_string;
            conn.Open();
        }

        private void buton_iesireRezervari_Click(object sender, EventArgs e)
        {
            DialogResult mesaj;
            mesaj = MessageBox.Show("Doresti sa iesi din sectiunea Rezervari?", "Iesire", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mesaj == DialogResult.Yes)
            {
                principal.Show();
                this.Close();
            }
        }

        private void nav_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Titlu aplicatie: 'Administrare hotel'\nLimbaje folosite: MySQL & C#\nElev: Radeoala Paul\nProfesor coordonator: Babutia Teodora", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void nav_rezervari_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aici poti adauga/modifica/sterge date despre rezervarile facute de catre clienti", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Rezervari_Load(object sender, EventArgs e)
        {
            Conexiune();
            try
            {
                DataTable tabel_date_rezervari = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM rezervari", conn);
                adapter.Fill(tabel_date_rezervari);
                date_rezervari.DataSource = tabel_date_rezervari;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buton_adaugaRezervari_Click(object sender, EventArgs e)
        {
            adaugaRezervari adauga = new adaugaRezervari();
            this.Close();
            adauga.Show();
        }

        private void buton_stergeRezervari_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < date_rezervari.Rows.Count; i++)
            {
                if (date_rezervari.Rows[i].Selected == true)
                {
                    try
                    {
                        Conexiune();
                        string query = "DELETE FROM rezervari WHERE ID_Client = '" + date_rezervari.Rows[i].Cells[0].FormattedValue.ToString() + "'";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        query = "UPDATE camere SET Rezervat = 'nu' WHERE Numar='" + date_rezervari.Rows[i].Cells[1].FormattedValue.ToString() + "'";
                        MySqlCommand cmd2 = new MySqlCommand(query, conn);
                        query = "UPDATE clienti SET Rezervare = 'nu' WHERE ID_Client ='" + date_rezervari.Rows[i].Cells[0].FormattedValue.ToString() + "'";
                        MySqlCommand cmd3 = new MySqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                        cmd3.ExecuteNonQuery();
                        DataTable tabel_date_rezervari = new DataTable();
                        MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM rezervari", conn);
                        adapter.Fill(tabel_date_rezervari);
                        date_rezervari.DataSource = tabel_date_rezervari;
                        MessageBox.Show("Ati sters aceasta inregistrare din baza de date.", "Stergere", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void buton_modificaRezervari_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < date_rezervari.Rows.Count; i++)
            {
                if (date_rezervari.Rows[i].Selected == true)
                {
                    modificaRezervari modifica = new modificaRezervari();
                    modifica.data(date_rezervari.Rows[i].Cells[0].FormattedValue.ToString(), "ID");
                    modifica.data(date_rezervari.Rows[i].Cells[1].FormattedValue.ToString(), "numar");
                    this.Close();
                    modifica.Show();
                }
            }
        }

    }
}
