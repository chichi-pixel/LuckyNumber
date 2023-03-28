using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;

namespace LuckyNumber
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true, Icon ="@mipmap/ic_launcher")]
    public class MainActivity : AppCompatActivity
    {
        private object resultTextView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            SeekBar seekBar;
            TextView resultTextView;
            Button  rollButton;

            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            seekBar = FindViewById<SeekBar>(Resource.Id.seekBar);
            resultTextView = FindViewById<TextView>(Resource.Id.resultTextView);
            rollButton = (Button)FindViewById(Resource.Id.rollButton);
            rollButton.Click += RollButton_Click;

        }

        private void RollButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int luckyNumber = random.Next(seekBar.Progress) + 1;
            resultTextView.Text = luckyNumber.ToString();

        }

        private void NewMethod(int LuckyNumber) => resultTextView.Text = LuckyNumber.ToString();

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}