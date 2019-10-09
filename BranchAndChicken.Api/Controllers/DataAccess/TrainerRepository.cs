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
                id =  Guid.NewGuid(),
                Name ="Trev Guinn",
                Specialty = Specialty.TaeCluckDoe,
                YearsOfExperience = 0
            },

            new Trainer
            {
                id = Guid.NewGuid(),
                Name = "Tony Fletcher",
                Specialty = Specialty.Chudo,
                YearsOfExperience = 12
            },

            new Trainer
            {
                id = Guid.NewGuid(),
                Name = "Glenn Dixon",
                Specialty = Specialty.ChravBagaw,
                YearsOfExperience = 3
            },

            new Trainer
            {
                id = Guid.NewGuid(),
                Name = "Tobias Blair",
                Specialty = Specialty.TaeCluckDoe,
                YearsOfExperience = 4
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

        public Trainer Update(Trainer updatedTrainer, Guid id)
        {
            var trainerToUpdate =_trainers.First(trainer => trainer.id == id);
            trainerToUpdate.Name = updatedTrainer.Name;
            trainerToUpdate.YearsOfExperience = trainerToUpdate.YearsOfExperience;
            trainerToUpdate.Specialty = updatedTrainer.Specialty;
            return trainerToUpdate;
        }

        public Trainer Add(Trainer newTrainer)
        {
            _trainers.Add(newTrainer);
            
        }
       
    }
}
