using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class SpinalEvaluationController : Helper
    {
        // GET: SpinalEvaluation
        public ActionResult Index()
        {
            return View();
        }

     

        [HttpGet]
        public ActionResult SpinalEvaluation(string id)
        {
            string testId = id;

            SpinalEvaluation spinalEvaluation = new SpinalEvaluation();
            spinalEvaluation.TestId = testId;

            //checkbox

            spinalEvaluation.TherapeuticexerciseStr = GetIdListForAns(testId,827);
            spinalEvaluation.Therapeuticexercise = MakeSelectListfromList(827, spinalEvaluation.TherapeuticexerciseStr);

            //radio
            spinalEvaluation.LeglengthdiscrepancyStr = GetIdForAns(testId,828);
            spinalEvaluation.Leglengthdiscrepancy = MakeSelectList(828, spinalEvaluation.LeglengthdiscrepancyStr);
            //string            
            spinalEvaluation.SLR1 = GetAnsDesForAns(testId, 829);
            spinalEvaluation.SLR2 = GetAnsDesForAns(testId, 830);
            spinalEvaluation.SLR3 = GetAnsDesForAns(testId, 831);
            spinalEvaluation.SLR4 = GetAnsDesForAns(testId, 832);
            spinalEvaluation.SLR5 = GetAnsDesForAns(testId, 833);
            spinalEvaluation.SLR6 = GetAnsDesForAns(testId, 834);
            spinalEvaluation.SLR7 = GetAnsDesForAns(testId, 835);
            spinalEvaluation.OSWESTRYSCORESpinal = GetAnsDesForAns(testId, 836);
            spinalEvaluation.WADDELLSSIGNSSpinal = GetAnsDesForAns(testId, 837);
            spinalEvaluation.OTHERFINDINGSSpinal = GetAnsDesForAns(testId, 838);
            spinalEvaluation.Painwithpalpation = GetAnsDesForAns(testId, 839);
            spinalEvaluation.toneSpinal = GetAnsDesForAns(testId, 840);
            spinalEvaluation.sittingSpinal = GetAnsDesForAns(testId, 841);
            spinalEvaluation.descriptionNo5Spinal = GetAnsDesForAns(testId, 842);
            spinalEvaluation.TherapeuticexerciseDescriptionSpinal1 = GetAnsDesForAns(testId, 843);
            spinalEvaluation.TherapeuticexerciseDescriptionSpinal2 = GetAnsDesForAns(testId, 844);
            //end

            spinalEvaluation.PainPresent = GetAnsDesForAns(testId, 98);
            spinalEvaluation.PainBest = GetAnsDesForAns(testId, 99);
            spinalEvaluation.PainWorst = GetAnsDesForAns(testId, 100);

            spinalEvaluation.SegmentalmobilityStr = GetIdForAns(testId, 141);
            spinalEvaluation.Segmentalmobility = MakeSelectList(141, spinalEvaluation.SegmentalmobilityStr);

            spinalEvaluation.RADICULARSYMPTOMSStr = GetIdForAns(testId, 136);
            spinalEvaluation.RADICULARSYMPTOMS = MakeSelectList(136, spinalEvaluation.RADICULARSYMPTOMSStr);

            spinalEvaluation.RADICULARSYMPTOMSOthers = GetAnsDesForAns(testId, 137);
            spinalEvaluation.RADICULARSYMPTOMSSite = GetAnsDesForAns(testId, 138);



            spinalEvaluation.DERMATOMESStr = GetIdForAns(testId, 135);
            spinalEvaluation.DERMATOMES = MakeSelectList(135, spinalEvaluation.DERMATOMESStr);

            spinalEvaluation.REFLEXESStr = GetIdForAns(testId, 134);
            spinalEvaluation.REFLEXES = MakeSelectList(134, spinalEvaluation.REFLEXESStr);



            spinalEvaluation.Occupation = GetAnsDesForAns(testId, 92);
            spinalEvaluation.HR = GetAnsDesForAns(testId, 377);
            spinalEvaluation.BP = GetAnsDesForAns(testId, 378);
       

            //radio
            spinalEvaluation.VocationalStr = GetIdForAns(testId, 576);
            spinalEvaluation.Vocational = MakeSelectList(576, spinalEvaluation.VocationalStr);
            //table 1
            spinalEvaluation.table1_11 = GetAnsDesForAns(testId, 766);
            spinalEvaluation.table1_12 = GetAnsDesForAns(testId, 767);
            spinalEvaluation.table1_13 = GetAnsDesForAns(testId, 768);
            spinalEvaluation.table1_14 = GetAnsDesForAns(testId, 769);
            spinalEvaluation.table1_21 = GetAnsDesForAns(testId, 770);
            spinalEvaluation.table1_22 = GetAnsDesForAns(testId, 771);
            spinalEvaluation.table1_23 = GetAnsDesForAns(testId, 772);
            spinalEvaluation.table1_24 = GetAnsDesForAns(testId, 773);
            spinalEvaluation.table1_31 = GetAnsDesForAns(testId, 774);
            spinalEvaluation.table1_32 = GetAnsDesForAns(testId, 775);
            spinalEvaluation.table1_33 = GetAnsDesForAns(testId, 776);
            spinalEvaluation.table1_34 = GetAnsDesForAns(testId, 777);
            spinalEvaluation.table1_41 = GetAnsDesForAns(testId, 778);
            spinalEvaluation.table1_42 = GetAnsDesForAns(testId, 779);
            spinalEvaluation.table1_43 = GetAnsDesForAns(testId, 780);
            spinalEvaluation.table1_44 = GetAnsDesForAns(testId, 781);
            spinalEvaluation.table1_51 = GetAnsDesForAns(testId, 782);
            spinalEvaluation.table1_52 = GetAnsDesForAns(testId, 783);
            spinalEvaluation.table1_53 = GetAnsDesForAns(testId, 784);
            spinalEvaluation.table1_54 = GetAnsDesForAns(testId, 785);
            spinalEvaluation.table1_61 = GetAnsDesForAns(testId, 786);
            spinalEvaluation.table1_62 = GetAnsDesForAns(testId, 787);
            spinalEvaluation.table1_63 = GetAnsDesForAns(testId, 788);
            spinalEvaluation.table1_64 = GetAnsDesForAns(testId, 789);
            //string

            spinalEvaluation.ENDURANCE1textbox = GetAnsDesForAns(testId, 644);
            spinalEvaluation.ENDURANCE2textbox = GetAnsDesForAns(testId, 645);
            spinalEvaluation.numberofstairs = GetAnsDesForAns(testId, 646);
            spinalEvaluation.SOCIALENVIRONMENT_Last = GetAnsDesForAns(testId, 647);
            spinalEvaluation.EQUIPMENT = GetAnsDesForAns(testId, 648);
            spinalEvaluation.table2_1 = GetAnsDesForAns(testId, 649);
            spinalEvaluation.table2_2 = GetAnsDesForAns(testId, 650);
            spinalEvaluation.table2_3 = GetAnsDesForAns(testId, 651);
            spinalEvaluation.table2_4 = GetAnsDesForAns(testId, 652);
            spinalEvaluation.table2_5 = GetAnsDesForAns(testId, 653);
            spinalEvaluation.table2_6 = GetAnsDesForAns(testId, 654);
            spinalEvaluation.table2_7 = GetAnsDesForAns(testId, 655);
            spinalEvaluation.table2_8 = GetAnsDesForAns(testId, 656);
            spinalEvaluation.table2_9 = GetAnsDesForAns(testId, 657);
            spinalEvaluation.table2_10 = GetAnsDesForAns(testId, 658);
            spinalEvaluation.table2_11 = GetAnsDesForAns(testId, 569);
            spinalEvaluation.table2_12 = GetAnsDesForAns(testId, 660);
            spinalEvaluation.table2_13 = GetAnsDesForAns(testId, 661);
            spinalEvaluation.table2_14 = GetAnsDesForAns(testId, 662);
            spinalEvaluation.table2_15 = GetAnsDesForAns(testId, 663);
            spinalEvaluation.table2_16 = GetAnsDesForAns(testId, 664);
            spinalEvaluation.table2_17 = GetAnsDesForAns(testId, 665);
            spinalEvaluation.table2_18 = GetAnsDesForAns(testId, 666);
            spinalEvaluation.table2_19 = GetAnsDesForAns(testId, 667);
            spinalEvaluation.table2_20 = GetAnsDesForAns(testId, 668);
            spinalEvaluation.table2_21 = GetAnsDesForAns(testId, 669);
            spinalEvaluation.table2_22 = GetAnsDesForAns(testId, 670);
            spinalEvaluation.table2_23 = GetAnsDesForAns(testId, 671);
            spinalEvaluation.table2_24 = GetAnsDesForAns(testId, 672);
            spinalEvaluation.BERGBALANCET = GetAnsDesForAns(testId, 673);
            spinalEvaluation.sitstand = GetAnsDesForAns(testId, 674);
            spinalEvaluation.supine = GetAnsDesForAns(testId, 675);
            spinalEvaluation.chair = GetAnsDesForAns(testId, 676);
            spinalEvaluation.cartransfers = GetAnsDesForAns(testId, 677);
            spinalEvaluation.TRANSFERS1 = GetAnsDesForAns(testId, 678);
            spinalEvaluation.TRANSFERS2 = GetAnsDesForAns(testId, 679);
            spinalEvaluation.TRANSFERS3 = GetAnsDesForAns(testId, 680);
            spinalEvaluation.sitting = GetAnsDesForAns(testId, 681);
            spinalEvaluation.standing = GetAnsDesForAns(testId, 682);
            spinalEvaluation.Hxoffalls = GetAnsDesForAns(testId, 683);
            spinalEvaluation.assistivedevice = GetAnsDesForAns(testId, 684);
            spinalEvaluation.braceorsupport = GetAnsDesForAns(testId, 685);
            spinalEvaluation.WBstatus = GetAnsDesForAns(testId, 686);
            spinalEvaluation.distanceGait = GetAnsDesForAns(testId, 687);
            spinalEvaluation.abnormalitiesnoted = GetAnsDesForAns(testId, 688);
            spinalEvaluation.TypeofSeat = GetAnsDesForAns(testId, 689);
            spinalEvaluation.Assist = GetAnsDesForAns(testId, 690);
            spinalEvaluation.Surface = GetAnsDesForAns(testId, 691);
            spinalEvaluation.Propels = GetAnsDesForAns(testId, 692);
            spinalEvaluation.descriptionNo1 = GetAnsDesForAns(testId, 693);
            spinalEvaluation.descriptionNo2 = GetAnsDesForAns(testId, 694);
            spinalEvaluation.descriptionNo3 = GetAnsDesForAns(testId, 695);
            spinalEvaluation.descriptionNo4 = GetAnsDesForAns(testId, 699);
            //end string


            //checkbox


            spinalEvaluation.TypedeviceStr = GetIdListForAns(testId, 790);
            spinalEvaluation.Typedevice = MakeSelectListfromList(790, spinalEvaluation.TypedeviceStr);


            spinalEvaluation.PressurereliefStr = GetIdListForAns(testId, 638);
            spinalEvaluation.Pressurerelief = MakeSelectListfromList(638, spinalEvaluation.PressurereliefStr);


            spinalEvaluation.LegrestsStr = GetIdListForAns(testId, 639);
            spinalEvaluation.Legrests = MakeSelectListfromList(639, spinalEvaluation.LegrestsStr);


            spinalEvaluation.ProperfitStr = GetIdListForAns(testId, 640);
            spinalEvaluation.Properfit = MakeSelectListfromList(640, spinalEvaluation.ProperfitStr);


            spinalEvaluation.GAITStr = GetIdListForAns(testId, 641);
            spinalEvaluation.GAIT = MakeSelectListfromList(641, spinalEvaluation.GAITStr);

            spinalEvaluation.SOCIALENVIRONMENTStr = GetIdListForAns(testId, 643);
            spinalEvaluation.SOCIALENVIRONMENT = MakeSelectListfromList(643, spinalEvaluation.SOCIALENVIRONMENTStr);


            //radio
            spinalEvaluation.LifestyleStr = GetIdForAns(testId, 630);
            spinalEvaluation.Lifestyle = MakeSelectList(630, spinalEvaluation.LifestyleStr);

            spinalEvaluation.ImpairmentsStr = GetIdForAns(testId, 631);
            spinalEvaluation.Impairments = MakeSelectList(631, spinalEvaluation.ImpairmentsStr);

            spinalEvaluation.ENDURANCE1Str = GetIdForAns(testId, 632);
            spinalEvaluation.ENDURANCE1 = MakeSelectList(632, spinalEvaluation.ENDURANCE1Str);


            spinalEvaluation.ENDURANCE2Str = GetIdForAns(testId, 633);
            spinalEvaluation.ENDURANCE2 = MakeSelectList(633, spinalEvaluation.ENDURANCE2Str);

            spinalEvaluation.ControlawarenessStr = GetIdForAns(testId, 634);
            spinalEvaluation.Controlawareness = MakeSelectList(634, spinalEvaluation.ControlawarenessStr);

            spinalEvaluation.zero12Str = GetIdForAns(testId, 635);
            spinalEvaluation.zero12 = MakeSelectList(635, spinalEvaluation.zero12Str);


            spinalEvaluation.FallRiskStr = GetIdForAns(testId, 636);
            spinalEvaluation.FallRisk = MakeSelectList(636, spinalEvaluation.FallRiskStr);


            spinalEvaluation.CervicalLordosisStr = GetIdForAns(testId, 121);
            spinalEvaluation.CervicalLordosis = MakeSelectList(121, spinalEvaluation.CervicalLordosisStr);
            spinalEvaluation.LumbarLordosisStr = GetIdForAns(testId, 122);
            spinalEvaluation.LumbarLordosis = MakeSelectList(122, spinalEvaluation.LumbarLordosisStr);
            spinalEvaluation.KyphosisStr = GetIdForAns(testId, 123);
            spinalEvaluation.Kyphosis = MakeSelectList(123, spinalEvaluation.KyphosisStr);
            spinalEvaluation.Scapulothoracic = GetAnsDesForAns(testId, 124);
            spinalEvaluation.Asymmetry = GetAnsDesForAns(testId, 125);



            //add
            spinalEvaluation.Location = GetAnsDesForAns(testId, 585);




            //add
            spinalEvaluation.Claim = GetAnsDesForAns(testId, 375);
            spinalEvaluation.DateOfSurgery = GetAnsDesForAns(testId, 376);




            //redefine
            spinalEvaluation.PhysicalTherapyTime = GetAnsDesForAns(testId, 385);
            spinalEvaluation.xperweek = GetAnsDesForAns(testId, 386);






            spinalEvaluation.PatientName = GetAnsDesForAns(testId, 20) + " " + GetAnsDesForAns(testId, 21);
            spinalEvaluation.Dx_ICD_10 = GetAnsDesForAns(testId, 73);
            spinalEvaluation.Date = GetAnsDesForAns(testId, 74);
            spinalEvaluation.DOB = GetAnsDesForAns(testId, 23);
            spinalEvaluation.Therapist = GetAnsDesForAns(testId, 75);
            spinalEvaluation.Physician = GetAnsDesForAns(testId, 76);
            spinalEvaluation.NextMDApt = GetAnsDesForAns(testId, 77);
            spinalEvaluation.DateOnset = GetAnsDesForAns(testId, 78);
            spinalEvaluation.MOI = GetAnsDesForAns(testId, 79);
            spinalEvaluation.PreviousTreatment = GetAnsDesForAns(testId, 80);

            spinalEvaluation.DidItHelpStr = GetIdForAns(testId, 81);
            spinalEvaluation.DidItHelp = MakeSelectList(81, spinalEvaluation.DidItHelpStr);

            spinalEvaluation.History_ChiefComplaint = GetAnsDesForAns(testId, 82);
            spinalEvaluation.DiagnosticFindings = GetAnsDesForAns(testId, 83);
            spinalEvaluation.Meds = GetAnsDesForAns(testId, 84);
            spinalEvaluation.PastMedicalHistory = GetAnsDesForAns(testId, 85);

            spinalEvaluation.PhysicalDemands = GetAnsDesForAns(testId, 93);

            spinalEvaluation.WorkStatusStr = GetIdForAns(testId, 94);
            spinalEvaluation.WorkStatus = MakeSelectList(94, spinalEvaluation.WorkStatusStr);

            spinalEvaluation.Reason = GetAnsDesForAns(testId, 95);



            spinalEvaluation.WhenWorse = GetAnsDesForAns(testId, 96);
            spinalEvaluation.WhenBetter = GetAnsDesForAns(testId, 97);
            spinalEvaluation.PainPresent = GetAnsDesForAns(testId, 98);
            spinalEvaluation.PainBest = GetAnsDesForAns(testId, 99);
            spinalEvaluation.PainWorst = GetAnsDesForAns(testId, 100);

            spinalEvaluation.QualityStr = GetIdForAns(testId, 102);
            spinalEvaluation.Quality = MakeSelectList(102, spinalEvaluation.QualityStr);

            //// List data
            spinalEvaluation.RehabPotentialStr = GetIdForAns(testId, 153);
            spinalEvaluation.RehabPotential = MakeSelectList(153, spinalEvaluation.RehabPotentialStr);
            spinalEvaluation.Goalstomet = GetAnsDesForAns(testId, 154);
            //spinalEvaluation.Biometricscore = GetAnsDesForAns(testId, 155);

            spinalEvaluation.PainPresent = GetAnsDesForAns(testId, 98);
     



            return View(spinalEvaluation);
        }
        [HttpPost]
        public ActionResult SpinalEvaluation(SpinalEvaluation model)
        {
            string testId = model.TestId;

            model.TestId = model.TestId;


            //checkbox

            model.Therapeuticexercise = MakeSelectListfromList(827, model.TherapeuticexerciseStr);
            insertTestAnswerTblList(testId, 827, model.TherapeuticexerciseStr);


            //radio
            model.Leglengthdiscrepancy = MakeSelectList(828, model.LeglengthdiscrepancyStr);
            insertTestAnswerTbl(testId, 828, model.LeglengthdiscrepancyStr);
            //string

            insertTestAnswerTblDesc(testId, 829, model.SLR1);
            insertTestAnswerTblDesc(testId, 830, model.SLR2);
            insertTestAnswerTblDesc(testId, 831, model.SLR3);
            insertTestAnswerTblDesc(testId, 832, model.SLR4);
            insertTestAnswerTblDesc(testId, 833, model.SLR5);
            insertTestAnswerTblDesc(testId, 834, model.SLR6);
            insertTestAnswerTblDesc(testId, 835, model.SLR7);
            insertTestAnswerTblDesc(testId, 836, model.OSWESTRYSCORESpinal);
            insertTestAnswerTblDesc(testId, 837, model.WADDELLSSIGNSSpinal);
            insertTestAnswerTblDesc(testId, 838, model.OTHERFINDINGSSpinal);
            insertTestAnswerTblDesc(testId, 839, model.Painwithpalpation);
            insertTestAnswerTblDesc(testId, 840, model.toneSpinal);
            insertTestAnswerTblDesc(testId, 841, model.sittingSpinal);
            insertTestAnswerTblDesc(testId, 842, model.descriptionNo5Spinal);
            insertTestAnswerTblDesc(testId, 843, model.TherapeuticexerciseDescriptionSpinal1);
            insertTestAnswerTblDesc(testId, 844, model.TherapeuticexerciseDescriptionSpinal2);
            //end


            insertTestAnswerTblDesc(testId, 98, model.PainPresent);
            insertTestAnswerTblDesc(testId, 99, model.PainBest);
            insertTestAnswerTblDesc(testId, 100, model.PainWorst);


            model.Segmentalmobility = MakeSelectList(141, model.SegmentalmobilityStr);
            insertTestAnswerTbl(testId, 141, model.SegmentalmobilityStr);

            model.DERMATOMES = MakeSelectList(135, model.DERMATOMESStr);
            insertTestAnswerTbl(testId, 135, model.DERMATOMESStr);

            model.REFLEXES = MakeSelectList(134, model.REFLEXESStr);
            insertTestAnswerTbl(testId, 134, model.REFLEXESStr);

            model.RADICULARSYMPTOMS = MakeSelectList(136, model.RADICULARSYMPTOMSStr);
            insertTestAnswerTbl(testId, 136, model.RADICULARSYMPTOMSStr);

            insertTestAnswerTblDesc(testId, 137, model.RADICULARSYMPTOMSOthers);
            insertTestAnswerTblDesc(testId, 138, model.RADICULARSYMPTOMSSite);


            insertTestAnswerTblDesc(testId, 92, model.Occupation);
            insertTestAnswerTblDesc(testId, 95, model.Reason);
            //radio
          
            model.Vocational = MakeSelectList(576, model.VocationalStr);
            insertTestAnswerTbl(testId, 576, model.VocationalStr);
            //table 1

            insertTestAnswerTblDesc(testId, 766, model.table1_11);
            insertTestAnswerTblDesc(testId, 767, model.table1_12);
            insertTestAnswerTblDesc(testId, 768, model.table1_13);
            insertTestAnswerTblDesc(testId, 769, model.table1_14);
            insertTestAnswerTblDesc(testId, 770, model.table1_21);
            insertTestAnswerTblDesc(testId, 771, model.table1_22);
            insertTestAnswerTblDesc(testId, 772, model.table1_23);
            insertTestAnswerTblDesc(testId, 773, model.table1_24);
            insertTestAnswerTblDesc(testId, 774, model.table1_31);
            insertTestAnswerTblDesc(testId, 775, model.table1_32);
            insertTestAnswerTblDesc(testId, 776, model.table1_33);
            insertTestAnswerTblDesc(testId, 777, model.table1_34);
            insertTestAnswerTblDesc(testId, 778, model.table1_41);
            insertTestAnswerTblDesc(testId, 779, model.table1_42);
            insertTestAnswerTblDesc(testId, 780, model.table1_43);
            insertTestAnswerTblDesc(testId, 781, model.table1_44);
            insertTestAnswerTblDesc(testId, 782, model.table1_51);
            insertTestAnswerTblDesc(testId, 783, model.table1_52);
            insertTestAnswerTblDesc(testId, 784, model.table1_53);
            insertTestAnswerTblDesc(testId, 785, model.table1_54);
            insertTestAnswerTblDesc(testId, 786, model.table1_61);
            insertTestAnswerTblDesc(testId, 787, model.table1_62);
            insertTestAnswerTblDesc(testId, 788, model.table1_63);
            insertTestAnswerTblDesc(testId, 789, model.table1_64);
            //string

            insertTestAnswerTblDesc(testId, 644, model.ENDURANCE1textbox);
            insertTestAnswerTblDesc(testId, 645, model.ENDURANCE2textbox);
            insertTestAnswerTblDesc(testId, 646, model.numberofstairs);
            insertTestAnswerTblDesc(testId, 647, model.SOCIALENVIRONMENT_Last);
            insertTestAnswerTblDesc(testId, 648, model.EQUIPMENT);
            insertTestAnswerTblDesc(testId, 649, model.table2_1);
            insertTestAnswerTblDesc(testId, 650, model.table2_2);
            insertTestAnswerTblDesc(testId, 651, model.table2_3);
            insertTestAnswerTblDesc(testId, 652, model.table2_4);
            insertTestAnswerTblDesc(testId, 653, model.table2_5);
            insertTestAnswerTblDesc(testId, 654, model.table2_6);
            insertTestAnswerTblDesc(testId, 655, model.table2_7);
            insertTestAnswerTblDesc(testId, 656, model.table2_8);
            insertTestAnswerTblDesc(testId, 657, model.table2_9);
            insertTestAnswerTblDesc(testId, 658, model.table2_10);
            insertTestAnswerTblDesc(testId, 659, model.table2_11);
            insertTestAnswerTblDesc(testId, 660, model.table2_12);
            insertTestAnswerTblDesc(testId, 661, model.table2_13);
            insertTestAnswerTblDesc(testId, 662, model.table2_14);
            insertTestAnswerTblDesc(testId, 663, model.table2_15);
            insertTestAnswerTblDesc(testId, 664, model.table2_16);
            insertTestAnswerTblDesc(testId, 665, model.table2_17);
            insertTestAnswerTblDesc(testId, 666, model.table2_18);
            insertTestAnswerTblDesc(testId, 667, model.table2_19);
            insertTestAnswerTblDesc(testId, 668, model.table2_20);
            insertTestAnswerTblDesc(testId, 669, model.table2_21);
            insertTestAnswerTblDesc(testId, 670, model.table2_22);
            insertTestAnswerTblDesc(testId, 671, model.table2_23);
            insertTestAnswerTblDesc(testId, 672, model.table2_24);
            insertTestAnswerTblDesc(testId, 673, model.BERGBALANCET);
            insertTestAnswerTblDesc(testId, 674, model.sitstand);
            insertTestAnswerTblDesc(testId, 675, model.supine);
            insertTestAnswerTblDesc(testId, 676, model.chair);
            insertTestAnswerTblDesc(testId, 677, model.cartransfers);
            insertTestAnswerTblDesc(testId, 678, model.TRANSFERS1);
            insertTestAnswerTblDesc(testId, 679, model.TRANSFERS2);
            insertTestAnswerTblDesc(testId, 680, model.TRANSFERS3);
            insertTestAnswerTblDesc(testId, 681, model.sitting);
            insertTestAnswerTblDesc(testId, 682, model.standing);
            insertTestAnswerTblDesc(testId, 683, model.Hxoffalls);
            insertTestAnswerTblDesc(testId, 684, model.assistivedevice);
            insertTestAnswerTblDesc(testId, 685, model.braceorsupport);
            insertTestAnswerTblDesc(testId, 686, model.WBstatus);
            insertTestAnswerTblDesc(testId, 687, model.distanceGait);
            insertTestAnswerTblDesc(testId, 688, model.abnormalitiesnoted);
            insertTestAnswerTblDesc(testId, 689, model.TypeofSeat);
            insertTestAnswerTblDesc(testId, 690, model.Assist);
            insertTestAnswerTblDesc(testId, 691, model.Surface);
            insertTestAnswerTblDesc(testId, 692, model.Propels);
            insertTestAnswerTblDesc(testId, 693, model.descriptionNo1);
            insertTestAnswerTblDesc(testId, 694, model.descriptionNo2);
            insertTestAnswerTblDesc(testId, 695, model.descriptionNo3);
            insertTestAnswerTblDesc(testId, 699, model.descriptionNo4);


            //end string
            //radio
            model.Lifestyle = MakeSelectList(630, model.LifestyleStr);
            insertTestAnswerTbl(testId, 630, model.LifestyleStr);

            model.Impairments = MakeSelectList(631, model.ImpairmentsStr);
            insertTestAnswerTbl(testId, 631, model.ImpairmentsStr);

            model.ENDURANCE1 = MakeSelectList(632, model.ENDURANCE1Str);
            insertTestAnswerTbl(testId, 632, model.ENDURANCE1Str);

            model.ENDURANCE2 = MakeSelectList(633, model.ENDURANCE2Str);
            insertTestAnswerTbl(testId, 633, model.ENDURANCE2Str);

            model.Controlawareness = MakeSelectList(634, model.ControlawarenessStr);
            insertTestAnswerTbl(testId, 634, model.ControlawarenessStr);

            model.zero12 = MakeSelectList(635, model.zero12Str);
            insertTestAnswerTbl(testId, 635, model.zero12Str);

            model.FallRisk = MakeSelectList(636, model.FallRiskStr);
            insertTestAnswerTbl(testId, 636, model.FallRiskStr);

            //checkbox
            model.SOCIALENVIRONMENT = MakeSelectListfromList(643, model.SOCIALENVIRONMENTStr);
            insertTestAnswerTblList(testId, 643, model.SOCIALENVIRONMENTStr);

            model.Typedevice = MakeSelectListfromList(790, model.TypedeviceStr);
            insertTestAnswerTblList(testId, 790, model.TypedeviceStr);

            model.GAIT = MakeSelectListfromList(641, model.GAITStr);
            insertTestAnswerTblList(testId, 641, model.GAITStr);

            model.Properfit = MakeSelectListfromList(640, model.ProperfitStr);
            insertTestAnswerTblList(testId, 640, model.ProperfitStr);

            model.Legrests = MakeSelectListfromList(639, model.LegrestsStr);
            insertTestAnswerTblList(testId, 639, model.LegrestsStr);

            model.Pressurerelief = MakeSelectListfromList(638, model.PressurereliefStr);
            insertTestAnswerTblList(testId, 638, model.PressurereliefStr);

            //end of checkbox


            model.CervicalLordosis = MakeSelectList(121, model.CervicalLordosisStr);
            insertTestAnswerTbl(testId, 121, model.CervicalLordosisStr);
            model.LumbarLordosis = MakeSelectList(122, model.LumbarLordosisStr);
            insertTestAnswerTbl(testId, 122, model.LumbarLordosisStr);
            model.Kyphosis = MakeSelectList(123, model.KyphosisStr);
            insertTestAnswerTbl(testId, 123, model.KyphosisStr);
            insertTestAnswerTblDesc(testId, 124, model.Scapulothoracic);
            insertTestAnswerTblDesc(testId, 125, model.Asymmetry);

            //end

            //model.SensationRight = MakeSelectListfromList(579, model.SensationRightStr);
            //model.SensationLeft = MakeSelectListfromList(580, model.SensationLeftStr);



            //string

            insertTestAnswerTblDesc(testId, 585, model.Location);




            insertTestAnswerTblDesc(testId, 379, model.AssessmentDesc);

            insertTestAnswerTblDesc(testId, 378, model.BP);
            insertTestAnswerTblDesc(testId, 377, model.HR);
            insertTestAnswerTblDesc(testId, 376, model.DateOfSurgery);
            insertTestAnswerTblDesc(testId, 375, model.Claim);

            //redefine
            insertTestAnswerTblDesc(testId, 385, model.PhysicalTherapyTime);
            insertTestAnswerTblDesc(testId, 386, model.xperweek);

            insertTestAnswerTblDesc(testId, 73, model.Dx_ICD_10);
            insertTestAnswerTblDesc(testId, 74, model.Date);
            insertTestAnswerTblDesc(testId, 23, model.DOB);
            insertTestAnswerTblDesc(testId, 75, model.Therapist);
            insertTestAnswerTblDesc(testId, 76, model.Physician);
            insertTestAnswerTblDesc(testId, 77, model.NextMDApt);
            insertTestAnswerTblDesc(testId, 78, model.DateOnset);
            insertTestAnswerTblDesc(testId, 79, model.MOI);
            insertTestAnswerTblDesc(testId, 80, model.PreviousTreatment);

            model.DidItHelp = MakeSelectList(81, model.DidItHelpStr);
            insertTestAnswerTbl(testId, 81, model.DidItHelpStr);

            insertTestAnswerTblDesc(testId, 82, model.History_ChiefComplaint);
            insertTestAnswerTblDesc(testId, 83, model.DiagnosticFindings);
            insertTestAnswerTblDesc(testId, 84, model.Meds);
            insertTestAnswerTblDesc(testId, 85, model.PastMedicalHistory);

            insertTestAnswerTblDesc(testId, 93, model.PhysicalDemands);

            model.WorkStatus = MakeSelectList(94, model.WorkStatusStr);
            insertTestAnswerTbl(testId, 94, model.WorkStatusStr);

            insertTestAnswerTblDesc(testId, 96, model.WhenWorse);
            insertTestAnswerTblDesc(testId, 97, model.WhenBetter);
            insertTestAnswerTblDesc(testId, 98, model.PainPresent);
            insertTestAnswerTblDesc(testId, 99, model.PainBest);
            insertTestAnswerTblDesc(testId, 100, model.PainWorst);

            model.Quality = MakeSelectList(94, model.QualityStr);
            insertTestAnswerTbl(testId, 94, model.QualityStr);



            ////List data
            model.RehabPotential = MakeSelectList(153, model.RehabPotentialStr);
            insertTestAnswerTbl(testId, 153, model.RehabPotentialStr);
            insertTestAnswerTblDesc(testId, 154, model.Goalstomet);

            return RedirectToAction("DailyNoteCervical", "Intake", new { id = model.TestId });
            //return RedirectToAction("PatientList", "Intake");
        }

    }
}