using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class GeneralFunctionalMobilityEvaluationController : Helper
    {
        // GET: GeneralFunctionalMobilityEvaluation
        public ActionResult Index()
        {
            return View();
        }




        [HttpGet]
        public ActionResult GeneralFunctionalMobilityEvaluation(string id)
        {
            string testId = id;

            GeneralFunctionalMobilityEvaluation GeneralFunctionalMobility = new GeneralFunctionalMobilityEvaluation();
            GeneralFunctionalMobility.TestId = testId;


            GeneralFunctionalMobility.DOMINANCEStr = GetIdForAns(testId, 390);
            GeneralFunctionalMobility.DOMINANCE = MakeSelectList(390, GeneralFunctionalMobility.DOMINANCEStr);

            //radio
            GeneralFunctionalMobility.VocationalStr = GetIdForAns(testId, 576);
            GeneralFunctionalMobility.Vocational = MakeSelectList(576, GeneralFunctionalMobility.VocationalStr);
            //table 1
            GeneralFunctionalMobility.table1_11 = GetAnsDesForAns(testId, 766);
            GeneralFunctionalMobility.table1_12 = GetAnsDesForAns(testId, 767);
            GeneralFunctionalMobility.table1_13 = GetAnsDesForAns(testId, 768);
            GeneralFunctionalMobility.table1_14 = GetAnsDesForAns(testId, 769);
            GeneralFunctionalMobility.table1_21 = GetAnsDesForAns(testId, 770);
            GeneralFunctionalMobility.table1_22 = GetAnsDesForAns(testId, 771);
            GeneralFunctionalMobility.table1_23 = GetAnsDesForAns(testId, 772);
            GeneralFunctionalMobility.table1_24 = GetAnsDesForAns(testId, 773);
            GeneralFunctionalMobility.table1_31 = GetAnsDesForAns(testId, 774);
            GeneralFunctionalMobility.table1_32 = GetAnsDesForAns(testId, 775);
            GeneralFunctionalMobility.table1_33 = GetAnsDesForAns(testId, 776);
            GeneralFunctionalMobility.table1_34 = GetAnsDesForAns(testId, 777);
            GeneralFunctionalMobility.table1_41 = GetAnsDesForAns(testId, 778);
            GeneralFunctionalMobility.table1_42 = GetAnsDesForAns(testId, 779);
            GeneralFunctionalMobility.table1_43 = GetAnsDesForAns(testId, 780);
            GeneralFunctionalMobility.table1_44 = GetAnsDesForAns(testId, 781);
            GeneralFunctionalMobility.table1_51 = GetAnsDesForAns(testId, 782);
            GeneralFunctionalMobility.table1_52 = GetAnsDesForAns(testId, 783);
            GeneralFunctionalMobility.table1_53 = GetAnsDesForAns(testId, 784);
            GeneralFunctionalMobility.table1_54 = GetAnsDesForAns(testId, 785);
            GeneralFunctionalMobility.table1_61 = GetAnsDesForAns(testId, 786);
            GeneralFunctionalMobility.table1_62 = GetAnsDesForAns(testId, 787);
            GeneralFunctionalMobility.table1_63 = GetAnsDesForAns(testId, 788);
            GeneralFunctionalMobility.table1_64 = GetAnsDesForAns(testId, 789);
            //string

            GeneralFunctionalMobility.ENDURANCE1textbox = GetAnsDesForAns(testId, 644);
            GeneralFunctionalMobility.ENDURANCE2textbox = GetAnsDesForAns(testId, 645);
            GeneralFunctionalMobility.numberofstairs = GetAnsDesForAns(testId, 646);
            GeneralFunctionalMobility.SOCIALENVIRONMENT_Last = GetAnsDesForAns(testId, 647);
            GeneralFunctionalMobility.EQUIPMENT = GetAnsDesForAns(testId, 648);
            GeneralFunctionalMobility.table2_1 = GetAnsDesForAns(testId, 649);
            GeneralFunctionalMobility.table2_2 = GetAnsDesForAns(testId, 650);
            GeneralFunctionalMobility.table2_3 = GetAnsDesForAns(testId, 651);
            GeneralFunctionalMobility.table2_4 = GetAnsDesForAns(testId, 652);
            GeneralFunctionalMobility.table2_5 = GetAnsDesForAns(testId, 653);
            GeneralFunctionalMobility.table2_6 = GetAnsDesForAns(testId, 654);
            GeneralFunctionalMobility.table2_7 = GetAnsDesForAns(testId, 655);
            GeneralFunctionalMobility.table2_8 = GetAnsDesForAns(testId, 656);
            GeneralFunctionalMobility.table2_9 = GetAnsDesForAns(testId, 657);
            GeneralFunctionalMobility.table2_10 = GetAnsDesForAns(testId, 658);
            GeneralFunctionalMobility.table2_11 = GetAnsDesForAns(testId, 569);
            GeneralFunctionalMobility.table2_12 = GetAnsDesForAns(testId, 660);
            GeneralFunctionalMobility.table2_13 = GetAnsDesForAns(testId, 661);
            GeneralFunctionalMobility.table2_14 = GetAnsDesForAns(testId, 662);
            GeneralFunctionalMobility.table2_15 = GetAnsDesForAns(testId, 663);
            GeneralFunctionalMobility.table2_16 = GetAnsDesForAns(testId, 664);
            GeneralFunctionalMobility.table2_17 = GetAnsDesForAns(testId, 665);
            GeneralFunctionalMobility.table2_18 = GetAnsDesForAns(testId, 666);
            GeneralFunctionalMobility.table2_19 = GetAnsDesForAns(testId, 667);
            GeneralFunctionalMobility.table2_20 = GetAnsDesForAns(testId, 668);
            GeneralFunctionalMobility.table2_21 = GetAnsDesForAns(testId, 669);
            GeneralFunctionalMobility.table2_22 = GetAnsDesForAns(testId, 670);
            GeneralFunctionalMobility.table2_23 = GetAnsDesForAns(testId, 671);
            GeneralFunctionalMobility.table2_24 = GetAnsDesForAns(testId, 672);
            GeneralFunctionalMobility.BERGBALANCET = GetAnsDesForAns(testId, 673);
            GeneralFunctionalMobility.sitstand = GetAnsDesForAns(testId, 674);
            GeneralFunctionalMobility.supine = GetAnsDesForAns(testId, 675);
            GeneralFunctionalMobility.chair = GetAnsDesForAns(testId, 676);
            GeneralFunctionalMobility.cartransfers = GetAnsDesForAns(testId, 677);
            GeneralFunctionalMobility.TRANSFERS1 = GetAnsDesForAns(testId, 678);
            GeneralFunctionalMobility.TRANSFERS2 = GetAnsDesForAns(testId, 679);
            GeneralFunctionalMobility.TRANSFERS3 = GetAnsDesForAns(testId, 680);
            GeneralFunctionalMobility.sitting = GetAnsDesForAns(testId, 681);
            GeneralFunctionalMobility.standing = GetAnsDesForAns(testId, 682);
            GeneralFunctionalMobility.Hxoffalls = GetAnsDesForAns(testId, 683);
            GeneralFunctionalMobility.assistivedevice = GetAnsDesForAns(testId, 684);
            GeneralFunctionalMobility.braceorsupport = GetAnsDesForAns(testId, 685);
            GeneralFunctionalMobility.WBstatus = GetAnsDesForAns(testId, 686);
            GeneralFunctionalMobility.distanceGait = GetAnsDesForAns(testId, 687);
            GeneralFunctionalMobility.abnormalitiesnoted = GetAnsDesForAns(testId, 688);
            GeneralFunctionalMobility.TypeofSeat = GetAnsDesForAns(testId, 689);
            GeneralFunctionalMobility.Assist = GetAnsDesForAns(testId, 690);
            GeneralFunctionalMobility.Surface = GetAnsDesForAns(testId, 691);
            GeneralFunctionalMobility.Propels = GetAnsDesForAns(testId, 692);
            GeneralFunctionalMobility.descriptionNo1 = GetAnsDesForAns(testId, 693);
            GeneralFunctionalMobility.descriptionNo2 = GetAnsDesForAns(testId, 694);
            GeneralFunctionalMobility.descriptionNo3 = GetAnsDesForAns(testId, 695);
            GeneralFunctionalMobility.descriptionNo4 = GetAnsDesForAns(testId, 699);
            //end string


            //checkbox


            GeneralFunctionalMobility.TypedeviceStr = GetIdListForAns(testId, 790);
            GeneralFunctionalMobility.Typedevice = MakeSelectListfromList(790, GeneralFunctionalMobility.TypedeviceStr);

            GeneralFunctionalMobility.TherapeuticexerciseStr = GetIdListForAns(testId, 637);
            GeneralFunctionalMobility.Therapeuticexercise = MakeSelectListfromList(637, GeneralFunctionalMobility.TherapeuticexerciseStr);

            GeneralFunctionalMobility.PressurereliefStr = GetIdListForAns(testId, 638);
            GeneralFunctionalMobility.Pressurerelief = MakeSelectListfromList(638, GeneralFunctionalMobility.PressurereliefStr);


            GeneralFunctionalMobility.LegrestsStr = GetIdListForAns(testId, 639);
            GeneralFunctionalMobility.Legrests = MakeSelectListfromList(639, GeneralFunctionalMobility.LegrestsStr);


            GeneralFunctionalMobility.ProperfitStr = GetIdListForAns(testId, 640);
            GeneralFunctionalMobility.Properfit = MakeSelectListfromList(640, GeneralFunctionalMobility.ProperfitStr);


            GeneralFunctionalMobility.GAITStr = GetIdListForAns(testId, 641);
            GeneralFunctionalMobility.GAIT = MakeSelectListfromList(641, GeneralFunctionalMobility.GAITStr);

            GeneralFunctionalMobility.SOCIALENVIRONMENTStr = GetIdListForAns(testId, 643);
            GeneralFunctionalMobility.SOCIALENVIRONMENT = MakeSelectListfromList(643, GeneralFunctionalMobility.SOCIALENVIRONMENTStr);


            //radio
            GeneralFunctionalMobility.LifestyleStr = GetIdForAns(testId, 630);
            GeneralFunctionalMobility.Lifestyle = MakeSelectList(630, GeneralFunctionalMobility.LifestyleStr);

            GeneralFunctionalMobility.ImpairmentsStr = GetIdForAns(testId, 631);
            GeneralFunctionalMobility.Impairments = MakeSelectList(631, GeneralFunctionalMobility.ImpairmentsStr);

            GeneralFunctionalMobility.ENDURANCE1Str = GetIdForAns(testId, 632);
            GeneralFunctionalMobility.ENDURANCE1 = MakeSelectList(632, GeneralFunctionalMobility.ENDURANCE1Str);


            GeneralFunctionalMobility.ENDURANCE2Str = GetIdForAns(testId, 633);
            GeneralFunctionalMobility.ENDURANCE2 = MakeSelectList(633, GeneralFunctionalMobility.ENDURANCE2Str);

            GeneralFunctionalMobility.ControlawarenessStr = GetIdForAns(testId, 634);
            GeneralFunctionalMobility.Controlawareness = MakeSelectList(634, GeneralFunctionalMobility.ControlawarenessStr);

            GeneralFunctionalMobility.zero12Str = GetIdForAns(testId, 635);
            GeneralFunctionalMobility.zero12 = MakeSelectList(635, GeneralFunctionalMobility.zero12Str);


            GeneralFunctionalMobility.FallRiskStr = GetIdForAns(testId, 636);
            GeneralFunctionalMobility.FallRisk = MakeSelectList(636, GeneralFunctionalMobility.FallRiskStr);


            GeneralFunctionalMobility.CervicalLordosisStr = GetIdForAns(testId, 121);
            GeneralFunctionalMobility.CervicalLordosis = MakeSelectList(121, GeneralFunctionalMobility.CervicalLordosisStr);
            GeneralFunctionalMobility.LumbarLordosisStr = GetIdForAns(testId, 122);
            GeneralFunctionalMobility.LumbarLordosis = MakeSelectList(122, GeneralFunctionalMobility.LumbarLordosisStr);
            GeneralFunctionalMobility.KyphosisStr = GetIdForAns(testId, 123);
            GeneralFunctionalMobility.Kyphosis = MakeSelectList(123, GeneralFunctionalMobility.KyphosisStr);
            GeneralFunctionalMobility.Scapulothoracic = GetAnsDesForAns(testId, 124);
            GeneralFunctionalMobility.Asymmetry = GetAnsDesForAns(testId, 125);



            //add
            GeneralFunctionalMobility.Location = GetAnsDesForAns(testId, 585);




            //add
            GeneralFunctionalMobility.Claim = GetAnsDesForAns(testId, 375);
            GeneralFunctionalMobility.DateOfSurgery = GetAnsDesForAns(testId, 376);




            //redefine
            GeneralFunctionalMobility.PhysicalTherapyTime = GetAnsDesForAns(testId, 385);
            GeneralFunctionalMobility.xperweek = GetAnsDesForAns(testId, 386);






            GeneralFunctionalMobility.PatientName = GetAnsDesForAns(testId, 20) + " " + GetAnsDesForAns(testId, 21);
            GeneralFunctionalMobility.Dx_ICD_10 = GetAnsDesForAns(testId, 73);
            GeneralFunctionalMobility.Date = GetAnsDesForAns(testId, 74);
            GeneralFunctionalMobility.DOB = GetAnsDesForAns(testId, 23);
            GeneralFunctionalMobility.Therapist = GetAnsDesForAns(testId, 75);
            GeneralFunctionalMobility.Physician = GetAnsDesForAns(testId, 76);
            GeneralFunctionalMobility.NextMDApt = GetAnsDesForAns(testId, 77);
            GeneralFunctionalMobility.DateOnset = GetAnsDesForAns(testId, 78);
            GeneralFunctionalMobility.MOI = GetAnsDesForAns(testId, 79);
            GeneralFunctionalMobility.PreviousTreatment = GetAnsDesForAns(testId, 80);

            GeneralFunctionalMobility.DidItHelpStr = GetIdForAns(testId, 81);
            GeneralFunctionalMobility.DidItHelp = MakeSelectList(81, GeneralFunctionalMobility.DidItHelpStr);

            GeneralFunctionalMobility.History_ChiefComplaint = GetAnsDesForAns(testId, 82);
            GeneralFunctionalMobility.DiagnosticFindings = GetAnsDesForAns(testId, 83);
            GeneralFunctionalMobility.Meds = GetAnsDesForAns(testId, 84);
            GeneralFunctionalMobility.PastMedicalHistory = GetAnsDesForAns(testId, 85);

            GeneralFunctionalMobility.PhysicalDemands = GetAnsDesForAns(testId, 93);

            GeneralFunctionalMobility.WorkStatusStr = GetIdForAns(testId, 94);
            GeneralFunctionalMobility.WorkStatus = MakeSelectList(94, GeneralFunctionalMobility.WorkStatusStr);

            GeneralFunctionalMobility.Reason = GetAnsDesForAns(testId, 95);



            GeneralFunctionalMobility.WhenWorse = GetAnsDesForAns(testId, 96);
            GeneralFunctionalMobility.WhenBetter = GetAnsDesForAns(testId, 97);
            GeneralFunctionalMobility.PainPresent = GetAnsDesForAns(testId, 98);
            GeneralFunctionalMobility.PainBest = GetAnsDesForAns(testId, 99);
            GeneralFunctionalMobility.PainWorst = GetAnsDesForAns(testId, 100);

            GeneralFunctionalMobility.QualityStr = GetIdForAns(testId, 102);
            GeneralFunctionalMobility.Quality = MakeSelectList(102, GeneralFunctionalMobility.QualityStr);

            //// List data
            GeneralFunctionalMobility.RehabPotentialStr = GetIdForAns(testId, 153);
            GeneralFunctionalMobility.RehabPotential = MakeSelectList(153, GeneralFunctionalMobility.RehabPotentialStr);
            GeneralFunctionalMobility.Goalstomet = GetAnsDesForAns(testId, 154);
            //GeneralFunctionalMobility.Biometricscore = GetAnsDesForAns(testId, 155);

            GeneralFunctionalMobility.PainPresent = GetAnsDesForAns(testId, 98);
            GeneralFunctionalMobility.PainWorst = GetAnsDesForAns(testId, 100);



            return View(GeneralFunctionalMobility);
        }
        [HttpPost]
        public ActionResult GeneralFunctionalMobilityEvaluation(GeneralFunctionalMobilityEvaluation model)
        {
            string testId = model.TestId;

            model.TestId = model.TestId;
            //radio
            model.DOMINANCE = MakeSelectList(390, model.DOMINANCEStr);
            insertTestAnswerTbl(testId, 390, model.DOMINANCEStr);
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

            model.Therapeuticexercise = MakeSelectListfromList(637, model.TherapeuticexerciseStr);
            insertTestAnswerTblList(testId, 637, model.TherapeuticexerciseStr);
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

            //insertTestAnswerTblDesc(testId, 378, model.BP);
            //insertTestAnswerTblDesc(testId, 377, model.HR);
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