using OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;
                
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant{Id = 01, Name = "Chuy's", Cuisine = CuisineType.Mexican, Location = "Austin"},
                new Restaurant{Id = 02, Name = "Carraba's", Cuisine = CuisineType.Italian, Location = "Houston"},
                new Restaurant{Id = 03, Name = "Yak and Yeti", Cuisine = CuisineType.Indian, Location = "Arvada"}

            };
        }

        public Restaurant GetById(int id)
        {
            return restaurants.SingleOrDefault(rest => rest.Id == id);
        }

        public Restaurant AddRestaurant(Restaurant newRestaurant)
        {
            restaurants.Add(newRestaurant);
            newRestaurant.Id = restaurants.Max(rest => rest.Id) + 1;
            return newRestaurant;
        }

        public Restaurant UpdateEntry(Restaurant updatedRestaurant)
        {
            var restaurant = restaurants.SingleOrDefault(rest => rest.Id == updatedRestaurant.Id);
            if(restaurant != null)
            {
                restaurant.Name = updatedRestaurant.Name;
                restaurant.Location = updatedRestaurant.Location;
                restaurant.Cuisine = updatedRestaurant.Cuisine;
            }
            return restaurant;
        }

        public int Commit()
        {
            return 0;
        } 

        public IEnumerable<Restaurant> GetRestaurantsByName(string name = null)
        {
            return from restaurant in restaurants
                   where string.IsNullOrEmpty(name) || restaurant.Name.StartsWith(name)
                   orderby restaurant.Name
                   select restaurant;
        }

        public Restaurant Delete(int id)
        {
            var restaurant = restaurants.FirstOrDefault(rest => rest.Id == id);
            if(restaurant != null)
            {
                restaurants.Remove(restaurant);
            }
            return restaurant;
        }

        public int GetRestaurantCount()
        {
            return restaurants.Count();
        }
    }
}
