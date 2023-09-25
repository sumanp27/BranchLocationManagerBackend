using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppAPI.Models.Branch
{
    public class BranchDto
    {
        [Required]
        public string BuCode5 { get; set; }
        [Required]
        public DateOnly OpenedDt { get; set; }
      
       

        public string Status { get; set; }
        [Required]

        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        
        public string StateName { get; set; }
        [Required]
        public string CountryName { get; set; }
        [Required]
        public string Currency { get; set; }
        [Required]

        public string Phone { get; set; }
        [Required]
        public string BusinessHours { get; set; }
        [Required]
        public decimal Latitude { get; set; }
        [Required]
        public decimal Longitude { get; set; }
    }

}
