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
    public partial class FormNotes : Form
    {
        private DataSet ds;
        Polaczenie polaczenie = new Polaczenie();

        public FormNotes()
        {
            InitializeComponent();

        }

        public FormNotes(int ulid, int rok)
        {
            InitializeComponent();

            ds = polaczenie.ZapytanieZ($"SELECT opis, data FROM notatki where idul={ulid} and rok={rok}");

            foreach(DataRow s in ds.Tables[0].Rows)
            {
                listBox1.Items.Add("[" + s["data"].ToString() + "] " + s["opis"].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
