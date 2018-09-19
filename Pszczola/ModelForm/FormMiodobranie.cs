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
        private double _wagaRamki;
        private Polaczenie _polaczenie = new Polaczenie();

        public FormMiodobranie()
        {
            InitializeComponent();
        }

        public FormMiodobranie(int idUla, int rok, string wagaRamki)
        {
            InitializeComponent();
            _idUla = idUla;
            _rok = rok;
            _wagaRamki = Double.Parse(wagaRamki);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double wagaNnetto = Double.Parse(t_waga.Text.Replace('.', ',')) - (Double.Parse(t_ramki.Text) * _wagaRamki);
            _polaczenie.ZapytanieZ($"INSERT INTO miodobrania (idul, rok, data, nazwa, ramki, wagan, wagab, uwagi) VALUES ({_idUla}, {_rok}, '{dateTimePicker1.Value.ToShortDateString().ToString()}', '{t_nazwa.Text}', {t_ramki.Text}, {wagaNnetto.ToString().Replace(',', '.')}, {t_waga.Text.Replace(',', '.')}, '{t_uwagi.Text}')");
            this.Close();
        }
    }
}
