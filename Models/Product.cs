using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Humman.Models
{
    public class Product
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Old { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public string Img { get; set; }
        public string Salary { get; set; }
    }
}
