namespace Pszczola.ModelForm
{
    partial class FormStatWybor
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
            this.label1 = new System.Windows.Forms.Label();
            this.b_generuj = new System.Windows.Forms.Button();
            this.radio_ogolna = new System.Windows.Forms.RadioButton();
            this.radio_ogolnaRok = new System.Windows.Forms.RadioButton();
            this.radio_ul = new System.Windows.Forms.RadioButton();
            this.radio_ulRok = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wybierz rodzaj statystyk";
            // 
            // b_generuj
            // 
            this.b_generuj.Location = new System.Drawing.Point(15, 117);
            this.b_generuj.Name = "b_generuj";
            this.b_generuj.Size = new System.Drawing.Size(193, 23);
            this.b_generuj.TabIndex = 5;
            this.b_generuj.Text = "Generuj";
            this.b_generuj.UseVisualStyleBackColor = true;
            this.b_generuj.Click += new System.EventHandler(this.B_generuj_Click);
            // 
            // radio_ogolna
            // 
            this.radio_ogolna.AutoSize = true;
            this.radio_ogolna.Location = new System.Drawing.Point(15, 25);
            this.radio_ogolna.Name = "radio_ogolna";
            this.radio_ogolna.Size = new System.Drawing.Size(114, 17);
            this.radio_ogolna.TabIndex = 6;
            this.radio_ogolna.TabStop = true;
            this.radio_ogolna.Text = "Ogólna ilość miodu";
            this.radio_ogolna.UseVisualStyleBackColor = true;
            // 
            // radio_ogolnaRok
            // 
            this.radio_ogolnaRok.AutoSize = true;
            this.radio_ogolnaRok.Location = new System.Drawing.Point(15, 48);
            this.radio_ogolnaRok.Name = "radio_ogolnaRok";
            this.radio_ogolnaRok.Size = new System.Drawing.Size(149, 17);
            this.radio_ogolnaRok.TabIndex = 7;
            this.radio_ogolnaRok.TabStop = true;
            this.radio_ogolnaRok.Text = "Ogólna ilość miodu w roku";
            this.radio_ogolnaRok.UseVisualStyleBackColor = true;
            // 
            // radio_ul
            // 
            this.radio_ul.AutoSize = true;
            this.radio_ul.Location = new System.Drawing.Point(15, 71);
            this.radio_ul.Name = "radio_ul";
            this.radio_ul.Size = new System.Drawing.Size(103, 17);
            this.radio_ul.TabIndex = 8;
            this.radio_ul.TabStop = true;
            this.radio_ul.Text = "Ilość miodu z ula";
            this.radio_ul.UseVisualStyleBackColor = true;
            // 
            // radio_ulRok
            // 
            this.radio_ulRok.AutoSize = true;
            this.radio_ulRok.Location = new System.Drawing.Point(15, 94);
            this.radio_ulRok.Name = "radio_ulRok";
            this.radio_ulRok.Size = new System.Drawing.Size(138, 17);
            this.radio_ulRok.TabIndex = 9;
            this.radio_ulRok.TabStop = true;
            this.radio_ulRok.Text = "Ilość miodu z ula w roku";
            this.radio_ulRok.UseVisualStyleBackColor = true;
            // 
            // FormStatWybor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 153);
            this.Controls.Add(this.radio_ulRok);
            this.Controls.Add(this.radio_ul);
            this.Controls.Add(this.radio_ogolnaRok);
            this.Controls.Add(this.radio_ogolna);
            this.Controls.Add(this.b_generuj);
            this.Controls.Add(this.label1);
            this.Name = "FormStatWybor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Statystyki";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_generuj;
        private System.Windows.Forms.RadioButton radio_ogolna;
        private System.Windows.Forms.RadioButton radio_ogolnaRok;
        private System.Windows.Forms.RadioButton radio_ul;
        private System.Windows.Forms.RadioButton radio_ulRok;
    }
}