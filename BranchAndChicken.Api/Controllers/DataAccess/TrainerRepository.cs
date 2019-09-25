using BranchAndChicken.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BranchAndChicken.Api.Controllers.DataAccess
{
    public class TrainerRepository
    {
        static List<Trainer> _trainers = new List<Trainer>
        {
            new Trainer
            {
                Name ="Nathan",
                Specialty = Specialty.TaeCluckDoe,
                YearsOfExperience = 0
            },

            new Trainer
            {
                Name = "Martin",
                Specialty = Specialty.Chudo,
                YearsOfExperience = 12
            },

            new Trainer
            {
                Name = "Adam",
                Specialty = Specialty.ChravMcgaw,
                YearsOfExperience = 3
            }

        };

        public List<Trainer> GetAll()
        {
            return _trainers;
        }

        public Trainer Get(string name)
        {
            var trainer = _trainers.First(t => t.Name == name);
            return trainer;

        }  

        public  void Remove(string name)
        {
            var trainer = Get(name);

            _trainers.Remove(trainer);
        }
    }
}
