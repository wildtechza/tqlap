using System;

namespace WildTech.TQLap.Models
{
    public class DriverClass
    {
        public Guid Id { get; set; }
        public Driver Driver { get; set; }
        public Class Class { get; set; }
        public int Number { get; set; }
        public int Transponder { get; set; }
    }
}
