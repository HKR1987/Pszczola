using Pszczola.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Pszczola.ModelForm
{
    public partial class FormStatWybor : Form
    {
        private readonly int _idUla;
        private readonly int _rok;

        public FormStatWybor(int idUla, int rok)
        {
            InitializeComponent();
            _idUla = idUla;
            _rok = rok;
        }
     
        private void B_generuj_Click(object sender, EventArgs e)
        {
            FormStat f = new FormStat(Opcje(), _idUla, _rok);
            f.ShowDialog();
        }

        private OpcjeStat Opcje()
        {
            RadioButton radioBtn = this.Controls.OfType<RadioButton>().Where(x => x.Checked).FirstOrDefault();
            if (radioBtn == null) { return OpcjeStat.UlWRoku; }
            switch (radioBtn.Name)
            {
                case "radio_ogolna":
                    return OpcjeStat.Ogolem;
                case "radio_ogolnaRok":
                    return OpcjeStat.CalyRok;
                case "radio_ul":
                    return OpcjeStat.CalyUl;
                case "radio_ulRok":
                    return OpcjeStat.UlWRoku;
                default:
                    return OpcjeStat.UlWRoku;
            }
        }
    }
}
