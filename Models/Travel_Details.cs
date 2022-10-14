using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FTRRequestPortal.Models
{
    [Table("Travel_Details")]
    public class Travel_Details
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Request_No { get; set; }

        [ForeignKey("Employee")]
        public string Emp_Id { get; set; }
        public string MGR { get; set; }
        public Employee Employee { get; set; }

        [ForeignKey("GCM")]
        public int GCM_Id { get; set; }
        public GCM GCM { get; set; }

        [ForeignKey("Travel")]
        public int Travel_Id { get; set; }
        public Travel Travel { get; set; }

        [ForeignKey("Country")]
        public string country_Id { get; set; }
        public Country Country { get; set; }

        [ForeignKey("City")]
        public int City_Id { get; set; }
        public City City { get; set; }

        [Required(ErrorMessage = "Satart Date is required")]
        public DateTime Start_Date { get; set; }

        [Required(ErrorMessage = "Expected Date is required")]
        public DateTime Expected_EndDate { get; set; }

        public string status { get; set; }
    }
}