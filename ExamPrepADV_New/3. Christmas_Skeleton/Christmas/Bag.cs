using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Christmas
{
    public class Bag
    {
        public Bag(string color, int capacity)
        {
            this.Color = color;
            this.Capacity = capacity;
            data = new List<Present>();
        }
        private readonly List<Present> data;
        public string Color { get; set; }
        public int Capacity { get; set; }
        public int Count => this.data.Count;
        public void Add(Present present)
        {
            if (this.Capacity > data.Count)
            {
                this.data.Add(present);
            }
        }

        public bool Remove(string name)
        {
            return data.Remove(data.FirstOrDefault(x => x.Name == name));
        }

        public Present GetHeaviestPresent()
        {
            Present heaviestPresent = data.OrderByDescending(x => x.Weight).FirstOrDefault();

            return heaviestPresent;
        }

        public Present GetPresent(string name)
        {
            Present currPresent = data.FirstOrDefault(n => n.Name == name);
            return currPresent;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{Color} bag contains:");

            foreach (var present in data)
            {
                sb.AppendLine($"{present.ToString()}");
            }

            return sb.ToString().Trim();
        }
    }
}
