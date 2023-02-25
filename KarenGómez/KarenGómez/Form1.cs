using System;
using System.Windows.Forms;

namespace KarenGómez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void primerFormularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            primerform primerform = new primerform();
            primerform.Show();
        }

        private void segundoFormularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            segundoform segundoform = new segundoform();
            segundoform.Show();
        }

        private void tercerFormularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tercerform tercerform = new tercerform();
            tercerform.Show();
        }
    }
}
