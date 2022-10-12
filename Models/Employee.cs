using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FTRRequestPortal.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public string Emp_Id { get; set; }

        [Required(ErrorMessage = "Employee Name is required")]
        public string Emp_Name { get; set; }

        [Required(ErrorMessage = "Manager is required")]
        public string MGR { get; set; }

        [Required(ErrorMessage = " Home City is required")]
        public string City { get; set; }

        [Required(ErrorMessage = "Home Country is required")]
        public string Country { get; set; }

        [ForeignKey("GCM")]
        [Required (ErrorMessage = " GCM LEVEL is required")]
        public int GCM_Id { get; set; }

        [Required(ErrorMessage = "DasId is required")]
        public string DAS_Id { get; set; }  







    }
}