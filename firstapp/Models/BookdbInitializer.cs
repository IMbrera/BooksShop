﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace firstapp.Models
{
    public class BookdbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Name = "Война и мир", Author = "Л. Толстой", Price = 220 });
            db.Books.Add(new Book { Name = "Отцы и дети", Author = "И. Тургенев", Price = 180 });
            db.Books.Add(new Book { Name = "Чайка", Author = "А. Чехов", Price = 150 });

            base.Seed(db);
        }
    }
}