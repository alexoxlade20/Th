using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Sneakers
    {
        public int Id { get; set; }
        // название книги
        public string Model { get; set; }
        // автор книги
        public string Company { get; set; }
        // цена
        public int Price { get; set; }
    }
}