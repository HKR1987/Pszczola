using Pszczola.Model;
using System;
using System.Windows.Forms;

namespace Pszczola
{
    public partial class FormMiodobranie : Form
    {
        private int _idUla;
        private int _rok;
        private Zapytania _zapytania = new Zapytania();

        public FormMiodobranie()
        {
            InitializeComponent();
        }

        public FormMiodobranie(int idUla, int rok)
        {
            InitializeComponent();
            _idUla = idUla;
            _rok = rok;
        }

        private void B_dodaj_Click(object sender, EventArgs e)
        {
            var brutto = Double.Parse(t_wagaRazem.Text);
            var tara = Double.Parse(t_wagaTara.Text);
            var netto = brutto - tara;

            var miodobranie = new Miodobranie
            {
                IdUl = _idUla,
                Rok = _rok,
                Data = dateTimePicker1.Value.ToShortDateString().ToString(),
                Ramki = Int32.Parse(t_ramki.Text),
                WagaNetto = netto,
                WagaBrutto = brutto,
                Uwagi = t_uwagi.Text
            };

            _zapytania.DodajMiodobranie(miodobranie);
            this.Close();
        }
    }
}
