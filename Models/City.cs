using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FTRRequestPortal.Models
{
    [Table("City")]
    public class City
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int? City_Id { get; set; }

        [Required(ErrorMessage = "Host City is required")]
        public string City_Name { get; set; }

        [ForeignKey("Country")]
        public string Country_Id { get; set; }
        public Country Country { get; set; }
    }
}