using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class User
    {
        //public int UserId { get; set; }
        // имя и фамилия покупателя
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        // адрес покупателя
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Ot { get; set; }
        public string Address { get; set; }
        public string Birth { get; set; }
        public string Number { get; set; }
        // ID книги
    }
}