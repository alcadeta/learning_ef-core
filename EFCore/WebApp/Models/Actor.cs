using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool AcademyWinner { get; set; }
    }
}
