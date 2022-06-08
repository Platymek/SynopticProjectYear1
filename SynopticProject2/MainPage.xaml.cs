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

            var map = new Mapsui.Map
            {
                CRS = "EPSG:3857",
                Transformation = new MinimalTransformation()
            };

            var tileLayer = OpenStreetMap.CreateTileLayer();

            map.Layers.Add(tileLayer);
            map.Widgets.Add(new Mapsui.Widgets.ScaleBar.ScaleBarWidget(map) { TextAlignment = Mapsui.Widgets.Alignment.Center, HorizontalAlignment = Mapsui.Widgets.HorizontalAlignment.Left, VerticalAlignment = Mapsui.Widgets.VerticalAlignment.Bottom });

            mapView.Map = map;
        }

        public void Button_Clicked(object sender, System.EventArgs e)
        {
            var location = DependencyService.Get<LocationInteface>().getNearestLocationAsync().Result;
            Console.WriteLine(location[0]);
            Location nearestLocation = synopticProject.Source.Map.GetNearestLocation(new System.Numerics.Vector2((float)location[0], (float)location[1]));
            ((Button)sender).Text = $" hello {nearestLocation.Position.X} , {nearestLocation.Position.Y}";
           
        }
    }
}
