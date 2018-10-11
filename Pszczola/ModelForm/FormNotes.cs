using Pszczola.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pszczola
{
    public partial class FormNotes : Form
    {
        private Polaczenie _polaczenie = new Polaczenie();
        private Zapytania _zapytania = new Zapytania();

        public FormNotes()
        {
            InitializeComponent();
        }

        public FormNotes(int ulid, int rok)
        {
            InitializeComponent();
            var listaNotatek = _zapytania.PobierzNotatki(ulid, rok);
            UzupelnijNotatki(listaNotatek);
        }

        private void UzupelnijNotatki(List<Notatka> listaNotatek)
        {
            foreach (Notatka n in listaNotatek)
            {
                lb_lista.Items.Add($"[{n.DataCzas}] {n.Opis}");
            }
        }

        private void B_zamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
