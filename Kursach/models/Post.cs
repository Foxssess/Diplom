using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach.models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string? NamePost { get; set; }
        public int RatePerHour { get; set; }
        public int IdDoctor { get; set; }

    }
}
