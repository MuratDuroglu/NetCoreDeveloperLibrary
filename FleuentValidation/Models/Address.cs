using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FleuentValidation.Models
{
    public class Address
    {

        public int Id { get; set; }


        public string Content { get; set; }


        public string Province { get; set; }


        public string PostCode { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }




    }
}
