using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Delegates
{
    public class Animal
    {
        public string? Name { get; set; }
        public string? ScientificName { get; set; }
        public IEnumerable<Animal > GetAnimals(IEnumerable<Animal> animals, Func<Animal, bool> predicate) 
        {
            return animals.Where(predicate);
        }

        public IQueryable<Animal> GetAnimalsFromJsonWithIQueryable(Expression<Func<Animal, bool>> predicate)
        {
            string fileName = "Animal.json";
            string jsonString = File.ReadAllText(fileName);
            return JsonConvert.DeserializeObject<IQueryable<Animal>>(jsonString)!.Where(predicate);
        }

        public IEnumerable<Animal> DeserielizeAnimals() 
        {
            string fileName = "Animal.json";
            string jsonString = File.ReadAllText(fileName);
            IEnumerable<Animal> animals = JsonConvert.DeserializeObject<IEnumerable<Animal>>(jsonString)!;
            return animals;
        }
    }
}
