using TestTask;
using TestTask.Model;

class Programm
{
    public static void Main()
    {
        int dishesCountOnPage = 2;

        List<Dish> dishes = new List<Dish>()
        {
            new Dish() { Name = "Пельм1ени"}
        };

        MenuMaster menu = new MenuMaster(dishes, dishesCountOnPage);

        foreach(var dish in menu.GetDishesCurrentPage(3))
        {
        Console.WriteLine(dish.Name);

        }
        Console.ReadKey();
    }
}