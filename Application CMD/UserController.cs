using System;

namespace Application_CMD
{
    internal class UserController
    {
        private string name;
        private string gender;
        private DateTime birthdate;
        private double weight;
        private double height;

        public UserController(string name, string gender, DateTime birthdate, double weight, double height)
        {
            this.name = name;
            this.gender = gender;
            this.birthdate = birthdate;
            this.weight = weight;
            this.height = height;
        }
    }
}