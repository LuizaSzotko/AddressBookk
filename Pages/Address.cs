using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace AddressBookk.Models
{
    public class Address
    {
        [Display(Name = "Twoja ulubiona ulica")]
        [StringLength(60, MinimumLength = 3), RegularExpression(@"[A-Z][a-z]*", ErrorMessage = "Niepoprawna nazwa ulicy"), Required(ErrorMessage = "Pole jest obowiązkowe")]
        public string Street { get; set; }
        [RegularExpression(@"[0-9]{2}-[0-9]{3}", ErrorMessage = "Zły format kodu"), Required(ErrorMessage = "Pole jest obowiązkowe")]
        public string ZipCode { get; set; }
        [StringLength(60, MinimumLength = 3), RegularExpression(@"[A-Z][a-z]*", ErrorMessage = "Niepoprawna nazwa miasta"), Required(ErrorMessage = "Pole jest obowiązkowe")]
        public string City { get; set; }
        [Required(ErrorMessage = "Pole jest obowiązkowe")]
        public int Number { get; set; }
    }
}
