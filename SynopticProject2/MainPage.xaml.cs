using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using synopticProject.Source;
using Mapsui.Utilities;
using Mapsui;
using Mapsui.UI.Forms;
using Mapsui.Projection;

namespace SynopticProject2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
           
        }

        async void Nearest_Location_Button_Clicked(object sender, System.EventArgs e)
        {
            var location = DependencyService.Get<LocationInteface>().getNearestLocationAsync().Result;

            Location nearestLocation = synopticProject.Source.Map.GetNearestLocation(new System.Numerics.Vector2((float)location[0], (float)location[1]));
            await Navigation.PushAsync(new LocationDetailsPage(nearestLocation));
        }

        async void Map_Button_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MapPage());
        }
    }
}
