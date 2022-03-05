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
    public partial class Angajati_Adauga : Form
    {
        public Angajati_Adauga()
        {
            InitializeComponent();
        }

        private void Angajati_Close_Click(object sender, EventArgs e)
        {
            Angajati angajati = new Angajati();
            this.Close();
            angajati.Show();
        }

        private void Angajati_Done_Click(object sender, EventArgs e)
        {
            if(angajati_nume.Text == "" || angajati_prenume.Text == "")
            {
                MessageBox.Show("Invalid","Invalid",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            string query;
            Database database = new Database();
            database.conn.Open();
            query = "INSERT INTO 'angajati' ('nume','prenume') VALUES ('" + angajati_nume.Text + "','" + angajati_prenume.Text + "'";
            MySqlCommand cmd = new MySqlCommand(query);
            cmd.ExecuteNonQuery();
        }
    }
}
