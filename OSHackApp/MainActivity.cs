using Android.App;
using Android.Content.Res;
using Android.OS;
using Android.Gms.Maps;
using Android.Widget;
using Android.Renderscripts;
using ZXing.Mobile;

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
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            EditText testText = FindViewById<EditText>(Resource.Id.TestText);
            Button qrReader = FindViewById<Button>(Resource.Id.QRReader);
            MobileBarcodeScanner.Initialize(Application);

            qrReader.Click += async (sender, e) =>
            {
                var scanner = new ZXing.Mobile.MobileBarcodeScanner();
                var result = await scanner.Scan();
                testText.Text = result.Text;
            };
            
        }

        
    };
}


