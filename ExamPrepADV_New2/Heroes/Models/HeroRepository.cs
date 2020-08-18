using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Heroes.Models
{
    public class HeroRepository
    {
        public HeroRepository()
        {
            this.heroes = new List<Hero>();
        }

        private readonly List<Hero> heroes;
        public int Count => this.heroes.Count;

        public void Add(Hero hero)
        {
            this.heroes.Add(hero);
        }

        public void Remove(string name)
        {
            Hero targetHero = this.heroes.FirstOrDefault(h => h.Name == name);

            heroes.Remove(targetHero);
        }

        public Hero GetHeroWithHighestStrength()
        {
            Hero hero = this.heroes.OrderByDescending
                (h => h.Item.Strength).FirstOrDefault();

            return hero;
        }
        public Hero GetHeroWithHighestAbility()
        {
            Hero hero = this.heroes.OrderByDescending
                (h => h.Item.Ability).FirstOrDefault();

            return hero;
        }
        public Hero GetHeroWithHighestIntelligence()
        {
            Hero hero = this.heroes.OrderByDescending
                (h => h.Item.Intelligence).FirstOrDefault();

            return hero;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var hero in heroes)
            {
                sb.AppendLine(hero.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}
