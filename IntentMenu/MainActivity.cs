using Android.App;
using Android.Content;
using Android.Net;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace IntentMenu
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button btn1, btn2;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            //Abrir segundo activity
            btn1 = FindViewById<Button>(Resource.Id.button1);
            btn1.Click += Btn1_Click;

            //Hacer llamada
            btn2 = FindViewById<Button>(Resource.Id.button2);
            btn2.Click += Btn2_Click;
        }

        private void Btn2_Click(object sender, System.EventArgs e)
        {
            string phone = "888-8888-8";
            Intent i = new Intent(Intent.ActionCall);
            i.SetData(Uri.Parse("tel:" + phone));
            StartActivity(i);
        }

        private void Btn1_Click(object sender, System.EventArgs e)
        {
            Intent i = new Intent(this, typeof(ActivitySegundo));
            StartActivity(i);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}