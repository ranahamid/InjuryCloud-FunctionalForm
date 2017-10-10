using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Medical
    {
        [Display(Name = "Test Id: ")]
        public string TestId { get; set; }

        // pain des
        public ICollection<System.Web.Mvc.SelectListItem> BestDescribesPain { get; set; }
        public string BestDescribesPainStr { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> BestDescribesFrequencyPain { get; set; }
        public string BestDescribesFrequencyPainStr { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> PainFeelWorse { get; set; }
        public List<string> PainFeelWorseStr { get; set; }

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
      //  [Range(2, 8, ErrorMessage = "Enter valid height in feet")]
        public int feet { get; set; }

        [Display(Name = "inches")]
       // [Range(0, 11, ErrorMessage = "Enter valid height in inch")]
        public int inches { get; set; }

        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Weight")]
       // [Range(2, 300, ErrorMessage = "Enter valid weight")]
        public int Weight { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> Sex { get; set; }
        public string SexStr { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> DominantHand { get; set; }
        public string DominantHandStr { get; set; }

        public DateTime Today { get; set; }

        ////PERSONAL HEALTH HISTORY

        public ICollection<System.Web.Mvc.SelectListItem> DoYouSmoke { get; set; }
        public string DoYouSmokeStr { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> LastPhysicalExam { get; set; }
        public string LastPhysicalExamStr { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> ReachedMenopause { get; set; }
        public string ReachedMenopauseStr { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> PSATestWithinTheLastYear { get; set; }
        public string PSATestWithinTheLastYearStr { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> ThyroidDysfunction { get; set; }
        public string ThyroidDysfunctionStr { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> RheumatoidArthritis { get; set; }
        public string RheumatoidArthritisStr { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> Osteoarthritis { get; set; }
        public string OsteoarthritisStr { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> Osteoporosis { get; set; }
        public string OsteoporosisStr { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> Cancer { get; set; }
        public string CancerStr { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> Stroke { get; set; }
        public string StrokeStr { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> HighCholesterol { get; set; }
        public string HighCholesterolStr { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> HighBloodPressure { get; set; }
        public string HighBloodPressureStr { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> DiabetesPersonalHistory { get; set; }
        public string DiabetesPersonalHistoryStr { get; set; }

        //MEDICATIONS
        public ICollection<System.Web.Mvc.SelectListItem> OTC { get; set; }
        public string OTCStr { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> PrescriptionNonSteroidal { get; set; }
        public string PrescriptionNonSteroidalStr { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> NarcoticPainMedications { get; set; }
        public string NarcoticPainMedicationsStr { get; set; }

        //SURGERY
        public ICollection<System.Web.Mvc.SelectListItem> Head { get; set; }
        public string HeadStr { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> CardiovascularPulmonary { get; set; }
        public string CardiovascularPulmonaryStr { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> Abdominal { get; set; }
        public string AbdominalStr { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> GenitoUrinary { get; set; }
        public string GenitoUrinaryStr { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> Spine { get; set; }
        public string SpineStr { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> PastSurgeryHadPerformDailyActivities { get; set; }
        public string PastSurgeryHadPerformDailyActivitiesStr { get; set; }





        //FAMILY HISTORY

        public ICollection<System.Web.Mvc.SelectListItem> DiabetesFamilyHistory { get; set; }
        public string DiabetesFamilyHistoryStr { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> ThyroidDysfunctionFamilyHistory { get; set; }
        public string ThyroidDysfunctionFamilyHistoryStr { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> RheumatoidArthritisLupusPsoriatic { get; set; }
        public string RheumatoidArthritisLupusPsoriaticStr { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> OsteoarthritisFamilyHistory { get; set; }
        public string OsteoarthritisFamilyHistoryStr { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> OsteoporosisFamilyHistory { get; set; }
        public string OsteoporosisFamilyHistoryStr { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> CancerFamilyHistory { get; set; }
        public string CancerFamilyHistoryStr { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> StrokeFamilyHistory { get; set; }
        public string StrokeFamilyHistoryStr { get; set; }

        //Oswestry Neck Pain Questionnaire


        public ICollection<System.Web.Mvc.SelectListItem> Section1 { get; set; }
        public string Section1Str { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> Section2 { get; set; }
        public string Section2Str { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> Section3 { get; set; }
        public string Section3Str { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> Section4 { get; set; }
        public string Section4Str { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> Section5 { get; set; }
        public string Section5Str { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> Section6 { get; set; }
        public string Section6Str { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> Section7 { get; set; }
        public string Section7Str { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> Section8 { get; set; }
        public string Section8Str { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> Section9 { get; set; }
        public string Section9Str { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> Section10 { get; set; }
        public string Section10Str { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> Section11 { get; set; }
        public string Section11Str { get; set; }

        [Display(Name = "Name")]
        public string OswestryName { get; set; }

        [Display(Name = "Date")]
        public DateTime OswestryDate { get; set; }

        [Display(Name = "OSW-SCORE")]
        public string OswestryOSWSCORE { get; set; }


        [Display(Name = "P-SCORE")]
        public string OswestryPSCORE { get; set; }

    }
    public class testIdCls
    {
        [Display(Name = "Test Id: ")]
        public string TestId { get; set; }
    }

}