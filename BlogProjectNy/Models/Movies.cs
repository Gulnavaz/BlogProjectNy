using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProjectNy.Models
{
    public class Movies
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime Datetime { get; set; }
        public string Category { get; set; }
        public string Text { get; set; }
    }
}
