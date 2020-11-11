using OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantsByName(string name);
        Restaurant GetById(int id);
        Restaurant UpdateEntry(Restaurant updatedRestaurant);
        Restaurant AddRestaurant(Restaurant newRestaurant);
        int Commit();
    }

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
    }
}
