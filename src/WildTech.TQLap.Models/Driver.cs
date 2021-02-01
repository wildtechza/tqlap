using System;
using System.Collections.Generic;

namespace WildTech.TQLap.Models
{
    public class Driver
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Country Country { get; set; }
        public IEnumerable<DriverClass> Classes { get; set; }
    }
}
