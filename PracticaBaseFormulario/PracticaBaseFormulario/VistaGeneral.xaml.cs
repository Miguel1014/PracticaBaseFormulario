using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;

namespace PracticaBaseFormulario 
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VistaGeneral : ContentPage
    {
        SQLiteConnection database;
        public VistaGeneral(object selectedItem)
        {
            var Datos = selectedItem as DatosFormulario;
            BindingContext = Datos;
            InitializeComponent();
            string db;
            db = DependencyService.Get<ISQLite>().GetLocalFilePath("DatosFormulario.db");
            database = new SQLiteConnection(db);

            string[] semestres = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
            picker1.ItemsSource = semestres;
            picker1.SelectedItem = Datos.Semestre;

            string[] carreras = { "Ing. Sistemas Computacionales", "Ingenieria Civil", "Ingenieria Industrial", "Gastronomia", "Lic. Biologia", "Lic. Administración", "Ingenieria en Mecatronica" };
            picker.ItemsSource = carreras;
            picker.SelectedItem = Datos.Carrera;


        }

        private void Button_Actualizar_Clicked(object sender, EventArgs e)
        {
            var datos = new DatosFormulario
            {
                Matricula = (long)Convert.ToInt64(VMatricula.Text),
                Nombre = VNombre.Text,
                Apellidos = VApellido.Text,
                Direccion = VDireccion.Text,
                Telefono = (long)Convert.ToInt64(VTelefono.Text),
                Carrera = Convert.ToString(picker.SelectedItem),
                Semestre = Convert.ToString(picker1.SelectedItem),
                Correo = VCorreo.Text,
                Github = VGithub.Text

            };
            database.Update(datos);
            Navigation.PushModalAsync(new Vista());
        


    }

        private void Button_Eliminar_Clicked(object sender, EventArgs e)
        {

            var Datos = new DatosFormulario
            {
                Matricula =(long)Convert.ToInt64(VMatricula.Text)
            };
            database.Delete(Datos);
            Navigation.PushModalAsync(new Vista());

        }

        private void VTelefono_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        
    }
}