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
    public partial class LocationDetailsPage : ContentPage
    {
        public LocationDetailsPage(Location nearestLocation)
        {
            
            InitializeComponent();
            StackLayout MainLayout = new StackLayout();
          

            Label NearestLocationNameLabel = new Label
            {
                Text = nearestLocation.Name,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                FontSize = 20
            };

            MainLayout.Children.Add(NearestLocationNameLabel);


            foreach (Organism organismToAdd in nearestLocation.Organisms)
            {
                int count = 0;
                Button NewButton = new Button()
                {
                    Text = organismToAdd.Name,
                    StyleId = count.ToString()
                };
                NewButton.Clicked += NewButton_Clicked;
                MainLayout.Children.Add(NewButton);
                count++;
            }

            Content = MainLayout;
        }

        private async void NewButton_Clicked(object sender, EventArgs e)
        {
            Button ClickedButton = (Button)sender;
            await Navigation.PushAsync(new OrganismDetailsPage(Map.GetOrganism(ClickedButton.Text)));
        }
    }
}