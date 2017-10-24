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
    public partial class Formulario3 : ContentPage
    {
        public Formulario3()
        {

            InitializeComponent();
        }

        public class datos3
        {

            public static string VCorreo1;
            public static string VGithub1;



        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            datos3.VCorreo1 = VCorreo.Text;
            datos3.VGithub1 = VGithub.Text;

            string scorreo = VCorreo.Text;
            string sgithub = VGithub.Text;



            if (!string.IsNullOrEmpty(scorreo) && !string.IsNullOrEmpty(sgithub))
            {

                SQLiteAsyncConnection database;
                string db;
                db = DependencyService.Get<ISQLite>().GetLocalFilePath("DatosFormulario.db");
                database = new SQLiteAsyncConnection(db);
                

                
                var Insert = new DatosFormulario
                {



                    Matricula = PracticaBaseFormulario.Formulario2.datos1.VMatricula1,
                    Nombre = PracticaBaseFormulario.Formulario1.datos.VNombre1,
                    Apellidos = PracticaBaseFormulario.Formulario1.datos.VApellido1,
                    Direccion = PracticaBaseFormulario.Formulario1.datos.VDireccion1,
                    Telefono = PracticaBaseFormulario.Formulario1.datos.VTelefono1,
                    Carrera =  PracticaBaseFormulario.Formulario2.datos1.VCarrera1,

                    Semestre = PracticaBaseFormulario.Formulario2.datos1.VSemestre1,
                    Correo = PracticaBaseFormulario.Formulario3.datos3.VCorreo1,
                    Github = PracticaBaseFormulario.Formulario3.datos3.VGithub1,
                };

                database.InsertAsync(Insert);

                Navigation.PushModalAsync(new Vista()).Wait();
            }
            else
            {
                DisplayAlert("Error", "Te faltan datos por llenar", "Ok");

            }

        }
    }
}