using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using Pszczola.Model;

namespace Pszczola
{
    public partial class Form1 : Form
    {

        protected DataSet Ds { get; set; }
        protected Ul Ul { get; set; }
        protected int Index { get; set; }
        protected int Ulid { get; set; }
        protected int Rok { get; set; }

        private Polaczenie _polaczenie = new Polaczenie();
        private Zapytania _zapytania = new Zapytania();

        public Form1()
        {
            InitializeComponent();
            if (!File.Exists("baza.sqlite"))
            {
                SQLiteConnection.CreateFile("baza.sqlite");
            }
            
            OdswiezListe();
            KontrolkiHide();
        }

        private void KontrolkiHide()
        {
            foreach (var k in this.Controls)
            {
                var c = k as Control;
                if ((string)c.Tag == "kontrolki")
                {
                    c.Visible = false;
                }
            }
        }

        private void KontrolkiShow()
        {
            foreach (var k in this.Controls)
            {
                var c = k as Control;
                if ((string)c.Tag == "kontrolki")
                {
                    c.Visible = true;
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            _zapytania.DodajUl(t_nowy.Text, comboBox1.Text);
            OdswiezListe();
        }


        private void OdswiezListe()
        {
            Index = 0;

            if (dataGridView1.DataSource != null & dataGridView1.SelectedRows.Count > 0)
            { 
                Index = dataGridView1.SelectedRows[0].Index;
                dataGridView1.Rows[Index].Selected = true;
            }

            Ds = _zapytania.PobierzListeUli(comboBox1.Text);

            try
            {
                dataGridView1.DataSource = Ds.Tables[0];
                dataGridView1.Columns[0].Visible = false;

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[Index].Selected = true;
                }

            }
            catch (System.IndexOutOfRangeException)
            {
                MessageBox.Show("Brak tabel. Zostaną one utworzone");
                _zapytania.UtworzTabele();
                OdswiezListe();
            }
        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            
            try
            {
                SprawdzenieZmian();
                Ulid = Int32.Parse(dataGridView1.SelectedCells[0].Value.ToString());
                Ul = _zapytania.PobierzUl(Ulid);
                GenerujDane(Ul, Ulid);
                KontrolkiShow();
            }
            catch (ArgumentOutOfRangeException)
            {
                //lista jest pusta
            }
        }

        private void SprawdzenieZmian()
        {
            if(Ul!=null && (t_nazwa.Text!=Ul.Nazwa || t_oznaczM.Text!=Ul.OznaczenieMatki || t_pochM.Text!=Ul.PochodzenieMatki))
            {
                DialogResult dialog = MessageBox.Show("Istnieją niezapisane dane.\nCzy chcesz je zapisać teraz?", "Informacja", MessageBoxButtons.YesNo);
                if(dialog == DialogResult.Yes)
                {
                    B_zapisz_Click(this, new EventArgs());
                }
            }
        }

        private void GenerujDane(Ul u, int id)
        {
            t_nazwa.Text = u.Nazwa;
            t_pochM.Text = u.PochodzenieMatki;
            t_oznaczM.Text = u.OznaczenieMatki;
            OdswiezNotatki();
            OdswiezMiodobrania();
        }

        private void OdswiezNotatki()
        {
            listBox1.Items.Clear();
            Ds = _zapytania.PobierzNotatki(Ul.IdUla, Ul.Rok);

            foreach (DataRow s in Ds.Tables[0].Rows)
            {
                listBox1.Items.Add("[" + s["data"].ToString() + "] " + s["opis"].ToString());
            }
        }

        private void OdswiezMiodobrania()
        {
            listBox2.Items.Clear();
            Ds = _zapytania.PobierzMiodobrania(Ul.IdUla, Ul.Rok);
            foreach (DataRow s in Ds.Tables[0].Rows)
            {
                listBox2.Items.Add("[" + s["data"].ToString() + "] " + s["nazwa"].ToString() + ": Waga netto: " + s["wagan"].ToString() + ": Waga brutto: " + s["wagab"].ToString() + ", Ramki: " + s["ramki"].ToString() + ", Uwagi: " + s["uwagi"].ToString());
            }
        }

        private void B_zapisz_Click(object sender, EventArgs e)
        {
            if (Ul.OznaczenieMatki != t_oznaczM.Text)
            {
                _zapytania.DodajHistorie("Oznaczenie Matki", Ul.IdUla, Ul.OznaczenieMatki, t_oznaczM.Text, Ul.Rok);
            }

            if (Ul.PochodzenieMatki != t_pochM.Text)
            {
                _zapytania.DodajHistorie("Pochodzenie Matki", Ul.IdUla, Ul.PochodzenieMatki, t_pochM.Text, Ul.Rok);
            }

            if (Ul.Nazwa != t_nazwa.Text)
            {
                _zapytania.DodajHistorie("Nazwa ula", Ul.IdUla, Ul.Nazwa, t_nazwa.Text, Ul.Rok);
            }

            var nowyUl = new Ul
            {
                IdUla = Ul.IdUla,
                Nazwa = t_nazwa.Text,
                PochodzenieMatki = t_pochM.Text,
                OznaczenieMatki = t_oznaczM.Text,
            };

            _zapytania.AktualizujUl(nowyUl);
            Ul = _zapytania.PobierzUl(Ulid);
            OdswiezListe();
        }

        private void B_historia_Click(object sender, EventArgs e)
        {
            Rok = Convert.ToInt32(comboBox1.Text);
            FormHistory hist = new FormHistory(Ulid, Rok);
            hist.ShowDialog();            
        }

        private void ComboBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            KontrolkiHide();
            OdswiezListe();
        }

        private void B_dodajNotatke_Click(object sender, EventArgs e)
        {
            _zapytania.DodajNotatke(t_dodajNot.Text, Ul.IdUla, Ul.Rok);
            t_dodajNot.Text = "";
            OdswiezNotatki();
            OdswiezMiodobrania();
        }

        private void B_notatki_Click(object sender, EventArgs e)
        {
            Rok = Convert.ToInt32(comboBox1.Text);
            FormNotes hist = new FormNotes(Ulid, Rok);
            hist.ShowDialog();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            FormMiodobranie f = new FormMiodobranie();
            f.ShowDialog();
        }

        private void B_miodobrania_Click(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            FormMiodobranie f = new FormMiodobranie(Ul.IdUla, Ul.Rok);
            f.ShowDialog();
            OdswiezMiodobrania();
        }

        private void B_stat_Click(object sender, EventArgs e)
        {
            FormStat f = new FormStat();
            f.ShowDialog();
        }
    }
}
