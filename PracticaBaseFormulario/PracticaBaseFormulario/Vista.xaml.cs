using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
namespace PracticaBaseFormulario
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Vista : ContentPage
    {
        SQLiteConnection database;
        public ObservableCollection<DatosFormulario> items { get; set; }

        public Vista()
        {

            InitializeComponent();
            string db;
            db = DependencyService.Get<ISQLite>().GetLocalFilePath("DatosFormulario.db");
            database = new SQLiteConnection(db);
            database.CreateTable<DatosFormulario>();
            items = new ObservableCollection<DatosFormulario>(database.Table<DatosFormulario>());
            BindingContext = this;




        }

        async void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            await Navigation.PushModalAsync(new VistaGeneral(e.SelectedItem as DatosFormulario));
        }


        private void insersion_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Formulario1());
        }

        private void insersion_Clicked_1(object sender, EventArgs e)
        {
            //Navigation.PushModalAsync(new Vista());
            
        }
    }
}
