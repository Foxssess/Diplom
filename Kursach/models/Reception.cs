using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach.models
{
    public class Reception
    {
        [Key]
        public int Id { get; set; }
        public string? Time  { get; set; }
        public int DoctorId { get; set; }
        public string? NameService { get; set; }
        public string? Cost { get; set; }
        public string? Room { get; set; }
        public DateOnly Data { get; set; }
        public int PatientId { get; set; }
        

    }
}
