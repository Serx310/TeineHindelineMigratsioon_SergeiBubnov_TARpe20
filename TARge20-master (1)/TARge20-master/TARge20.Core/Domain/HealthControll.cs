using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TARge20.Core.Domain
{
    public class HealthControll
    {
        [Key]
        public int Id { get; set; }
        public int Employee_Id { get; set; }
        public DateTime Givingout { get; set; }
        public DateTime availableFrom { get; set; }
        public DateTime availableuUntil { get; set; }
    }
}
