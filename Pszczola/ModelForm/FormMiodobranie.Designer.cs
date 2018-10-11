namespace Pszczola
{
    partial class FormMiodobranie
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.t_wagaTara = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.t_ramki = new System.Windows.Forms.TextBox();
            this.t_wagaRazem = new System.Windows.Forms.TextBox();
            this.b_Dodaj = new System.Windows.Forms.Button();
            this.t_uwagi = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // t_wagaTara
            // 
            this.t_wagaTara.Location = new System.Drawing.Point(120, 76);
            this.t_wagaTara.Name = "t_wagaTara";
            this.t_wagaTara.Size = new System.Drawing.Size(100, 20);
            this.t_wagaTara.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Waga ramek po odw.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ilość ramek";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Waga razem";
            // 
            // t_ramki
            // 
            this.t_ramki.Location = new System.Drawing.Point(118, 25);
            this.t_ramki.Name = "t_ramki";
            this.t_ramki.Size = new System.Drawing.Size(100, 20);
            this.t_ramki.TabIndex = 2;
            // 
            // t_wagaRazem
            // 
            this.t_wagaRazem.Location = new System.Drawing.Point(12, 76);
            this.t_wagaRazem.Name = "t_wagaRazem";
            this.t_wagaRazem.Size = new System.Drawing.Size(100, 20);
            this.t_wagaRazem.TabIndex = 3;
            // 
            // button1
            // 
            this.b_Dodaj.Location = new System.Drawing.Point(14, 195);
            this.b_Dodaj.Name = "button1";
            this.b_Dodaj.Size = new System.Drawing.Size(206, 23);
            this.b_Dodaj.TabIndex = 6;
            this.b_Dodaj.Text = "Dodaj";
            this.b_Dodaj.UseVisualStyleBackColor = true;
            this.b_Dodaj.Click += new System.EventHandler(this.B_dodaj_Click);
            // 
            // t_uwagi
            // 
            this.t_uwagi.Location = new System.Drawing.Point(12, 127);
            this.t_uwagi.Name = "t_uwagi";
            this.t_uwagi.Size = new System.Drawing.Size(206, 62);
            this.t_uwagi.TabIndex = 5;
            this.t_uwagi.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Uwagi";
            // 
            // FormMiodobranie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 227);
            this.Controls.Add(this.t_uwagi);
            this.Controls.Add(this.b_Dodaj);
            this.Controls.Add(this.t_wagaRazem);
            this.Controls.Add(this.t_ramki);
            this.Controls.Add(this.t_wagaTara);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMiodobranie";
            this.Text = "Miodobranie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox t_wagaTara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox t_ramki;
        private System.Windows.Forms.TextBox t_wagaRazem;
        private System.Windows.Forms.Button b_Dodaj;
        private System.Windows.Forms.RichTextBox t_uwagi;
        private System.Windows.Forms.Label label5;
    }
}