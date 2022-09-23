using NUnit.Framework;
using System;
using System.Collections.Generic;
using TestTask.Model;

namespace TestTask.Test
{
    public class Tests
    {
        [Test]
        public void IsValidMenuMaster()
        {
            int countDishesOnPage = 3;
            int id = 3;

            List<Dish> dishes = new List<Dish>()
            {
                new Dish() { Name = "Матча" },
                new Dish() { Name = "Латте" },
                new Dish() { Name = "Смузи" },
                new Dish() { Name = "Джин" },
                new Dish() { Name = "Эскимо" },
                new Dish() { Name = "Кровавая Мэри" },
                new Dish() { Name = "Американо"}
            };

            List<Dish> listDishes = new List<Dish>
            {
                new Dish{Name = "Матча"},
                new Dish{Name = "Джин"},
                new Dish{Name = "Американо"}
            };

            MenuMaster menu = new MenuMaster(dishes, countDishesOnPage);

            Page page = new Page();
            page.DishesCurrentPage.Add(new Dish() { Name = "Американо" });

            var dishesNames = new List<string>();
            foreach (var dish in listDishes)
            {
                dishesNames.Add(dish.Name);
            }

            var currentDishes = new List<string>();
            foreach (var dish in page.DishesCurrentPage)
            {
                currentDishes.Add(dish.Name);
            }

            var dishesCurrentPage = new List<string>();
            foreach (var dish in menu.GetDishesCurrentPage(id))
            {
                dishesCurrentPage.Add(dish.Name);
            }

            var firstDishesAllPages = new List<string>();
            foreach (var dish in menu.GetFirstDishesAllPages())
            {
                firstDishesAllPages.Add(dish.Name);
            }

            Assert.AreEqual(7, menu.GetCountDishes());
            Assert.AreEqual(3, menu.GetCountPages());
            Assert.AreEqual(1, menu.GetDishesCountCurrentPage(id));
            Assert.AreEqual(currentDishes, dishesCurrentPage);
            Assert.AreEqual(dishesNames, firstDishesAllPages);
        }

        [TestCase(0, 3)]
        [TestCase(-1, 3)]
        [TestCase(11, 3)]
        [TestCase(3, 0)]
        [TestCase(3, 4)]
        [TestCase(3, -1)]
        public void IsInvalidCountDishesOnPage_IsInvalidPageId(int countDishesOnPage, int id)
        {
            List<Dish> dishes = new List<Dish>()
            {
                new Dish() { Name = "Матча" },
                new Dish() { Name = "Латте" },
                new Dish() { Name = "Смузи" },
                new Dish() { Name = "Джин" },
                new Dish() { Name = "Эскимо" },
                new Dish() { Name = "Кровавая Мэри" },
                new Dish() { Name = "Американо"}
            };
            Assert.Throws<Exception>(() =>
            {
                MenuMaster menu = new MenuMaster(dishes, countDishesOnPage);
                menu.GetDishesCountCurrentPage(id);
                menu.GetDishesCurrentPage(id);
            });


            //var countPages = menu.GetCountPages();

            ////var menuMasterArgumentException = Assert.Throws<ArgumentException>(() => new MenuMaster(dishes, countDishesOnPage));
            //var menuMasterException = Assert.Throws<ArgumentOutOfRangeException>(() => new MenuMaster(dishes, countDishesOnPage));
            //var dishesOnPageException = Assert.Throws<Exception>(()=> menu.GetDishesCountCurrentPage(id));
            //var dishesCurrentPageException = Assert.Throws<Exception>(() => menu.GetDishesCurrentPage(id));

            ////Assert.Equals("Список блюд не должен быть пустым.", menuMasterArgumentException.Message);
            //Assert.Equals("Диапозон блюд на одной странице должен быть от 1 до 10.", menuMasterException.Message);
            //Assert.Equals($"Страницы под номером {id} не существует. Всего {countPages} страниц.", dishesOnPageException.Message);
            //Assert.Equals($"Страницы под номером {id} не существует. Всего {countPages} страниц.", dishesCurrentPageException.Message);
        }

        [Test]
        public void IsInvalidDishesCollection()
        {
            int countDishesOnPage = 2;
            List<Dish> dishes = new List<Dish>();

            Assert.Throws<ArgumentNullException>(() =>
            {
                MenuMaster menu = new MenuMaster(dishes, countDishesOnPage);
            });
        }
    }
}