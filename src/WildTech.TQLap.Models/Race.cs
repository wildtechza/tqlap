using System;

namespace WildTech.TQLap.Models
{
    public class Race
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Event Event { get; set; }
    }
}
