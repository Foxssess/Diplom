using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach.models
{
    public class WorkTime
    {
        [Key]
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public string? TypeShift { get; set; }
        public string? BeginShift { get; set; }
        public string? EndShift { get; set; }
        public DateOnly? Data { get; set; }
    }
}
