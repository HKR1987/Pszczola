using Pszczola.Model;
using System.Data;
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
            foreach (DataRow r in _ds.Tables[0].Rows)
            {
                chart1.Series["Miód"].Points.AddXY(r["data"].ToString(), r["sum"].ToString());
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
            switch (opcje)
            {
                case OpcjeStat.Ogolem:
                    return $"SELECT data, sum(wagan) sum FROM miodobrania group by data";
                case OpcjeStat.CalyRok:
                    return $"SELECT data, sum(wagan) sum FROM miodobrania where rok={_rok} group by data";
                case OpcjeStat.CalyUl:
                    return $"SELECT data, sum(wagan) sum FROM miodobrania where idul={_idUla} group by data";
                case OpcjeStat.UlWRoku:
                    return $"SELECT data, sum(wagan) sum FROM miodobrania where idul={_idUla} and rok={_rok} group by data";
                default:
                    return $"SELECT data, sum(wagan) sum FROM miodobrania where idul={_idUla} and rok={_rok} group by data";
            }
        }
    }
}
