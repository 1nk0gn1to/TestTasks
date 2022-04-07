using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_BL.Model
{
    /// <summary>
    /// пол
    /// </summary>
    [Serializable]
    internal class Gender
    {
        /// <summary>
        /// название
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// задать пол
        /// </summary>
        /// <param name="name"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public Gender (string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пола не может быть пустым или null", nameof(name));
            }

            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
