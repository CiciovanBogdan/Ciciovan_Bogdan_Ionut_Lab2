using Ciciovan_Bogdan_Ionut_Lab2.Models;

namespace Ciciovan_Bogdan_Ionut_Lab2.Models.ViewModels
{
    public class PublisherIndexData
    {
        public IEnumerable<Publisher> Publishers { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
