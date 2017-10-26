using Android.App;
using Android.Widget;
using Android.OS;
using Android.Gms.Maps;

namespace OSHackApp
{
    [Activity(Label = "OSHackApp", MainLauncher = true)]
    public class MainActivity : Activity, IOnMapReadyCallback
    {
        public void OnMapReady(GoogleMap googleMap)
        {
            throw new System.NotImplementedException();
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //test
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}

