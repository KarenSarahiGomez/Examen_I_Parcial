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

            if (Producto1TextBox.Text == "")
            {
                errorProvider1.SetError(Producto1TextBox, "Ingrese un producto");
                return;
            }
            if (Producto2TextBox.Text == "")
            {
                errorProvider1.SetError(Producto2TextBox, "Ingrese un producto");
                return;
            }
            if (PrimerTextBox.Text == "")
            {
                errorProvider1.SetError(PrimerTextBox, "Seleccione una precio");
                return;
            }
            if (SegundoTextBox.Text == "")
            {
                errorProvider1.SetError(SegundoTextBox, "Ingrese un precio");
                return;
            }
            if (Cantidad1textBox.Text == "")
            {
                errorProvider1.SetError(Cantidad1textBox, "Ingrese una cantidad");
                return;
            }
            if (Cantidad2textBox.Text == "")
            {
                errorProvider1.SetError(Cantidad2textBox, "Ingrese una cantidad");
                return;
            }
            errorProvider1.Clear();

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
