using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach.models
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }

        public string? SecondName { get; set; }
        public string? FirstName { get; set; }
        public string? FatherName { get; set; }
        public string? Gender { get; set; }
        public string? Address { get; set; }
        public DateOnly BirthDay { get; set; }
        public string? Phone { get; set; }
        public string? Snils { get; set; }
        public string? Polis { get; set; }
        public string? Passport { get; set; }

    }
}
