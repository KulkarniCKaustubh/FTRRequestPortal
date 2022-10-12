using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FTRRequestPortal.Models
{
    public class Travel_Details
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public  int Request_No { get; set; }

        [ForeignKey("Employee")]
        public string Emp_Id { get; set; }

        [ForeignKey("GCM")]
        [Required(ErrorMessage = "GCM Level is required")]
        public int GCM_Id { get; set; }

        [ForeignKey("TRAVEL")]
        [Required(ErrorMessage = "Travel Type  is required")]
        public int Travel_Id { get; set; }

        [ForeignKey("Country")]
        [Required(ErrorMessage = "Host Country is required")]
        public string country_Id { get; set; }

        [ForeignKey("City")]
        [Required(ErrorMessage = "Host City required")]
        public  int City_Id { get; set; }

        [Required(ErrorMessage = "Satart Date is required")]
        public DateTime Start_Date { get; set; }

        [Required(ErrorMessage = "Expected Date is required")]
        public DateTime Expected_EndDate { get; set; }


        [ForeignKey("Employee")]
         [Required(ErrorMessage = "Manager is required")]
        public string MGR { get; set; }

        public string status  { get; set; }




    }
}