using NUnit.Framework;
using System;
using System.Collections.Generic;
using TestTask.Model;

namespace TestTask.Test
{
    public class MenuMasterTests
    {
        [TestCase(1, 1, 5, 1)]
        [TestCase(1, 2, 5, 1)]
        [TestCase(1, 3, 5, 1)]
        [TestCase(1, 4, 5, 1)]
        [TestCase(1, 5, 5, 1)]
        [TestCase(2, 1, 3, 2)]
        [TestCase(2, 2, 3, 2)]
        [TestCase(2, 3, 3, 1)]
        [TestCase(3, 1, 2, 3)]
        [TestCase(3, 2, 2, 2)]
        [TestCase(4, 1, 2, 4)]
        [TestCase(4, 2, 2, 1)]
        [TestCase(5, 1, 1, 5)]
        public void IsValidMenuMaster(int dishesCountOnPage, int id, int expectedPagesCount, int expectedDishesCountCurrentPage)
        {

            List<Dish> dishes = new List<Dish>()
            {
                new Dish() { Name = "��" },
                new Dish() { Name = "�����" },
                new Dish() { Name = "������� ��-����������" },
                new Dish() { Name = "���� ��������� � �������� � ��������� ������" },
                new Dish() { Name = "������" }
            };

            Page page = new Page();

            List<Dish> expectedListDishes = new List<Dish>();

            #region [Filling excpected results for last two methods]
            if (dishesCountOnPage == 1 && id == 1)
            {
                expectedListDishes.Add(new Dish { Name = "��" });
                expectedListDishes.Add(new Dish { Name = "�����" });
                expectedListDishes.Add(new Dish { Name = "������� ��-����������" });
                expectedListDishes.Add(new Dish { Name = "���� ��������� � �������� � ��������� ������" });
                expectedListDishes.Add(new Dish { Name = "������" });

                page.DishesCurrentPage.Add(new Dish() { Name = "��" });
            }
            if (dishesCountOnPage == 1 && id == 2)
            {
                expectedListDishes.Add(new Dish { Name = "��" });
                expectedListDishes.Add(new Dish { Name = "�����" });
                expectedListDishes.Add(new Dish { Name = "������� ��-����������" });
                expectedListDishes.Add(new Dish { Name = "���� ��������� � �������� � ��������� ������" });
                expectedListDishes.Add(new Dish { Name = "������" });

                page.DishesCurrentPage.Add(new Dish() { Name = "�����" });
            }
            if (dishesCountOnPage == 1 && id == 3)
            {
                expectedListDishes.Add(new Dish { Name = "��" });
                expectedListDishes.Add(new Dish { Name = "�����" });
                expectedListDishes.Add(new Dish { Name = "������� ��-����������" });
                expectedListDishes.Add(new Dish { Name = "���� ��������� � �������� � ��������� ������" });
                expectedListDishes.Add(new Dish { Name = "������" });

                page.DishesCurrentPage.Add(new Dish() { Name = "������� ��-����������" });
            }
            if (dishesCountOnPage == 1 && id == 4)
            {
                expectedListDishes.Add(new Dish { Name = "��" });
                expectedListDishes.Add(new Dish { Name = "�����" });
                expectedListDishes.Add(new Dish { Name = "������� ��-����������" });
                expectedListDishes.Add(new Dish { Name = "���� ��������� � �������� � ��������� ������" });
                expectedListDishes.Add(new Dish { Name = "������" });

                page.DishesCurrentPage.Add(new Dish() { Name = "���� ��������� � �������� � ��������� ������" });
            }
            if (dishesCountOnPage == 1 && id == 5)
            {
                expectedListDishes.Add(new Dish { Name = "��" });
                expectedListDishes.Add(new Dish { Name = "�����" });
                expectedListDishes.Add(new Dish { Name = "������� ��-����������" });
                expectedListDishes.Add(new Dish { Name = "���� ��������� � �������� � ��������� ������" });
                expectedListDishes.Add(new Dish { Name = "������" });

                page.DishesCurrentPage.Add(new Dish() { Name = "������" });
            }
            if (dishesCountOnPage == 2 && id == 1)
            {
                expectedListDishes.Add(new Dish { Name = "��" });
                expectedListDishes.Add(new Dish { Name = "������� ��-����������" });
                expectedListDishes.Add(new Dish { Name = "������" });

                page.DishesCurrentPage.Add(new Dish() { Name = "��" });
                page.DishesCurrentPage.Add(new Dish() { Name = "�����" });
            }
            if (dishesCountOnPage == 2 && id == 2)
            {
                expectedListDishes.Add(new Dish { Name = "��" });
                expectedListDishes.Add(new Dish { Name = "������� ��-����������" });
                expectedListDishes.Add(new Dish { Name = "������" });

                page.DishesCurrentPage.Add(new Dish() { Name = "������� ��-����������" });
                page.DishesCurrentPage.Add(new Dish() { Name = "���� ��������� � �������� � ��������� ������" });
            }
            if (dishesCountOnPage == 2 && id == 3)
            {
                expectedListDishes.Add(new Dish { Name = "��" });
                expectedListDishes.Add(new Dish { Name = "������� ��-����������" });
                expectedListDishes.Add(new Dish { Name = "������" });

                page.DishesCurrentPage.Add(new Dish() { Name = "������" });

            }
            if (dishesCountOnPage == 3 && id == 1)
            {
                expectedListDishes.Add(new Dish { Name = "��" });
                expectedListDishes.Add(new Dish{Name = "���� ��������� � �������� � ��������� ������"});

                page.DishesCurrentPage.Add(new Dish() { Name = "��" });
                page.DishesCurrentPage.Add(new Dish() { Name = "�����" });
                page.DishesCurrentPage.Add(new Dish() { Name = "������� ��-����������" });
            }
            if (dishesCountOnPage == 3 && id == 2)
            {
                expectedListDishes.Add(new Dish { Name = "��" });
                expectedListDishes.Add(new Dish { Name = "���� ��������� � �������� � ��������� ������" });

                page.DishesCurrentPage.Add(new Dish() { Name = "���� ��������� � �������� � ��������� ������" });
                page.DishesCurrentPage.Add(new Dish() { Name = "������" });
            }
            if (dishesCountOnPage == 4 && id == 1)
            {
                expectedListDishes.Add(new Dish { Name = "��" });
                expectedListDishes.Add(new Dish{Name = "������"});

                page.DishesCurrentPage.Add(new Dish() { Name = "��" });
                page.DishesCurrentPage.Add(new Dish() { Name = "�����" });
                page.DishesCurrentPage.Add(new Dish() { Name = "������� ��-����������" });
                page.DishesCurrentPage.Add(new Dish() { Name = "���� ��������� � �������� � ��������� ������" });
                
            }
            if (dishesCountOnPage == 4 && id == 2)
            {
                expectedListDishes.Add(new Dish { Name = "��" });
                expectedListDishes.Add(new Dish { Name = "������" });

                page.DishesCurrentPage.Add(new Dish() { Name = "������" });
            }
            if(dishesCountOnPage == 5 && id == 1)
            {
                expectedListDishes.Add(new Dish { Name = "��" });

                page.DishesCurrentPage.Add(new Dish() { Name = "��" });
                page.DishesCurrentPage.Add(new Dish() { Name = "�����" });
                page.DishesCurrentPage.Add(new Dish() { Name = "������� ��-����������" });
                page.DishesCurrentPage.Add(new Dish() { Name = "���� ��������� � �������� � ��������� ������" });
                page.DishesCurrentPage.Add(new Dish() { Name = "������" });
            }
            #endregion

            MenuMaster menu = new MenuMaster(dishes, dishesCountOnPage);

            var expectedFirstDishesAllPage = new List<string>();
            foreach (var dish in expectedListDishes)
            {
                expectedFirstDishesAllPage.Add(dish.Name);
            }

            var expectedDishesCurrentPage = new List<string>();
            foreach (var dish in page.DishesCurrentPage)
            {
                expectedDishesCurrentPage.Add(dish.Name);
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

            Assert.AreEqual(5, menu.GetDishesCount());
            Assert.AreEqual(expectedPagesCount, menu.GetPagesCount());
            Assert.AreEqual(expectedDishesCountCurrentPage, menu.GetDishesCountCurrentPage(id));
            Assert.AreEqual(expectedDishesCurrentPage, dishesCurrentPage);
            Assert.AreEqual(expectedFirstDishesAllPage, firstDishesAllPages);
        }

        [TestCase(0, 3)]
        [TestCase(-1, 3)]
        [TestCase(11, 3)]
        [TestCase(3, 0)]
        [TestCase(3, 4)]
        [TestCase(3, -1)]
        public void IsInvalidDishesCountOnPage_IsInvalidPageId(int dishesCountOnPage, int id)
        {
            List<Dish> dishes = new List<Dish>()
            {
                new Dish() { Name = "�����" },
                new Dish() { Name = "�����" },
                new Dish() { Name = "�����" },
                new Dish() { Name = "����" },
                new Dish() { Name = "������" },
                new Dish() { Name = "�������� ����" },
                new Dish() { Name = "���������"}
            };
            Assert.Throws<Exception>(() =>
            {
                MenuMaster menu = new MenuMaster(dishes, dishesCountOnPage);
                menu.GetDishesCountCurrentPage(id);
                menu.GetDishesCurrentPage(id);
            });


            //var countPages = menu.GetCountPages();

            ////var menuMasterArgumentException = Assert.Throws<ArgumentException>(() => new MenuMaster(dishes, countDishesOnPage));
            //var menuMasterException = Assert.Throws<ArgumentOutOfRangeException>(() => new MenuMaster(dishes, countDishesOnPage));
            //var dishesOnPageException = Assert.Throws<Exception>(()=> menu.GetDishesCountCurrentPage(id));
            //var dishesCurrentPageException = Assert.Throws<Exception>(() => menu.GetDishesCurrentPage(id));

            ////Assert.Equals("������ ���� �� ������ ���� ������.", menuMasterArgumentException.Message);
            //Assert.Equals("�������� ���� �� ����� �������� ������ ���� �� 1 �� 10.", menuMasterException.Message);
            //Assert.Equals($"�������� ��� ������� {id} �� ����������. ����� {countPages} �������.", dishesOnPageException.Message);
            //Assert.Equals($"�������� ��� ������� {id} �� ����������. ����� {countPages} �������.", dishesCurrentPageException.Message);
        }

        [Test]
        public void IsNullDishesCollection()
        {
            int dishesCountOnPage = 2;
            List<Dish> dishes = new List<Dish>();

            Assert.Throws<ArgumentNullException>(() =>
            {
                MenuMaster menu = new MenuMaster(dishes, dishesCountOnPage);
            });
        }

        [TestCase("1234")]
        [TestCase("qwerty")]
        [TestCase("�_��")]
        [TestCase("���te")]
        [TestCase("������1��")]
        [TestCase("��������������������������������������������������������������������������������������������")]
        [TestCase("")]
        [TestCase("�")]
        public void IsInvalidDishesName(string dish)
        {
            int dishesCountOnPage = 2;
            List<Dish> dishes = new List<Dish>()
            {
                new Dish() { Name = "��������"},
                new Dish() { Name = dish },
                new Dish() { Name = "������ ���������"}
            };

            Assert.Throws<ArgumentException>(() =>
            {
                MenuMaster menu = new MenuMaster(dishes, dishesCountOnPage);
            });
        }

        [TestCase(null)]
        public void IsNullDishesName(string dish)
        {
            int dishesCountOnPage = 2;
            List<Dish> dishes = new List<Dish>()
            {
                new Dish() { Name = "��������"},
                new Dish() { Name = dish },
                new Dish() { Name = "������ ���������"}
            };

            Assert.Throws<ArgumentNullException>(() =>
            {
                MenuMaster menu = new MenuMaster(dishes, dishesCountOnPage);
            });
        }
    }
}