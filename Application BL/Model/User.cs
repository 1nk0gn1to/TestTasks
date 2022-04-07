using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_BL.Model
{
    /// <summary>
    /// пользователь
    /// </summary>
    [Serializable]
    internal class User
    {
        #region Свойства
        /// <summary>
        /// имя
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// пол
        /// </summary>
        public Gender Gender { get; }
        /// <summary>
        /// дата рождения
        /// </summary>
        public DateTime BirthDate { get; }
        /// <summary>
        /// вес
        /// </summary>
        public double Weight { get; set; }
        /// <summary>
        /// рост
        /// </summary>
        public double Height { get; set; }
        #endregion
        /// <summary>
        /// новый пользователь
        /// </summary>
        /// <param name="name">имя</param>
        /// <param name="gender">пол</param>
        /// <param name="birthDate">дата рождения</param>
        /// <param name="weigth">вес</param>
        /// <param name="heigth">рост</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public User(string name, Gender gender, DateTime birthDate, double weight, double height)
        {
            #region Проверка условий
            if (string.IsNullOrWhiteSpace(name)) ;
            {
                throw new ArgumentNullException("имя пользователя не может быть пустым или null.", nameof(name));
            }

            if(gender == null)
            {
                throw new ArgumentNullException("пол не может быть null.", nameof(gender));
            }

            if(birthDate < DateTime.Parse("01.01.1900") || birthDate >= DateTime.Now)
            {
                throw new ArgumentException("невозможная дата рождения.", nameof(birthDate));
            }

            if(weigth <= 0)
            {
                throw new ArgumentException("вес не может быть меньше или равен нулю.", nameof(weigth));
            }

            if(heigth <= 0)
            {
                throw new ArgumentException("рост не может быть меньше или равен нулю.", nameof(heigth));
            }
            #endregion

            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Weight = weight;
            Height = height;
        }
            public override string ToString()
            {
            return Name;
            }
    }
}
