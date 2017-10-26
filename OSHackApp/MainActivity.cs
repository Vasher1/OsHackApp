using Android.App;
using Android.Widget;
using Android.OS;

namespace OSHackApp
{
    [Activity(Label = "OSHackApp", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Hello Squid!
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}

