using PizzaAPI.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace PizzaAPI.Services
{
    public static class PizzaService
    {
        public static IEnumerable<Pizza> Get()
        {
            return PizzaRepository.GetPizzas();
        }

        public static IEnumerable<Pizza> GetOne(string name)
        {
            var result =
                (from p in PizzaRepository.GetPizzas()
                where p.Name.Contains(name)
                select new Pizza(p.Id, p.Name, p.Ingredients, p.Price.ConvertToUsd())).ToList();

            return result;
        }

        public static double ConvertToUsd(this double price)
        {
            return price > 0 ? price * 0.85 : price;
        }
    }
}