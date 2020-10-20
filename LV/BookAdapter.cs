using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.App;
using Android.Content;
using System.IO;


namespace LV
{
    public class BookAdapter: BaseAdapter<Book>
    {
        List<Book> books;

        public BookAdapter(List<Book> books)
        {
            this.books = books;
        }

        public override Book this[int position]
        {
            get
            {
                return books[position];
            }
        }

        public override int Count
        {
            get
            {
                return books.Count;
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var inflater = LayoutInflater.From(parent.Context);
            var view = inflater.Inflate(Resource.Layout.BooksRow, parent, false);

            var photo = view.FindViewById<ImageView>(Resource.Id.photoImageView);
            var name = view.FindViewById<TextView>(Resource.Id.nameTextView);
            var category = view.FindViewById<TextView>(Resource.Id.categoryTextView);

            Stream stream = parent.Context.Assets.Open(books[position].ImageUrl);
            Drawable drawable = Drawable.CreateFromStream(stream, null);
            photo.SetImageDrawable(drawable);

            name.Text = books[position].title;
            category.Text = books[position].Genre;

            return view;
        }
    }
}