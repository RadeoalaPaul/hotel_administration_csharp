namespace administrare_hotel
{
    partial class modificaClienti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modificaClienti));
            this.buton_modificaClientiSalvare = new System.Windows.Forms.Button();
            this.buton_IesiremodificaClienti = new System.Windows.Forms.Button();
            this.text_modificaClienti_telefon = new System.Windows.Forms.TextBox();
            this.text_modificaClienti_prenume = new System.Windows.Forms.TextBox();
            this.text_modificaClienti_nume = new System.Windows.Forms.TextBox();
            this.label_nume = new System.Windows.Forms.Label();
            this.label_prenume = new System.Windows.Forms.Label();
            this.label_telefon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buton_modificaClientiSalvare
            // 
            this.buton_modificaClientiSalvare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buton_modificaClientiSalvare.Location = new System.Drawing.Point(91, 171);
            this.buton_modificaClientiSalvare.Name = "buton_modificaClientiSalvare";
            this.buton_modificaClientiSalvare.Size = new System.Drawing.Size(101, 33);
            this.buton_modificaClientiSalvare.TabIndex = 14;
            this.buton_modificaClientiSalvare.Text = "Salvare";
            this.buton_modificaClientiSalvare.UseVisualStyleBackColor = true;
            this.buton_modificaClientiSalvare.Click += new System.EventHandler(this.buton_modificaClientiSalvare_Click);
            // 
            // buton_IesiremodificaClienti
            // 
            this.buton_IesiremodificaClienti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buton_IesiremodificaClienti.Location = new System.Drawing.Point(91, 210);
            this.buton_IesiremodificaClienti.Name = "buton_IesiremodificaClienti";
            this.buton_IesiremodificaClienti.Size = new System.Drawing.Size(101, 33);
            this.buton_IesiremodificaClienti.TabIndex = 15;
            this.buton_IesiremodificaClienti.Text = "Iesire";
            this.buton_IesiremodificaClienti.UseVisualStyleBackColor = true;
            this.buton_IesiremodificaClienti.Click += new System.EventHandler(this.buton_IesiremodificaClienti_Click);
            // 
            // text_modificaClienti_telefon
            // 
            this.text_modificaClienti_telefon.Location = new System.Drawing.Point(67, 77);
            this.text_modificaClienti_telefon.Name = "text_modificaClienti_telefon";
            this.text_modificaClienti_telefon.Size = new System.Drawing.Size(186, 20);
            this.text_modificaClienti_telefon.TabIndex = 25;
            // 
            // text_modificaClienti_prenume
            // 
            this.text_modificaClienti_prenume.Location = new System.Drawing.Point(67, 51);
            this.text_modificaClienti_prenume.Name = "text_modificaClienti_prenume";
            this.text_modificaClienti_prenume.Size = new System.Drawing.Size(186, 20);
            this.text_modificaClienti_prenume.TabIndex = 26;
            // 
            // text_modificaClienti_nume
            // 
            this.text_modificaClienti_nume.Location = new System.Drawing.Point(67, 25);
            this.text_modificaClienti_nume.Name = "text_modificaClienti_nume";
            this.text_modificaClienti_nume.Size = new System.Drawing.Size(186, 20);
            this.text_modificaClienti_nume.TabIndex = 27;
            // 
            // label_nume
            // 
            this.label_nume.AutoSize = true;
            this.label_nume.Location = new System.Drawing.Point(12, 28);
            this.label_nume.Name = "label_nume";
            this.label_nume.Size = new System.Drawing.Size(35, 13);
            this.label_nume.TabIndex = 28;
            this.label_nume.Text = "Nume";
            this.label_nume.UseMnemonic = false;
            // 
            // label_prenume
            // 
            this.label_prenume.AutoSize = true;
            this.label_prenume.Location = new System.Drawing.Point(12, 54);
            this.label_prenume.Name = "label_prenume";
            this.label_prenume.Size = new System.Drawing.Size(49, 13);
            this.label_prenume.TabIndex = 29;
            this.label_prenume.Text = "Prenume";
            // 
            // label_telefon
            // 
            this.label_telefon.AutoSize = true;
            this.label_telefon.Location = new System.Drawing.Point(12, 84);
            this.label_telefon.Name = "label_telefon";
            this.label_telefon.Size = new System.Drawing.Size(43, 13);
            this.label_telefon.TabIndex = 30;
            this.label_telefon.Text = "Telefon";
            // 
            // modificaClienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 255);
            this.Controls.Add(this.label_telefon);
            this.Controls.Add(this.label_prenume);
            this.Controls.Add(this.label_nume);
            this.Controls.Add(this.text_modificaClienti_nume);
            this.Controls.Add(this.text_modificaClienti_prenume);
            this.Controls.Add(this.text_modificaClienti_telefon);
            this.Controls.Add(this.buton_IesiremodificaClienti);
            this.Controls.Add(this.buton_modificaClientiSalvare);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "modificaClienti";
            this.Text = "modificaClienti";
            this.Load += new System.EventHandler(this.modificaClienti_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buton_modificaClientiSalvare;
        private System.Windows.Forms.Button buton_IesiremodificaClienti;
        private System.Windows.Forms.TextBox text_modificaClienti_telefon;
        private System.Windows.Forms.TextBox text_modificaClienti_prenume;
        private System.Windows.Forms.TextBox text_modificaClienti_nume;
        private System.Windows.Forms.Label label_nume;
        private System.Windows.Forms.Label label_prenume;
        private System.Windows.Forms.Label label_telefon;
    }
}