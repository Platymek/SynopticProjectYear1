using synopticProject.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SynopticProject2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganismDetailsPage : ContentPage
    {


        public OrganismDetailsPage(Organism organism)
        {
            InitializeComponent();
            Organism = organism;
            Testing.Text = organism.Name;
        }

        public Organism Organism { get; }
    }
}