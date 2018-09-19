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
    public partial class FormHistory : Form
    {
        private Zapytania _zapytania = new Zapytania();
        private List<HistUl> _histUl;

        public FormHistory()
        {
            InitializeComponent();
        }

        public FormHistory(int ulid, int rok)
        {
            InitializeComponent();
           _histUl = _zapytania.PobierzHistorie(ulid, rok);
            foreach(HistUl s in _histUl)
            {
                listBox1.Items.Add("[" + s.Gdzie + "] " + "Zmiana z: " + s.ZmianaZ +" na: " + s.ZmianaNa + "  (" + s.Czas+")");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
