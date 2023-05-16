using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models.BookCategory
{
    public class BookCategory : BaseModel
    {
        public string NameArabic { get; set; }
        public string NameEnglish { get; set; }
        public string SectionID { get; set; }
    }
}
