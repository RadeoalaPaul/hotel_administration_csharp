namespace administrare_hotel
{
    partial class modificaCamere
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modificaCamere));
            this.buton_IesireModificaCamere = new System.Windows.Forms.Button();
            this.buton_modificaCamereSalvare = new System.Windows.Forms.Button();
            this.text_modificaCamere_pat_dublu = new System.Windows.Forms.TextBox();
            this.text_modificaCamere_frigider = new System.Windows.Forms.TextBox();
            this.label_frigider = new System.Windows.Forms.Label();
            this.label_pat_dublu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buton_IesireModificaCamere
            // 
            this.buton_IesireModificaCamere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buton_IesireModificaCamere.Location = new System.Drawing.Point(91, 210);
            this.buton_IesireModificaCamere.Name = "buton_IesireModificaCamere";
            this.buton_IesireModificaCamere.Size = new System.Drawing.Size(101, 33);
            this.buton_IesireModificaCamere.TabIndex = 12;
            this.buton_IesireModificaCamere.Text = "Iesire";
            this.buton_IesireModificaCamere.UseVisualStyleBackColor = true;
            this.buton_IesireModificaCamere.Click += new System.EventHandler(this.buton_IesireModificaCamere_Click);
            // 
            // buton_modificaCamereSalvare
            // 
            this.buton_modificaCamereSalvare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buton_modificaCamereSalvare.Location = new System.Drawing.Point(91, 171);
            this.buton_modificaCamereSalvare.Name = "buton_modificaCamereSalvare";
            this.buton_modificaCamereSalvare.Size = new System.Drawing.Size(101, 33);
            this.buton_modificaCamereSalvare.TabIndex = 13;
            this.buton_modificaCamereSalvare.Text = "Salvare";
            this.buton_modificaCamereSalvare.UseVisualStyleBackColor = true;
            this.buton_modificaCamereSalvare.Click += new System.EventHandler(this.buton_modificaCamereSalvare_Click);
            // 
            // text_modificaCamere_pat_dublu
            // 
            this.text_modificaCamere_pat_dublu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_modificaCamere_pat_dublu.Location = new System.Drawing.Point(67, 103);
            this.text_modificaCamere_pat_dublu.Name = "text_modificaCamere_pat_dublu";
            this.text_modificaCamere_pat_dublu.Size = new System.Drawing.Size(186, 20);
            this.text_modificaCamere_pat_dublu.TabIndex = 14;
            // 
            // text_modificaCamere_frigider
            // 
            this.text_modificaCamere_frigider.Location = new System.Drawing.Point(67, 77);
            this.text_modificaCamere_frigider.Name = "text_modificaCamere_frigider";
            this.text_modificaCamere_frigider.Size = new System.Drawing.Size(186, 20);
            this.text_modificaCamere_frigider.TabIndex = 16;
            // 
            // label_frigider
            // 
            this.label_frigider.AutoSize = true;
            this.label_frigider.Location = new System.Drawing.Point(20, 77);
            this.label_frigider.Name = "label_frigider";
            this.label_frigider.Size = new System.Drawing.Size(41, 13);
            this.label_frigider.TabIndex = 20;
            this.label_frigider.Text = "Frigider";
            // 
            // label_pat_dublu
            // 
            this.label_pat_dublu.AutoSize = true;
            this.label_pat_dublu.Location = new System.Drawing.Point(9, 105);
            this.label_pat_dublu.Name = "label_pat_dublu";
            this.label_pat_dublu.Size = new System.Drawing.Size(52, 13);
            this.label_pat_dublu.TabIndex = 21;
            this.label_pat_dublu.Text = "Pat dublu";
            // 
            // modificaCamere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 255);
            this.Controls.Add(this.label_pat_dublu);
            this.Controls.Add(this.label_frigider);
            this.Controls.Add(this.text_modificaCamere_frigider);
            this.Controls.Add(this.text_modificaCamere_pat_dublu);
            this.Controls.Add(this.buton_modificaCamereSalvare);
            this.Controls.Add(this.buton_IesireModificaCamere);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "modificaCamere";
            this.Text = "modificaCamere";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buton_IesireModificaCamere;
        private System.Windows.Forms.Button buton_modificaCamereSalvare;
        private System.Windows.Forms.TextBox text_modificaCamere_pat_dublu;
        private System.Windows.Forms.TextBox text_modificaCamere_frigider;
        private System.Windows.Forms.Label label_frigider;
        private System.Windows.Forms.Label label_pat_dublu;
    }
}