using LinnqPractice.Pets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinnqPractice.Pets;
namespace LinqPractice.Pets
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PetType PetType { get; set; }
        public float Weight { get; set; }

        public Pet(int id, string name, PetType type, float weight)
        {
            Id = id;
            Name = name;
            PetType = type;
            Weight = weight;
        }



    }
}
