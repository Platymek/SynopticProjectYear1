using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SynopticProject2.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

[assembly: Dependency(typeof(AndroidLocationInterfaceReference))]

namespace SynopticProject2.Droid
{
    public class AndroidLocationInterfaceReference : LocationInteface
    {
        public async Task<decimal[]> getNearestLocationAsync()
        {
                try
                {
                    var location = await Geolocation.GetLastKnownLocationAsync();

                    if (location != null)
                    {
                        return new decimal[] { (decimal)location.Latitude, (decimal)location.Longitude, (decimal)location.Altitude };
                    }
                }
                catch (FeatureNotSupportedException fnsEx)
                {
                    // Handle not supported on device exception
                }
                catch (FeatureNotEnabledException fneEx)
                {
                    // Handle not enabled on device exception
                }
                catch (PermissionException pEx)
                {
                    // Handle permission exception
                }
                catch (Exception ex)
                {
                    // Unable to get location
                }

           
            
            throw new NotImplementedException();
        }
    }
}