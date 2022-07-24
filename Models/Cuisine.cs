using System.Collections.Generic;

namespace BestRestaurants.Models
{
    public class Cuisine
    {
        public Cuisine()
        {
            this.Restaurant = new HashSet<Restaurant>();
        }

        public int CuisineId { get; set; }
        public string CuisineType { get; set; }
        public virtual ICollection<Restaurant> Restaurant { get; set; }
    }
}