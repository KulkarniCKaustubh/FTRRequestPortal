using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FTRRequestPortal.Models
{
    [Table("GCM")]
    public class GCM
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int? GCM_ID { get; set; }

        [Required(ErrorMessage = "GCM Level is required")]
        public string GCM_Level { get; set; }
    }
}