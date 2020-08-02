using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Rabbits
{

    public class Cage
    {
        public Cage()
        {
            this.data = new List<Rabbit>();
        }

        public Cage(string name, int capacity) : this()
        {
            this.Name = name;
            this.Capacity = capacity;
        }

        private readonly List<Rabbit> data;

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count => this.data.Count;

        public void Add(Rabbit rabbit)
        {
            if (this.data.Count + 1 <= this.Capacity)
            {
                this.data.Add(rabbit);
            }
        }

        public bool RemoveRabbit(string name)
        {
            Rabbit rabbit = this.data.FirstOrDefault(r => r.Name == name);
            if (rabbit!= null)
            {
                this.data.Remove(rabbit);

                return true;
            }

            return false;
        }

        public void RemoveSpecies(string species)
        {
            this.data.RemoveAll(x => x.Species == species);
        }

        public Rabbit SellRabbit(string name)
        {
            Rabbit rabbit = this.data.FirstOrDefault(r => r.Name == name);

            if (rabbit != null)
            {
                rabbit.Available = false;
            }

            return rabbit;
        }

        public Rabbit[] SellRabbitsBySpecies(string species)
        {
            Rabbit[] rabbits = this.data
                .Where(r => r.Species == species)
                .ToArray();
            foreach (var rabbit in rabbits)
            {
                rabbit.Available = false;
            }

            return rabbits;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Rabbits available at {this.Name}:");

            foreach (var rabbit in data.Where(r=>r.Available))
            {
                sb.AppendLine(rabbit.ToString().Trim());
            }

            return sb.ToString().Trim();
        }

    }
}