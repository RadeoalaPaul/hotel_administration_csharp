namespace administrare_hotel
{
    partial class Clienti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clienti));
            this.date_clienti = new System.Windows.Forms.DataGridView();
            this.buton_iesireClienti = new System.Windows.Forms.Button();
            this.nav_clienti = new System.Windows.Forms.MenuStrip();
            this.nav_about = new System.Windows.Forms.ToolStripMenuItem();
            this.nav_clienti_help = new System.Windows.Forms.ToolStripMenuItem();
            this.buton_stergeClienti = new System.Windows.Forms.Button();
            this.buton_modificaClienti = new System.Windows.Forms.Button();
            this.buton_adaugaCLienti = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.date_clienti)).BeginInit();
            this.nav_clienti.SuspendLayout();
            this.SuspendLayout();
            // 
            // date_clienti
            // 
            this.date_clienti.BackgroundColor = System.Drawing.SystemColors.Control;
            this.date_clienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.date_clienti.Location = new System.Drawing.Point(12, 78);
            this.date_clienti.Name = "date_clienti";
            this.date_clienti.Size = new System.Drawing.Size(584, 421);
            this.date_clienti.TabIndex = 0;
            // 
            // buton_iesireClienti
            // 
            this.buton_iesireClienti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buton_iesireClienti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buton_iesireClienti.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buton_iesireClienti.Location = new System.Drawing.Point(602, 439);
            this.buton_iesireClienti.Name = "buton_iesireClienti";
            this.buton_iesireClienti.Size = new System.Drawing.Size(148, 60);
            this.buton_iesireClienti.TabIndex = 4;
            this.buton_iesireClienti.Text = "Iesire";
            this.buton_iesireClienti.UseVisualStyleBackColor = true;
            this.buton_iesireClienti.Click += new System.EventHandler(this.buton_iesireClienti_Click);
            // 
            // nav_clienti
            // 
            this.nav_clienti.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.nav_clienti.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nav_about,
            this.nav_clienti_help});
            this.nav_clienti.Location = new System.Drawing.Point(0, 0);
            this.nav_clienti.Name = "nav_clienti";
            this.nav_clienti.Size = new System.Drawing.Size(758, 24);
            this.nav_clienti.TabIndex = 5;
            this.nav_clienti.Text = "menuStrip1";
            // 
            // nav_about
            // 
            this.nav_about.Name = "nav_about";
            this.nav_about.Size = new System.Drawing.Size(52, 20);
            this.nav_about.Text = "About";
            this.nav_about.Click += new System.EventHandler(this.nav_about_Click);
            // 
            // nav_clienti_help
            // 
            this.nav_clienti_help.Name = "nav_clienti_help";
            this.nav_clienti_help.Size = new System.Drawing.Size(44, 20);
            this.nav_clienti_help.Text = "Help";
            this.nav_clienti_help.Click += new System.EventHandler(this.nav_clienti_help_Click);
            // 
            // buton_stergeClienti
            // 
            this.buton_stergeClienti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buton_stergeClienti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buton_stergeClienti.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buton_stergeClienti.Image = global::administrare_hotel.Properties.Resources.delete;
            this.buton_stergeClienti.Location = new System.Drawing.Point(602, 210);
            this.buton_stergeClienti.Name = "buton_stergeClienti";
            this.buton_stergeClienti.Size = new System.Drawing.Size(148, 60);
            this.buton_stergeClienti.TabIndex = 3;
            this.buton_stergeClienti.Text = "Sterge";
            this.buton_stergeClienti.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buton_stergeClienti.UseVisualStyleBackColor = true;
            // 
            // buton_modificaClienti
            // 
            this.buton_modificaClienti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buton_modificaClienti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buton_modificaClienti.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buton_modificaClienti.Image = global::administrare_hotel.Properties.Resources.edit;
            this.buton_modificaClienti.Location = new System.Drawing.Point(602, 144);
            this.buton_modificaClienti.Name = "buton_modificaClienti";
            this.buton_modificaClienti.Size = new System.Drawing.Size(148, 60);
            this.buton_modificaClienti.TabIndex = 2;
            this.buton_modificaClienti.Text = "Modifica";
            this.buton_modificaClienti.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buton_modificaClienti.UseVisualStyleBackColor = true;
            // 
            // buton_adaugaCLienti
            // 
            this.buton_adaugaCLienti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buton_adaugaCLienti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buton_adaugaCLienti.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buton_adaugaCLienti.Image = ((System.Drawing.Image)(resources.GetObject("buton_adaugaCLienti.Image")));
            this.buton_adaugaCLienti.Location = new System.Drawing.Point(602, 78);
            this.buton_adaugaCLienti.Name = "buton_adaugaCLienti";
            this.buton_adaugaCLienti.Size = new System.Drawing.Size(148, 60);
            this.buton_adaugaCLienti.TabIndex = 1;
            this.buton_adaugaCLienti.Text = "Adauga";
            this.buton_adaugaCLienti.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buton_adaugaCLienti.UseVisualStyleBackColor = true;
            // 
            // Clienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(758, 511);
            this.ControlBox = false;
            this.Controls.Add(this.buton_iesireClienti);
            this.Controls.Add(this.buton_stergeClienti);
            this.Controls.Add(this.buton_modificaClienti);
            this.Controls.Add(this.buton_adaugaCLienti);
            this.Controls.Add(this.date_clienti);
            this.Controls.Add(this.nav_clienti);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.nav_clienti;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Clienti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clienti";
            ((System.ComponentModel.ISupportInitialize)(this.date_clienti)).EndInit();
            this.nav_clienti.ResumeLayout(false);
            this.nav_clienti.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView date_clienti;
        private System.Windows.Forms.Button buton_adaugaCLienti;
        private System.Windows.Forms.Button buton_modificaClienti;
        private System.Windows.Forms.Button buton_stergeClienti;
        private System.Windows.Forms.Button buton_iesireClienti;
        private System.Windows.Forms.MenuStrip nav_clienti;
        private System.Windows.Forms.ToolStripMenuItem nav_about;
        private System.Windows.Forms.ToolStripMenuItem nav_clienti_help;
    }
}