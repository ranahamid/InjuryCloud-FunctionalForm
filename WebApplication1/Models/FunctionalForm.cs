using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class testIdCls
    {
        [Display(Name = "Test Id: ")]
        public string TestId { get; set; }
    }

    public class Medical
    {
        [Display(Name ="Test Id: ")]
        public string TestId { get; set; }

       // pain des
        public ICollection<System.Web.Mvc.SelectListItem> BestDescribesPain { get; set; }
        public string BestDescribesPainStr { get; set; }
       
        public ICollection<System.Web.Mvc.SelectListItem> BestDescribesFrequencyPain { get; set; }
        public string BestDescribesFrequencyPainStr { get; set; }
       
        public ICollection<System.Web.Mvc.SelectListItem> PainFeelWorse { get; set; }
        public string PainFeelWorseStr { get; set; }

        //
        public ICollection<System.Web.Mvc.SelectListItem> BestDescribesPainrightNow { get; set; }
        public string BestDescribesPainrightNowStr { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> WorstPainOverPast { get; set; }
        public string WorstPainOverPastStr { get; set; }


        public ICollection<System.Web.Mvc.SelectListItem> LeastPainOverPast { get; set; }
        public string LeastPainOverPastStr { get; set; }
        //






        [Display(Name = "What makes your pain feel better?")]
        public string makesPainFeelBetter { get; set; }





        //General Medical History
        public ICollection<System.Web.Mvc.SelectListItem> HistoryOfCancer { get; set; }
        public string HistoryOfCancerStr { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> Pacemaker { get; set; }
        public string PacemakerStr { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> Hypertension { get; set; }
        public string HypertensionStr { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> Bowel_bladder { get; set; }
        public string Bowel_bladderStr { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> Diabetic { get; set; }
        public string DiabeticStr { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> Pregnant { get; set; }
        public string PregnantStr { get; set; }

        [Display(Name = "Please list any other relevant past medical or orthopedic history")]
        public string PastMedicalHistory { get; set; }

        //BIOGRAPHIC INFORMATION
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "PIN (Enter Four Digits)")]
        public int Pin { get; set; }
        
        [Display(Name = "Date of Birth)")]
        public DateTime DateOfBirth { get; set; }

  

        [Display(Name = "feet")]
        [Range(2, 8, ErrorMessage = "Enter valid height in feet")]
        public int feet { get; set; }

        [Display(Name = "inches")]
        [Range(0, 11, ErrorMessage = "Enter valid height in inch")]
        public int inches { get; set; }

        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Weight")]
        [Range(2, 300, ErrorMessage = "Enter valid weight")]
        public int Weight { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> Sex { get; set; }
        public string SexStr { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> DominantHand { get; set; }
        public string DominantHandStr { get; set; }
                
        public DateTime Today { get; set; }

        //




    }





}