using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FleuentValidation.Models
{
    public class Customer
    {

        public int Id { get; set; }

        [Required(ErrorMessage ="attiributreden geldi")]
        public string Name { get; set; }

        public string Email { get; set; }

        public int Age { get; set; }

        public DateTime?  BirthDay { get; set; }

        public IList<Address> Addresses { get; set; }



    }
}
