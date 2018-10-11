using Pszczola.Model;
using Pszczola.ModelForm;
using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace Pszczola
{
    public partial class FormMain : Form
    {
        protected Ul Ul { get; set; }
        protected int Index { get; set; }
        protected int Ulid { get; set; }
        protected int Rok { get; set; }
        private Zapytania _zapytania = new Zapytania();

        public FormMain()
        {
            InitializeComponent();
            if (!File.Exists("baza.sqlite"))
            {
                SQLiteConnection.CreateFile("baza.sqlite");
            }
            
            OdswiezListeUli();
            KontrolkiHide();
            Rok = Convert.ToInt32(cb_rok.Text);
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

        private void B_dodajUl_Click(object sender, EventArgs e)
        {
            _zapytania.DodajUl(t_nowy.Text, cb_rok.Text);
            OdswiezListeUli();
        }

        private void OdswiezListeUli()
        {
            Index = 0;

            if (dgv_listaUli.DataSource != null & dgv_listaUli.SelectedRows.Count > 0)
            { 
                Index = dgv_listaUli.SelectedRows[0].Index;
                dgv_listaUli.Rows[Index].Selected = true;
            }

            try
            {
                dgv_listaUli.DataSource = _zapytania.PobierzListeUli(cb_rok.Text);
                dgv_listaUli.Columns[0].Visible = false;
                dgv_listaUli.Columns[2].Visible = false;
                dgv_listaUli.Columns[3].Visible = false;

                if (dgv_listaUli.SelectedRows.Count > 0)
                {
                    dgv_listaUli.ClearSelection();
                    dgv_listaUli.Rows[Index].Selected = true;
                }
            }
            catch (System.IndexOutOfRangeException)
            {
                MessageBox.Show("Brak tabel. Zostaną one utworzone");
                _zapytania.UtworzTabele();
                OdswiezListeUli();
            }
        }

        private void Dgv_listaUli_Click(object sender, EventArgs e)
        {
            
            try
            {
                SprawdzCzySaZmiany();
                Ulid = Int32.Parse(dgv_listaUli.SelectedCells[0].Value.ToString());
                Ul = _zapytania.PobierzUl(Ulid);
                PokazDane(Ul, Ulid);
                KontrolkiShow();
            }
            catch (ArgumentOutOfRangeException)
            {
                //lista jest pusta
            }
        }

        private void SprawdzCzySaZmiany()
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

        private void PokazDane(Ul u, int id)
        {
            t_nazwa.Text = u.Nazwa;
            t_pochM.Text = u.PochodzenieMatki;
            t_oznaczM.Text = u.OznaczenieMatki;
            OdswiezNotatki();
            OdswiezMiodobrania();
        }

        private void OdswiezNotatki()
        {
            l_notatek.Items.Clear();
            var listaNotatek = _zapytania.PobierzNotatki(Ul.IdUla, Rok);
            foreach (Notatka notatka in listaNotatek)
            {
                l_notatek.Items.Add(new ListViewItem(new string[] {notatka.DataCzas, notatka.Opis}));
                if (l_notatek.Items.Count == 3)
                {
                    break;
                }
            }
        }

        private void OdswiezMiodobrania()
        {
            listBox2.Items.Clear();
            var listaMiodobran = _zapytania.PobierzMiodobrania(Ul.IdUla, Rok);
            foreach (Miodobranie miodobranie in listaMiodobran)
            {
                listBox2.Items.Add($"[{miodobranie.Data}]: Waga netto: {miodobranie.WagaNetto}, " +
                        $"Waga brutto: {miodobranie.WagaBrutto}, Ramki: {miodobranie.Ramki}, Uwagi: {miodobranie.Uwagi}");
            }
        }

        private void B_zapisz_Click(object sender, EventArgs e)
        {
            DodajHistorieZmian();

            var nowyUl = new Ul
            {
                IdUla = Ul.IdUla,
                Nazwa = t_nazwa.Text,
                PochodzenieMatki = t_pochM.Text,
                OznaczenieMatki = t_oznaczM.Text,
            };

            _zapytania.AktualizujUl(nowyUl);
            Ul = _zapytania.PobierzUl(Ulid);
            OdswiezListeUli();
        }

        private void DodajHistorieZmian()
        {
            if (Ul.OznaczenieMatki != t_oznaczM.Text)
            {
                _zapytania.DodajHistorie("Oznaczenie Matki", Ul.IdUla, Ul.OznaczenieMatki, t_oznaczM.Text, Rok);
            }

            if (Ul.PochodzenieMatki != t_pochM.Text)
            {
                _zapytania.DodajHistorie("Pochodzenie Matki", Ul.IdUla, Ul.PochodzenieMatki, t_pochM.Text, Rok);
            }

            if (Ul.Nazwa != t_nazwa.Text)
            {
                _zapytania.DodajHistorie("Nazwa ula", Ul.IdUla, Ul.Nazwa, t_nazwa.Text, Rok);
            }
        }

        private void B_historia_Click(object sender, EventArgs e)
        {
            FormHistory hist = new FormHistory(Ulid, Rok);
            hist.ShowDialog();            
        }

        private void Cb_rok_TextChanged(object sender, EventArgs e)
        {
            Rok = Convert.ToInt32(cb_rok.Text);
            dgv_listaUli.DataSource = null;
            KontrolkiHide();
            OdswiezListeUli();
        }

        private void B_dodajNotatke_Click(object sender, EventArgs e)
        {
            _zapytania.DodajNotatke(t_dodajNot.Text, Ul.IdUla, Rok);
            t_dodajNot.Text = "";
            OdswiezNotatki();
        }

        private void B_notatki_Click(object sender, EventArgs e)
        {
            FormNotes notatki = new FormNotes(Ulid, Rok);
            notatki.ShowDialog();
        }

        private void B_DodajMiodobranie_Click(object sender, EventArgs e)
        {
            FormMiodobranie form = new FormMiodobranie(Ul.IdUla, Rok);
            form.ShowDialog();
            OdswiezMiodobrania();
        }

        private void B_stat_Click(object sender, EventArgs e)
        {
            FormStatWybor form = new FormStatWybor(Ul.IdUla, Rok);
            form.ShowDialog();
        }
    }
}
