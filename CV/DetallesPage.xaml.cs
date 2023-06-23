using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CV
{
    public partial class DetallesPage : ContentPage
    {
        public DetallesPage(string nombre, DateTime fechaNacimiento, string ocupacion, string contacto, string nacionalidad, string nivelIngles, List<string> lenguajesProgramacion)
        {
            InitializeComponent();

            
            nombreLabel.Text = nombre;
            fechaNacimientoLabel.Text = fechaNacimiento.ToString("dd/MM/yyyy");
            ocupacionLabel.Text = ocupacion;
            contactoLabel.Text = contacto;
            nacionalidadLabel.Text = nacionalidad;
            nivelInglesLabel.Text = nivelIngles;
            lenguajesProgramacionLabel.Text = string.Join(", ", lenguajesProgramacion);
        }
    }


}
