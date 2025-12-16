using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Ciciovan_Bogdan_Ionut_Lab2.Models
{
    public class Genre
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}
