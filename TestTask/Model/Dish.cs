using System.Text.RegularExpressions;

namespace TestTask.Model
{
    public class Dish
    {
        string _name;
        public string Name 
        {
            get
            {
                return _name;
            }
            set 
            { 
                if(String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(Name);
                }
                else if(value.Length > 20)
                {
                    throw new ArgumentOutOfRangeException(Name);
                }
                _name = value; 
            }
        }
        //Можно добавить еще что-нибудь (цена, размер порций)
    }
}
