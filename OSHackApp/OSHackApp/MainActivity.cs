using Android.App;
using Android.Widget;
using Android.OS;
using ZXing.Mobile;
using Android.Views;

namespace OSHackApp
{
    [Activity(Label = "OSHackApp", Theme = "@android:style/Theme.NoTitleBar", MainLauncher = true)]
    public class MainActivity : Activity 
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);
            InitialiseBarcodeScanner();
        }

        private void InitialiseBarcodeScanner()
        {
            MobileBarcodeScanner.Initialize(Application);

            Button scanButton = (Button)FindViewById(Resource.Id.buttonScan);
            TextView text = (TextView)FindViewById(Resource.Id.textView1);
            text.Text = "";

            scanButton.Click += async (sender, e) =>
            {
                var scanner = new MobileBarcodeScanner();
                var result = await scanner.Scan();
                switch(result.Text.ToString())
                {
                    case "5000159500920":
                        text.Text = "You scanned some M&Ms!";
                        break;
                    default:
                        text.Text = result.Text;
                        break;
                }
            };
        }
    }
}

