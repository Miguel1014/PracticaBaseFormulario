using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PracticaBaseFormulario
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Formulario2 : ContentPage
    {
        public Formulario2()
        {
            InitializeComponent();

            string[] semestres = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
            picker1.ItemsSource = semestres;
            picker1.SelectedIndex = 0;

            string[] carreras = { "Ing. Sistemas Computacionales", "Ingenieria Civil", "Ingenieria Industrial", "Gastronomia", "Lic. Biologia", "Lic. Administración","Ingenieria en Mecatronica" };
            picker.ItemsSource = carreras;
            picker.SelectedIndex = 0;

        }

        public class datos1
        {

            public static string VCarrera1;
            public static string VSemestre1;
            public static int VMatricula1;


            public static Entry VCar = new Entry();
            public static string VSem;




        }


        private void Button_Clicked(object sender, EventArgs e)
        {

            datos1.VSemestre1= Convert.ToString(picker1.SelectedItem);
            datos1.VCarrera1=Convert.ToString(picker.SelectedItem);
            datos1.VMatricula1=Convert.ToInt32(VMatricula.Text);
           

            

            var Xcarrera = picker.SelectedItem;
            var Xsemestre = picker1.SelectedItem;
            var Xmatricula = VMatricula.Text;


            string scarrera = "" + picker.SelectedIndex;
            string ssemestre = "" + picker1.SelectedItem;
            var smatricula = VMatricula.Text;


            if (!string.IsNullOrEmpty(scarrera) && !string.IsNullOrEmpty(ssemestre) && !string.IsNullOrEmpty(smatricula))
            {
                Navigation.PushModalAsync(new Formulario3());

            }
            else
            {
                DisplayAlert("Error", "Te faltan datos por llenar", "Ok");

            }


        }
    }
}