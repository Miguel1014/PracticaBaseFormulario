using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using PracticaBaseFormulario.UWP;
using Windows.Storage;

[assembly: Dependency(typeof(BD_UWP))]
namespace PracticaBaseFormulario.UWP
{


    public class BD_UWP : ISQLite
    {
        public string GetLocalFilePath(string filename)
        {
            return Path.Combine(ApplicationData.Current.LocalFolder.Path, filename);
        }
    }
}