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

        public FormStat()
        {
            InitializeComponent();
            _ds = _polaczenie.ZapytanieDataSet($"SELECT data, sum(wagab) sum FROM miodobrania group by data");
            foreach (DataRow s in _ds.Tables[0].Rows)
            {
                chart1.Series["Miód"].Points.AddXY(s["data"].ToString(), s["sum"].ToString());
            }
        }
    }
}
