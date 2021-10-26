using Hotel.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Models
{
    public class HotelDTO : CreateHotelDTO
    {
        public int Id { get; set; }

        public CountryDTO Country { get; set; }
    }
    public class CreateHotelDTO
    {
        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 5)]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 5)]
        public string Address { get; set; }

        [Required]
        [Range(1, 5)]
        public double Rate { get; set; }

        [Required]
        public int CountryId { get; set; }
    }
}
