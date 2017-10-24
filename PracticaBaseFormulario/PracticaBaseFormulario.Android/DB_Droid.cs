using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PracticaBaseFormulario.Droid;
using Xamarin.Forms;
using System.IO;


using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;


[assembly: Dependency(typeof(BD_Droid))]
namespace PracticaBaseFormulario.Droid
{
    public class BD_Droid : ISQLite
    {
        public string GetLocalFilePath(string Filename)
        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

            return Path.Combine(path, Filename);
        }
    }
}


