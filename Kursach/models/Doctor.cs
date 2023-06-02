using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach.models
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }

        public string? SecondNameTeacher { get; set; }
        public string? FirstNameTeacher { get; set; }
        
        public string? FatherNameTeacher { get; set; }
        public string? Post { get; set; }
        public DateOnly BirthDay{ get; set; }
        public string? Adress { get; set; }
        public string? Phone { get; set; }
        public string? Experience { get; set; }
        public string? Diploma { get; set; }
        public string? MilitaryTicket { get; set; }
        public string? Snils { get; set; }
        public string? Passport { get; set; }





    }

}
