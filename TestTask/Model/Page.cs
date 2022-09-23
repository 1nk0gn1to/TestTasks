using System;
namespace TestTask.Model
{
    public class Page
    {
        public int Id { get; set; }
        public List<Dish> DishesCurrentPage { get; set; } = new List<Dish>();
    }

}
