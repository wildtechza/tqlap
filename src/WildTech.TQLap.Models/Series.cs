using System;
using System.Collections.Generic;

namespace WildTech.TQLap.Models
{
    public class Series
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Event> Events { get; set; }
    }
}
