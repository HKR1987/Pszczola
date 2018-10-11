using System;
using System.Windows.Forms;

namespace Pszczola
{
    public partial class FormListaMiodobran : Form
    {
        public FormListaMiodobran()
        {
            InitializeComponent();
        }

        private void B_zamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
