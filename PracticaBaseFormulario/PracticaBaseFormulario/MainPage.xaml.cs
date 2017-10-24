using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PracticaBaseFormulario
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void insertar(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Formulario1());
        }
    }
}
