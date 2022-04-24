namespace administrare_hotel
{
    partial class Rezervari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rezervari));
            this.date_rezervari = new System.Windows.Forms.DataGridView();
            this.buton_iesireRezervari = new System.Windows.Forms.Button();
            this.nav_rezervari = new System.Windows.Forms.MenuStrip();
            this.nav_about = new System.Windows.Forms.ToolStripMenuItem();
            this.nav_rezervari_help = new System.Windows.Forms.ToolStripMenuItem();
            this.buton_stergeRezervari = new System.Windows.Forms.Button();
            this.buton_modificaRezervari = new System.Windows.Forms.Button();
            this.buton_adaugaRezervari = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.date_rezervari)).BeginInit();
            this.nav_rezervari.SuspendLayout();
            this.SuspendLayout();
            // 
            // date_rezervari
            // 
            this.date_rezervari.AllowUserToAddRows = false;
            this.date_rezervari.AllowUserToDeleteRows = false;
            this.date_rezervari.BackgroundColor = System.Drawing.SystemColors.Control;
            this.date_rezervari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.date_rezervari.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.date_rezervari.Location = new System.Drawing.Point(12, 78);
            this.date_rezervari.MultiSelect = false;
            this.date_rezervari.Name = "date_rezervari";
            this.date_rezervari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.date_rezervari.Size = new System.Drawing.Size(584, 421);
            this.date_rezervari.TabIndex = 0;
            // 
            // buton_iesireRezervari
            // 
            this.buton_iesireRezervari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buton_iesireRezervari.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buton_iesireRezervari.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buton_iesireRezervari.Location = new System.Drawing.Point(602, 439);
            this.buton_iesireRezervari.Name = "buton_iesireRezervari";
            this.buton_iesireRezervari.Size = new System.Drawing.Size(148, 60);
            this.buton_iesireRezervari.TabIndex = 4;
            this.buton_iesireRezervari.Text = "Iesire";
            this.buton_iesireRezervari.UseVisualStyleBackColor = true;
            this.buton_iesireRezervari.Click += new System.EventHandler(this.buton_iesireRezervari_Click);
            // 
            // nav_rezervari
            // 
            this.nav_rezervari.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.nav_rezervari.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nav_about,
            this.nav_rezervari_help});
            this.nav_rezervari.Location = new System.Drawing.Point(0, 0);
            this.nav_rezervari.Name = "nav_rezervari";
            this.nav_rezervari.Size = new System.Drawing.Size(758, 24);
            this.nav_rezervari.TabIndex = 5;
            this.nav_rezervari.Text = "menuStrip1";
            // 
            // nav_about
            // 
            this.nav_about.Name = "nav_about";
            this.nav_about.Size = new System.Drawing.Size(55, 20);
            this.nav_about.Text = "Despre";
            this.nav_about.Click += new System.EventHandler(this.nav_about_Click);
            // 
            // nav_rezervari_help
            // 
            this.nav_rezervari_help.Name = "nav_rezervari_help";
            this.nav_rezervari_help.Size = new System.Drawing.Size(52, 20);
            this.nav_rezervari_help.Text = "Ajutor";
            this.nav_rezervari_help.Click += new System.EventHandler(this.nav_rezervari_help_Click);
            // 
            // buton_stergeRezervari
            // 
            this.buton_stergeRezervari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buton_stergeRezervari.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buton_stergeRezervari.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buton_stergeRezervari.Image = global::administrare_hotel.Properties.Resources.delete;
            this.buton_stergeRezervari.Location = new System.Drawing.Point(602, 210);
            this.buton_stergeRezervari.Name = "buton_stergeRezervari";
            this.buton_stergeRezervari.Size = new System.Drawing.Size(148, 60);
            this.buton_stergeRezervari.TabIndex = 3;
            this.buton_stergeRezervari.Text = "Sterge";
            this.buton_stergeRezervari.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buton_stergeRezervari.UseVisualStyleBackColor = true;
            this.buton_stergeRezervari.Click += new System.EventHandler(this.buton_stergeRezervari_Click);
            // 
            // buton_modificaRezervari
            // 
            this.buton_modificaRezervari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buton_modificaRezervari.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buton_modificaRezervari.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buton_modificaRezervari.Image = global::administrare_hotel.Properties.Resources.edit;
            this.buton_modificaRezervari.Location = new System.Drawing.Point(602, 144);
            this.buton_modificaRezervari.Name = "buton_modificaRezervari";
            this.buton_modificaRezervari.Size = new System.Drawing.Size(148, 60);
            this.buton_modificaRezervari.TabIndex = 2;
            this.buton_modificaRezervari.Text = "Modifica";
            this.buton_modificaRezervari.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buton_modificaRezervari.UseVisualStyleBackColor = true;
            this.buton_modificaRezervari.Click += new System.EventHandler(this.buton_modificaRezervari_Click);
            // 
            // buton_adaugaRezervari
            // 
            this.buton_adaugaRezervari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buton_adaugaRezervari.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buton_adaugaRezervari.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buton_adaugaRezervari.Image = ((System.Drawing.Image)(resources.GetObject("buton_adaugaRezervari.Image")));
            this.buton_adaugaRezervari.Location = new System.Drawing.Point(602, 78);
            this.buton_adaugaRezervari.Name = "buton_adaugaRezervari";
            this.buton_adaugaRezervari.Size = new System.Drawing.Size(148, 60);
            this.buton_adaugaRezervari.TabIndex = 1;
            this.buton_adaugaRezervari.Text = "Adauga";
            this.buton_adaugaRezervari.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buton_adaugaRezervari.UseVisualStyleBackColor = true;
            this.buton_adaugaRezervari.Click += new System.EventHandler(this.buton_adaugaRezervari_Click);
            // 
            // Rezervari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(758, 511);
            this.ControlBox = false;
            this.Controls.Add(this.buton_iesireRezervari);
            this.Controls.Add(this.buton_stergeRezervari);
            this.Controls.Add(this.buton_modificaRezervari);
            this.Controls.Add(this.buton_adaugaRezervari);
            this.Controls.Add(this.date_rezervari);
            this.Controls.Add(this.nav_rezervari);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.nav_rezervari;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Rezervari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervari";
            this.Load += new System.EventHandler(this.Rezervari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.date_rezervari)).EndInit();
            this.nav_rezervari.ResumeLayout(false);
            this.nav_rezervari.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView date_rezervari;
        private System.Windows.Forms.Button buton_adaugaRezervari;
        private System.Windows.Forms.Button buton_modificaRezervari;
        private System.Windows.Forms.Button buton_stergeRezervari;
        private System.Windows.Forms.Button buton_iesireRezervari;
        private System.Windows.Forms.MenuStrip nav_rezervari;
        private System.Windows.Forms.ToolStripMenuItem nav_about;
        private System.Windows.Forms.ToolStripMenuItem nav_rezervari_help;
    }
}