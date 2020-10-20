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
    public class BookData
    {
        public static List<Book> Books { get; private set; }
        static BookData()
        {
            var temp = new List<Book>();

            AddBooks(temp);

            Books = temp.OrderBy(i => i.title).ToList();
        }

        static void AddBooks(List<Book> Books)
        {
            Books.Add(new Book()
            {
                title = "Resident Evil Zero Hour",
                Genre = "Horror / Fantasy",
                ImageUrl = "images/resident-evil-0.jpg",
                Summary = "The first novel on the Resident Evil Franchise"
            });

            Books.Add(new Book()
            {
                title = "Resident Evil Umbrella Conspiracy",
                Genre = "Horror / Fantasy",
                ImageUrl = "images/resident-evil-1.jpg",
                Summary = "Second novel on the Resident Evil Franchise"
            });

            Books.Add(new Book()
            {
                title = "Resident Evil Underworld",
                Genre = "Horror / Fantasy",
                ImageUrl = "images/resident-evil-2.jpg",
                Summary = "Third novel on the Resident Evil Franchise"
            });

            Books.Add(new Book()
            {
                title = "Resident Evil Nemesis",
                Genre = "Horror / Fantasy",
                ImageUrl = "images/resident-evil-3.jpg",
                Summary = "Forth novel on the Resident Evil Franchise"
            });

            Books.Add(new Book()
            {
                title = "Resident Evil Caliban Conspiracy",
                Genre = "Horror / Fantasy",
                ImageUrl = "images/resident-evil-4.jpg",
                Summary = "Fifth novel on the Resident Evil Franchise"
            });

        }
    }
}