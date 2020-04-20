using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace MickKonradProjectBackend
{
    public class DueTime
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        public int StopId { get; set; }

        [Required]
        public int TimeDue { get; set; }

        [Required]
        public string Route { get; set; }
    }
}
