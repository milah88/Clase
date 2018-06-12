using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using System;

namespace App1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button btnAuth;
        EditText editTextUserName;
        EditText editTextPassword;
        EditText token;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            btnAuth = FindViewById<Button>(Resource.Id.btnAuth);
            editTextUserName = FindViewById<EditText>(Resource.Id.editTextUserName);
            editTextPassword = FindViewById<EditText>(Resource.Id.editTextPassword);
            editTextPassword = FindViewById<EditText>(Resource.Id.token);
            btnAuth.Click += DoAuthentication;
        }

        private void DoAuthentication(object sender, EventArgs e)
        {
            if (editTextUserName.Text.Equals("bichito") && editTextUserName.Text.Equals("123456"))
            {
                Toast.MakeText(this, "Usuario Valido", ToastLength.Short).Show();
            }
            else
            {
                Toast.MakeText(this, "Usuario Invalido, el teléfono se destruirá", ToastLength.Short);
            }

        }
    }
}

