namespace administrare_hotel
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nav_main = new System.Windows.Forms.MenuStrip();
            this.nav_about = new System.Windows.Forms.ToolStripMenuItem();
            this.nav_main_help = new System.Windows.Forms.ToolStripMenuItem();
            this.db_status = new System.Windows.Forms.TextBox();
            this.buton_Clienti = new System.Windows.Forms.Button();
            this.buton_Iesire = new System.Windows.Forms.Button();
            this.buton_Rezervari = new System.Windows.Forms.Button();
            this.buton_Camere = new System.Windows.Forms.Button();
            this.buton_Angajati = new System.Windows.Forms.Button();
            this.nav_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // nav_main
            // 
            this.nav_main.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.nav_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nav_about,
            this.nav_main_help});
            this.nav_main.Location = new System.Drawing.Point(0, 0);
            this.nav_main.Name = "nav_main";
            this.nav_main.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.nav_main.Size = new System.Drawing.Size(471, 24);
            this.nav_main.TabIndex = 6;
            this.nav_main.Text = "nav_main";
            // 
            // nav_about
            // 
            this.nav_about.Name = "nav_about";
            this.nav_about.Size = new System.Drawing.Size(52, 20);
            this.nav_about.Text = "About";
            this.nav_about.Click += new System.EventHandler(this.nav_about_Click);
            // 
            // nav_main_help
            // 
            this.nav_main_help.Name = "nav_main_help";
            this.nav_main_help.Size = new System.Drawing.Size(44, 20);
            this.nav_main_help.Text = "Help";
            this.nav_main_help.Click += new System.EventHandler(this.nav_main_help_Click);
            // 
            // db_status
            // 
            this.db_status.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.db_status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.db_status.Location = new System.Drawing.Point(12, 54);
            this.db_status.Name = "db_status";
            this.db_status.Size = new System.Drawing.Size(220, 13);
            this.db_status.TabIndex = 7;
            this.db_status.Text = "Database Status: ";
            // 
            // buton_Clienti
            // 
            this.buton_Clienti.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buton_Clienti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buton_Clienti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buton_Clienti.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buton_Clienti.Image = ((System.Drawing.Image)(resources.GetObject("buton_Clienti.Image")));
            this.buton_Clienti.Location = new System.Drawing.Point(239, 124);
            this.buton_Clienti.Name = "buton_Clienti";
            this.buton_Clienti.Size = new System.Drawing.Size(220, 100);
            this.buton_Clienti.TabIndex = 5;
            this.buton_Clienti.Text = "Clienti";
            this.buton_Clienti.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buton_Clienti.UseVisualStyleBackColor = false;
            this.buton_Clienti.Click += new System.EventHandler(this.buton_Clienti_Click);
            // 
            // buton_Iesire
            // 
            this.buton_Iesire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buton_Iesire.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buton_Iesire.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buton_Iesire.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buton_Iesire.Image = ((System.Drawing.Image)(resources.GetObject("buton_Iesire.Image")));
            this.buton_Iesire.Location = new System.Drawing.Point(97, 389);
            this.buton_Iesire.Name = "buton_Iesire";
            this.buton_Iesire.Size = new System.Drawing.Size(280, 80);
            this.buton_Iesire.TabIndex = 4;
            this.buton_Iesire.Text = "Iesire";
            this.buton_Iesire.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buton_Iesire.UseVisualStyleBackColor = true;
            this.buton_Iesire.Click += new System.EventHandler(this.buton_Iesire_Click);
            // 
            // buton_Rezervari
            // 
            this.buton_Rezervari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buton_Rezervari.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buton_Rezervari.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buton_Rezervari.Image = global::administrare_hotel.Properties.Resources.rezervare;
            this.buton_Rezervari.Location = new System.Drawing.Point(12, 232);
            this.buton_Rezervari.Name = "buton_Rezervari";
            this.buton_Rezervari.Size = new System.Drawing.Size(220, 100);
            this.buton_Rezervari.TabIndex = 3;
            this.buton_Rezervari.Text = "Rezervari";
            this.buton_Rezervari.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buton_Rezervari.UseVisualStyleBackColor = true;
            this.buton_Rezervari.Click += new System.EventHandler(this.buton_Rezervari_Click);
            // 
            // buton_Camere
            // 
            this.buton_Camere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buton_Camere.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buton_Camere.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buton_Camere.Image = global::administrare_hotel.Properties.Resources.camere;
            this.buton_Camere.Location = new System.Drawing.Point(238, 232);
            this.buton_Camere.Name = "buton_Camere";
            this.buton_Camere.Size = new System.Drawing.Size(220, 100);
            this.buton_Camere.TabIndex = 2;
            this.buton_Camere.Text = "Camere";
            this.buton_Camere.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buton_Camere.UseVisualStyleBackColor = true;
            this.buton_Camere.Click += new System.EventHandler(this.buton_Camere_Click);
            // 
            // buton_Angajati
            // 
            this.buton_Angajati.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buton_Angajati.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buton_Angajati.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buton_Angajati.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buton_Angajati.Image = global::administrare_hotel.Properties.Resources.angajati3;
            this.buton_Angajati.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buton_Angajati.Location = new System.Drawing.Point(12, 124);
            this.buton_Angajati.Name = "buton_Angajati";
            this.buton_Angajati.Size = new System.Drawing.Size(220, 100);
            this.buton_Angajati.TabIndex = 0;
            this.buton_Angajati.Text = "Angajati";
            this.buton_Angajati.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buton_Angajati.UseVisualStyleBackColor = true;
            this.buton_Angajati.Click += new System.EventHandler(this.buton_Angajati_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(471, 481);
            this.ControlBox = false;
            this.Controls.Add(this.db_status);
            this.Controls.Add(this.buton_Clienti);
            this.Controls.Add(this.buton_Iesire);
            this.Controls.Add(this.buton_Rezervari);
            this.Controls.Add(this.buton_Camere);
            this.Controls.Add(this.buton_Angajati);
            this.Controls.Add(this.nav_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.nav_main;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "administrare_hotel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.nav_main.ResumeLayout(false);
            this.nav_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buton_Angajati;
        private System.Windows.Forms.Button buton_Camere;
        private System.Windows.Forms.Button buton_Rezervari;
        private System.Windows.Forms.Button buton_Iesire;
        private System.Windows.Forms.Button buton_Clienti;
        private System.Windows.Forms.MenuStrip nav_main;
        private System.Windows.Forms.ToolStripMenuItem nav_about;
        private System.Windows.Forms.ToolStripMenuItem nav_main_help;
        private System.Windows.Forms.TextBox db_status;
    }
}

