using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class SpinalEvaluation     
    {
        public string SLR1 { get; set; }
        public string SLR2 { get; set; }
        public string SLR3 { get; set; }
        public string SLR4 { get; set; }
        public string SLR5 { get; set; }
        public string SLR6 { get; set; }
        public string SLR7 { get; set; }
        public string OSWESTRYSCORESpinal { get; set; }
        public string WADDELLSSIGNSSpinal { get; set; }
        public string OTHERFINDINGSSpinal { get; set; }
        public string Painwithpalpation { get; set; }
        public string toneSpinal { get; set; }
        public string sittingSpinal { get; set; }
        public string descriptionNo5Spinal { get; set; }
        public string TherapeuticexerciseDescriptionSpinal1 { get; set; }
        public string TherapeuticexerciseDescriptionSpinal2 { get; set; }


        [Display(Name = "/10 @ present")]
        public string PainPresent { get; set; }
        [Display(Name = "/10 @ best")]
        public string PainBest { get; set; }
        [Display(Name = "/10 @ worst")]
        public string PainWorst { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Segmentalmobility { get; set; }
        public string SegmentalmobilityStr { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> RADICULARSYMPTOMS { get; set; }
        public string RADICULARSYMPTOMSStr { get; set; }

        public string RADICULARSYMPTOMSOthers { get; set; }
        [Display(Name = "Site")]
        public string RADICULARSYMPTOMSSite { get; set; }


        public ICollection<System.Web.Mvc.SelectListItem> DERMATOMES { get; set; }
        public string DERMATOMESStr { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> REFLEXES { get; set; }
        public string REFLEXESStr { get; set; }

        public string Occupation { get; set; }
        [Display(Name = "HR=")]
        public string HR { get; set; }
        [Display(Name = "BP=")]
        public string BP { get; set; }

        //radio
        public ICollection<System.Web.Mvc.SelectListItem> Leglengthdiscrepancy { get; set; }
        public string LeglengthdiscrepancyStr { get; set; }


        

        //table 1
        public string table1_11 { get; set; }
        public string table1_12 { get; set; }
        public string table1_13 { get; set; }
        public string table1_14 { get; set; }
        public string table1_21 { get; set; }
        public string table1_22 { get; set; }
        public string table1_23 { get; set; }
        public string table1_24 { get; set; }
        public string table1_31 { get; set; }
        public string table1_32 { get; set; }
        public string table1_33 { get; set; }
        public string table1_34 { get; set; }
        public string table1_41 { get; set; }
        public string table1_42 { get; set; }
        public string table1_43 { get; set; }
        public string table1_44 { get; set; }
        public string table1_51 { get; set; }
        public string table1_52 { get; set; }
        public string table1_53 { get; set; }
        public string table1_54 { get; set; }
        public string table1_61 { get; set; }
        public string table1_62 { get; set; }
        public string table1_63 { get; set; }
        public string table1_64 { get; set; }

        //string

        public string ENDURANCE1textbox { get; set; }
        public string ENDURANCE2textbox { get; set; }
        public string numberofstairs { get; set; }
        public string SOCIALENVIRONMENT_Last { get; set; }
        public string EQUIPMENT { get; set; }
        public string table2_1 { get; set; }
        public string table2_2 { get; set; }
        public string table2_3 { get; set; }
        public string table2_4 { get; set; }
        public string table2_5 { get; set; }
        public string table2_6 { get; set; }
        public string table2_7 { get; set; }
        public string table2_8 { get; set; }
        public string table2_9 { get; set; }
        public string table2_10 { get; set; }
        public string table2_11 { get; set; }
        public string table2_12 { get; set; }
        public string table2_13 { get; set; }
        public string table2_14 { get; set; }
        public string table2_15 { get; set; }
        public string table2_16 { get; set; }
        public string table2_17 { get; set; }
        public string table2_18 { get; set; }
        public string table2_19 { get; set; }
        public string table2_20 { get; set; }
        public string table2_21 { get; set; }
        public string table2_22 { get; set; }
        public string table2_23 { get; set; }
        public string table2_24 { get; set; }

        public string BERGBALANCET { get; set; }
        public string sitstand { get; set; }
        public string supine { get; set; }
        public string chair { get; set; }
        public string cartransfers { get; set; }
        public string TRANSFERS1 { get; set; }
        public string TRANSFERS2 { get; set; }
        public string TRANSFERS3 { get; set; }

        public string standing { get; set; }
        public string Hxoffalls { get; set; }
        public string assistivedevice { get; set; }
        public string braceorsupport { get; set; }
        public string WBstatus { get; set; }
        public string distanceGait { get; set; }
        public string abnormalitiesnoted { get; set; }
        public string TypeofSeat { get; set; }
        public string Assist { get; set; }
        public string Surface { get; set; }
        public string Propels { get; set; }
        public string descriptionNo1 { get; set; }
        public string descriptionNo2 { get; set; }
        public string descriptionNo3 { get; set; }
        public string descriptionNo4 { get; set; }
        //end string
        public ICollection<System.Web.Mvc.SelectListItem> CervicalLordosis { get; set; }
        public string CervicalLordosisStr { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> LumbarLordosis { get; set; }
        public string LumbarLordosisStr { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Kyphosis { get; set; }
        public string KyphosisStr { get; set; }

        public string Scapulothoracic { get; set; }
        public string Asymmetry { get; set; }


        //TemporomandibularEvaluation

        public ICollection<System.Web.Mvc.SelectListItem> Headache { get; set; }
        public string HeadacheStr { get; set; }

        [Display(Name = "Location:")]
        public string Location { get; set; }


        //radio
        public ICollection<System.Web.Mvc.SelectListItem> Vocational { get; set; }
        public string VocationalStr { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Lifestyle { get; set; }
        public string LifestyleStr { get; set; }


        public ICollection<System.Web.Mvc.SelectListItem> Impairments { get; set; }
        public string ImpairmentsStr { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> ENDURANCE1 { get; set; }
        public string ENDURANCE1Str { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> ENDURANCE2 { get; set; }
        public string ENDURANCE2Str { get; set; }



        public ICollection<System.Web.Mvc.SelectListItem> Controlawareness { get; set; }
        public string ControlawarenessStr { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> zero12 { get; set; }
        public string zero12Str { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> FallRisk { get; set; }
        public string FallRiskStr { get; set; }

        //check box
        public ICollection<System.Web.Mvc.SelectListItem> Pressurerelief { get; set; }
        public List<string> PressurereliefStr { get; set; }


        public ICollection<System.Web.Mvc.SelectListItem> Therapeuticexercise { get; set; }
        public List<string> TherapeuticexerciseStr { get; set; }


        public ICollection<System.Web.Mvc.SelectListItem> Legrests { get; set; }
        public List<string> LegrestsStr { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Properfit { get; set; }
        public List<string> ProperfitStr { get; set; }

        //check
        public ICollection<System.Web.Mvc.SelectListItem> Typedevice { get; set; }
        public List<string> TypedeviceStr { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> GAIT { get; set; }
        public List<string> GAITStr { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> TRANSFERS { get; set; }
        public List<string> TRANSFERSStr { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> SOCIALENVIRONMENT { get; set; }
        public List<string> SOCIALENVIRONMENTStr { get; set; }


        //[Display(Name = "CERVICAL CLEARING")]
        //public string CERVICALCLEARING { get; set; }

        //[Display(Name = "OTHER FINDINGS")]
        //public string OTHERFINDINGS { get; set; }



        //add
        [Display(Name = "Claim#")]
        public string Claim { get; set; }
        [Display(Name = "Date of Surgery")]
        public string DateOfSurgery { get; set; }


        public string AssessmentDesc { get; set; }

        //public string descriptionNo5 { get; set; }

        //checkbox    
        public string TherapeuticexerciseDescription { get; set; }


        //end of adding


        [Display(Name = "Test Id: ")]
        public string TestId { get; set; }

        [Display(Name = "Patient Name")]
        public string PatientName { get; set; }

        [Display(Name = "Dx/ ICD-10")]
        public string Dx_ICD_10 { get; set; }
        public string Date { get; set; }
        public string DOB { get; set; }


        public string Therapist { get; set; }
        public string Physician { get; set; }
        [Display(Name = "Next MD apt")]
        public string NextMDApt { get; set; }
        [Display(Name = "Date of Onset")]
        public string DateOnset { get; set; }
        [Display(Name = "MOI(ortho, degenerative, insidious, trama, MVA, overuse)")]

        public string MOI { get; set; }
        [Display(Name = "Previous Treatment for this condition")]
        public string PreviousTreatment { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> DidItHelp { get; set; }
        public string DidItHelpStr { get; set; }
        [Display(Name = "History")]
        public string History_ChiefComplaint { get; set; }
        [Display(Name = "Diagnostic findings")]
        public string DiagnosticFindings { get; set; }
        [Display(Name = "Med(formulate list as type med)")]
        public string Meds { get; set; }
        [Display(Name = "Past Medical History")]
        public string PastMedicalHistory { get; set; }


        //public string Occupation { get; set; }


        [Display(Name = "Physical Demands")]
        public string PhysicalDemands { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> WorkStatus { get; set; }
        public string WorkStatusStr { get; set; }
        public string Reason { get; set; }



        //public int Weight { get; set; }
        //public string BMI { get; set; }
        [Display(Name = "When Worse")]
        public string WhenWorse { get; set; }
        [Display(Name = "When Better")]
        public string WhenBetter { get; set; }
   
        public ICollection<System.Web.Mvc.SelectListItem> Quality { get; set; }
        public string QualityStr { get; set; }


        public ICollection<System.Web.Mvc.SelectListItem> RehabPotential { get; set; }
        public string RehabPotentialStr { get; set; }

        public string Goalstomet { get; set; }

        public string sitting { get; set; }

        public string PhysicalTherapyTime { get; set; }
        public string xperweek { get; set; }

    }
}