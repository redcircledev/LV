using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace LV
{
    [Activity(Label = "BookDetail")]
    public class DetailBooks : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Details); 
            //Se rescata el dato que le mandamos a travez del nombre que le pusimos al mandarlo "ItemPosition". Si no recibe nada, entonces será -1
            int position = Intent.GetIntExtra("ItemPosition", -1);
            var item = BookData.Books[position];


            FindViewById<TextView>(Resource.Id.nameTextView).Text = "Titulo: " + item.title;
            FindViewById<TextView>(Resource.Id.genreTextView).Text = "Genero: " + item.Genre.ToString();
            FindViewById<TextView>(Resource.Id.summaryTextView).Text = "summary: " + item.Summary.ToString();
            var imag = FindViewById<ImageView>(Resource.Id.bookView);

            Stream stream = Assets.Open(item.ImageUrl);
            Drawable drawable = Drawable.CreateFromStream(stream, null);
            imag.SetImageDrawable(drawable);
            return;

        }
    }
}