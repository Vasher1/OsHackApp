using Android.App;
using Android.Widget;
using Android.OS;
using ZXing.Mobile;
using Android.Views;

namespace OSHackApp
{
    [Activity(Label = "OSHackApp", MainLauncher = true)]
    public class MainActivity : Activity 
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);

            Button scanButton = (Button)FindViewById(Resource.Id.buttonScan);
            //TextView text = (TextView)FindViewById(Resource.Id.textView1);

            scanButton.Click += async (sender, e) =>
            {
                var scanner = new MobileBarcodeScanner();
                var result = await scanner.Scan();
                //text.Text = result.Text;
            };
        }
    }
}

