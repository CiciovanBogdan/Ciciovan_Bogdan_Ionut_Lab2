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
        public DbSet<Ciciovan_Bogdan_Ionut_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Ciciovan_Bogdan_Ionut_Lab2.Models.Author> Author { get; set; } = default!;
        public DbSet<Ciciovan_Bogdan_Ionut_Lab2.Models.Category> Category { get; set; } = default!;
        public DbSet<Ciciovan_Bogdan_Ionut_Lab2.Models.BookCategory> BookCategory { get; set; } = default!;
    }
}
