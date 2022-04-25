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
        Button btn1, btn2, btn3, btn4;
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

            //Abrir el navegador
            btn3 = FindViewById<Button>(Resource.Id.button3);
            btn3.Click += Btn3_Click;

            //Abrir el mapa
            btn4 = FindViewById<Button>(Resource.Id.button4);
            btn4.Click += Btn4_Click;
        }

        private void Btn4_Click(object sender, System.EventArgs e)
        {
            //Establecemos la laitu y la longitud del punto a mostrar
            string locate = "geo:12.1058595,-86.2729785";
            Intent i = new Intent(Intent.ActionView);
            i.SetData(Uri.Parse(locate));
            StartActivity(i);
        }

        private void Btn3_Click(object sender, System.EventArgs e)
        {
            string url = "http://www.google.com";
            Intent i = new Intent(Intent.ActionView);
            i.SetData(Uri.Parse(url));
            StartActivity(i);
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