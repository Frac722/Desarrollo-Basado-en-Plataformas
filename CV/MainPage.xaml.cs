using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CV
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void EnviarButton_Clicked(object sender, EventArgs e)
        {
            // Obtén los datos del formulario
            string nombre = nombreEntry.Text;
            DateTime fechaNacimiento = fechaNacimientoPicker.Date;
            string ocupacion = ocupacionEntry.Text;
            string contacto = contactoEntry.Text;
            string nacionalidad = nacionalidadPicker.SelectedItem?.ToString();
            string nivelIngles = GetSelectedRadioButtonText();
            List<string> lenguajesProgramacion = GetSelectedCheckBoxes();

            // Crea una nueva página y pasa los datos como parámetros
            DetallesPage detallesPage = new DetallesPage(nombre, fechaNacimiento, ocupacion, contacto, nacionalidad, nivelIngles, lenguajesProgramacion);

            // Realiza la navegación a la nueva página
            await Navigation.PushAsync(detallesPage);
        }

        private string GetSelectedRadioButtonText()
        {
            if (basicoRadioButton.IsChecked)
                return "Básico";
            else if (intermedioRadioButton.IsChecked)
                return "Intermedio";
            else if (avanzadoRadioButton.IsChecked)
                return "Avanzado";
            else if (fluidoRadioButton.IsChecked)
                return "Fluido";
            else
                return string.Empty;
        }

        private List<string> GetSelectedCheckBoxes()
        {
            List<string> selectedLenguajes = new List<string>();

            if (javaCheckBox.IsChecked)
                selectedLenguajes.Add("Java");
            if (pythonCheckBox.IsChecked)
                selectedLenguajes.Add("Python");
            if (javascriptCheckBox.IsChecked)
                selectedLenguajes.Add("JavaScript");
            if (cplusCheckBox.IsChecked)
                selectedLenguajes.Add("C++");
            if (phpCheckBox.IsChecked)
                selectedLenguajes.Add("PHP");

            return selectedLenguajes;
        }
    }
}
