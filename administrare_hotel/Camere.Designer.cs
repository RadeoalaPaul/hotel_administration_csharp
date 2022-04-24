namespace administrare_hotel
{
    partial class Camere
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Camere));
            this.date_camere = new System.Windows.Forms.DataGridView();
            this.buton_iesireCamere = new System.Windows.Forms.Button();
            this.nav_camere = new System.Windows.Forms.MenuStrip();
            this.nav_about = new System.Windows.Forms.ToolStripMenuItem();
            this.nav_camere_help = new System.Windows.Forms.ToolStripMenuItem();
            this.buton_stergeCamere = new System.Windows.Forms.Button();
            this.buton_modificaCamere = new System.Windows.Forms.Button();
            this.buton_adaugaCamere = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.date_camere)).BeginInit();
            this.nav_camere.SuspendLayout();
            this.SuspendLayout();
            // 
            // date_camere
            // 
            this.date_camere.AllowUserToAddRows = false;
            this.date_camere.AllowUserToDeleteRows = false;
            this.date_camere.BackgroundColor = System.Drawing.SystemColors.Control;
            this.date_camere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.date_camere.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.date_camere.Location = new System.Drawing.Point(12, 78);
            this.date_camere.MultiSelect = false;
            this.date_camere.Name = "date_camere";
            this.date_camere.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.date_camere.Size = new System.Drawing.Size(584, 421);
            this.date_camere.TabIndex = 0;
            // 
            // buton_iesireCamere
            // 
            this.buton_iesireCamere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buton_iesireCamere.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buton_iesireCamere.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buton_iesireCamere.Location = new System.Drawing.Point(602, 439);
            this.buton_iesireCamere.Name = "buton_iesireCamere";
            this.buton_iesireCamere.Size = new System.Drawing.Size(144, 60);
            this.buton_iesireCamere.TabIndex = 4;
            this.buton_iesireCamere.Text = "Iesire";
            this.buton_iesireCamere.UseVisualStyleBackColor = true;
            this.buton_iesireCamere.Click += new System.EventHandler(this.buton_iesireCamere_Click);
            // 
            // nav_camere
            // 
            this.nav_camere.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.nav_camere.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nav_about,
            this.nav_camere_help});
            this.nav_camere.Location = new System.Drawing.Point(0, 0);
            this.nav_camere.Name = "nav_camere";
            this.nav_camere.Size = new System.Drawing.Size(758, 24);
            this.nav_camere.TabIndex = 5;
            this.nav_camere.Text = "menuStrip1";
            // 
            // nav_about
            // 
            this.nav_about.Name = "nav_about";
            this.nav_about.Size = new System.Drawing.Size(55, 20);
            this.nav_about.Text = "Despre";
            this.nav_about.Click += new System.EventHandler(this.nav_about_Click);
            // 
            // nav_camere_help
            // 
            this.nav_camere_help.Name = "nav_camere_help";
            this.nav_camere_help.Size = new System.Drawing.Size(52, 20);
            this.nav_camere_help.Text = "Ajutor";
            this.nav_camere_help.Click += new System.EventHandler(this.nav_camere_help_Click);
            // 
            // buton_stergeCamere
            // 
            this.buton_stergeCamere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buton_stergeCamere.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buton_stergeCamere.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buton_stergeCamere.Image = global::administrare_hotel.Properties.Resources.delete;
            this.buton_stergeCamere.Location = new System.Drawing.Point(602, 210);
            this.buton_stergeCamere.Name = "buton_stergeCamere";
            this.buton_stergeCamere.Size = new System.Drawing.Size(148, 60);
            this.buton_stergeCamere.TabIndex = 3;
            this.buton_stergeCamere.Text = "Sterge";
            this.buton_stergeCamere.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buton_stergeCamere.UseVisualStyleBackColor = true;
            this.buton_stergeCamere.Click += new System.EventHandler(this.buton_stergeCamere_Click);
            // 
            // buton_modificaCamere
            // 
            this.buton_modificaCamere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buton_modificaCamere.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buton_modificaCamere.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buton_modificaCamere.Image = global::administrare_hotel.Properties.Resources.edit;
            this.buton_modificaCamere.Location = new System.Drawing.Point(602, 144);
            this.buton_modificaCamere.Name = "buton_modificaCamere";
            this.buton_modificaCamere.Size = new System.Drawing.Size(148, 60);
            this.buton_modificaCamere.TabIndex = 2;
            this.buton_modificaCamere.Text = "Modifica";
            this.buton_modificaCamere.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buton_modificaCamere.UseVisualStyleBackColor = true;
            this.buton_modificaCamere.Click += new System.EventHandler(this.buton_modificaCamere_Click);
            // 
            // buton_adaugaCamere
            // 
            this.buton_adaugaCamere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buton_adaugaCamere.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buton_adaugaCamere.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buton_adaugaCamere.Image = ((System.Drawing.Image)(resources.GetObject("buton_adaugaCamere.Image")));
            this.buton_adaugaCamere.Location = new System.Drawing.Point(602, 78);
            this.buton_adaugaCamere.Name = "buton_adaugaCamere";
            this.buton_adaugaCamere.Size = new System.Drawing.Size(148, 60);
            this.buton_adaugaCamere.TabIndex = 1;
            this.buton_adaugaCamere.Text = "Adauga";
            this.buton_adaugaCamere.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buton_adaugaCamere.UseVisualStyleBackColor = true;
            this.buton_adaugaCamere.Click += new System.EventHandler(this.buton_adaugaCamere_Click);
            // 
            // Camere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(758, 511);
            this.ControlBox = false;
            this.Controls.Add(this.buton_iesireCamere);
            this.Controls.Add(this.buton_stergeCamere);
            this.Controls.Add(this.buton_modificaCamere);
            this.Controls.Add(this.buton_adaugaCamere);
            this.Controls.Add(this.date_camere);
            this.Controls.Add(this.nav_camere);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.nav_camere;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Camere";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Camere";
            this.Load += new System.EventHandler(this.Camere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.date_camere)).EndInit();
            this.nav_camere.ResumeLayout(false);
            this.nav_camere.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView date_camere;
        private System.Windows.Forms.Button buton_adaugaCamere;
        private System.Windows.Forms.Button buton_modificaCamere;
        private System.Windows.Forms.Button buton_stergeCamere;
        private System.Windows.Forms.Button buton_iesireCamere;
        private System.Windows.Forms.MenuStrip nav_camere;
        private System.Windows.Forms.ToolStripMenuItem nav_about;
        private System.Windows.Forms.ToolStripMenuItem nav_camere_help;
    }
}