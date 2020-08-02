using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStationRecruitment
{
    public class SpaceStation
    {
        private List<Astronaut> data;

        private SpaceStation() 
        {
            this.data = new List<Astronaut>();
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count => this.data.Count;

        public SpaceStation(string name, int capacity) : this()
        {
            this.Name = name;
            this.Capacity = capacity;
        }

        public void Add(Astronaut astronaut)
        {
            if (this.data.Count + 1 <= this.Capacity)
            {
                this.data.Add(astronaut);
            }
        }
        public bool Remove(string name)
        {
           Astronaut astronaut= this.data.FirstOrDefault(x => x.Name == name);

           if (astronaut == null)
           {
               return false;
           }
           else
           {
               this.data.Remove(astronaut);
               return true;
           }
        }

        public Astronaut GetOldestAstronaut()
        {
            Astronaut oldesAstronaut = this.data
                .OrderByDescending(a => a.Age)
                .FirstOrDefault();

            return oldesAstronaut;
        }

        public Astronaut GetAstronaut(string name)
        {
            Astronaut astronaut = this.data.FirstOrDefault(a => a.Name == name);
            return astronaut;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Astronauts working at Space Station {this.Name}:");
            foreach (var astronaut in data)
            {
                sb.AppendLine(astronaut.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
