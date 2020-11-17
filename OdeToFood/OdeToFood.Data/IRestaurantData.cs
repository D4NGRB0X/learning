﻿using OdeToFood.Core;
using System.Collections.Generic;
using System.Text;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantsByName(string name);
        Restaurant GetById(int id);
        Restaurant UpdateEntry(Restaurant updatedRestaurant);
        Restaurant AddRestaurant(Restaurant newRestaurant);
        Restaurant Delete(int id);
        int GetRestaurantCount();
        int Commit();
    }
}
