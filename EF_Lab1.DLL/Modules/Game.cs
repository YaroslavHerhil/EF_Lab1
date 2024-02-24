using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Lab1.DLL.Modules
{
    public class Game
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Studio { get; set; }
        public string Genre { get; set; }
        public int? CopiesSold { get; set; }
        public string? Style { get; set; } //single, multi, oncouch-coop etc.
        public DateTime ReleaseDate { get; set; }
    }
}
