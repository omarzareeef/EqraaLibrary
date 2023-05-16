using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models.Branch
{
    public class Branch : BaseModel
    {
        public string NameArabic { get; set; }
        public string NameEnglish { get; set; }
        public string Logo { get; set; }
        public string Address { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string Mobile { get; set; }
        [Column(TypeName = "time")]
        public TimeSpan OpeningTime { get; set; }
        [Column(TypeName = "time")]
        public TimeSpan ClosingTime { get; set; }
        public bool IsActive { get; set; }
    }
}
