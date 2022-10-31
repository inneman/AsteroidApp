using AsteroidApp.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AsteroidApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ObjectPage : ContentPage
    {
        public ObjectPage(object dangerousObject)
        {
            InitializeComponent();

            layout.BindingContext = dangerousObject;
        }
    }
}