using Microsoft.EntityFrameworkCore;
using Ciciovan_Bogdan_Ionut_Lab2.Models;
namespace Ciciovan_Bogdan_Ionut_Lab2.Data
{
    public static class DbInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Ciciovan_Bogdan_Ionut_Lab2Context(serviceProvider.GetRequiredService
            <DbContextOptions<Ciciovan_Bogdan_Ionut_Lab2Context>>()))
            {
                if (context.Book.Any())
                {
                    return; // BD a fost creata anterior
                }

                context.Authors.AddRange(
                    new Authors { FirstName = "Mihail", LastName = "Sadoveanu" },
                    new Authors { FirstName = "George", LastName = "Calinescu" },
                    new Authors { FirstName = "Mircea", LastName = "Eliade" }
                );

                context.Genre.AddRange(
                    new Genre { Name = "Roman" },
                    new Genre { Name = "Nuvela" },
                    new Genre { Name = "Poezie" }
                );
                context.Customer.AddRange(
                    new Customer { Name = "Popescu Marcela", Adress = "Str. Plopilor, nr. 24", BirthDate = DateTime.Parse("1979-09-01") },
                    new Customer { Name = "Mihailescu Cornel", Adress = "Str. Bucuresti, nr. 45, ap. 2", BirthDate = DateTime.Parse("1969-07-08") }
                );
                context.SaveChanges();

                context.Book.AddRange(
                    new Book { Title = "Baltagul", AuthorsID = context.Authors.First(a => a.LastName == "Sadoveanu").ID, Price = Decimal.Parse("22"), GenreID = context.Genre.First(g => g.Name == "Roman").ID },
                    new Book { Title = "Enigma Otiliei", AuthorsID = context.Authors.First(a => a.LastName == "Calinescu").ID, Price = Decimal.Parse("18"), GenreID = context.Genre.First(g => g.Name == "Roman").ID },
                    new Book { Title = "Maytrei", AuthorsID = context.Authors.First(a => a.LastName == "Eliade").ID, Price = Decimal.Parse("27"), GenreID = context.Genre.First(g => g.Name == "Roman").ID }
                );

                context.SaveChanges();
            }
        }
    }
}