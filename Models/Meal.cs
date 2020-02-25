using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FamousBeanPortal.Models
{
    public class Meal
    {
        public string Id { get; set; }
        public int MealId { get; set; }
        public int CategoryId { get; set; }
        public string MealName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string NutritionValues { get; set; }
        public string Status { get; set; }


    }
}
