using System;

namespace WildTech.TQLap.Models
{
    public class Event
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Track Track { get; set; }
    }
}
