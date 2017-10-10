using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class TemporomandibularEvaluation
    {
        //TemporomandibularEvaluation

        public ICollection<System.Web.Mvc.SelectListItem> Headache { get; set; }
        public string HeadacheStr { get; set; }


        //text- temporomandibular evaluation
        [Display(Name = "Location:")]
        public string Location { get; set; }

        //string
        public string Depression { get; set; }
        public string Anterior { get; set; }
        public string Lateralright { get; set; }
        public string Lateralleft { get; set; }
        public string CERVICALSHOULDER { get; set; }
        public string CRANIALNERVE { get; set; }
        public string descriptionNo4 { get; set; }

        //radio

        public ICollection<System.Web.Mvc.SelectListItem> DOMINANCE { get; set; }
        public string DOMINANCEStr { get; set; }


        public ICollection<System.Web.Mvc.SelectListItem> MOUTHGUARD { get; set; }
        public string MOUTHGUARDStr { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> TOOTHGRINDER { get; set; }
        public string TOOTHGRINDERStr { get; set; }

        public ICollection<System.Web.Mvc.SelectListItem> Vocational { get; set; }
        public string VocationalStr { get; set; }

        //check box
        public ICollection<System.Web.Mvc.SelectListItem> Sensation { get; set; }
        public List<string> SensationStr { get; set; }


        public ICollection<System.Web.Mvc.SelectListItem> Therapeuticexercise { get; set; }
        public List<string> TherapeuticexerciseStr { get; set; }


        public ICollection<System.Web.Mvc.SelectListItem> SensationRight { get; set; }
        public List<string> SensationRightStr { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> SensationLeft { get; set; }
        public List<string> SensationLeftStr { get; set; }





        //string

        //public string FLEXIONAElbowRightROM { get; set; }
        //public string FLEXIONAElbowRightStrength { get; set; }
        //public string FLEXIONAElbowLeftRom { get; set; }
        //public string FLEXIONAElbowLeftStrength { get; set; }
        //public string ExtensionElbow1 { get; set; }
        //public string ExtensionElbow2 { get; set; }
        //public string ExtensionElbow3 { get; set; }
        //public string ExtensionElbow4 { get; set; }
        //public string SupinationElbow1 { get; set; }
        //public string SupinationElbow2 { get; set; }
        //public string SupinationElbow3 { get; set; }
        //public string SupinationElbow4 { get; set; }
        //public string PronationElbow1 { get; set; }
        //public string PronationElbow2 { get; set; }
        //public string PronationElbow3 { get; set; }
        //public string PronationElbow4 { get; set; }
        //public string FlexionWrist1 { get; set; }
        //public string FlexionWrist2 { get; set; }
        //public string FlexionWrist3 { get; set; }
        //public string FlexionWrist4 { get; set; }
        //public string ExtensionWrist1 { get; set; }
        //public string ExtensionWrist2 { get; set; }
        //public string ExtensionWrist3 { get; set; }
        //public string ExtensionWrist4 { get; set; }
        //public string Ulnar1 { get; set; }
        //public string Ulnar2 { get; set; }
        //public string Ulnar3 { get; set; }
        //public string Ulnar4 { get; set; }
        //public string Radial1 { get; set; }
        //public string Radial2 { get; set; }
        //public string Radial3 { get; set; }
        //public string Radial4 { get; set; }
        //public string CMCFlex1 { get; set; }
        //public string CMCFlex2 { get; set; }
        //public string CMCFlex3 { get; set; }
        //public string CMCFlex4 { get; set; }
        //public string CMCExt1 { get; set; }
        //public string CMCExt2 { get; set; }
        //public string CMCExt3 { get; set; }
        //public string CMCExt4 { get; set; }
        //public string CMCAbd1 { get; set; }
        //public string CMCAbd2 { get; set; }
        //public string CMCAbd3 { get; set; }
        //public string CMCAbd4 { get; set; }
        //public string Opposition1 { get; set; }
        //public string Opposition2 { get; set; }
        //public string Opposition3 { get; set; }
        //public string Opposition4 { get; set; }
        //public string MCPFlex1 { get; set; }
        //public string MCPFlex2 { get; set; }
        //public string MCPFlex3 { get; set; }
        //public string MCPFlex4 { get; set; }
        //public string MCPExt1 { get; set; }
        //public string MCPExt2 { get; set; }
        //public string MCPExt3 { get; set; }
        //public string MCPExt4 { get; set; }
        //public string IPFlex1 { get; set; }
        //public string IPFlex2 { get; set; }
        //public string IPFlex3 { get; set; }
        //public string IPFlex4 { get; set; }
        //public string IPExt1 { get; set; }
        //public string IPExt2 { get; set; }
        //public string IPExt3 { get; set; }
        //public string IPExt4 { get; set; }
        //public string MCPFlexDigits1 { get; set; }
        //public string MCPFlexDigits2 { get; set; }
        //public string MCPFlexDigits3 { get; set; }
        //public string MCPFlexDigits4 { get; set; }
        //public string MCPExtDigits1 { get; set; }
        //public string MCPExtDigits2 { get; set; }
        //public string MCPExtDigits3 { get; set; }
        //public string MCPExtDigits4 { get; set; }
        //public string MCPAbdDigits1 { get; set; }
        //public string MCPAbdDigits2 { get; set; }
        //public string MCPAbdDigits3 { get; set; }
        //public string MCPAbdDigits4 { get; set; }
        //public string PIPFlexDigits1 { get; set; }
        //public string PIPFlexDigits2 { get; set; }
        //public string PIPFlexDigits3 { get; set; }
        //public string PIPFlexDigits4 { get; set; }
        //public string PIPExtDigits1 { get; set; }
        //public string PIPExtDigits2 { get; set; }
        //public string PIPExtDigits3 { get; set; }
        //public string PIPExtDigits4 { get; set; }
        //public string DIPFlexDigits1 { get; set; }
        //public string DIPFlexDigits2 { get; set; }
        //public string DIPFlexDigits3 { get; set; }
        //public string DIPFlexDigits4 { get; set; }
        //public string DIPExtDigits1 { get; set; }
        //public string DIPExtDigits2 { get; set; }
        //public string DIPExtDigits3 { get; set; }
        //public string DIPExtDigits4 { get; set; }
        //public string GRIPRight { get; set; }
        //public string GRIPLeft { get; set; }
        //public string PINCHRight { get; set; }
        //public string PINCHLeft { get; set; }

        //end


        //[Display(Name = "CERVICAL CLEARING")]
        //public string CERVICALCLEARING { get; set; }

        [Display(Name = "OTHER FINDINGS")]
        public string OTHERFINDINGS { get; set; }



        //add
        [Display(Name = "Claim#")]
        public string Claim { get; set; }
        [Display(Name = "Date of Surgery")]
        public string DateOfSurgery { get; set; }

        [Display(Name = "HR=")]
        public string HR { get; set; }
        [Display(Name = "BP=")]
        public string BP { get; set; }

        public string AssessmentDesc { get; set; }
        public string pulling { get; set; }
        public string descriptionNo5 { get; set; }
        [Display(Name = "UE FUNCTIONAL INDEX SCORE")]
        public string UEFUNCTIONALINDEXSCORE { get; set; }
        //public string Right { get; set; }
        //public string Left { get; set; }
        //table -2

        public string POSTURE { get; set; }
        public string PALPATION { get; set; }
        [Display(Name = "G-H. & A-C JT.MOBILITY")]
        public string GHAC { get; set; }

        [Display(Name = "SCAPULAR MOBILITY")]
        public string SCAPULARMOBILITY { get; set; }

        [Display(Name = "SPECIAL TESTS")]
        public string SPECIALTESTS { get; set; }


        //checkbox    
        public string TherapeuticexerciseDescription { get; set; }






        ////Flexion
        //public string FLEXIONAROMRightA { get; set; }
        //public string FLEXIONPROMRightP { get; set; }
        //public string FLEXIONStrengthRight { get; set; }
        //public string FLEXIONAROMLeftA { get; set; }
        //public string FLEXIONPROMLeftP { get; set; }
        //public string FLEXIONStrengthLeft { get; set; }
        //public string AbductionAROMRightA { get; set; }
        //public string AbductionPROMRightP { get; set; }
        //public string AbductionStrengthRight { get; set; }
        //public string AbductionAROMLeftA { get; set; }
        //public string AbductionPROMLeftP { get; set; }
        //public string AbductionStrengthLeft { get; set; }
        //public string ExtensionAROMRightA { get; set; }
        //public string ExtensionPROMRightP { get; set; }
        //public string ExtensionStrengthRight { get; set; }
        //public string ExtensionAROMLeftA { get; set; }
        //public string ExtensionPROMLeftP { get; set; }
        //public string ExtensionStrengthLeft { get; set; }
        //public string ExternalRotationAROMRightA { get; set; }
        //public string ExternalRotationPROMRightP { get; set; }
        //public string ExternalRotationStrengthRight { get; set; }
        //public string ExternalRotationAROMLeftA { get; set; }
        //public string ExternalRotationPROMLeftP { get; set; }
        //public string ExternalRotationStrengthLeft { get; set; }
        //public string InternalRotationAROMRightA { get; set; }
        //public string InternalRotationPROMRightP { get; set; }
        //public string InternalRotationStrengthRight { get; set; }
        //public string InternalRotationAROMLeftA { get; set; }
        //public string InternalRotationPROMLeftP { get; set; }
        //public string InternalRotationStrengthLeft { get; set; }
        //public string HorizontalAbductionAROMRightA { get; set; }
        //public string HorizontalAbductionPROMRightP { get; set; }
        //public string HorizontalAbductionStrengthRight { get; set; }
        //public string HorizontalAbductionAROMLeftA { get; set; }
        //public string HorizontalAbductionPROMLeftP { get; set; }
        //public string HorizontalAbductionStrengthLeft { get; set; }
        //public string HorizontalAdductionAROMRightA { get; set; }
        //public string HorizontalAdductionPROMRightP { get; set; }
        //public string HorizontalAdductionStrengthRight { get; set; }
        //public string HorizontalAdductionAROMLeftA { get; set; }
        //public string HorizontalAdductionPROMLeftP { get; set; }
        //public string HorizontalAdductionStrengthLeft { get; set; }


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
        [Display(Name = "Type")]
        public string Surgeries1Type { get; set; }
        [Display(Name = "Date")]
        public string Surgeries1Date { get; set; }
        [Display(Name = "Type")]
        public string Surgeries2Type { get; set; }
        [Display(Name = "Date")]
        public string Surgeries2Date { get; set; }
        [Display(Name = "Type")]
        public string Surgeries3Type { get; set; }
        [Display(Name = "Date")]
        public string Surgeries3Date { get; set; }
        public string Occupation { get; set; }
        [Display(Name = "Physical Demands")]
        public string PhysicalDemands { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> WorkStatus { get; set; }
        public string WorkStatusStr { get; set; }
        public string Reason { get; set; }





        //public int feet { get; set; }
        //public int inches { get; set; }
        //public int Weight { get; set; }
        //public string BMI { get; set; }
        [Display(Name = "When Worse")]
        public string WhenWorse { get; set; }
        [Display(Name = "When Better")]
        public string WhenBetter { get; set; }
        [Display(Name = "/10 @ present")]
        public string PainPresent { get; set; }
        [Display(Name = "/10 @ best")]
        public string PainBest { get; set; }
        [Display(Name = "/10 @ worst")]
        public string PainWorst { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Quality { get; set; }
        public string QualityStr { get; set; }

        //Table data

        //public string FLEXIONAROM { get; set; }
        //public string FLEXIONPROM { get; set; }
        //public string FLEXIONTHORACICAROM { get; set; }
        //public string EXTENSIONAROM { get; set; }
        //public string EXTENSIONPROM { get; set; }
        //public string EXTENSIONTHORACICAROM { get; set; }
        //public string SIDEBENDRIGHTAROM { get; set; }
        //public string SIDEBENDRIGHTPROM { get; set; }
        //public string SIDEBENDRIGHTTHORACICAROM { get; set; }
        //public string SIDEBENDLEFTAROM { get; set; }
        //public string SIDEBENDLEFTPROM { get; set; }
        //public string SIDEBENDLEFTTHORACICAROM { get; set; }
        //public string ROTATERIGHTAROM { get; set; }
        //public string ROTATERIGHTPROM { get; set; }
        //public string ROTATERIGHTTHORACICAROM { get; set; }
        //public string ROTATELEFTAROM { get; set; }
        //public string ROTATELEFTPROM { get; set; }
        //public string ROTATELEFTTHORACICAROM { get; set; }

        //public ICollection<System.Web.Mvc.SelectListItem> CervicalLordosis { get; set; }
        //public string CervicalLordosisStr { get; set; }
        //public ICollection<System.Web.Mvc.SelectListItem> LumbarLordosis { get; set; }
        //public string LumbarLordosisStr { get; set; }
        //public ICollection<System.Web.Mvc.SelectListItem> Kyphosis { get; set; }
        //public string KyphosisStr { get; set; }

        //public string Scapulothoracic { get; set; }
        //public string Asymmetry { get; set; }
        //public ICollection<System.Web.Mvc.SelectListItem> FirstRib { get; set; }
        //public string FirstRibStr { get; set; }
        //public ICollection<System.Web.Mvc.SelectListItem> NEURATTENSIONTESTING { get; set; }
        //public string NEURATTENSIONTESTINGStr { get; set; }

        //  Table Data Right

        //public ICollection<System.Web.Mvc.SelectListItem> UpperTrap { get; set; }
        //public string UpperTrapStr { get; set; }

        //public ICollection<System.Web.Mvc.SelectListItem> MiddleTrap { get; set; }
        //public string MiddleTrapStr { get; set; }

        //public ICollection<System.Web.Mvc.SelectListItem> LowerTrap { get; set; }
        //public string LowerTrapStr { get; set; }

        //public ICollection<System.Web.Mvc.SelectListItem> DeepNeckFlexor { get; set; }
        //public string DeepNeckFlexorStr { get; set; }

        //public ICollection<System.Web.Mvc.SelectListItem> UEflexion { get; set; }
        //public string UEflexionStr { get; set; }

        //public ICollection<System.Web.Mvc.SelectListItem> HeadAche { get; set; }
        //public string HeadAcheStr { get; set; }

        //public ICollection<System.Web.Mvc.SelectListItem> REFLEXES { get; set; }
        //public string REFLEXESStr { get; set; }
        //public ICollection<System.Web.Mvc.SelectListItem> DERMATOMES { get; set; }
        //public string DERMATOMESStr { get; set; }

        //public ICollection<System.Web.Mvc.SelectListItem> RADICULARSYMPTOMS { get; set; }
        //public string RADICULARSYMPTOMSStr { get; set; }

        //public string RADICULARSYMPTOMSOthers { get; set; }
        //[Display(Name = "Site")]
        //public string RADICULARSYMPTOMSSite { get; set; }
        //[Display(Name = "Manual Traction")]
        //public string RADICULARSYMPTOMSManualTraction { get; set; }

        //public ICollection<System.Web.Mvc.SelectListItem> RepeatedMovementTesting { get; set; }
        //public string RepeatedMovementTestingStr { get; set; }
        //public ICollection<System.Web.Mvc.SelectListItem> Segmentalmobility { get; set; }
        //public string SegmentalmobilityStr { get; set; }
        //public ICollection<System.Web.Mvc.SelectListItem> UnderPain_TTP { get; set; }
        //public string UnderPain_TTPStr { get; set; }
        //public ICollection<System.Web.Mvc.SelectListItem> Triggerpointesnoted { get; set; }
        //public string TriggerpointesnotedStr { get; set; }

        //public ICollection<System.Web.Mvc.SelectListItem> Musclelength { get; set; }
        //public string MusclelengthStr { get; set; }
        //public ICollection<System.Web.Mvc.SelectListItem> WADDELLSSIGN { get; set; }
        //public string WADDELLSSIGNStr { get; set; }
        //public ICollection<System.Web.Mvc.SelectListItem> OTHERFINDINGS_IMPAIRMENTS { get; set; }
        //public string OTHERFINDINGS_IMPAIRMENTSStr { get; set; }
        //public ICollection<System.Web.Mvc.SelectListItem> C1CervRotation { get; set; }
        //public string C1CervRotationStr { get; set; }

        //public ICollection<System.Web.Mvc.SelectListItem> C4ShldrShrug { get; set; }
        //public string C4ShldrShrugStr { get; set; }
        //public ICollection<System.Web.Mvc.SelectListItem> C5ShldrAbd { get; set; }
        //public string C5ShldrAbdStr { get; set; }
        //public ICollection<System.Web.Mvc.SelectListItem> C6WristExt_Elbflex { get; set; }
        //public string C6WristExt_ElbflexStr { get; set; }

        //public ICollection<System.Web.Mvc.SelectListItem> C7Wristflex_ElbExt { get; set; }
        //public string C7Wristflex_ElbExtStr { get; set; }
        //public ICollection<System.Web.Mvc.SelectListItem> C8FingerFlex { get; set; }
        //public string C8FingerFlexStr { get; set; }
        //public ICollection<System.Web.Mvc.SelectListItem> T1DigitalAdd_Abd { get; set; }
        //public string T1DigitalAdd_AbdStr { get; set; }

        // List data

        public ICollection<System.Web.Mvc.SelectListItem> RehabPotential { get; set; }
        public string RehabPotentialStr { get; set; }

        public string Goalstomet { get; set; }

        //public string Biometricscore { get; set; }
        //public ICollection<System.Web.Mvc.SelectListItem> WNLtoimprove { get; set; }
        //public string WNLtoimproveStr { get; set; }
        //public ICollection<System.Web.Mvc.SelectListItem> Goalsactivities { get; set; }
        //public string GoalsactivitiesStr { get; set; }
        //public ICollection<System.Web.Mvc.SelectListItem> functionalcapacity { get; set; }
        //public string functionalcapacityStr { get; set; }
        //public string sitting { get; set; }

        public string PhysicalTherapyTime { get; set; }
        public string xperweek { get; set; }
        //public ICollection<System.Web.Mvc.SelectListItem> PlanofCare { get; set; }
        //public string PlanofCareStr { get; set; }
        //public ICollection<System.Web.Mvc.SelectListItem> Modalities { get; set; }
        //public string ModalitiesStr { get; set; }
        //public string _DryNeedling { get; set; }
        //public string AddDMEbox { get; set; }

        // List of Exercises
        //Table 1
        //public string TherapeuticExerciseTime { get; set; }
        //public string TherapeuticExerciseUnits { get; set; }
        //public string TherapeuticExercise1 { get; set; }
        //public string TherapeuticExercise2 { get; set; }
        //public string TherapeuticExercise3 { get; set; }
        //public string TherapeuticExerciseSet1 { get; set; }
        //public string TherapeuticExerciseSet2 { get; set; }
        //public string TherapeuticExerciseSet3 { get; set; }
        //public string TherapeuticExerciseRep1 { get; set; }
        //public string TherapeuticExerciseRep2 { get; set; }
        //public string TherapeuticExerciseRep3 { get; set; }
        //public string TherapeuticExerciseResistanc1 { get; set; }
        //public string TherapeuticExerciseResistanc2 { get; set; }
        //public string TherapeuticExerciseResistanc3 { get; set; }
        //public string TherapeuticExerciseComments1 { get; set; }
        //public string TherapeuticExerciseComments2 { get; set; }
        //public string TherapeuticExerciseComments3 { get; set; }

        ////table 2
        //public string TherapeuticActivityTime { get; set; }
        //public string TherapeuticActivityUnits { get; set; }
        //public string TherapeuticActivityExercise1 { get; set; }
        //public string TherapeuticActivityExercise2 { get; set; }
        //public string TherapeuticActivityExercise3 { get; set; }
        //public string TherapeuticActivitySet1 { get; set; }
        //public string TherapeuticActivitySet2 { get; set; }
        //public string TherapeuticActivitySet3 { get; set; }
        //public string TherapeuticActivityRep1 { get; set; }
        //public string TherapeuticActivityRep2 { get; set; }
        //public string TherapeuticActivityRep3 { get; set; }
        //public string TherapeuticActivityResistanc1 { get; set; }
        //public string TherapeuticActivityResistanc2 { get; set; }
        //public string TherapeuticActivityResistanc3 { get; set; }
        //public string TherapeuticActivityComments1 { get; set; }
        //public string TherapeuticActivityComments2 { get; set; }
        //public string TherapeuticActivityComments3 { get; set; }

        ////Table 3
        //public string NeuromuscularReeducationTime { get; set; }
        //public string NeuromuscularReeducationUnits { get; set; }
        //public string NeuromuscularReeducationExercise1 { get; set; }
        //public string NeuromuscularReeducationExercise2 { get; set; }
        //public string NeuromuscularReeducationExercise3 { get; set; }
        //public string NeuromuscularReeducationSet1 { get; set; }
        //public string NeuromuscularReeducationSet2 { get; set; }
        //public string NeuromuscularReeducationSet3 { get; set; }
        //public string NeuromuscularReeducationRep1 { get; set; }
        //public string NeuromuscularReeducationRep2 { get; set; }
        //public string NeuromuscularReeducationRep3 { get; set; }
        //public string NeuromuscularReeducationResistanc1 { get; set; }
        //public string NeuromuscularReeducationResistanc2 { get; set; }
        //public string NeuromuscularReeducationResistanc3 { get; set; }
        //public string NeuromuscularReeducationComments1 { get; set; }
        //public string NeuromuscularReeducationComments2 { get; set; }
        //public string NeuromuscularReeducationComments3 { get; set; }


        ////Exercise list

        //public string ManualTherapyTime { get; set; }
        //public string ManualTherapyUnits { get; set; }
        //public ICollection<System.Web.Mvc.SelectListItem> ManualTherapy { get; set; }
        //public string ManualTherapyStr { get; set; }
        //public string Suboccipitals_ope { get; set; }
        //public string Cervicalmobilizationsgrade { get; set; }
        //public string Cervicalmobilizationsopen { get; set; }
        //public string Thoracicmobilizationgrade { get; set; }
        //public string Thoracicmobilizationopen { get; set; }
        //public string SelfCareTime { get; set; }
        //public ICollection<System.Web.Mvc.SelectListItem> SelfCare { get; set; }
        //public string SelfCareStr { get; set; }
        //public string MechanicalTractionTime { get; set; }
        //public string MechanicalTractionConstant { get; set; }
        //public string ElectricalStimulationTime { get; set; }
        //public ICollection<System.Web.Mvc.SelectListItem> ElectricalStimulation { get; set; }
        //public string ElectricalStimulationStr { get; set; }
        //public string UltrasoundTime { get; set; }
        //public string UltrasoundLocation { get; set; }
        //public string UltrasoundMHz { get; set; }
        //public string UltrasoundW_cm2 { get; set; }
        //public string Hot_ColdPackTime { get; set; }
        //public ICollection<System.Web.Mvc.SelectListItem> Hot_ColdPack { get; set; }
        //public string Hot_ColdPackStr { get; set; }
        //public string Hot_ColdPackTotalTime { get; set; }
        //public ICollection<System.Web.Mvc.SelectListItem> ManualElectricalStim { get; set; }
        //public string ManualElectricalStimStr { get; set; }
        //public string ManualElectricalStimCPTcodes { get; set; }
        //public string ExerciseTimeIn { get; set; }
        //public string ExerciseTimeOut { get; set; }
    }
}