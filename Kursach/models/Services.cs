using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach.models
{
    public class Services
    {
        [Key]
        public int Id { get; set; }
        public string? NameService { get; set; }
        public string? Cost { get; set; }
        public int? IdPost { get; set; }

    }
}
