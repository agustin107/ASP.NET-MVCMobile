using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Mobile.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int IdStudies { get; set; }
        public Studies Studies { get; set; }
        public string Email { get; set; }
        public int IdTelephone { get; set; }
        public Telephone Telephones { get; set; }
    }
}