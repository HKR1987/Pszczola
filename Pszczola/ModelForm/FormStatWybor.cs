using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if(radio_ogolna.Checked)
            {
                return OpcjeStat.Ogolem;
            }
            else if(radio_ogolnaRok.Checked)
            {
                return OpcjeStat.CalyRok;
            }
            else if(radio_ul.Checked)
            {
                return OpcjeStat.CalyUl;
            }
            else
            {
                return OpcjeStat.UlWRoku;
            }
        }
    }
}
