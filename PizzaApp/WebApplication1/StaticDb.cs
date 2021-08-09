using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1
{
    public static class StaticDb
    {
        public static List<Book> Books = new List<Book>
        {
            new Book
            {
                Id = 1,
                Title = "Zoki Poki"
            },
            new Book
            {
                Id = 2,
                Title = "Kasni Porasni"
            }
        };
    }
}
