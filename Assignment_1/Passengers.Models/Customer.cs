using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passengers.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string f_name { get; set; }

        public string l_name { get; set; }

        public string phone_no { get; set; }
    }
}
