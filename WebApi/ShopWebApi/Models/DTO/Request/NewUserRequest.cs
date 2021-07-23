using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopWebApi.DTO
{
    public class NewUserRequest
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Password { get; set; }       
        public string Phone { get; set; }
        [Required]
        public string EMail { get; set; }

        public NewAddressRequest adress { get; set; }


    }
}
