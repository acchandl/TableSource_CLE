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
        public string organizationName { get; set; }
        [Required]
        public string organizationAddress { get; set; }
        [Required]
        public string organizationCity { get; set; }
        [Required]
        public string organizationState { get; set; }
        [Required]
        public int organizationZip { get; set; }
        [Required]
        public string organizationPhone { get; set; }
        [Required]
        public string organizationEmail { get; set; }
        public int categoryID { get; set; }

        public virtual Category Category { get; set; }
    }
}