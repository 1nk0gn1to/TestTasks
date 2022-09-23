using TestTask;
using TestTask.Model;

class Programm
{
    public static void Main()
    {
        List<Dish> dishes1 = new List<Dish>()
        {
            new Dish() { Name = "qrgbnjbnklanbNKLNBASKNBKNASLKBDNJSKGNLAKNBLA" }
        };
        List<Dish> dishes = new List<Dish>()
        {
            new Dish() { Name = "Матча"},
            new Dish() { Name = "Латте"},
            new Dish() { Name = "Смузи"},
            new Dish() { Name = "Джин" },
            new Dish() { Name = "Эскимо" },
            new Dish() { Name = "Кровавая Мэри"},
            new Dish() { Name = "Американо"},
        };
        Console.WriteLine("Введите число");
        var countDishes = Convert.ToInt32(Console.ReadLine());

        MenuMaster menu = new MenuMaster(dishes, countDishes);

        Console.WriteLine(menu.GetCountDishes());
        Console.WriteLine(menu.GetCountPages());
        Console.WriteLine(menu.GetDishesCountCurrentPage(1));
        foreach (var item in menu.GetDishesCurrentPage(1))
            {
                Console.Write($"{item.Name} ");
            }
        Console.WriteLine();
        foreach(var item in menu.GetFirstDishesAllPages())
        {
            Console.Write(item.Name);
        }
        Console.ReadKey();
    }
}