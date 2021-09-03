using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TARge20.Core.Domain
{
    public class EstonianOffice
    {
        [Key]
        public int Id { get; set; }
        public string Location { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public virtual List<Employee> Employees { get; set; }
    }
}
