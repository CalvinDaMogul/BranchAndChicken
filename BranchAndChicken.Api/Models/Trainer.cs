using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BranchAndChicken.Api.Models
{
    public class Trainer
    {
        public string Name { get; set; }
        public int YearsOfExperience { get; set; }
        public Specialty Specialty { get; set; }
        public List<Chicken> Cooper { get; set; }
    }
    public enum Specialty
    {
        Chudo,
        Chousting,
        TaeCluckDoe,
        ChravMcgaw

    }
}


