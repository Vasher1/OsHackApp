using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Widget;
using ZXing.Mobile;
using ZXing;

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
            var options = new MobileBarcodeScanningOptions
            {
                AutoRotate = true,
                DisableAutofocus = true,
                UseFrontCameraIfAvailable = false,
                TryHarder = true,
                PossibleFormats = new List<BarcodeFormat>
                {
                    BarcodeFormat.EAN_8, BarcodeFormat.EAN_13
                }
            };
            qrReader.Click += async (sender, e) =>
            {
                var scanner = new MobileBarcodeScanner();
                var result = await scanner.Scan(options);
                testText.Text = result.Text;
            };
            
        }

        
    };
}


