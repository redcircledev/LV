using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace LV
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.main);
            var booksList = FindViewById<ListView>(Resource.Id.booksListView);
            booksList.Adapter = new BookAdapter(BookData.Books);
            booksList.ItemClick += OnBooksClick;

        }

        void OnBooksClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            int position = e.Position;

            var intent = new Intent(this, typeof(DetailBooks));
            intent.PutExtra("ItemPosition", position);
            StartActivity(intent);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {

            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);

        }
    }
}