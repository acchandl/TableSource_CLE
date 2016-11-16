using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TableSource_CLE.Models
{
    public class Donation
    {
        [Key]
        public int donationID { get; set; }

        [Required]
        public string type { get; set; }

        [DataType(DataType.Date)]
        public DateTime pickUpDate { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public string pickupTime { get; set; }

        [Required]
        public double weight { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime ExpirationDate { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        public string organizationName { get; set; }

        [Required]
        [StringLength(100)]
        public string organizationAddress { get; set; }

        [Required]
        [StringLength(100)]
        public string organizationCity { get; set; }

        [Required]
        [StringLength(2, ErrorMessage = "The {0} must be {2} characters long.", MinimumLength = 2)]
        public string organizationState { get; set; }

        [Required]
        [StringLength(5, ErrorMessage = "The {0} must be {2} digits long.", MinimumLength = 5)]
        public string organizationZip { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "The {0} must be {2} digits long with no dashes.", MinimumLength = 10)]
        public string organizationPhone { get; set; }

        [Required]
        [EmailAddress]
        public string organizationEmail { get; set; }

        public int categoryID { get; set; }

        public virtual Category Category { get; set; }
    }
}