using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ConversorDivisas
{
    public partial class MainPage : ContentPage
    {
        double q;

        double dolares;

        double factor = 8;
        public MainPage()
        {
            InitializeComponent();
        }

        private void Convertir()
        {
            q = Convert.ToDouble(inputQuetzales.Text);
            dolares = q / factor;
            if(dolares != 1)
            {
                lblResultado.Text = dolares.ToString() + " dólares";
            } else
            {   
                lblResultado.Text = dolares.ToString() + " dolar";
            }            
        }

        private void Validar()
        {
            if (!string.IsNullOrEmpty(inputQuetzales.Text))
            {
                Convertir();
            } else
            {
                DisplayAlert("Error", "Debe ingresar un monto en quetzales valido", "Aceptar");
                inputQuetzales.Focus();
            }
        }

        private void btnConvertir_Clicked(object sender, EventArgs e)
        {
            Validar();
        }
    }
}
