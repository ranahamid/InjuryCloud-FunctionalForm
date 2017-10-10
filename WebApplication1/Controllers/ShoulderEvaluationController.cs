using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ShoulderEvaluationController : Helper
    {
        // GET: ShoulderEvaluation
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult ShoulderEvaluation(string id)
        {
            string testId = id;


            ShoulderEvaluation shoulderEvaluation = new ShoulderEvaluation();
            shoulderEvaluation.TestId = testId;

            shoulderEvaluation.VocationalStr = GetIdForAns(testId, 576);
            shoulderEvaluation.Vocational = MakeSelectList(576, shoulderEvaluation.VocationalStr);
            shoulderEvaluation.CERVICALCLEARING = GetAnsDesForAns(testId, 575);

            //add
            shoulderEvaluation.Claim = GetAnsDesForAns(testId, 375);
            shoulderEvaluation.DateOfSurgery = GetAnsDesForAns(testId, 376);
            shoulderEvaluation.HR = GetAnsDesForAns(testId, 377);
            shoulderEvaluation.BP = GetAnsDesForAns(testId, 378);
            shoulderEvaluation.AssessmentDesc = GetAnsDesForAns(testId, 379);
            shoulderEvaluation.pulling = GetAnsDesForAns(testId, 380);
            shoulderEvaluation.descriptionNo5 = GetAnsDesForAns(testId, 381);

            shoulderEvaluation.UEFUNCTIONALINDEXSCORE = GetAnsDesForAns(testId, 382);
            shoulderEvaluation.Right = GetAnsDesForAns(testId, 383);
            shoulderEvaluation.Left = GetAnsDesForAns(testId, 384);



            //redefine
            shoulderEvaluation.PhysicalTherapyTime = GetAnsDesForAns(testId, 385);
            shoulderEvaluation.xperweek = GetAnsDesForAns(testId, 386);

            //checkbox
            shoulderEvaluation.SensationRightStr = GetIdListForAns(testId, 387);
            shoulderEvaluation.SensationRight = MakeSelectListfromList(387, shoulderEvaluation.SensationRightStr);

            shoulderEvaluation.SensationLeftStr = GetIdListForAns(testId, 388);
            shoulderEvaluation.SensationLeft = MakeSelectListfromList(388, shoulderEvaluation.SensationLeftStr);

            shoulderEvaluation.TherapeuticexerciseStr = GetIdListForAns(testId, 389);
            shoulderEvaluation.Therapeuticexercise = MakeSelectListfromList(389, shoulderEvaluation.TherapeuticexerciseStr);

            //radio
            shoulderEvaluation.DOMINANCEStr = GetIdForAns(testId, 390);
            shoulderEvaluation.DOMINANCE = MakeSelectList(390, shoulderEvaluation.DOMINANCEStr);



            //table add-1

            shoulderEvaluation.FLEXIONAROMRightA = GetAnsDesForAns(testId, 391);
            shoulderEvaluation.FLEXIONPROMRightP = GetAnsDesForAns(testId, 392);
            shoulderEvaluation.FLEXIONStrengthRight = GetAnsDesForAns(testId, 393);
            shoulderEvaluation.FLEXIONAROMLeftA = GetAnsDesForAns(testId, 394);
            shoulderEvaluation.FLEXIONPROMLeftP = GetAnsDesForAns(testId, 395);
            shoulderEvaluation.FLEXIONStrengthLeft = GetAnsDesForAns(testId, 396);
            shoulderEvaluation.AbductionAROMRightA = GetAnsDesForAns(testId, 397);
            shoulderEvaluation.AbductionPROMRightP = GetAnsDesForAns(testId, 398);
            shoulderEvaluation.AbductionStrengthRight = GetAnsDesForAns(testId, 399);
            shoulderEvaluation.AbductionAROMLeftA = GetAnsDesForAns(testId, 400);
            shoulderEvaluation.AbductionPROMLeftP = GetAnsDesForAns(testId, 401);
            shoulderEvaluation.AbductionStrengthLeft = GetAnsDesForAns(testId, 402);
            shoulderEvaluation.ExtensionAROMRightA = GetAnsDesForAns(testId, 403);
            shoulderEvaluation.ExtensionPROMRightP = GetAnsDesForAns(testId, 404);
            shoulderEvaluation.ExtensionStrengthRight = GetAnsDesForAns(testId, 405);
            shoulderEvaluation.ExtensionAROMLeftA = GetAnsDesForAns(testId, 406);
            shoulderEvaluation.ExtensionPROMLeftP = GetAnsDesForAns(testId, 407);
            shoulderEvaluation.ExtensionStrengthLeft = GetAnsDesForAns(testId, 408);

            shoulderEvaluation.ExternalRotationAROMRightA = GetAnsDesForAns(testId, 409);
            shoulderEvaluation.ExternalRotationPROMRightP = GetAnsDesForAns(testId, 410);
            shoulderEvaluation.ExternalRotationStrengthRight = GetAnsDesForAns(testId, 411);
            shoulderEvaluation.ExternalRotationAROMLeftA = GetAnsDesForAns(testId, 412);
            shoulderEvaluation.ExternalRotationPROMLeftP = GetAnsDesForAns(testId, 413);
            shoulderEvaluation.ExternalRotationStrengthLeft = GetAnsDesForAns(testId, 414);
            shoulderEvaluation.InternalRotationAROMRightA = GetAnsDesForAns(testId, 415);
            shoulderEvaluation.InternalRotationPROMRightP = GetAnsDesForAns(testId, 416);
            shoulderEvaluation.InternalRotationStrengthRight = GetAnsDesForAns(testId, 417);
            shoulderEvaluation.InternalRotationAROMLeftA = GetAnsDesForAns(testId, 418);
            shoulderEvaluation.InternalRotationPROMLeftP = GetAnsDesForAns(testId, 419);
            shoulderEvaluation.InternalRotationStrengthLeft = GetAnsDesForAns(testId, 420);
            shoulderEvaluation.HorizontalAbductionAROMRightA = GetAnsDesForAns(testId, 421);
            shoulderEvaluation.HorizontalAbductionPROMRightP = GetAnsDesForAns(testId, 422);
            shoulderEvaluation.HorizontalAbductionStrengthRight = GetAnsDesForAns(testId, 423);
            shoulderEvaluation.HorizontalAbductionAROMLeftA = GetAnsDesForAns(testId, 424);

            shoulderEvaluation.HorizontalAbductionPROMLeftP = GetAnsDesForAns(testId, 425);
            shoulderEvaluation.HorizontalAbductionStrengthLeft = GetAnsDesForAns(testId, 426);
            shoulderEvaluation.HorizontalAdductionAROMRightA = GetAnsDesForAns(testId, 427);
            shoulderEvaluation.HorizontalAdductionPROMRightP = GetAnsDesForAns(testId, 428);
            shoulderEvaluation.HorizontalAdductionStrengthRight = GetAnsDesForAns(testId, 429);
            shoulderEvaluation.HorizontalAdductionAROMLeftA = GetAnsDesForAns(testId, 430);
            shoulderEvaluation.HorizontalAdductionPROMLeftP = GetAnsDesForAns(testId, 431);
            shoulderEvaluation.HorizontalAdductionStrengthLeft = GetAnsDesForAns(testId, 432);

            //finish table -1
            //table-2
            shoulderEvaluation.POSTURE = GetAnsDesForAns(testId, 433);
            shoulderEvaluation.PALPATION = GetAnsDesForAns(testId, 434);
            shoulderEvaluation.GHAC = GetAnsDesForAns(testId, 435);
            shoulderEvaluation.SCAPULARMOBILITY = GetAnsDesForAns(testId, 436);
            shoulderEvaluation.SPECIALTESTS = GetAnsDesForAns(testId, 437);
            shoulderEvaluation.OTHERFINDINGS = GetAnsDesForAns(testId, 438);






            shoulderEvaluation.PatientName = GetAnsDesForAns(testId, 20) + " " + GetAnsDesForAns(testId, 21);
            shoulderEvaluation.Dx_ICD_10 = GetAnsDesForAns(testId, 73);
            shoulderEvaluation.Date = GetAnsDesForAns(testId, 74);
            shoulderEvaluation.DOB = GetAnsDesForAns(testId, 23);
            shoulderEvaluation.Therapist = GetAnsDesForAns(testId, 75);
            shoulderEvaluation.Physician = GetAnsDesForAns(testId, 76);
            shoulderEvaluation.NextMDApt = GetAnsDesForAns(testId, 77);
            shoulderEvaluation.DateOnset = GetAnsDesForAns(testId, 78);
            shoulderEvaluation.MOI = GetAnsDesForAns(testId, 79);
            shoulderEvaluation.PreviousTreatment = GetAnsDesForAns(testId, 80);

            shoulderEvaluation.DidItHelpStr = GetIdForAns(testId, 81);
            shoulderEvaluation.DidItHelp = MakeSelectList(81, shoulderEvaluation.DidItHelpStr);

            shoulderEvaluation.History_ChiefComplaint = GetAnsDesForAns(testId, 82);
            shoulderEvaluation.DiagnosticFindings = GetAnsDesForAns(testId, 83);
            shoulderEvaluation.Meds = GetAnsDesForAns(testId, 84);
            shoulderEvaluation.PastMedicalHistory = GetAnsDesForAns(testId, 85);
            shoulderEvaluation.Surgeries1Type = GetAnsDesForAns(testId, 86);
            shoulderEvaluation.Surgeries1Date = GetAnsDesForAns(testId, 87);
            shoulderEvaluation.Surgeries2Type = GetAnsDesForAns(testId, 88);
            shoulderEvaluation.Surgeries2Date = GetAnsDesForAns(testId, 89);
            shoulderEvaluation.Surgeries3Type = GetAnsDesForAns(testId, 90);
            shoulderEvaluation.Surgeries3Date = GetAnsDesForAns(testId, 91);
            shoulderEvaluation.Occupation = GetAnsDesForAns(testId, 92);
            shoulderEvaluation.PhysicalDemands = GetAnsDesForAns(testId, 93);

            shoulderEvaluation.WorkStatusStr = GetIdForAns(testId, 94);
            shoulderEvaluation.WorkStatus = MakeSelectList(94, shoulderEvaluation.WorkStatusStr);

            shoulderEvaluation.Reason = GetAnsDesForAns(testId, 95);

            shoulderEvaluation.feet = GetAnsDesForAns(testId, 24) != string.Empty ? Int32.Parse(GetAnsDesForAns(testId, 24)) : 2; //24
            shoulderEvaluation.inches = GetAnsDesForAns(testId, 25) != string.Empty ? Int32.Parse(GetAnsDesForAns(testId, 25)) : 0; //25
            shoulderEvaluation.Weight = GetAnsDesForAns(testId, 27) != string.Empty ? Int32.Parse(GetAnsDesForAns(testId, 27)) : 2; //27

            shoulderEvaluation.BMI = GetAnsDesForAns(testId, 101);

            shoulderEvaluation.WhenWorse = GetAnsDesForAns(testId, 96);
            shoulderEvaluation.WhenBetter = GetAnsDesForAns(testId, 97);
            shoulderEvaluation.PainPresent = GetAnsDesForAns(testId, 98);
            shoulderEvaluation.PainBest = GetAnsDesForAns(testId, 99);
            shoulderEvaluation.PainWorst = GetAnsDesForAns(testId, 100);

            shoulderEvaluation.QualityStr = GetIdForAns(testId, 102);
            shoulderEvaluation.Quality = MakeSelectList(102, shoulderEvaluation.QualityStr);

            //Table Data Left

            shoulderEvaluation.FLEXIONAROM = GetAnsDesForAns(testId, 103);
            shoulderEvaluation.FLEXIONPROM = GetAnsDesForAns(testId, 104);
            shoulderEvaluation.FLEXIONTHORACICAROM = GetAnsDesForAns(testId, 105);
            shoulderEvaluation.EXTENSIONAROM = GetAnsDesForAns(testId, 106);
            shoulderEvaluation.EXTENSIONPROM = GetAnsDesForAns(testId, 107);
            shoulderEvaluation.EXTENSIONTHORACICAROM = GetAnsDesForAns(testId, 108);
            shoulderEvaluation.SIDEBENDRIGHTAROM = GetAnsDesForAns(testId, 109);
            shoulderEvaluation.SIDEBENDRIGHTPROM = GetAnsDesForAns(testId, 110);
            shoulderEvaluation.SIDEBENDRIGHTTHORACICAROM = GetAnsDesForAns(testId, 111);
            shoulderEvaluation.SIDEBENDLEFTAROM = GetAnsDesForAns(testId, 112);
            shoulderEvaluation.SIDEBENDLEFTPROM = GetAnsDesForAns(testId, 113);
            shoulderEvaluation.SIDEBENDLEFTTHORACICAROM = GetAnsDesForAns(testId, 114);
            shoulderEvaluation.ROTATERIGHTAROM = GetAnsDesForAns(testId, 115);
            shoulderEvaluation.ROTATERIGHTPROM = GetAnsDesForAns(testId, 116);
            shoulderEvaluation.ROTATERIGHTTHORACICAROM = GetAnsDesForAns(testId, 117);
            shoulderEvaluation.ROTATELEFTAROM = GetAnsDesForAns(testId, 118);
            shoulderEvaluation.ROTATELEFTPROM = GetAnsDesForAns(testId, 119);
            shoulderEvaluation.ROTATELEFTTHORACICAROM = GetAnsDesForAns(testId, 120);


            shoulderEvaluation.CervicalLordosisStr = GetIdForAns(testId, 121);
            shoulderEvaluation.CervicalLordosis = MakeSelectList(121, shoulderEvaluation.CervicalLordosisStr);
            shoulderEvaluation.LumbarLordosisStr = GetIdForAns(testId, 122);
            shoulderEvaluation.LumbarLordosis = MakeSelectList(122, shoulderEvaluation.LumbarLordosisStr);
            shoulderEvaluation.KyphosisStr = GetIdForAns(testId, 123);
            shoulderEvaluation.Kyphosis = MakeSelectList(123, shoulderEvaluation.KyphosisStr);
            shoulderEvaluation.Scapulothoracic = GetAnsDesForAns(testId, 124);
            shoulderEvaluation.Asymmetry = GetAnsDesForAns(testId, 125);
            shoulderEvaluation.FirstRibStr = GetIdForAns(testId, 126);
            shoulderEvaluation.FirstRib = MakeSelectList(126, shoulderEvaluation.FirstRibStr);
            shoulderEvaluation.NEURATTENSIONTESTINGStr = GetIdForAns(testId, 127);
            shoulderEvaluation.NEURATTENSIONTESTING = MakeSelectList(127, shoulderEvaluation.NEURATTENSIONTESTINGStr);

            //Table Data Right

            shoulderEvaluation.UpperTrapStr = GetIdForAns(testId, 128);
            shoulderEvaluation.UpperTrap = MakeSelectList(128, shoulderEvaluation.UpperTrapStr);
            shoulderEvaluation.MiddleTrapStr = GetIdForAns(testId, 129);
            shoulderEvaluation.MiddleTrap = MakeSelectList(129, shoulderEvaluation.MiddleTrapStr);
            shoulderEvaluation.LowerTrapStr = GetIdForAns(testId, 130);
            shoulderEvaluation.LowerTrap = MakeSelectList(130, shoulderEvaluation.LowerTrapStr);
            shoulderEvaluation.DeepNeckFlexorStr = GetIdForAns(testId, 131);
            shoulderEvaluation.DeepNeckFlexor = MakeSelectList(131, shoulderEvaluation.DeepNeckFlexorStr);
            shoulderEvaluation.UEflexionStr = GetIdForAns(testId, 132);
            shoulderEvaluation.UEflexion = MakeSelectList(132, shoulderEvaluation.UEflexionStr);

            shoulderEvaluation.HeadAcheStr = GetIdForAns(testId, 133);
            shoulderEvaluation.HeadAche = MakeSelectList(133, shoulderEvaluation.HeadAcheStr);
            shoulderEvaluation.REFLEXESStr = GetIdForAns(testId, 134);
            shoulderEvaluation.REFLEXES = MakeSelectList(134, shoulderEvaluation.REFLEXESStr);
            shoulderEvaluation.DERMATOMESStr = GetIdForAns(testId, 135);
            shoulderEvaluation.DERMATOMES = MakeSelectList(135, shoulderEvaluation.DERMATOMESStr);
            shoulderEvaluation.RADICULARSYMPTOMSStr = GetIdForAns(testId, 136);
            shoulderEvaluation.RADICULARSYMPTOMS = MakeSelectList(136, shoulderEvaluation.RADICULARSYMPTOMSStr);

            shoulderEvaluation.RADICULARSYMPTOMSOthers = GetAnsDesForAns(testId, 137);
            shoulderEvaluation.RADICULARSYMPTOMSSite = GetAnsDesForAns(testId, 138);
            shoulderEvaluation.RADICULARSYMPTOMSManualTraction = GetAnsDesForAns(testId, 139);


            shoulderEvaluation.RepeatedMovementTestingStr = GetIdForAns(testId, 140);
            shoulderEvaluation.RepeatedMovementTesting = MakeSelectList(140, shoulderEvaluation.RepeatedMovementTestingStr);
            shoulderEvaluation.SegmentalmobilityStr = GetIdForAns(testId, 141);
            shoulderEvaluation.Segmentalmobility = MakeSelectList(141, shoulderEvaluation.SegmentalmobilityStr);
            shoulderEvaluation.UnderPain_TTPStr = GetIdForAns(testId, 253);
            shoulderEvaluation.UnderPain_TTP = MakeSelectList(253, shoulderEvaluation.UnderPain_TTPStr);

            shoulderEvaluation.TriggerpointesnotedStr = GetIdForAns(testId, 142);
            shoulderEvaluation.Triggerpointesnoted = MakeSelectList(142, shoulderEvaluation.TriggerpointesnotedStr);
            shoulderEvaluation.MusclelengthStr = GetIdForAns(testId, 143);
            shoulderEvaluation.Musclelength = MakeSelectList(143, shoulderEvaluation.MusclelengthStr);
            shoulderEvaluation.WADDELLSSIGNStr = GetIdForAns(testId, 144);
            shoulderEvaluation.WADDELLSSIGN = MakeSelectList(144, shoulderEvaluation.WADDELLSSIGNStr);
            shoulderEvaluation.OTHERFINDINGS_IMPAIRMENTSStr = GetIdForAns(testId, 145);
            shoulderEvaluation.OTHERFINDINGS_IMPAIRMENTS = MakeSelectList(145, shoulderEvaluation.OTHERFINDINGS_IMPAIRMENTSStr);

            shoulderEvaluation.C1CervRotationStr = GetIdForAns(testId, 146);
            shoulderEvaluation.C1CervRotation = MakeSelectList(146, shoulderEvaluation.C1CervRotationStr);
            shoulderEvaluation.C4ShldrShrugStr = GetIdForAns(testId, 147);
            shoulderEvaluation.C4ShldrShrug = MakeSelectList(147, shoulderEvaluation.C4ShldrShrugStr);
            shoulderEvaluation.C5ShldrAbdStr = GetIdForAns(testId, 148);
            shoulderEvaluation.C5ShldrAbd = MakeSelectList(148, shoulderEvaluation.C5ShldrAbdStr);
            shoulderEvaluation.C6WristExt_ElbflexStr = GetIdForAns(testId, 149);
            shoulderEvaluation.C6WristExt_Elbflex = MakeSelectList(149, shoulderEvaluation.C6WristExt_ElbflexStr);
            shoulderEvaluation.C7Wristflex_ElbExtStr = GetIdForAns(testId, 150);
            shoulderEvaluation.C7Wristflex_ElbExt = MakeSelectList(150, shoulderEvaluation.C7Wristflex_ElbExtStr);
            shoulderEvaluation.C8FingerFlexStr = GetIdForAns(testId, 151);
            shoulderEvaluation.C8FingerFlex = MakeSelectList(151, shoulderEvaluation.C8FingerFlexStr);
            shoulderEvaluation.T1DigitalAdd_AbdStr = GetIdForAns(testId, 152);
            shoulderEvaluation.T1DigitalAdd_Abd = MakeSelectList(152, shoulderEvaluation.T1DigitalAdd_AbdStr);

            // List data
            shoulderEvaluation.RehabPotentialStr = GetIdForAns(testId, 153);
            shoulderEvaluation.RehabPotential = MakeSelectList(153, shoulderEvaluation.RehabPotentialStr);
            shoulderEvaluation.Goalstomet = GetAnsDesForAns(testId, 154);
            shoulderEvaluation.Biometricscore = GetAnsDesForAns(testId, 155);

            shoulderEvaluation.PainPresent = GetAnsDesForAns(testId, 98);
            shoulderEvaluation.PainWorst = GetAnsDesForAns(testId, 100);

            shoulderEvaluation.WNLtoimproveStr = GetIdForAns(testId, 156);
            shoulderEvaluation.WNLtoimprove = MakeSelectList(156, shoulderEvaluation.WNLtoimproveStr);
            shoulderEvaluation.GoalsactivitiesStr = GetIdForAns(testId, 165);
            shoulderEvaluation.Goalsactivities = MakeSelectList(165, shoulderEvaluation.GoalsactivitiesStr);
            shoulderEvaluation.functionalcapacityStr = GetIdForAns(testId, 157);
            shoulderEvaluation.functionalcapacity = MakeSelectList(157, shoulderEvaluation.functionalcapacityStr);

            shoulderEvaluation.sitting = GetAnsDesForAns(testId, 158);



            shoulderEvaluation.PlanofCareStr = GetIdForAns(testId, 161);
            shoulderEvaluation.PlanofCare = MakeSelectList(161, shoulderEvaluation.PlanofCareStr);
            shoulderEvaluation.ModalitiesStr = GetIdForAns(testId, 162);
            shoulderEvaluation.Modalities = MakeSelectList(162, shoulderEvaluation.ModalitiesStr);
            shoulderEvaluation._DryNeedling = GetAnsDesForAns(testId, 163);
            shoulderEvaluation.AddDMEbox = GetAnsDesForAns(testId, 164);

            // List of Exercises

            //Table 1
            shoulderEvaluation.TherapeuticExerciseTime = GetAnsDesForAns(testId, 168);
            shoulderEvaluation.TherapeuticExerciseUnits = GetAnsDesForAns(testId, 169);
            shoulderEvaluation.TherapeuticExercise1 = GetAnsDesForAns(testId, 170);
            shoulderEvaluation.TherapeuticExercise2 = GetAnsDesForAns(testId, 171);
            shoulderEvaluation.TherapeuticExercise3 = GetAnsDesForAns(testId, 172);
            shoulderEvaluation.TherapeuticExerciseSet1 = GetAnsDesForAns(testId, 173);
            shoulderEvaluation.TherapeuticExerciseSet2 = GetAnsDesForAns(testId, 174);
            shoulderEvaluation.TherapeuticExerciseSet3 = GetAnsDesForAns(testId, 175);
            shoulderEvaluation.TherapeuticExerciseRep1 = GetAnsDesForAns(testId, 176);
            shoulderEvaluation.TherapeuticExerciseRep2 = GetAnsDesForAns(testId, 177);
            shoulderEvaluation.TherapeuticExerciseRep3 = GetAnsDesForAns(testId, 178);
            shoulderEvaluation.TherapeuticExerciseResistanc1 = GetAnsDesForAns(testId, 179);
            shoulderEvaluation.TherapeuticExerciseResistanc2 = GetAnsDesForAns(testId, 180);
            shoulderEvaluation.TherapeuticExerciseResistanc3 = GetAnsDesForAns(testId, 181);
            shoulderEvaluation.TherapeuticExerciseComments1 = GetAnsDesForAns(testId, 182);
            shoulderEvaluation.TherapeuticExerciseComments2 = GetAnsDesForAns(testId, 183);
            shoulderEvaluation.TherapeuticExerciseComments3 = GetAnsDesForAns(testId, 184);

            //Table 2
            shoulderEvaluation.TherapeuticActivityTime = GetAnsDesForAns(testId, 185);
            shoulderEvaluation.TherapeuticActivityUnits = GetAnsDesForAns(testId, 186);
            shoulderEvaluation.TherapeuticActivityExercise1 = GetAnsDesForAns(testId, 187);
            shoulderEvaluation.TherapeuticActivityExercise2 = GetAnsDesForAns(testId, 188);
            shoulderEvaluation.TherapeuticActivityExercise3 = GetAnsDesForAns(testId, 189);
            shoulderEvaluation.TherapeuticActivitySet1 = GetAnsDesForAns(testId, 190);
            shoulderEvaluation.TherapeuticActivitySet2 = GetAnsDesForAns(testId, 191);
            shoulderEvaluation.TherapeuticActivitySet3 = GetAnsDesForAns(testId, 192);
            shoulderEvaluation.TherapeuticActivityRep1 = GetAnsDesForAns(testId, 193);
            shoulderEvaluation.TherapeuticActivityRep2 = GetAnsDesForAns(testId, 194);
            shoulderEvaluation.TherapeuticActivityRep3 = GetAnsDesForAns(testId, 195);
            shoulderEvaluation.TherapeuticActivityResistanc1 = GetAnsDesForAns(testId, 196);
            shoulderEvaluation.TherapeuticActivityResistanc2 = GetAnsDesForAns(testId, 197);
            shoulderEvaluation.TherapeuticActivityResistanc3 = GetAnsDesForAns(testId, 198);
            shoulderEvaluation.TherapeuticActivityComments1 = GetAnsDesForAns(testId, 199);
            shoulderEvaluation.TherapeuticActivityComments2 = GetAnsDesForAns(testId, 200);
            shoulderEvaluation.TherapeuticActivityComments3 = GetAnsDesForAns(testId, 201);

            //Table 3
            shoulderEvaluation.NeuromuscularReeducationTime = GetAnsDesForAns(testId, 202);
            shoulderEvaluation.NeuromuscularReeducationUnits = GetAnsDesForAns(testId, 203);
            shoulderEvaluation.NeuromuscularReeducationExercise1 = GetAnsDesForAns(testId, 204);
            shoulderEvaluation.NeuromuscularReeducationExercise2 = GetAnsDesForAns(testId, 205);
            shoulderEvaluation.NeuromuscularReeducationExercise3 = GetAnsDesForAns(testId, 206);
            shoulderEvaluation.NeuromuscularReeducationSet1 = GetAnsDesForAns(testId, 207);
            shoulderEvaluation.NeuromuscularReeducationSet2 = GetAnsDesForAns(testId, 208);
            shoulderEvaluation.NeuromuscularReeducationSet3 = GetAnsDesForAns(testId, 209);
            shoulderEvaluation.NeuromuscularReeducationRep1 = GetAnsDesForAns(testId, 210);
            shoulderEvaluation.NeuromuscularReeducationRep2 = GetAnsDesForAns(testId, 211);
            shoulderEvaluation.NeuromuscularReeducationRep3 = GetAnsDesForAns(testId, 212);
            shoulderEvaluation.NeuromuscularReeducationResistanc1 = GetAnsDesForAns(testId, 213);
            shoulderEvaluation.NeuromuscularReeducationResistanc2 = GetAnsDesForAns(testId, 214);
            shoulderEvaluation.NeuromuscularReeducationResistanc3 = GetAnsDesForAns(testId, 215);
            shoulderEvaluation.NeuromuscularReeducationComments1 = GetAnsDesForAns(testId, 216);
            shoulderEvaluation.NeuromuscularReeducationComments2 = GetAnsDesForAns(testId, 217);
            shoulderEvaluation.NeuromuscularReeducationComments3 = GetAnsDesForAns(testId, 218);

            //Others Exercise list

            shoulderEvaluation.ManualTherapyTime = GetAnsDesForAns(testId, 219);
            shoulderEvaluation.ManualTherapyUnits = GetAnsDesForAns(testId, 220);
            shoulderEvaluation.ManualTherapyStr = GetIdForAns(testId, 221);
            shoulderEvaluation.ManualTherapy = MakeSelectList(221, shoulderEvaluation.ManualTherapyStr);
            shoulderEvaluation.Suboccipitals_ope = GetAnsDesForAns(testId, 222);
            shoulderEvaluation.Cervicalmobilizationsgrade = GetAnsDesForAns(testId, 223);
            shoulderEvaluation.Cervicalmobilizationsopen = GetAnsDesForAns(testId, 224);
            shoulderEvaluation.Thoracicmobilizationgrade = GetAnsDesForAns(testId, 225);
            shoulderEvaluation.Thoracicmobilizationopen = GetAnsDesForAns(testId, 226);
            shoulderEvaluation.SelfCareTime = GetAnsDesForAns(testId, 227);
            shoulderEvaluation.SelfCareStr = GetIdForAns(testId, 228);
            shoulderEvaluation.SelfCare = MakeSelectList(228, shoulderEvaluation.SelfCareStr);

            shoulderEvaluation.MechanicalTractionTime = GetAnsDesForAns(testId, 229);
            shoulderEvaluation.MechanicalTractionConstant = GetAnsDesForAns(testId, 230);
            shoulderEvaluation.ElectricalStimulationTime = GetAnsDesForAns(testId, 231);
            shoulderEvaluation.ElectricalStimulationStr = GetIdForAns(testId, 232);
            shoulderEvaluation.ElectricalStimulation = MakeSelectList(232, shoulderEvaluation.ElectricalStimulationStr);

            shoulderEvaluation.UltrasoundTime = GetAnsDesForAns(testId, 233);
            shoulderEvaluation.UltrasoundLocation = GetAnsDesForAns(testId, 234);
            shoulderEvaluation.UltrasoundMHz = GetAnsDesForAns(testId, 235);
            shoulderEvaluation.UltrasoundW_cm2 = GetAnsDesForAns(testId, 236);
            shoulderEvaluation.Hot_ColdPackTime = GetAnsDesForAns(testId, 237);

            shoulderEvaluation.Hot_ColdPackStr = GetIdForAns(testId, 238);
            shoulderEvaluation.Hot_ColdPack = MakeSelectList(238, shoulderEvaluation.Hot_ColdPackStr);
            shoulderEvaluation.Hot_ColdPackTotalTime = GetAnsDesForAns(testId, 239);
            shoulderEvaluation.ManualElectricalStimStr = GetIdForAns(testId, 240);
            shoulderEvaluation.ManualElectricalStim = MakeSelectList(240, shoulderEvaluation.ManualElectricalStimStr);
            shoulderEvaluation.ManualElectricalStimCPTcodes = GetAnsDesForAns(testId, 241);
            shoulderEvaluation.ExerciseTimeIn = GetAnsDesForAns(testId, 242);
            shoulderEvaluation.ExerciseTimeOut = GetAnsDesForAns(testId, 243);


            return View(shoulderEvaluation);
        }
        [HttpPost]
        public ActionResult ShoulderEvaluation(ShoulderEvaluation model)
        {
            string testId = model.TestId;

            model.TestId = model.TestId;

            insertTestAnswerTblDesc(testId, 575, model.CERVICALCLEARING);

            //radio
            model.Vocational = MakeSelectList(576, model.VocationalStr);
            insertTestAnswerTbl(testId, 576, model.VocationalStr);

            //done
            insertTestAnswerTblDesc(testId, 382, model.UEFUNCTIONALINDEXSCORE);
            insertTestAnswerTblDesc(testId, 383, model.Right);
            insertTestAnswerTblDesc(testId, 384, model.Left);
            insertTestAnswerTblDesc(testId, 381, model.descriptionNo5);

            insertTestAnswerTblDesc(testId, 380, model.pulling);

            insertTestAnswerTblDesc(testId, 379, model.AssessmentDesc);

            insertTestAnswerTblDesc(testId, 378, model.BP);
            insertTestAnswerTblDesc(testId, 377, model.HR);
            insertTestAnswerTblDesc(testId, 376, model.DateOfSurgery);
            insertTestAnswerTblDesc(testId, 375, model.Claim);

            //redefine
            insertTestAnswerTblDesc(testId, 385, model.PhysicalTherapyTime);
            insertTestAnswerTblDesc(testId, 386, model.xperweek);







            //checkbox
            model.SensationRight = MakeSelectListfromList(387, model.SensationRightStr);
            insertTestAnswerTblList(testId, 387, model.SensationRightStr);

            model.SensationLeft = MakeSelectListfromList(388, model.SensationLeftStr);
            insertTestAnswerTblList(testId, 388, model.SensationLeftStr);

            model.Therapeuticexercise = MakeSelectListfromList(389, model.TherapeuticexerciseStr);
            insertTestAnswerTblList(testId, 389, model.TherapeuticexerciseStr);
            //radio
            model.DOMINANCE = MakeSelectList(390, model.DOMINANCEStr);
            insertTestAnswerTbl(testId, 390, model.DOMINANCEStr);

            //table -1
            insertTestAnswerTblDesc(testId, 391, model.FLEXIONAROMRightA);
            insertTestAnswerTblDesc(testId, 392, model.FLEXIONPROMRightP);
            insertTestAnswerTblDesc(testId, 393, model.FLEXIONStrengthRight);
            insertTestAnswerTblDesc(testId, 394, model.FLEXIONAROMLeftA);
            insertTestAnswerTblDesc(testId, 395, model.FLEXIONPROMLeftP);
            insertTestAnswerTblDesc(testId, 396, model.FLEXIONStrengthLeft);
            insertTestAnswerTblDesc(testId, 397, model.AbductionAROMRightA);
            insertTestAnswerTblDesc(testId, 398, model.AbductionPROMRightP);
            insertTestAnswerTblDesc(testId, 399, model.AbductionStrengthRight);
            insertTestAnswerTblDesc(testId, 400, model.AbductionAROMLeftA);
            insertTestAnswerTblDesc(testId, 401, model.AbductionPROMLeftP);
            insertTestAnswerTblDesc(testId, 402, model.AbductionStrengthLeft);
            insertTestAnswerTblDesc(testId, 403, model.ExtensionAROMRightA);
            insertTestAnswerTblDesc(testId, 404, model.ExtensionPROMRightP);
            insertTestAnswerTblDesc(testId, 405, model.ExtensionStrengthRight);
            insertTestAnswerTblDesc(testId, 406, model.ExtensionAROMLeftA);
            insertTestAnswerTblDesc(testId, 407, model.ExtensionPROMLeftP);
            insertTestAnswerTblDesc(testId, 408, model.ExtensionStrengthLeft);
            insertTestAnswerTblDesc(testId, 409, model.ExternalRotationAROMRightA);
            insertTestAnswerTblDesc(testId, 410, model.ExternalRotationPROMRightP);
            insertTestAnswerTblDesc(testId, 411, model.ExternalRotationStrengthRight);
            insertTestAnswerTblDesc(testId, 412, model.ExternalRotationAROMLeftA);
            insertTestAnswerTblDesc(testId, 413, model.ExternalRotationPROMLeftP);
            insertTestAnswerTblDesc(testId, 414, model.ExternalRotationStrengthLeft);
            insertTestAnswerTblDesc(testId, 415, model.InternalRotationAROMRightA);
            insertTestAnswerTblDesc(testId, 416, model.InternalRotationPROMRightP);
            insertTestAnswerTblDesc(testId, 417, model.InternalRotationStrengthRight);
            insertTestAnswerTblDesc(testId, 418, model.InternalRotationAROMLeftA);
            insertTestAnswerTblDesc(testId, 419, model.InternalRotationPROMLeftP);
            insertTestAnswerTblDesc(testId, 420, model.InternalRotationStrengthLeft);
            insertTestAnswerTblDesc(testId, 421, model.HorizontalAbductionAROMRightA);
            insertTestAnswerTblDesc(testId, 422, model.HorizontalAbductionPROMRightP);
            insertTestAnswerTblDesc(testId, 423, model.HorizontalAbductionStrengthRight);
            insertTestAnswerTblDesc(testId, 424, model.HorizontalAbductionAROMLeftA);
            insertTestAnswerTblDesc(testId, 425, model.HorizontalAbductionPROMLeftP);
            insertTestAnswerTblDesc(testId, 426, model.HorizontalAbductionStrengthLeft);
            insertTestAnswerTblDesc(testId, 427, model.HorizontalAdductionAROMRightA);
            insertTestAnswerTblDesc(testId, 428, model.HorizontalAdductionPROMRightP);
            insertTestAnswerTblDesc(testId, 429, model.HorizontalAdductionStrengthRight);
            insertTestAnswerTblDesc(testId, 430, model.HorizontalAdductionAROMLeftA);
            insertTestAnswerTblDesc(testId, 431, model.HorizontalAdductionPROMLeftP);
            insertTestAnswerTblDesc(testId, 432, model.HorizontalAdductionStrengthLeft);
            //end of table -1

            //table-2
            insertTestAnswerTblDesc(testId, 433, model.POSTURE);
            insertTestAnswerTblDesc(testId, 434, model.PALPATION);
            insertTestAnswerTblDesc(testId, 435, model.GHAC);
            insertTestAnswerTblDesc(testId, 436, model.SCAPULARMOBILITY);
            insertTestAnswerTblDesc(testId, 437, model.SPECIALTESTS);
            insertTestAnswerTblDesc(testId, 438, model.OTHERFINDINGS);
            //end of table -2



            // insertTestAnswerTblDesc(testId, 18, model.PatientName);
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
            insertTestAnswerTblDesc(testId, 86, model.Surgeries1Type);
            insertTestAnswerTblDesc(testId, 87, model.Surgeries1Date);
            insertTestAnswerTblDesc(testId, 88, model.Surgeries2Type);
            insertTestAnswerTblDesc(testId, 89, model.Surgeries2Date);
            insertTestAnswerTblDesc(testId, 90, model.Surgeries3Type);
            insertTestAnswerTblDesc(testId, 91, model.Surgeries3Date);
            insertTestAnswerTblDesc(testId, 92, model.Occupation);
            insertTestAnswerTblDesc(testId, 93, model.PhysicalDemands);

            model.WorkStatus = MakeSelectList(94, model.WorkStatusStr);
            insertTestAnswerTbl(testId, 94, model.WorkStatusStr);

            insertTestAnswerTblDesc(testId, 95, model.Reason);
            insertTestAnswerTblDesc(testId, 24, model.feet.ToString());
            insertTestAnswerTblDesc(testId, 25, model.inches.ToString());
            insertTestAnswerTblDesc(testId, 27, model.Weight.ToString());
            insertTestAnswerTblDesc(testId, 101, model.BMI);
            insertTestAnswerTblDesc(testId, 96, model.WhenWorse);
            insertTestAnswerTblDesc(testId, 97, model.WhenBetter);
            insertTestAnswerTblDesc(testId, 98, model.PainPresent);
            insertTestAnswerTblDesc(testId, 99, model.PainBest);
            insertTestAnswerTblDesc(testId, 100, model.PainWorst);

            model.Quality = MakeSelectList(94, model.QualityStr);
            insertTestAnswerTbl(testId, 94, model.QualityStr);

            //Table Data Left
            insertTestAnswerTblDesc(testId, 103, model.FLEXIONAROM);
            insertTestAnswerTblDesc(testId, 104, model.FLEXIONPROM);
            insertTestAnswerTblDesc(testId, 105, model.FLEXIONTHORACICAROM);
            insertTestAnswerTblDesc(testId, 106, model.EXTENSIONAROM);
            insertTestAnswerTblDesc(testId, 107, model.EXTENSIONPROM);
            insertTestAnswerTblDesc(testId, 108, model.EXTENSIONTHORACICAROM);
            insertTestAnswerTblDesc(testId, 109, model.SIDEBENDRIGHTAROM);
            insertTestAnswerTblDesc(testId, 110, model.SIDEBENDRIGHTPROM);
            insertTestAnswerTblDesc(testId, 111, model.SIDEBENDRIGHTTHORACICAROM);
            insertTestAnswerTblDesc(testId, 112, model.SIDEBENDLEFTAROM);

            insertTestAnswerTblDesc(testId, 113, model.SIDEBENDLEFTPROM);
            insertTestAnswerTblDesc(testId, 114, model.SIDEBENDLEFTTHORACICAROM);
            insertTestAnswerTblDesc(testId, 115, model.ROTATERIGHTAROM);
            insertTestAnswerTblDesc(testId, 116, model.ROTATERIGHTPROM);
            insertTestAnswerTblDesc(testId, 117, model.ROTATERIGHTTHORACICAROM);
            insertTestAnswerTblDesc(testId, 118, model.ROTATELEFTAROM);
            insertTestAnswerTblDesc(testId, 119, model.ROTATELEFTPROM);
            insertTestAnswerTblDesc(testId, 120, model.ROTATELEFTTHORACICAROM);

            model.CervicalLordosis = MakeSelectList(121, model.CervicalLordosisStr);
            insertTestAnswerTbl(testId, 121, model.CervicalLordosisStr);
            model.LumbarLordosis = MakeSelectList(122, model.LumbarLordosisStr);
            insertTestAnswerTbl(testId, 122, model.LumbarLordosisStr);
            model.Kyphosis = MakeSelectList(123, model.KyphosisStr);
            insertTestAnswerTbl(testId, 123, model.KyphosisStr);
            insertTestAnswerTblDesc(testId, 124, model.Scapulothoracic);
            insertTestAnswerTblDesc(testId, 125, model.Asymmetry);
            model.FirstRib = MakeSelectList(126, model.FirstRibStr);
            insertTestAnswerTbl(testId, 126, model.FirstRibStr);
            model.NEURATTENSIONTESTING = MakeSelectList(127, model.NEURATTENSIONTESTINGStr);
            insertTestAnswerTbl(testId, 127, model.NEURATTENSIONTESTINGStr);

            //Table Data Right


            model.UpperTrap = MakeSelectList(128, model.UpperTrapStr);
            insertTestAnswerTbl(testId, 128, model.UpperTrapStr);
            model.MiddleTrap = MakeSelectList(129, model.MiddleTrapStr);
            insertTestAnswerTbl(testId, 129, model.MiddleTrapStr);
            model.LowerTrap = MakeSelectList(130, model.LowerTrapStr);
            insertTestAnswerTbl(testId, 130, model.LowerTrapStr);
            model.DeepNeckFlexor = MakeSelectList(131, model.DeepNeckFlexorStr);
            insertTestAnswerTbl(testId, 131, model.DeepNeckFlexorStr);
            model.UEflexion = MakeSelectList(132, model.UEflexionStr);
            insertTestAnswerTbl(testId, 132, model.UEflexionStr);


            model.HeadAche = MakeSelectList(133, model.HeadAcheStr);
            insertTestAnswerTbl(testId, 133, model.HeadAcheStr);
            model.REFLEXES = MakeSelectList(134, model.REFLEXESStr);
            insertTestAnswerTbl(testId, 134, model.REFLEXESStr);
            model.DERMATOMES = MakeSelectList(135, model.DERMATOMESStr);
            insertTestAnswerTbl(testId, 135, model.DERMATOMESStr);
            model.RADICULARSYMPTOMS = MakeSelectList(136, model.RADICULARSYMPTOMSStr);
            insertTestAnswerTbl(testId, 136, model.RADICULARSYMPTOMSStr);

            insertTestAnswerTblDesc(testId, 137, model.RADICULARSYMPTOMSOthers);
            insertTestAnswerTblDesc(testId, 138, model.RADICULARSYMPTOMSSite);
            insertTestAnswerTblDesc(testId, 139, model.RADICULARSYMPTOMSManualTraction);


            model.RepeatedMovementTesting = MakeSelectList(140, model.RepeatedMovementTestingStr);
            insertTestAnswerTbl(testId, 140, model.RepeatedMovementTestingStr);
            model.Segmentalmobility = MakeSelectList(141, model.SegmentalmobilityStr);
            insertTestAnswerTbl(testId, 141, model.SegmentalmobilityStr);
            model.UnderPain_TTP = MakeSelectList(253, model.UnderPain_TTPStr);
            insertTestAnswerTbl(testId, 253, model.UnderPain_TTPStr);
            model.Triggerpointesnoted = MakeSelectList(142, model.TriggerpointesnotedStr);
            insertTestAnswerTbl(testId, 142, model.TriggerpointesnotedStr);

            model.Musclelength = MakeSelectList(143, model.MusclelengthStr);
            insertTestAnswerTbl(testId, 143, model.MusclelengthStr);
            model.WADDELLSSIGN = MakeSelectList(144, model.WADDELLSSIGNStr);
            insertTestAnswerTbl(testId, 144, model.WADDELLSSIGNStr);
            model.OTHERFINDINGS_IMPAIRMENTS = MakeSelectList(145, model.OTHERFINDINGS_IMPAIRMENTSStr);
            insertTestAnswerTbl(testId, 145, model.OTHERFINDINGS_IMPAIRMENTSStr);
            model.C1CervRotation = MakeSelectList(146, model.C1CervRotationStr);
            insertTestAnswerTbl(testId, 146, model.C1CervRotationStr);


            model.C4ShldrShrug = MakeSelectList(147, model.C4ShldrShrugStr);
            insertTestAnswerTbl(testId, 147, model.C4ShldrShrugStr);
            model.C5ShldrAbd = MakeSelectList(148, model.C5ShldrAbdStr);
            insertTestAnswerTbl(testId, 148, model.C5ShldrAbdStr);
            model.C6WristExt_Elbflex = MakeSelectList(149, model.C6WristExt_ElbflexStr);
            insertTestAnswerTbl(testId, 149, model.C6WristExt_ElbflexStr);
            model.C7Wristflex_ElbExt = MakeSelectList(150, model.C7Wristflex_ElbExtStr);
            insertTestAnswerTbl(testId, 150, model.C7Wristflex_ElbExtStr);


            model.C8FingerFlex = MakeSelectList(151, model.C8FingerFlexStr);
            insertTestAnswerTbl(testId, 151, model.C8FingerFlexStr);
            model.T1DigitalAdd_Abd = MakeSelectList(152, model.T1DigitalAdd_AbdStr);
            insertTestAnswerTbl(testId, 152, model.T1DigitalAdd_AbdStr);


            //List data
            model.RehabPotential = MakeSelectList(153, model.RehabPotentialStr);
            insertTestAnswerTbl(testId, 153, model.RehabPotentialStr);
            insertTestAnswerTblDesc(testId, 154, model.Goalstomet);
            insertTestAnswerTblDesc(testId, 155, model.Biometricscore);

            model.WNLtoimprove = MakeSelectList(156, model.WNLtoimproveStr);
            insertTestAnswerTbl(testId, 156, model.WNLtoimproveStr);
            model.Goalsactivities = MakeSelectList(156, model.GoalsactivitiesStr);
            insertTestAnswerTbl(testId, 165, model.GoalsactivitiesStr);
            model.functionalcapacity = MakeSelectList(157, model.functionalcapacityStr);
            insertTestAnswerTbl(testId, 157, model.functionalcapacityStr);


            insertTestAnswerTblDesc(testId, 158, model.sitting);



            model.PlanofCare = MakeSelectList(161, model.PlanofCareStr);
            insertTestAnswerTbl(testId, 161, model.PlanofCareStr);
            model.Modalities = MakeSelectList(162, model.ModalitiesStr);
            insertTestAnswerTbl(testId, 162, model.ModalitiesStr);
            insertTestAnswerTblDesc(testId, 163, model._DryNeedling);
            insertTestAnswerTblDesc(testId, 164, model.AddDMEbox);

            //Table 1

            insertTestAnswerTblDesc(testId, 168, model.TherapeuticExerciseTime);
            insertTestAnswerTblDesc(testId, 169, model.TherapeuticExerciseUnits);
            insertTestAnswerTblDesc(testId, 170, model.TherapeuticExercise1);
            insertTestAnswerTblDesc(testId, 171, model.TherapeuticExercise2);
            insertTestAnswerTblDesc(testId, 172, model.TherapeuticExercise3);
            insertTestAnswerTblDesc(testId, 173, model.TherapeuticExerciseSet1);
            insertTestAnswerTblDesc(testId, 174, model.TherapeuticExerciseSet2);
            insertTestAnswerTblDesc(testId, 175, model.TherapeuticExerciseSet3);
            insertTestAnswerTblDesc(testId, 176, model.TherapeuticExerciseRep1);
            insertTestAnswerTblDesc(testId, 177, model.TherapeuticExerciseRep2);
            insertTestAnswerTblDesc(testId, 178, model.TherapeuticExerciseRep3);
            insertTestAnswerTblDesc(testId, 179, model.TherapeuticExerciseResistanc1);
            insertTestAnswerTblDesc(testId, 180, model.TherapeuticExerciseResistanc2);
            insertTestAnswerTblDesc(testId, 181, model.TherapeuticExerciseResistanc3);
            insertTestAnswerTblDesc(testId, 182, model.TherapeuticExerciseComments1);
            insertTestAnswerTblDesc(testId, 183, model.TherapeuticExerciseComments2);
            insertTestAnswerTblDesc(testId, 184, model.TherapeuticExerciseComments3);

            //Table 2

            insertTestAnswerTblDesc(testId, 185, model.TherapeuticActivityTime);
            insertTestAnswerTblDesc(testId, 186, model.TherapeuticActivityUnits);
            insertTestAnswerTblDesc(testId, 187, model.TherapeuticActivityExercise1);
            insertTestAnswerTblDesc(testId, 188, model.TherapeuticActivityExercise2);
            insertTestAnswerTblDesc(testId, 189, model.TherapeuticActivityExercise3);
            insertTestAnswerTblDesc(testId, 190, model.TherapeuticActivitySet1);
            insertTestAnswerTblDesc(testId, 191, model.TherapeuticActivitySet2);
            insertTestAnswerTblDesc(testId, 192, model.TherapeuticActivitySet3);
            insertTestAnswerTblDesc(testId, 193, model.TherapeuticActivityRep1);
            insertTestAnswerTblDesc(testId, 194, model.TherapeuticActivityRep2);
            insertTestAnswerTblDesc(testId, 195, model.TherapeuticActivityRep3);
            insertTestAnswerTblDesc(testId, 196, model.TherapeuticActivityResistanc1);
            insertTestAnswerTblDesc(testId, 197, model.TherapeuticActivityResistanc2);
            insertTestAnswerTblDesc(testId, 198, model.TherapeuticActivityResistanc3);
            insertTestAnswerTblDesc(testId, 199, model.TherapeuticActivityComments1);
            insertTestAnswerTblDesc(testId, 200, model.TherapeuticActivityComments2);
            insertTestAnswerTblDesc(testId, 201, model.TherapeuticActivityComments3);

            //Table 3

            insertTestAnswerTblDesc(testId, 202, model.NeuromuscularReeducationTime);
            insertTestAnswerTblDesc(testId, 203, model.NeuromuscularReeducationUnits);
            insertTestAnswerTblDesc(testId, 204, model.NeuromuscularReeducationExercise1);
            insertTestAnswerTblDesc(testId, 205, model.NeuromuscularReeducationExercise2);
            insertTestAnswerTblDesc(testId, 206, model.NeuromuscularReeducationExercise3);
            insertTestAnswerTblDesc(testId, 207, model.NeuromuscularReeducationSet1);
            insertTestAnswerTblDesc(testId, 208, model.NeuromuscularReeducationSet2);
            insertTestAnswerTblDesc(testId, 209, model.NeuromuscularReeducationSet3);
            insertTestAnswerTblDesc(testId, 210, model.NeuromuscularReeducationRep1);
            insertTestAnswerTblDesc(testId, 211, model.NeuromuscularReeducationRep2);
            insertTestAnswerTblDesc(testId, 212, model.NeuromuscularReeducationRep3);
            insertTestAnswerTblDesc(testId, 213, model.NeuromuscularReeducationResistanc1);
            insertTestAnswerTblDesc(testId, 214, model.NeuromuscularReeducationResistanc2);
            insertTestAnswerTblDesc(testId, 215, model.NeuromuscularReeducationResistanc3);
            insertTestAnswerTblDesc(testId, 216, model.NeuromuscularReeducationComments1);
            insertTestAnswerTblDesc(testId, 217, model.NeuromuscularReeducationComments2);
            insertTestAnswerTblDesc(testId, 218, model.NeuromuscularReeducationComments3);

            //Others Exercise list

            insertTestAnswerTblDesc(testId, 219, model.ManualTherapyTime);
            insertTestAnswerTblDesc(testId, 220, model.ManualTherapyUnits);
            model.ManualTherapy = MakeSelectList(221, model.ManualTherapyStr);
            insertTestAnswerTbl(testId, 221, model.ManualTherapyStr);

            insertTestAnswerTblDesc(testId, 222, model.Suboccipitals_ope);
            insertTestAnswerTblDesc(testId, 223, model.Cervicalmobilizationsgrade);
            insertTestAnswerTblDesc(testId, 224, model.Cervicalmobilizationsopen);
            insertTestAnswerTblDesc(testId, 225, model.Thoracicmobilizationgrade);
            insertTestAnswerTblDesc(testId, 226, model.Thoracicmobilizationopen);
            insertTestAnswerTblDesc(testId, 227, model.SelfCareTime);
            model.SelfCare = MakeSelectList(228, model.SelfCareStr);
            insertTestAnswerTbl(testId, 228, model.SelfCareStr);
            insertTestAnswerTblDesc(testId, 229, model.MechanicalTractionTime);
            insertTestAnswerTblDesc(testId, 230, model.MechanicalTractionConstant);
            insertTestAnswerTblDesc(testId, 231, model.ElectricalStimulationTime);
            model.ElectricalStimulation = MakeSelectList(232, model.ElectricalStimulationStr);
            insertTestAnswerTbl(testId, 232, model.ElectricalStimulationStr);

            insertTestAnswerTblDesc(testId, 233, model.UltrasoundTime);
            insertTestAnswerTblDesc(testId, 234, model.UltrasoundLocation);
            insertTestAnswerTblDesc(testId, 235, model.UltrasoundMHz);
            insertTestAnswerTblDesc(testId, 236, model.UltrasoundW_cm2);
            insertTestAnswerTblDesc(testId, 237, model.Hot_ColdPackTime);

            model.Hot_ColdPack = MakeSelectList(238, model.Hot_ColdPackStr);
            insertTestAnswerTbl(testId, 238, model.Hot_ColdPackStr);
            insertTestAnswerTblDesc(testId, 239, model.Hot_ColdPackTotalTime);
            model.ManualElectricalStim = MakeSelectList(240, model.ManualElectricalStimStr);
            insertTestAnswerTbl(testId, 240, model.ManualElectricalStimStr);

            insertTestAnswerTblDesc(testId, 241, model.ManualElectricalStimCPTcodes);
            insertTestAnswerTblDesc(testId, 242, model.ExerciseTimeIn);
            insertTestAnswerTblDesc(testId, 243, model.ExerciseTimeOut);

            return RedirectToAction("DailyNoteCervical", "Intake", new { id = model.TestId });
            //return RedirectToAction("PatientList", "Intake");
        }



    }
}