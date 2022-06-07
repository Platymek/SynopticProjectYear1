using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using synopticProject.Source;

namespace SynopticProject2
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        public void Button_Clicked(object sender, System.EventArgs e)
        {
            var location = DependencyService.Get<LocationInteface>().getNearestLocationAsync().Result;
            Console.WriteLine(location[0]);
            Location nearestLocation = Map.GetNearestLocation(new System.Numerics.Vector2((float)location[0], (float)location[1]));
            ((Button)sender).Text = $" hello {nearestLocation.Position.X} , {nearestLocation.Position.Y}";
           
        }
    }
}
