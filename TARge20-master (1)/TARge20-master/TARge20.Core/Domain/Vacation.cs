using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Vacation
    {
        [Key]
        public int Id { get; set; }
        public DateTime Beginning { get; set; }
        public DateTime End { get; set; }
        public int Quantity { get; set; }
    }
}
