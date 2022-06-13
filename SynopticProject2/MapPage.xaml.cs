using Mapsui;
using Mapsui.Projection;
using Mapsui.UI.Forms;
using Mapsui.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using synopticProject.Source;

namespace SynopticProject2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapPage : ContentPage
    {
        public MapPage()
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

            var IronRange = new Pin()
            {
                Position = new Position(-12.5975f, 143.4111f),
                Type = PinType.Pin,
                Label = "Iron Range",
                Address = "Zero point",
            };

            var DaintreeRainforest = new Pin()
            {
                Position = new Position(-16.1700f, 145.4185f),
                Type = PinType.Pin,
                Label = "Daintree Rainforest",
                Address = "Zero point",
            };

            var Lakefield = new Pin()
            {
                Position = new Position(-15.53092f, 143.75705f),
                Type = PinType.Pin,
                Label = "Lakefield",
                Address = "Zero point",
            };

            var OyalaThumotang = new Pin()
            {
                Position = new Position(-13.684401f, 142.887187f),
                Type = PinType.Pin,
                Label = "Oyala Thumotang",
                Address = "Zero point",
            };

            var MtCook = new Pin()
            {
                Position = new Position(-15.733333f, 145.100000f),
                Type = PinType.Pin,
                Label = "Mt Cook",
                Address = "Zero point",
            };

            mapView.PinClicked += async (sender, args) =>
            {
                Console.WriteLine("fsadfasdfsadf");
                
                Console.WriteLine("Pin Label: " + args.Pin.Label);

                Location locationOfClick = synopticProject.Source.Map.GetLocation(args.Pin.Label);
                Console.WriteLine("Location Returned: " + locationOfClick.Name);
                args.Handled = true;
                await Navigation.PushAsync(new LocationDetailsPage(locationOfClick));
                
            };

            mapView.Pins.Add(IronRange);
            mapView.Pins.Add(DaintreeRainforest);
            mapView.Pins.Add(Lakefield);
            mapView.Pins.Add(OyalaThumotang);
            mapView.Pins.Add(MtCook);

            var location = DependencyService.Get<LocationInteface>().getNearestLocationAsync().Result;

            mapView.Map = map;
            mapView.MyLocationEnabled = true;
            mapView.MyLocationFollow = true;
            mapView.MyLocationLayer.UpdateMyLocation(new Position((double)location[0], (double)location[1]));



        }
    }
}