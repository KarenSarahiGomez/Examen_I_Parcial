using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarenGómez
{
    public partial class segundoform : Form
    {
        public segundoform()
        {
            InitializeComponent();
        }
        double subtotal, desc;
        private async void CalTotalButton_Click(object sender, EventArgs e)
        {
            double prod1 = Convert.ToDouble(PrimerTextBox.Text);
            double prod2 = Convert.ToDouble(SegundoTextBox.Text);
            double cant1 = Convert.ToDouble(Cantidad1textBox.Text);
            double cant2 = Convert.ToDouble(Cantidad2textBox.Text);

            double totalPago = await TotalpAsync(prod1, prod2, cant1, cant2);
            TotalLabel.Text = Convert.ToString(totalPago);
        }
        private async Task<double> TotalpAsync(double p1, double p2, double c1, double c2)
        {
            double totalPago = await Task.Run(() =>
            {
                subtotal = (p1 * c1) + (p2 * c2);
                desc = (subtotal * 0.15);
                return totalPago = (subtotal - desc);
            });
            return totalPago;
        }
    }
}
