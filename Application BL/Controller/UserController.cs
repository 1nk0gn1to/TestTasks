using Application_BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Application_BL.Controller
{
    /// <summary>
    /// контроллер пользователя
    /// </summary>
    internal class UserController
    {
        /// <summary>
        /// пользователь
        /// </summary>
        public User User { get; }

        /// <summary>
        /// созадание нового контроллера пользователя.
        /// </summary>
        /// <param name="user"></param>
        /// <exception cref="ArgumentException"></exception>
        public UserController(string userName, string genderName, DateTime birthDay, double weigth, double heigth)
        {
            //TODO:проверка.

            var gender = new Gender(genderName);
            var user = new User(userName, gender, birthDay, weigth, heigth);
        }
        public UserController()
        {
            var formatter = new BinaryFormatter();
            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                if (formatter.Deserialize(fs) is User user) ;
                {
                    User = user;
                }
                //TODO: Что делатьб если пользователя не прочитали?
            }

        }

        /// <summary>
        /// сохранение жанных пользователя.
        /// </summary>
        public void Save()
        {
            var formatter = new BinaryFormatter();
            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, User);
            }
        }
        /// <summary>
        /// полуение данных пользователя.
        /// </summary>
        /// <returns>пользователь</returns>
        
    }
}
