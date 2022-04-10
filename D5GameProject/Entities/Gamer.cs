using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Entities
{
    internal class Gamer : IEntity
    {
        public Gamer()
        {
        }

        public Gamer(string firstName, string lastName, DateTime birthYear, string nationalityId)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthYear = birthYear;
            NationalityId = nationalityId;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthYear { get; set; }
        public string NationalityId { get; set; }

    }
}
