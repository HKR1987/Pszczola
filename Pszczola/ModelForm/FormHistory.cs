using Pszczola.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pszczola
{
    public partial class FormHistory : Form
    {
        private Zapytania _zapytania = new Zapytania();

        public FormHistory()
        {
            InitializeComponent();
        }

        public FormHistory(int ulid, int rok)
        {
            InitializeComponent();
            var listaHistorii = _zapytania.PobierzHistorie(ulid, rok);
            UzupelnijHistorie(listaHistorii);
        }

        private void UzupelnijHistorie(List<HistUl> listaHistorii)
        {
            foreach (HistUl s in listaHistorii)
            {
                lb_historia.Items.Add($"[{s.Gdzie}] Zmiana z: {s.ZmianaZ} na: {s.ZmianaNa}  ({s.Czas})");
            }
        }

        private void B_zamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
