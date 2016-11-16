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
        [Display (Name = "Type of Organization/Company")]
        public string type { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Pick-Up Date")]
        public DateTime pickUpDate { get; set; }

        [Required]
        [DataType(DataType.Time)]
        [Display(Name = "Pick-Up Time")]
        public string pickupTime { get; set; }

        [Required]
        [Display(Name = "Donation Weight")]
        public double weight { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Donation Expiration Date")]
        public DateTime ExpirationDate { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        [Display(Name = "Organization/Company Name")]
        public string organizationName { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Pick-Up Address")]
        public string organizationAddress { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "City")]
        public string organizationCity { get; set; }

        [Required]
        [StringLength(2, ErrorMessage = "The {0} must be {2} characters long.", MinimumLength = 2)]
        [Display(Name = "State")]
        public string organizationState { get; set; }

        [Required]
        [StringLength(5, ErrorMessage = "The {0} must be {2} digits long.", MinimumLength = 5)]
        [Display(Name = "Zip Code")]
        public string organizationZip { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "The {0} must be {2} digits long with no dashes.", MinimumLength = 10)]
        [Display(Name = "Contact Telephone Number")]
        public string organizationPhone { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Contact Email")]
        public string organizationEmail { get; set; }

        public int categoryID { get; set; }

        public virtual Category Category { get; set; }
    }
}