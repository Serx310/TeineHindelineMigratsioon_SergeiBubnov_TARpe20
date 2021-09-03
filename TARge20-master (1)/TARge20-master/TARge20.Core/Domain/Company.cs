using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TARge20.Core.Domain
{
     public class Company
    {
        [Key]
        public int Id { get; set; }
        public string CName { get; set; }
        public DateTime foundingDate { get; set; }
        public virtual EstonianOffice EstonianOffice { get; set; }
    }
}
