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
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void segundoFormularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form2 = new Form1();
            form2.Show();
        }

        private void tercerFormularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form3 = new Form1();
            form3.Show();
        }
    }
}
