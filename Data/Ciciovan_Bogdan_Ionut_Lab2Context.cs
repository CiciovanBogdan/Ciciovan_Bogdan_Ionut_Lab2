using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ciciovan_Bogdan_Ionut_Lab2.Models;

namespace Ciciovan_Bogdan_Ionut_Lab2.Data
{
    public class Ciciovan_Bogdan_Ionut_Lab2Context : DbContext
    {
        public Ciciovan_Bogdan_Ionut_Lab2Context (DbContextOptions<Ciciovan_Bogdan_Ionut_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Ciciovan_Bogdan_Ionut_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Ciciovan_Bogdan_Ionut_Lab2.Models.Customer> Customer { get; set; } = default!;
        public DbSet<Ciciovan_Bogdan_Ionut_Lab2.Models.Genre> Genre { get; set; } = default!;
        public DbSet<Ciciovan_Bogdan_Ionut_Lab2.Models.Authors> Authors { get; set; } = default!;
        public DbSet<Ciciovan_Bogdan_Ionut_Lab2.Models.Order> Order { get; set; } = default!;
    }
}
