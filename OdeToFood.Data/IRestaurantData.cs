using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OdeToFood.Core;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantsData : IRestaurantData
    {
        private List<Restaurant> restaurants;

        public InMemoryRestaurantsData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant {Id = 1, Name = "Herb's Pizza", Location = "Missouri", Cuisine = CuisineType.Italian},
                new Restaurant {Id = 2, Name = "Cinnamon Club", Location = "London", Cuisine = CuisineType.None},
                new Restaurant {Id = 3, Name = "Rancho Grande", Location = "Missouri", Cuisine = CuisineType.Mexican}
            };

        }

        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                orderby r.Name
                select r;
        }
    }
}
