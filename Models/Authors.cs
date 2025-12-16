using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Ciciovan_Bogdan_Ionut_Lab2.Models
{
    public class Authors
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}
