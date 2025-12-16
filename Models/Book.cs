using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Ciciovan_Bogdan_Ionut_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int? AuthorsID { get; set; }
        public Authors? Authors { get; set; }
        public decimal Price { get; set; }
        public int? GenreID { get; set; }
        public Genre? Genre { get; set; }
        public ICollection<Order>? Orders { get; set; }
    }
}
