namespace administrare_hotel
{
    partial class Angajati
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Angajati));
            this.date_angajati = new System.Windows.Forms.DataGridView();
            this.buton_iesireAngajati = new System.Windows.Forms.Button();
            this.nav_angajati = new System.Windows.Forms.MenuStrip();
            this.nav_about = new System.Windows.Forms.ToolStripMenuItem();
            this.nav_angajati_help = new System.Windows.Forms.ToolStripMenuItem();
            this.buton_adaugaAngajati = new System.Windows.Forms.Button();
            this.buton_modificaAngajati = new System.Windows.Forms.Button();
            this.buton_stergeAngajati = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.date_angajati)).BeginInit();
            this.nav_angajati.SuspendLayout();
            this.SuspendLayout();
            // 
            // date_angajati
            // 
            this.date_angajati.AllowUserToAddRows = false;
            this.date_angajati.AllowUserToDeleteRows = false;
            this.date_angajati.AllowUserToOrderColumns = true;
            this.date_angajati.BackgroundColor = System.Drawing.SystemColors.Control;
            this.date_angajati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.date_angajati.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.date_angajati.Location = new System.Drawing.Point(12, 66);
            this.date_angajati.MultiSelect = false;
            this.date_angajati.Name = "date_angajati";
            this.date_angajati.ReadOnly = true;
            this.date_angajati.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.date_angajati.Size = new System.Drawing.Size(580, 433);
            this.date_angajati.TabIndex = 0;
            // 
            // buton_iesireAngajati
            // 
            this.buton_iesireAngajati.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buton_iesireAngajati.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buton_iesireAngajati.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buton_iesireAngajati.Location = new System.Drawing.Point(598, 439);
            this.buton_iesireAngajati.Name = "buton_iesireAngajati";
            this.buton_iesireAngajati.Size = new System.Drawing.Size(148, 60);
            this.buton_iesireAngajati.TabIndex = 4;
            this.buton_iesireAngajati.Text = "Iesire";
            this.buton_iesireAngajati.UseVisualStyleBackColor = true;
            this.buton_iesireAngajati.Click += new System.EventHandler(this.buton_iesireAngajati_Click);
            // 
            // nav_angajati
            // 
            this.nav_angajati.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.nav_angajati.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nav_about,
            this.nav_angajati_help});
            this.nav_angajati.Location = new System.Drawing.Point(0, 0);
            this.nav_angajati.Name = "nav_angajati";
            this.nav_angajati.Size = new System.Drawing.Size(758, 24);
            this.nav_angajati.TabIndex = 5;
            this.nav_angajati.Text = "menuStrip1";
            // 
            // nav_about
            // 
            this.nav_about.Name = "nav_about";
            this.nav_about.Size = new System.Drawing.Size(55, 20);
            this.nav_about.Text = "Despre";
            this.nav_about.Click += new System.EventHandler(this.nav_about_Click);
            // 
            // nav_angajati_help
            // 
            this.nav_angajati_help.Name = "nav_angajati_help";
            this.nav_angajati_help.Size = new System.Drawing.Size(52, 20);
            this.nav_angajati_help.Text = "Ajutor";
            this.nav_angajati_help.Click += new System.EventHandler(this.nav_angajati_help_Click);
            // 
            // buton_adaugaAngajati
            // 
            this.buton_adaugaAngajati.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buton_adaugaAngajati.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buton_adaugaAngajati.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buton_adaugaAngajati.Image = ((System.Drawing.Image)(resources.GetObject("buton_adaugaAngajati.Image")));
            this.buton_adaugaAngajati.Location = new System.Drawing.Point(598, 66);
            this.buton_adaugaAngajati.Name = "buton_adaugaAngajati";
            this.buton_adaugaAngajati.Size = new System.Drawing.Size(148, 60);
            this.buton_adaugaAngajati.TabIndex = 6;
            this.buton_adaugaAngajati.Text = "Adauga";
            this.buton_adaugaAngajati.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buton_adaugaAngajati.UseVisualStyleBackColor = true;
            this.buton_adaugaAngajati.Click += new System.EventHandler(this.buton_adaugaAngajati_Click);
            // 
            // buton_modificaAngajati
            // 
            this.buton_modificaAngajati.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buton_modificaAngajati.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buton_modificaAngajati.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buton_modificaAngajati.Image = global::administrare_hotel.Properties.Resources.edit;
            this.buton_modificaAngajati.Location = new System.Drawing.Point(598, 132);
            this.buton_modificaAngajati.Name = "buton_modificaAngajati";
            this.buton_modificaAngajati.Size = new System.Drawing.Size(148, 60);
            this.buton_modificaAngajati.TabIndex = 7;
            this.buton_modificaAngajati.Text = "Modifica";
            this.buton_modificaAngajati.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buton_modificaAngajati.UseVisualStyleBackColor = true;
            this.buton_modificaAngajati.Click += new System.EventHandler(this.buton_modificaAngajati_Click);
            // 
            // buton_stergeAngajati
            // 
            this.buton_stergeAngajati.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buton_stergeAngajati.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buton_stergeAngajati.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buton_stergeAngajati.Image = global::administrare_hotel.Properties.Resources.delete;
            this.buton_stergeAngajati.Location = new System.Drawing.Point(598, 198);
            this.buton_stergeAngajati.Name = "buton_stergeAngajati";
            this.buton_stergeAngajati.Size = new System.Drawing.Size(148, 60);
            this.buton_stergeAngajati.TabIndex = 8;
            this.buton_stergeAngajati.Text = "Sterge";
            this.buton_stergeAngajati.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buton_stergeAngajati.UseVisualStyleBackColor = true;
            this.buton_stergeAngajati.Click += new System.EventHandler(this.buton_stergeAngajati_Click);
            // 
            // Angajati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(758, 511);
            this.ControlBox = false;
            this.Controls.Add(this.buton_stergeAngajati);
            this.Controls.Add(this.buton_modificaAngajati);
            this.Controls.Add(this.buton_adaugaAngajati);
            this.Controls.Add(this.buton_iesireAngajati);
            this.Controls.Add(this.date_angajati);
            this.Controls.Add(this.nav_angajati);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.nav_angajati;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Angajati";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Angajati";
            this.Load += new System.EventHandler(this.Angajati_Load);
            ((System.ComponentModel.ISupportInitialize)(this.date_angajati)).EndInit();
            this.nav_angajati.ResumeLayout(false);
            this.nav_angajati.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView date_angajati;
        private System.Windows.Forms.Button buton_iesireAngajati;
        private System.Windows.Forms.MenuStrip nav_angajati;
        private System.Windows.Forms.ToolStripMenuItem nav_about;
        private System.Windows.Forms.ToolStripMenuItem nav_angajati_help;
        private System.Windows.Forms.Button buton_adaugaAngajati;
        private System.Windows.Forms.Button buton_modificaAngajati;
        private System.Windows.Forms.Button buton_stergeAngajati;
    }
}