using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Child
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Id_code { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Parents_Name { get; set; }
    }
}
