using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models.Book
{
    public class Book : BaseModel
    {
        public string NameArabic { get; set; }
        public string NameEnglish { get; set; }
        public string Logo { get; set; }
        public string PDF { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }
        public string AuthorName { get; set; }
        public string TranslatorName { get; set; }
        public string PublishingHouse { get; set; }
        public string PublishingYear { get; set; }
        public int AvailableNumber { get; set; }
        public int PagesCount { get; set; }

        public string BookCategoryID { get; set; }
    }
}
