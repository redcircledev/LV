using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace LV
{
    public class Book
    {
        public string title { get; set; }
        public string ImageUrl { get; set; }
        public string Genre { get; set; }
        public string Summary { get; set; }

        public override string ToString()
        {
            return title + " " + Genre;
        }
    }
}