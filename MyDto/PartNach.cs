using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDto
{
    public class PartNach: location
    {
        public string Book {  get; set; }
        public string Perek { get; set; }
        public string Pasuk { get; set; }
        public string Text { get; set; }

    }
}
