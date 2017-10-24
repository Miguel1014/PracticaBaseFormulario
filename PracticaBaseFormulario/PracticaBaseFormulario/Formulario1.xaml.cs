using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using System.Text.RegularExpressions;

namespace PracticaBaseFormulario
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Formulario1 : ContentPage
    {
        public static Boolean num;
        public Formulario1()
        {
            InitializeComponent();

            


        }

        public class datos
        {

            public static String VNombre1;
            public static String VApellido1;
            public static long VTelefono1;
            public static String VDireccion1;
 }



        public void Button_Clicked(object sender, EventArgs e)
        {

            

            datos.VNombre1 = VNombre.Text;
            datos.VApellido1 = VApellido.Text;
            
        
            datos.VTelefono1 = (long)Convert.ToInt64(VTelefono.Text);
            datos.VDireccion1 = VDireccion.Text;

            

            var Xnombre = VApellido.Text;
            var Xapellido = VApellido.Text;
            var Xtelefono = VTelefono.Text;
            var Xdireccion = VDireccion.Text;

            int limite = 10;


            string text = VTelefono.Text;

            if (!string.IsNullOrEmpty(Xnombre) && !string.IsNullOrEmpty(Xapellido) && !string.IsNullOrEmpty(Xtelefono)
               && !string.IsNullOrEmpty(Xdireccion))
            {

                if (text.Length < limite)
                {
                    DisplayAlert("Error", "Debe contener 10  numeros", "Ok");
                }
                else
                {




                    Navigation.PushModalAsync(new Formulario2());
                }
            }
            else
            {
                DisplayAlert("Error", "Te faltan datos por llenar", "Ok");

            }
        }



        private void VTelefono_TextChanged(object sender, TextChangedEventArgs e)
        {
            int limite = 10;


            string text = VTelefono.Text;      
            if (text.Length > limite)       
            {
                text = text.Remove(text.Length - 1);  
                VTelefono.Text = text;        
            }

            

           








        }
    }
}
