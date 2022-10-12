using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FTRRequestPortal.Models
{
    [Table("Travel")]
    public class Travel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int? Travel_Id { get; set; }

        [Required(ErrorMessage = "Travel Type is required")]
        public string Travel_Type { get; set; }
    }
}