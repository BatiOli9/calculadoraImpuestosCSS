using Microsoft.VisualBasic.Logging;
using System.ComponentModel;

namespace calculadoraImpuestosCSS
{
    public partial class Form1 : Form
    {
        int productos;
        int envios;
        int oficiales;
        string oficial;
        string producto;
        string envio;
        int oficialInt;
        int productoInt;
        int envioInt;
        int productoEnvio;
        int impuestos;
        int haulTotal;
        int impuestosPesos;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(productosTB.Text) || string.IsNullOrEmpty(envioTB.Text) || string.IsNullOrEmpty(oficialTB.Text))
            {
                MessageBox.Show("Debes completar los tres campos para calcular los impuestos");
            }
            else if (!int.TryParse(productosTB.Text, out productos))
            {
                MessageBox.Show("Debes completar la calculadora con numeros");
            }
            else if (!int.TryParse(envioTB.Text, out envios))
            {
                MessageBox.Show("Debes completar la calculadora con numeros");
            }
            else if (!int.TryParse(oficialTB.Text, out oficiales))
            {
                MessageBox.Show("Debes completar la calculadora con numeros");
            }
            else
            {
                producto = productosTB.Text;
                envio = envioTB.Text;
                oficial = oficialTB.Text;
                productoInt = int.Parse(producto);
                envioInt = int.Parse(envio);
                oficialInt = int.Parse(oficial);

                productoEnvio = productoInt + envioInt;

                if (productoEnvio < 50)
                {
                    MessageBox.Show("Ya que el costo de tu envio y productos no llegan a los $50 USD no hace falta que pagues impuestos, vas a tener que pagar una tasa aduanera que no es exacta");
                    impuestosVer.Text = "No vas a tener que pagar impuestos";
                    totalVer.Text = $"El costo de tu haul total va a ser ${productoEnvio} USD";
                    oficialVer.Text = "No vas a tener que pagar impuestos";
                }
                else
                {
                    impuestos = (productoEnvio - 50) / 2;
                    haulTotal = impuestos + productoEnvio;
                    impuestosPesos = impuestos * oficialInt;
                    MessageBox.Show("Gracias por usar nuestra calculadora! Ahora vas a poder ver los resultados abajo el boton");
                    impuestosVer.Text = $"Los impuestos te van a costar: ${impuestos} USD";
                    oficialVer.Text = $"Costo impuestos en pesos: ${impuestosPesos} ARS";
                    totalVer.Text = $"El costo total del haul va a ser: ${haulTotal} USD";
                }
                productosTB.Clear();
                oficialTB.Clear();
                envioTB.Clear();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}