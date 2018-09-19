using Pszczola.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void Button1_Click(object sender, EventArgs e)
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
