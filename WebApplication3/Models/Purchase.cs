using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        // имя и фамилия покупателя
        public string Email { get; set; }
        // адрес покупателя
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public int Number { get; set; }
        // ID книги
        public int SneakersId { get; set; }
        // дата покупки
        public DateTime Date { get; set; }
    }
}