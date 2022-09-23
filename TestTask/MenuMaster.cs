using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Model;

namespace TestTask
{
    public class MenuMaster
    {
        List<Dish> _dishes;
        int _countElementsOnPage;
        Page _page;

        List<Page> pages = new List<Page>();

        public MenuMaster(List<Dish> dishes, int countElementsOnPage)
        {
            if (dishes.Count == 0)
            {
                throw new ArgumentNullException("Список блюд не должен быть пустым.");
            }
            else if (countElementsOnPage > 10 || countElementsOnPage <= 0)
            {
                throw new Exception("Количество блюд на одной странице должно быть в диапозоне от 1 до 10.");
            }

            _dishes = dishes;
            _countElementsOnPage = countElementsOnPage;

            CreatePages();
        }

        private void CreatePages()
        {
            var result = 0.0;

            if (_dishes.Count % _countElementsOnPage == 1)
            {
                result = (_dishes.Count / _countElementsOnPage) + 1;
            }
            else
            {
                result = _dishes.Count / _countElementsOnPage;
            }

            for (int i = 1; i <= result; ++i)
            {
                pages.Add(new Page() { Id = i });
            }

            int index = 0;

            foreach (var dish in _dishes)
            {
                pages[index].DishesCurrentPage.Add(dish);

                if (pages[index].DishesCurrentPage.Count == _countElementsOnPage)
                {
                    index += 1;
                }
            }
        }

        public int GetCountDishes()
        {
            return _dishes.Count;
        }

        public int GetCountPages()
        {
            return pages.Count;
        }

        public int GetDishesCountCurrentPage(int id)
        {
            if(id <= pages.Count && id > 0)
            {
                _page = pages.Single(_page => _page.Id == id);
            }
            else
            {
                throw new Exception($"Страницы под номером {id} не существует. Всего {pages.Count} страниц.");
            }

            return _page.DishesCurrentPage.Count;
        }

        public IEnumerable<Dish> GetDishesCurrentPage(int id)
        {
            if (id <= pages.Count && id > 0)
            {
                _page = pages.Single(_page => _page.Id == id);

                foreach (var dish in (_page.DishesCurrentPage))
                {
                    yield return dish;
                }
            }
            else
            {
                throw new Exception($"Страницы под номером {id} не существует. Всего {pages.Count} страниц.");
            }
        }

        public IEnumerable<Dish> GetFirstDishesAllPages()
        {
            for(int i = 0; i < pages.Count; i++)
            {
                yield return pages[i].DishesCurrentPage.First();
            }
        }
    }
}
