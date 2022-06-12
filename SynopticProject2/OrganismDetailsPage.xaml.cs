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
            OrganismName.Text = organism.Name;
            OrganismDescription.Text = organism.Description;
            OrganismSeverity.Text = organism.SeverityToString();
            OrganismDanger.Text = organism.DangerToString();

        }

        public Organism Organism { get; }
    }
}