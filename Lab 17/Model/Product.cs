using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Lab_17.Model
{
    internal class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public Productor Productor { get; set; } 
        public List<Category> categories { get; set; } = new List<Category> ();
        public List<Tag> Tag { get; set; }

    }
}
