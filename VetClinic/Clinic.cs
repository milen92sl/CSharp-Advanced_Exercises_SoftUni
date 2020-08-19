using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
    public class Clinic
    {
        private readonly ICollection<Pet> data;
        public int Capacity { get; set; }

        public Clinic(int capacity)
        {
            this.Capacity = capacity;
            this.data = new List<Pet>();
        }

        public int Count => this.data.Count;

        public void Add(Pet pet)
        {
            this.data.Add(pet);
        }

        public bool Remove(string name)
        {
            Pet targetPet = this.data.FirstOrDefault(p => p.Name == name);
            return data.Remove(targetPet);
        }

        public Pet GetPet(string name, string owner)
        {
            Pet targetPet = this.data
                .OrderByDescending(p => p.Name == name).ThenByDescending(p => p.Owner == owner).FirstOrDefault();
            if (!data.Contains(targetPet))
            {
                return null;
            }
            else
            {
                return targetPet;
            }
        }

        public Pet GetOldestPet()
        {
            Pet oldestPet = this.data
                .OrderByDescending(p => p.Age).FirstOrDefault();

            return oldestPet;
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine();
            sb.AppendLine($"The clinic has the following patients:");

            foreach (var pet in data)
            {
                sb.Append(pet.Name + " ");
                sb.AppendLine(pet.Owner + " ");
            }
            return sb.ToString().Trim();
        }
    }
}
