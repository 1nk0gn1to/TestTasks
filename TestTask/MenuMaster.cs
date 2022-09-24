using System.Text.RegularExpressions;
using TestTask.Model;

namespace TestTask
{
    public class MenuMaster
    {
        List<Dish> _dishes;
        int _dishesCountOnPage;
        Page _page;

        List<Page> pages = new List<Page>();

        public MenuMaster(List<Dish> dishes, int dishesCountsOnPage)
        {
            if (dishes.Count == 0)
            {
                throw new ArgumentNullException(null, "Список блюд не должен быть пустым.");
            }

            for(int i = 0; i < dishes.Count; i++)
            {  
                if(dishes[i].Name == null)
                {
                    throw new ArgumentNullException(null, "Имя не должно быть пустым");
                }
                else if(Regex.IsMatch(dishes[i].Name, @"[^А-Яа-я\s\W]") || dishes[i].Name.Length > 50 || dishes[i].Name.Length < 2)
                {
                    throw new ArgumentException("Названия блюд должны содержать только русские буквы и символы кроме нижнего подчеркивания.\n" +
                                                "Длина должна быть в диапозоне от 2 до 50 символов.");
                }

            }

            if (dishesCountsOnPage > 10 || dishesCountsOnPage <= 0)
            {
                throw new Exception("Количество блюд на одной странице должно быть в диапозоне от 1 до 10.");
            }

            _dishes = dishes;
            _dishesCountOnPage = dishesCountsOnPage;

            CreatePages();
        }

        private void CreatePages()
        {
            var result = 0.0;
            if ((_dishes.Count % _dishesCountOnPage) > 0)
            {
                result = (_dishes.Count / _dishesCountOnPage) + 1;
            }
            else
            {
                result = _dishes.Count / _dishesCountOnPage;
            }

            for (int i = 1; i <= result; i++)
            {
                pages.Add(new Page() { Id = i });
            }

            int index = 0;

            foreach (var dish in _dishes)
            {
                pages[index].DishesCurrentPage.Add(dish);

                if (pages[index].DishesCurrentPage.Count == _dishesCountOnPage)
                {
                    index += 1;
                }
            }
        }

        public int GetDishesCount()
        {
            return _dishes.Count;
        }

        public int GetPagesCount()
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
                throw new Exception($"Страницы под номером {id} не существует. Страницы нумеруются от цифры 1, и их общее количество: {pages.Count}.");
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
                throw new Exception($"Страницы под номером {id} не существует. Страницы нумеруются от цифры 1, и их общее количество: {pages.Count}.");
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
