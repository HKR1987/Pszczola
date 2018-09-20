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
    public partial class FormStat : Form
    {
        private DataSet _ds;
        private Polaczenie _polaczenie = new Polaczenie();
        private OpcjeStat _opcjeStat;
        private readonly int _idUla;
        private readonly int _rok;

        public FormStat()
        {
            InitializeComponent();
        }

        private void PokazStatystyki()
        {
            foreach (DataRow s in _ds.Tables[0].Rows)
            {
                chart1.Series["Miód"].Points.AddXY(s["data"].ToString(), s["sum"].ToString());
            }
        }

        public FormStat(OpcjeStat opcjeStat, int idUla, int rok)
        {
            InitializeComponent();
            _opcjeStat = opcjeStat;
            _idUla = idUla;
            _rok = rok;
            _ds = _polaczenie.ZapytanieDataSet(Zapytanie(_opcjeStat));
            PokazStatystyki();
        }

        private string Zapytanie(OpcjeStat opcje)
        {
            if(opcje == OpcjeStat.Ogolem)
            {
                return $"SELECT data, sum(wagan) sum FROM miodobrania group by data";
            }
            else if (opcje == OpcjeStat.CalyRok)
            {
                return $"SELECT data, sum(wagan) sum FROM miodobrania where rok={_rok} group by data";
            }
            else if (opcje == OpcjeStat.CalyUl)
            {
                return $"SELECT data, sum(wagan) sum FROM miodobrania where idul={_idUla} group by data";
            }
            else
            {
                return $"SELECT data, sum(wagan) sum FROM miodobrania where idul={_idUla} and rok={_rok} group by data";
            }
        }
    }
}
