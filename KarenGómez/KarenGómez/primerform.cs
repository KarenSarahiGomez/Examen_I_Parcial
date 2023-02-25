using System;
using System.Windows.Forms;

namespace KarenGómez
{
    public partial class primerform : Form
    {
        public primerform()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            double Cap = 200000;
            double i = 0.015;
            double tim = 0;
            double I;
            double NCap;

            for (double c = 1; c < 13; c++)

            {
                tim++;

                if (c == 1)
                {
                    ListBox1.Items.Add("Enero: ");
                    ListBox1.Items.Add(I = Cap * i * tim);
                    NCap = Cap + I;
                    Cap = Cap + I;
                }

                if (c == 2)
                {
                    ListBox1.Items.Add("Febrero: ");
                    ListBox1.Items.Add(I = Cap * i * tim);
                    NCap = Cap + I;
                    Cap = Cap + I;
                }

                if (c == 3)
                {
                    ListBox1.Items.Add("Marzo: ");
                    ListBox1.Items.Add(I = Cap * i * tim);
                    NCap = Cap + I;
                    Cap = Cap + I;
                }

                if (c == 4)
                {
                    ListBox1.Items.Add("Abril: ");
                    ListBox1.Items.Add(I = Cap * i * tim);
                    NCap = Cap + I;
                    Cap = Cap + I;
                }

                if (c == 5)
                {
                    ListBox1.Items.Add("Mayo: ");
                    ListBox1.Items.Add(I = Cap * i * tim);
                    NCap = Cap + I;
                    Cap = Cap + I;
                }

                if (c == 6)
                {
                    ListBox1.Items.Add("Junio: ");
                    ListBox1.Items.Add(I = Cap * i * tim);
                    NCap = Cap + I;
                    Cap = Cap + I;
                }

                if (c == 7)
                {
                    ListBox1.Items.Add("Julio: ");
                    ListBox1.Items.Add(I = Cap * i * tim);
                    NCap = Cap + I;
                    Cap = Cap + I;
                }

                if (c == 8)
                {
                    ListBox1.Items.Add("Agosto: ");
                    ListBox1.Items.Add(I = Cap * i * tim);
                    NCap = Cap + I;
                    Cap = Cap + I;
                }

                if (c == 9)
                {
                    ListBox1.Items.Add("Septiembre: ");
                    ListBox1.Items.Add(I = Cap * i * tim);
                    NCap = Cap + 1;
                    Cap = Cap + I;
                }

                if (c == 10)
                {
                    ListBox1.Items.Add("Octubre: ");
                    ListBox1.Items.Add(I = Cap * i * tim);
                    NCap = Cap + I;
                    Cap = Cap + I;
                }

                if (c == 11)
                {
                    ListBox1.Items.Add("Noviembre: ");
                    ListBox1.Items.Add(I = Cap * i * tim);
                    NCap = Cap + I;
                    Cap = Cap + I;
                }

                if (c == 12)
                {
                    ListBox1.Items.Add("Diciembre: ");
                    ListBox1.Items.Add(I = Cap * i * tim);
                    NCap = Cap + I;
                    Cap = Cap + I;
                }
            }
        }
    }
}


