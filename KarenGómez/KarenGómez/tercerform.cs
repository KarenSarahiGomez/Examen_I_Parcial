using System;
using System.Windows.Forms;

namespace KarenGómez
{
    public partial class tercerform : Form
    {
        public tercerform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int multiplos;

            for (int i = 1; i < 101; i++)
            {
                multiplos = i;

                if (multiplos % 3 == 0 && multiplos % 5 == 0)
                {
                    ListBox1.Items.Add("Karen Gómez");
                }
                else
                {
                    if (multiplos % 3 == 0)
                    {
                        ListBox1.Items.Add("Karen");
                    }
                    else
                    {
                        if (multiplos % 5 == 0)
                        {
                            ListBox1.Items.Add("Gómez");
                        }
                        else
                        {
                            ListBox1.Items.Add(multiplos);
                        }
                    }
                }
            }
        }
    }
}
