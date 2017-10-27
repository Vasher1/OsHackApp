using Android.App;
using Android.OS;
using Android.Widget;
using ZXing.Mobile;

namespace OSHackApp
{
    [Activity(Label = "OSHackApp", MainLauncher = true)]
    public class MainActivity : Activity
    {
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
                var scanner = new MobileBarcodeScanner();
                var result = await scanner.Scan();
                testText.Text = result.Text;
            };
            
        }

        
    };
}


