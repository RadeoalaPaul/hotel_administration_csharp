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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buton_adaugaCamere = new System.Windows.Forms.Button();
            this.buton_modificaCamere = new System.Windows.Forms.Button();
            this.buton_stergeCamere = new System.Windows.Forms.Button();
            this.buton_iesireCamere = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(584, 421);
            this.dataGridView1.TabIndex = 0;
            // 
            // buton_adaugaCamere
            // 
            this.buton_adaugaCamere.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buton_adaugaCamere.Location = new System.Drawing.Point(610, 86);
            this.buton_adaugaCamere.Name = "buton_adaugaCamere";
            this.buton_adaugaCamere.Size = new System.Drawing.Size(130, 60);
            this.buton_adaugaCamere.TabIndex = 1;
            this.buton_adaugaCamere.Text = "Adauga";
            this.buton_adaugaCamere.UseVisualStyleBackColor = true;
            // 
            // buton_modificaCamere
            // 
            this.buton_modificaCamere.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buton_modificaCamere.Location = new System.Drawing.Point(610, 152);
            this.buton_modificaCamere.Name = "buton_modificaCamere";
            this.buton_modificaCamere.Size = new System.Drawing.Size(130, 60);
            this.buton_modificaCamere.TabIndex = 2;
            this.buton_modificaCamere.Text = "Modifica";
            this.buton_modificaCamere.UseVisualStyleBackColor = true;
            // 
            // buton_stergeCamere
            // 
            this.buton_stergeCamere.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buton_stergeCamere.Location = new System.Drawing.Point(610, 218);
            this.buton_stergeCamere.Name = "buton_stergeCamere";
            this.buton_stergeCamere.Size = new System.Drawing.Size(130, 60);
            this.buton_stergeCamere.TabIndex = 3;
            this.buton_stergeCamere.Text = "Sterge";
            this.buton_stergeCamere.UseVisualStyleBackColor = true;
            // 
            // buton_iesireCamere
            // 
            this.buton_iesireCamere.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buton_iesireCamere.Location = new System.Drawing.Point(610, 447);
            this.buton_iesireCamere.Name = "buton_iesireCamere";
            this.buton_iesireCamere.Size = new System.Drawing.Size(130, 60);
            this.buton_iesireCamere.TabIndex = 4;
            this.buton_iesireCamere.Text = "Iesire";
            this.buton_iesireCamere.UseVisualStyleBackColor = true;
            this.buton_iesireCamere.Click += new System.EventHandler(this.buton_iesireCamere_Click);
            // 
            // Camere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(752, 519);
            this.ControlBox = false;
            this.Controls.Add(this.buton_iesireCamere);
            this.Controls.Add(this.buton_stergeCamere);
            this.Controls.Add(this.buton_modificaCamere);
            this.Controls.Add(this.buton_adaugaCamere);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Camere";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Camere";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buton_adaugaCamere;
        private System.Windows.Forms.Button buton_modificaCamere;
        private System.Windows.Forms.Button buton_stergeCamere;
        private System.Windows.Forms.Button buton_iesireCamere;
    }
}