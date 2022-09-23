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
                _name = value; 
            }
        }
        //Можно добавить еще что-нибудь (описание, цена, размер порций, фото)
    }
}
