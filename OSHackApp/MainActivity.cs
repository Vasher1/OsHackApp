using Android.App;
using Android.Widget;
using Android.OS;
using Android.Gms.Maps;

namespace OSHackApp
{
    [Activity(Label = "OSHackApp", MainLauncher = true)]
    public class MainActivity : Activity, IOnMapReadyCallback
    {
        private MapFragment _mapFragment;
        private GoogleMap _map;
        public void OnMapReady(GoogleMap map)
        {
            _map = map;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //test
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            InitMapFragment();
        }

        private void InitMapFragment()
        {
            _mapFragment = FragmentManager.FindFragmentByTag("map") as MapFragment;
            if (_mapFragment == null)
            {
                GoogleMapOptions mapOptions = new GoogleMapOptions()
                    .InvokeMapType(GoogleMap.MapTypeSatellite)
                    .InvokeZoomControlsEnabled(false)
                    .InvokeCompassEnabled(true);

                FragmentTransaction fragTx = FragmentManager.BeginTransaction();
                _mapFragment = MapFragment.NewInstance(mapOptions);
                fragTx.Add(Resource.Id.map, _mapFragment, "map");
                fragTx.Commit();
            }
            _mapFragment.GetMapAsync(this);
        }

    }
}

