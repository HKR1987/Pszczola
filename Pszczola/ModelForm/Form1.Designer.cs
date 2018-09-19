namespace Pszczola
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.b_dodaj = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.t_nazwa = new System.Windows.Forms.TextBox();
            this.t_oznaczM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.l_rok = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.t_pochM = new System.Windows.Forms.TextBox();
            this.b_zapisz = new System.Windows.Forms.Button();
            this.b_historia = new System.Windows.Forms.Button();
            this.t_nowy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.b_notatki = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.t_dodajNot = new System.Windows.Forms.TextBox();
            this.b_dodajNotatke = new System.Windows.Forms.Button();
            this.b_miodobrania = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.b_stat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // b_dodaj
            // 
            this.b_dodaj.Location = new System.Drawing.Point(202, 335);
            this.b_dodaj.Name = "b_dodaj";
            this.b_dodaj.Size = new System.Drawing.Size(46, 23);
            this.b_dodaj.TabIndex = 13;
            this.b_dodaj.Text = "Dodaj";
            this.b_dodaj.UseVisualStyleBackColor = true;
            this.b_dodaj.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.MenuText;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(233, 290);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Click += new System.EventHandler(this.DataGridView1_Click);
            // 
            // t_nazwa
            // 
            this.t_nazwa.Location = new System.Drawing.Point(357, 12);
            this.t_nazwa.Name = "t_nazwa";
            this.t_nazwa.Size = new System.Drawing.Size(100, 20);
            this.t_nazwa.TabIndex = 3;
            this.t_nazwa.Tag = "kontrolki";
            // 
            // t_oznaczM
            // 
            this.t_oznaczM.Location = new System.Drawing.Point(592, 45);
            this.t_oznaczM.Name = "t_oznaczM";
            this.t_oznaczM.Size = new System.Drawing.Size(100, 20);
            this.t_oznaczM.TabIndex = 6;
            this.t_oznaczM.Tag = "kontrolki";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(475, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 26);
            this.label1.TabIndex = 5;
            this.label1.Tag = "kontrolki";
            this.label1.Text = "Oznaczenie matki\r\n(barwa znaczka / rok)\r\n";
            // 
            // comboBox1
            // 
            this.comboBox1.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019"});
            this.comboBox1.Location = new System.Drawing.Point(45, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "2018";
            this.comboBox1.TextChanged += new System.EventHandler(this.ComboBox1_TextChanged);
            // 
            // l_rok
            // 
            this.l_rok.AutoSize = true;
            this.l_rok.Location = new System.Drawing.Point(12, 15);
            this.l_rok.Name = "l_rok";
            this.l_rok.Size = new System.Drawing.Size(27, 13);
            this.l_rok.TabIndex = 7;
            this.l_rok.Text = "Rok";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Tag = "kontrolki";
            this.label2.Text = "Nazwa ula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 26);
            this.label3.TabIndex = 9;
            this.label3.Tag = "kontrolki";
            this.label3.Text = "Pochodzenie matki\r\n(rasa / linia)\r\n";
            // 
            // t_pochM
            // 
            this.t_pochM.Location = new System.Drawing.Point(357, 45);
            this.t_pochM.Name = "t_pochM";
            this.t_pochM.Size = new System.Drawing.Size(100, 20);
            this.t_pochM.TabIndex = 5;
            this.t_pochM.Tag = "kontrolki";
            // 
            // b_zapisz
            // 
            this.b_zapisz.Location = new System.Drawing.Point(445, 335);
            this.b_zapisz.Name = "b_zapisz";
            this.b_zapisz.Size = new System.Drawing.Size(75, 23);
            this.b_zapisz.TabIndex = 15;
            this.b_zapisz.Tag = "kontrolki";
            this.b_zapisz.Text = "Zapisz";
            this.b_zapisz.UseVisualStyleBackColor = true;
            this.b_zapisz.Click += new System.EventHandler(this.B_zapisz_Click);
            // 
            // b_historia
            // 
            this.b_historia.Location = new System.Drawing.Point(607, 335);
            this.b_historia.Name = "b_historia";
            this.b_historia.Size = new System.Drawing.Size(85, 23);
            this.b_historia.TabIndex = 17;
            this.b_historia.Tag = "kontrolki";
            this.b_historia.Text = "Historia zmian";
            this.b_historia.UseVisualStyleBackColor = true;
            this.b_historia.Click += new System.EventHandler(this.B_historia_Click);
            // 
            // t_nowy
            // 
            this.t_nowy.Location = new System.Drawing.Point(66, 337);
            this.t_nowy.Name = "t_nowy";
            this.t_nowy.Size = new System.Drawing.Size(130, 20);
            this.t_nowy.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nowy ul:";
            // 
            // b_notatki
            // 
            this.b_notatki.Location = new System.Drawing.Point(526, 335);
            this.b_notatki.Name = "b_notatki";
            this.b_notatki.Size = new System.Drawing.Size(75, 23);
            this.b_notatki.TabIndex = 16;
            this.b_notatki.Tag = "kontrolki";
            this.b_notatki.Text = "Notatki";
            this.b_notatki.UseVisualStyleBackColor = true;
            this.b_notatki.Click += new System.EventHandler(this.B_notatki_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(260, 221);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(432, 82);
            this.listBox1.TabIndex = 9;
            this.listBox1.Tag = "kontrolki";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 18;
            this.label5.Tag = "kontrolki";
            this.label5.Text = "Ostatnie notatki";
            // 
            // t_dodajNot
            // 
            this.t_dodajNot.Location = new System.Drawing.Point(260, 309);
            this.t_dodajNot.Name = "t_dodajNot";
            this.t_dodajNot.Size = new System.Drawing.Size(341, 20);
            this.t_dodajNot.TabIndex = 10;
            this.t_dodajNot.Tag = "kontrolki";
            // 
            // b_dodajNotatke
            // 
            this.b_dodajNotatke.Location = new System.Drawing.Point(607, 307);
            this.b_dodajNotatke.Name = "b_dodajNotatke";
            this.b_dodajNotatke.Size = new System.Drawing.Size(85, 23);
            this.b_dodajNotatke.TabIndex = 11;
            this.b_dodajNotatke.Tag = "kontrolki";
            this.b_dodajNotatke.Text = "Dodaj notatkę";
            this.b_dodajNotatke.UseVisualStyleBackColor = true;
            this.b_dodajNotatke.Click += new System.EventHandler(this.B_dodajNotatke_Click);
            // 
            // b_miodobrania
            // 
            this.b_miodobrania.Location = new System.Drawing.Point(364, 335);
            this.b_miodobrania.Name = "b_miodobrania";
            this.b_miodobrania.Size = new System.Drawing.Size(75, 23);
            this.b_miodobrania.TabIndex = 14;
            this.b_miodobrania.Tag = "kontrolki";
            this.b_miodobrania.Text = "Miodobrania";
            this.b_miodobrania.UseVisualStyleBackColor = true;
            this.b_miodobrania.Click += new System.EventHandler(this.B_miodobrania_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.HorizontalScrollbar = true;
            this.listBox2.Location = new System.Drawing.Point(260, 91);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(260, 108);
            this.listBox2.TabIndex = 7;
            this.listBox2.Tag = "kontrolki";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 8;
            this.label6.Tag = "kontrolki";
            this.label6.Text = "Miodobrania";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(526, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 108);
            this.button1.TabIndex = 8;
            this.button1.Tag = "kontrolki";
            this.button1.Text = "Dodaj miodobranie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_2);
            // 
            // b_stat
            // 
            this.b_stat.Location = new System.Drawing.Point(283, 335);
            this.b_stat.Name = "b_stat";
            this.b_stat.Size = new System.Drawing.Size(75, 23);
            this.b_stat.TabIndex = 19;
            this.b_stat.Tag = "kontrolki";
            this.b_stat.Text = "Statystyki";
            this.b_stat.UseVisualStyleBackColor = true;
            this.b_stat.Click += new System.EventHandler(this.B_stat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 370);
            this.Controls.Add(this.b_stat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.b_dodajNotatke);
            this.Controls.Add(this.t_dodajNot);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.b_miodobrania);
            this.Controls.Add(this.b_notatki);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.t_nowy);
            this.Controls.Add(this.b_historia);
            this.Controls.Add(this.b_zapisz);
            this.Controls.Add(this.t_pochM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.l_rok);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t_oznaczM);
            this.Controls.Add(this.t_nazwa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.b_dodaj);
            this.Name = "Form1";
            this.Text = "Pszczoła";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_dodaj;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox t_nazwa;
        private System.Windows.Forms.TextBox t_oznaczM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_rok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox t_pochM;
        private System.Windows.Forms.Button b_zapisz;
        private System.Windows.Forms.Button b_historia;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox t_nowy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button b_notatki;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox t_dodajNot;
        private System.Windows.Forms.Button b_dodajNotatke;
        private System.Windows.Forms.Button b_miodobrania;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button b_stat;
    }
}

