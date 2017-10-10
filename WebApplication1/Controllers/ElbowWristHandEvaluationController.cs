using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ElbowWristHandEvaluationController : Helper
    {
        // GET: ElbowWristHandEvaluation
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ElbowWristHandEvaluation(string id)
        {
            string testId = id;

            ElbowWristHandEvaluation ElbowWristHand = new ElbowWristHandEvaluation();
            ElbowWristHand.TestId = testId;


            //checkbox
            ElbowWristHand.SensationStr = GetIdListForAns(testId, 444);
            ElbowWristHand.Sensation = MakeSelectListfromList(444, ElbowWristHand.SensationStr);


            ElbowWristHand.TherapeuticexerciseStr = GetIdListForAns(testId, 445);
            ElbowWristHand.Therapeuticexercise = MakeSelectListfromList(445, ElbowWristHand.TherapeuticexerciseStr);

            //radio
            ElbowWristHand.DOMINANCEStr = GetIdForAns(testId, 446);
            ElbowWristHand.DOMINANCE = MakeSelectList(446, ElbowWristHand.DOMINANCEStr);


            //elbow add 
            ElbowWristHand.FLEXIONAElbowRightROM = GetAnsDesForAns(testId, 447);
            ElbowWristHand.FLEXIONAElbowRightStrength = GetAnsDesForAns(testId, 448);
            ElbowWristHand.FLEXIONAElbowLeftRom = GetAnsDesForAns(testId, 449);
            ElbowWristHand.FLEXIONAElbowLeftStrength = GetAnsDesForAns(testId, 450);
            ElbowWristHand.ExtensionElbow1 = GetAnsDesForAns(testId, 451);
            ElbowWristHand.ExtensionElbow2 = GetAnsDesForAns(testId, 452);
            ElbowWristHand.ExtensionElbow3 = GetAnsDesForAns(testId, 453);
            ElbowWristHand.ExtensionElbow4 = GetAnsDesForAns(testId, 454);

            ElbowWristHand.SupinationElbow1 = GetAnsDesForAns(testId, 455);
            ElbowWristHand.SupinationElbow2 = GetAnsDesForAns(testId, 456);
            ElbowWristHand.SupinationElbow3 = GetAnsDesForAns(testId, 457);
            ElbowWristHand.SupinationElbow4 = GetAnsDesForAns(testId, 458);
            ElbowWristHand.PronationElbow1 = GetAnsDesForAns(testId, 459);
            ElbowWristHand.PronationElbow2 = GetAnsDesForAns(testId, 460);
            ElbowWristHand.PronationElbow3 = GetAnsDesForAns(testId, 4461);
            ElbowWristHand.PronationElbow4 = GetAnsDesForAns(testId, 462);

            ElbowWristHand.FlexionWrist1 = GetAnsDesForAns(testId, 463);
            ElbowWristHand.FlexionWrist2 = GetAnsDesForAns(testId, 464);
            ElbowWristHand.FlexionWrist3 = GetAnsDesForAns(testId, 465);
            ElbowWristHand.FlexionWrist4 = GetAnsDesForAns(testId, 466);

            ElbowWristHand.ExtensionWrist1 = GetAnsDesForAns(testId, 467);
            ElbowWristHand.ExtensionWrist2 = GetAnsDesForAns(testId, 468);
            ElbowWristHand.ExtensionWrist3 = GetAnsDesForAns(testId, 469);
            ElbowWristHand.ExtensionWrist4 = GetAnsDesForAns(testId, 470);

            ElbowWristHand.Ulnar1 = GetAnsDesForAns(testId, 471);
            ElbowWristHand.Ulnar2 = GetAnsDesForAns(testId, 472);
            ElbowWristHand.Ulnar3 = GetAnsDesForAns(testId, 473);
            ElbowWristHand.Ulnar4 = GetAnsDesForAns(testId, 474);
            ElbowWristHand.Radial1 = GetAnsDesForAns(testId, 475);
            ElbowWristHand.Radial2 = GetAnsDesForAns(testId, 476);
            ElbowWristHand.Radial3 = GetAnsDesForAns(testId, 477);
            ElbowWristHand.Radial4 = GetAnsDesForAns(testId, 478);

            ElbowWristHand.CMCFlex1 = GetAnsDesForAns(testId, 479);
            ElbowWristHand.CMCFlex2 = GetAnsDesForAns(testId, 480);
            ElbowWristHand.CMCFlex3 = GetAnsDesForAns(testId, 481);
            ElbowWristHand.CMCFlex4 = GetAnsDesForAns(testId, 482);
            ElbowWristHand.CMCExt1 = GetAnsDesForAns(testId, 483);
            ElbowWristHand.CMCExt2 = GetAnsDesForAns(testId, 484);
            ElbowWristHand.CMCExt3 = GetAnsDesForAns(testId, 485);
            ElbowWristHand.CMCExt4 = GetAnsDesForAns(testId, 486);

            ElbowWristHand.CMCAbd1 = GetAnsDesForAns(testId, 487);
            ElbowWristHand.CMCAbd2 = GetAnsDesForAns(testId, 488);
            ElbowWristHand.CMCAbd3 = GetAnsDesForAns(testId, 489);
            ElbowWristHand.CMCAbd4 = GetAnsDesForAns(testId, 490);
            ElbowWristHand.Opposition1 = GetAnsDesForAns(testId, 491);
            ElbowWristHand.Opposition2 = GetAnsDesForAns(testId, 492);
            ElbowWristHand.Opposition3 = GetAnsDesForAns(testId, 493);
            ElbowWristHand.Opposition4 = GetAnsDesForAns(testId, 494);

            ElbowWristHand.MCPFlex1 = GetAnsDesForAns(testId, 495);
            ElbowWristHand.MCPFlex2 = GetAnsDesForAns(testId, 496);
            ElbowWristHand.MCPFlex3 = GetAnsDesForAns(testId, 497);
            ElbowWristHand.MCPFlex4 = GetAnsDesForAns(testId, 498);

            ElbowWristHand.MCPExt1 = GetAnsDesForAns(testId, 499);
            ElbowWristHand.MCPExt2 = GetAnsDesForAns(testId, 500);
            ElbowWristHand.MCPExt3 = GetAnsDesForAns(testId, 501);
            ElbowWristHand.MCPExt4 = GetAnsDesForAns(testId, 502);

            ElbowWristHand.IPFlex1 = GetAnsDesForAns(testId, 503);
            ElbowWristHand.IPFlex2 = GetAnsDesForAns(testId, 504);
            ElbowWristHand.IPFlex3 = GetAnsDesForAns(testId, 505);
            ElbowWristHand.IPFlex4 = GetAnsDesForAns(testId, 506);
            ElbowWristHand.IPExt1 = GetAnsDesForAns(testId, 507);
            ElbowWristHand.IPExt2 = GetAnsDesForAns(testId, 508);
            ElbowWristHand.IPExt3 = GetAnsDesForAns(testId, 509);
            ElbowWristHand.IPExt4 = GetAnsDesForAns(testId, 510);

            ElbowWristHand.MCPFlexDigits1 = GetAnsDesForAns(testId, 511);
            ElbowWristHand.MCPFlexDigits2 = GetAnsDesForAns(testId, 512);
            ElbowWristHand.MCPFlexDigits3 = GetAnsDesForAns(testId, 513);
            ElbowWristHand.MCPFlexDigits4 = GetAnsDesForAns(testId, 514);
            ElbowWristHand.MCPExtDigits1 = GetAnsDesForAns(testId, 515);
            ElbowWristHand.MCPExtDigits2 = GetAnsDesForAns(testId, 516);

            ElbowWristHand.MCPExtDigits3 = GetAnsDesForAns(testId, 517);
            ElbowWristHand.MCPExtDigits4 = GetAnsDesForAns(testId, 518);
            ElbowWristHand.MCPAbdDigits1 = GetAnsDesForAns(testId, 519);

            ElbowWristHand.MCPAbdDigits2 = GetAnsDesForAns(testId, 520);
            ElbowWristHand.MCPAbdDigits3 = GetAnsDesForAns(testId, 521);
            ElbowWristHand.MCPAbdDigits4 = GetAnsDesForAns(testId, 522);

            ElbowWristHand.PIPFlexDigits1 = GetAnsDesForAns(testId, 523);
            ElbowWristHand.PIPFlexDigits2 = GetAnsDesForAns(testId, 524);

            ElbowWristHand.PIPFlexDigits3 = GetAnsDesForAns(testId, 525);
            ElbowWristHand.PIPFlexDigits4 = GetAnsDesForAns(testId, 526);

            ElbowWristHand.PIPExtDigits1 = GetAnsDesForAns(testId, 527);
            ElbowWristHand.PIPExtDigits2 = GetAnsDesForAns(testId, 528);
            ElbowWristHand.PIPExtDigits3 = GetAnsDesForAns(testId, 529);
            ElbowWristHand.PIPExtDigits4 = GetAnsDesForAns(testId, 530);

            ElbowWristHand.DIPFlexDigits1 = GetAnsDesForAns(testId, 531);
            ElbowWristHand.DIPFlexDigits2 = GetAnsDesForAns(testId, 532);
            ElbowWristHand.DIPFlexDigits3 = GetAnsDesForAns(testId, 533);
            ElbowWristHand.DIPFlexDigits4 = GetAnsDesForAns(testId, 534);

            ElbowWristHand.DIPExtDigits1 = GetAnsDesForAns(testId, 535);
            ElbowWristHand.DIPExtDigits2 = GetAnsDesForAns(testId, 536);
            ElbowWristHand.DIPExtDigits3 = GetAnsDesForAns(testId, 537);
            ElbowWristHand.DIPExtDigits4 = GetAnsDesForAns(testId, 538);

            ElbowWristHand.GRIPRight = GetAnsDesForAns(testId, 539);
            ElbowWristHand.GRIPLeft = GetAnsDesForAns(testId, 540);
            ElbowWristHand.PINCHRight = GetAnsDesForAns(testId, 541);
            ElbowWristHand.PINCHLeft = GetAnsDesForAns(testId, 542);
            //finish


            //add
            ElbowWristHand.Claim = GetAnsDesForAns(testId, 375);
            ElbowWristHand.DateOfSurgery = GetAnsDesForAns(testId, 376);
            ElbowWristHand.HR = GetAnsDesForAns(testId, 377);
            ElbowWristHand.BP = GetAnsDesForAns(testId, 378);
            ElbowWristHand.AssessmentDesc = GetAnsDesForAns(testId, 379);
            ElbowWristHand.pulling = GetAnsDesForAns(testId, 380);
            ElbowWristHand.descriptionNo5 = GetAnsDesForAns(testId, 381);

            ElbowWristHand.UEFUNCTIONALINDEXSCORE = GetAnsDesForAns(testId, 382);
            ElbowWristHand.Right = GetAnsDesForAns(testId, 383);
            ElbowWristHand.Left = GetAnsDesForAns(testId, 384);



            //redefine
            ElbowWristHand.PhysicalTherapyTime = GetAnsDesForAns(testId, 385);
            ElbowWristHand.xperweek = GetAnsDesForAns(testId, 386);



            //table add-1

            ElbowWristHand.FLEXIONAROMRightA = GetAnsDesForAns(testId, 391);
            ElbowWristHand.FLEXIONPROMRightP = GetAnsDesForAns(testId, 392);
            ElbowWristHand.FLEXIONStrengthRight = GetAnsDesForAns(testId, 393);
            ElbowWristHand.FLEXIONAROMLeftA = GetAnsDesForAns(testId, 394);
            ElbowWristHand.FLEXIONPROMLeftP = GetAnsDesForAns(testId, 395);
            ElbowWristHand.FLEXIONStrengthLeft = GetAnsDesForAns(testId, 396);
            ElbowWristHand.AbductionAROMRightA = GetAnsDesForAns(testId, 397);
            ElbowWristHand.AbductionPROMRightP = GetAnsDesForAns(testId, 398);
            ElbowWristHand.AbductionStrengthRight = GetAnsDesForAns(testId, 399);
            ElbowWristHand.AbductionAROMLeftA = GetAnsDesForAns(testId, 400);
            ElbowWristHand.AbductionPROMLeftP = GetAnsDesForAns(testId, 401);
            ElbowWristHand.AbductionStrengthLeft = GetAnsDesForAns(testId, 402);
            ElbowWristHand.ExtensionAROMRightA = GetAnsDesForAns(testId, 403);
            ElbowWristHand.ExtensionPROMRightP = GetAnsDesForAns(testId, 404);
            ElbowWristHand.ExtensionStrengthRight = GetAnsDesForAns(testId, 405);
            ElbowWristHand.ExtensionAROMLeftA = GetAnsDesForAns(testId, 406);
            ElbowWristHand.ExtensionPROMLeftP = GetAnsDesForAns(testId, 407);
            ElbowWristHand.ExtensionStrengthLeft = GetAnsDesForAns(testId, 408);

            ElbowWristHand.ExternalRotationAROMRightA = GetAnsDesForAns(testId, 409);
            ElbowWristHand.ExternalRotationPROMRightP = GetAnsDesForAns(testId, 410);
            ElbowWristHand.ExternalRotationStrengthRight = GetAnsDesForAns(testId, 411);
            ElbowWristHand.ExternalRotationAROMLeftA = GetAnsDesForAns(testId, 412);
            ElbowWristHand.ExternalRotationPROMLeftP = GetAnsDesForAns(testId, 413);
            ElbowWristHand.ExternalRotationStrengthLeft = GetAnsDesForAns(testId, 414);
            ElbowWristHand.InternalRotationAROMRightA = GetAnsDesForAns(testId, 415);
            ElbowWristHand.InternalRotationPROMRightP = GetAnsDesForAns(testId, 416);
            ElbowWristHand.InternalRotationStrengthRight = GetAnsDesForAns(testId, 417);
            ElbowWristHand.InternalRotationAROMLeftA = GetAnsDesForAns(testId, 418);
            ElbowWristHand.InternalRotationPROMLeftP = GetAnsDesForAns(testId, 419);
            ElbowWristHand.InternalRotationStrengthLeft = GetAnsDesForAns(testId, 420);
            ElbowWristHand.HorizontalAbductionAROMRightA = GetAnsDesForAns(testId, 421);
            ElbowWristHand.HorizontalAbductionPROMRightP = GetAnsDesForAns(testId, 422);
            ElbowWristHand.HorizontalAbductionStrengthRight = GetAnsDesForAns(testId, 423);
            ElbowWristHand.HorizontalAbductionAROMLeftA = GetAnsDesForAns(testId, 424);

            ElbowWristHand.HorizontalAbductionPROMLeftP = GetAnsDesForAns(testId, 425);
            ElbowWristHand.HorizontalAbductionStrengthLeft = GetAnsDesForAns(testId, 426);
            ElbowWristHand.HorizontalAdductionAROMRightA = GetAnsDesForAns(testId, 427);
            ElbowWristHand.HorizontalAdductionPROMRightP = GetAnsDesForAns(testId, 428);
            ElbowWristHand.HorizontalAdductionStrengthRight = GetAnsDesForAns(testId, 429);
            ElbowWristHand.HorizontalAdductionAROMLeftA = GetAnsDesForAns(testId, 430);
            ElbowWristHand.HorizontalAdductionPROMLeftP = GetAnsDesForAns(testId, 431);
            ElbowWristHand.HorizontalAdductionStrengthLeft = GetAnsDesForAns(testId, 432);

            //finish table -1
            //table-2
            ElbowWristHand.POSTURE = GetAnsDesForAns(testId, 433);
            ElbowWristHand.PALPATION = GetAnsDesForAns(testId, 434);
            ElbowWristHand.GHAC = GetAnsDesForAns(testId, 435);
            ElbowWristHand.SCAPULARMOBILITY = GetAnsDesForAns(testId, 436);
            ElbowWristHand.SPECIALTESTS = GetAnsDesForAns(testId, 437);
            ElbowWristHand.OTHERFINDINGS = GetAnsDesForAns(testId, 438);






            ElbowWristHand.PatientName = GetAnsDesForAns(testId, 20) + " " + GetAnsDesForAns(testId, 21);
            ElbowWristHand.Dx_ICD_10 = GetAnsDesForAns(testId, 73);
            ElbowWristHand.Date = GetAnsDesForAns(testId, 74);
            ElbowWristHand.DOB = GetAnsDesForAns(testId, 23);
            ElbowWristHand.Therapist = GetAnsDesForAns(testId, 75);
            ElbowWristHand.Physician = GetAnsDesForAns(testId, 76);
            ElbowWristHand.NextMDApt = GetAnsDesForAns(testId, 77);
            ElbowWristHand.DateOnset = GetAnsDesForAns(testId, 78);
            ElbowWristHand.MOI = GetAnsDesForAns(testId, 79);
            ElbowWristHand.PreviousTreatment = GetAnsDesForAns(testId, 80);

            ElbowWristHand.DidItHelpStr = GetIdForAns(testId, 81);
            ElbowWristHand.DidItHelp = MakeSelectList(81, ElbowWristHand.DidItHelpStr);

            ElbowWristHand.History_ChiefComplaint = GetAnsDesForAns(testId, 82);
            ElbowWristHand.DiagnosticFindings = GetAnsDesForAns(testId, 83);
            ElbowWristHand.Meds = GetAnsDesForAns(testId, 84);
            ElbowWristHand.PastMedicalHistory = GetAnsDesForAns(testId, 85);
            ElbowWristHand.Surgeries1Type = GetAnsDesForAns(testId, 86);
            ElbowWristHand.Surgeries1Date = GetAnsDesForAns(testId, 87);
            ElbowWristHand.Surgeries2Type = GetAnsDesForAns(testId, 88);
            ElbowWristHand.Surgeries2Date = GetAnsDesForAns(testId, 89);
            ElbowWristHand.Surgeries3Type = GetAnsDesForAns(testId, 90);
            ElbowWristHand.Surgeries3Date = GetAnsDesForAns(testId, 91);
            ElbowWristHand.Occupation = GetAnsDesForAns(testId, 92);
            ElbowWristHand.PhysicalDemands = GetAnsDesForAns(testId, 93);

            ElbowWristHand.WorkStatusStr = GetIdForAns(testId, 94);
            ElbowWristHand.WorkStatus = MakeSelectList(94, ElbowWristHand.WorkStatusStr);

            ElbowWristHand.Reason = GetAnsDesForAns(testId, 95);

            ElbowWristHand.feet = GetAnsDesForAns(testId, 24) != string.Empty ? Int32.Parse(GetAnsDesForAns(testId, 24)) : 2; //24
            ElbowWristHand.inches = GetAnsDesForAns(testId, 25) != string.Empty ? Int32.Parse(GetAnsDesForAns(testId, 25)) : 0; //25
            ElbowWristHand.Weight = GetAnsDesForAns(testId, 27) != string.Empty ? Int32.Parse(GetAnsDesForAns(testId, 27)) : 2; //27

            ElbowWristHand.BMI = GetAnsDesForAns(testId, 101);

            ElbowWristHand.WhenWorse = GetAnsDesForAns(testId, 96);
            ElbowWristHand.WhenBetter = GetAnsDesForAns(testId, 97);
            ElbowWristHand.PainPresent = GetAnsDesForAns(testId, 98);
            ElbowWristHand.PainBest = GetAnsDesForAns(testId, 99);
            ElbowWristHand.PainWorst = GetAnsDesForAns(testId, 100);

            ElbowWristHand.QualityStr = GetIdForAns(testId, 102);
            ElbowWristHand.Quality = MakeSelectList(102, ElbowWristHand.QualityStr);

            //Table Data Left

            ElbowWristHand.FLEXIONAROM = GetAnsDesForAns(testId, 103);
            ElbowWristHand.FLEXIONPROM = GetAnsDesForAns(testId, 104);
            ElbowWristHand.FLEXIONTHORACICAROM = GetAnsDesForAns(testId, 105);
            ElbowWristHand.EXTENSIONAROM = GetAnsDesForAns(testId, 106);
            ElbowWristHand.EXTENSIONPROM = GetAnsDesForAns(testId, 107);
            ElbowWristHand.EXTENSIONTHORACICAROM = GetAnsDesForAns(testId, 108);
            ElbowWristHand.SIDEBENDRIGHTAROM = GetAnsDesForAns(testId, 109);
            ElbowWristHand.SIDEBENDRIGHTPROM = GetAnsDesForAns(testId, 110);
            ElbowWristHand.SIDEBENDRIGHTTHORACICAROM = GetAnsDesForAns(testId, 111);
            ElbowWristHand.SIDEBENDLEFTAROM = GetAnsDesForAns(testId, 112);
            ElbowWristHand.SIDEBENDLEFTPROM = GetAnsDesForAns(testId, 113);
            ElbowWristHand.SIDEBENDLEFTTHORACICAROM = GetAnsDesForAns(testId, 114);
            ElbowWristHand.ROTATERIGHTAROM = GetAnsDesForAns(testId, 115);
            ElbowWristHand.ROTATERIGHTPROM = GetAnsDesForAns(testId, 116);
            ElbowWristHand.ROTATERIGHTTHORACICAROM = GetAnsDesForAns(testId, 117);
            ElbowWristHand.ROTATELEFTAROM = GetAnsDesForAns(testId, 118);
            ElbowWristHand.ROTATELEFTPROM = GetAnsDesForAns(testId, 119);
            ElbowWristHand.ROTATELEFTTHORACICAROM = GetAnsDesForAns(testId, 120);


            ElbowWristHand.CervicalLordosisStr = GetIdForAns(testId, 121);
            ElbowWristHand.CervicalLordosis = MakeSelectList(121, ElbowWristHand.CervicalLordosisStr);
            ElbowWristHand.LumbarLordosisStr = GetIdForAns(testId, 122);
            ElbowWristHand.LumbarLordosis = MakeSelectList(122, ElbowWristHand.LumbarLordosisStr);
            ElbowWristHand.KyphosisStr = GetIdForAns(testId, 123);
            ElbowWristHand.Kyphosis = MakeSelectList(123, ElbowWristHand.KyphosisStr);
            ElbowWristHand.Scapulothoracic = GetAnsDesForAns(testId, 124);
            ElbowWristHand.Asymmetry = GetAnsDesForAns(testId, 125);
            ElbowWristHand.FirstRibStr = GetIdForAns(testId, 126);
            ElbowWristHand.FirstRib = MakeSelectList(126, ElbowWristHand.FirstRibStr);
            ElbowWristHand.NEURATTENSIONTESTINGStr = GetIdForAns(testId, 127);
            ElbowWristHand.NEURATTENSIONTESTING = MakeSelectList(127, ElbowWristHand.NEURATTENSIONTESTINGStr);

            //Table Data Right

            ElbowWristHand.UpperTrapStr = GetIdForAns(testId, 128);
            ElbowWristHand.UpperTrap = MakeSelectList(128, ElbowWristHand.UpperTrapStr);
            ElbowWristHand.MiddleTrapStr = GetIdForAns(testId, 129);
            ElbowWristHand.MiddleTrap = MakeSelectList(129, ElbowWristHand.MiddleTrapStr);
            ElbowWristHand.LowerTrapStr = GetIdForAns(testId, 130);
            ElbowWristHand.LowerTrap = MakeSelectList(130, ElbowWristHand.LowerTrapStr);
            ElbowWristHand.DeepNeckFlexorStr = GetIdForAns(testId, 131);
            ElbowWristHand.DeepNeckFlexor = MakeSelectList(131, ElbowWristHand.DeepNeckFlexorStr);
            ElbowWristHand.UEflexionStr = GetIdForAns(testId, 132);
            ElbowWristHand.UEflexion = MakeSelectList(132, ElbowWristHand.UEflexionStr);

            ElbowWristHand.HeadAcheStr = GetIdForAns(testId, 133);
            ElbowWristHand.HeadAche = MakeSelectList(133, ElbowWristHand.HeadAcheStr);
            ElbowWristHand.REFLEXESStr = GetIdForAns(testId, 134);
            ElbowWristHand.REFLEXES = MakeSelectList(134, ElbowWristHand.REFLEXESStr);
            ElbowWristHand.DERMATOMESStr = GetIdForAns(testId, 135);
            ElbowWristHand.DERMATOMES = MakeSelectList(135, ElbowWristHand.DERMATOMESStr);
            ElbowWristHand.RADICULARSYMPTOMSStr = GetIdForAns(testId, 136);
            ElbowWristHand.RADICULARSYMPTOMS = MakeSelectList(136, ElbowWristHand.RADICULARSYMPTOMSStr);

            ElbowWristHand.RADICULARSYMPTOMSOthers = GetAnsDesForAns(testId, 137);
            ElbowWristHand.RADICULARSYMPTOMSSite = GetAnsDesForAns(testId, 138);
            ElbowWristHand.RADICULARSYMPTOMSManualTraction = GetAnsDesForAns(testId, 139);


            ElbowWristHand.RepeatedMovementTestingStr = GetIdForAns(testId, 140);
            ElbowWristHand.RepeatedMovementTesting = MakeSelectList(140, ElbowWristHand.RepeatedMovementTestingStr);
            ElbowWristHand.SegmentalmobilityStr = GetIdForAns(testId, 141);
            ElbowWristHand.Segmentalmobility = MakeSelectList(141, ElbowWristHand.SegmentalmobilityStr);
            ElbowWristHand.UnderPain_TTPStr = GetIdForAns(testId, 253);
            ElbowWristHand.UnderPain_TTP = MakeSelectList(253, ElbowWristHand.UnderPain_TTPStr);

            ElbowWristHand.TriggerpointesnotedStr = GetIdForAns(testId, 142);
            ElbowWristHand.Triggerpointesnoted = MakeSelectList(142, ElbowWristHand.TriggerpointesnotedStr);
            ElbowWristHand.MusclelengthStr = GetIdForAns(testId, 143);
            ElbowWristHand.Musclelength = MakeSelectList(143, ElbowWristHand.MusclelengthStr);
            ElbowWristHand.WADDELLSSIGNStr = GetIdForAns(testId, 144);
            ElbowWristHand.WADDELLSSIGN = MakeSelectList(144, ElbowWristHand.WADDELLSSIGNStr);
            ElbowWristHand.OTHERFINDINGS_IMPAIRMENTSStr = GetIdForAns(testId, 145);
            ElbowWristHand.OTHERFINDINGS_IMPAIRMENTS = MakeSelectList(145, ElbowWristHand.OTHERFINDINGS_IMPAIRMENTSStr);

            ElbowWristHand.C1CervRotationStr = GetIdForAns(testId, 146);
            ElbowWristHand.C1CervRotation = MakeSelectList(146, ElbowWristHand.C1CervRotationStr);
            ElbowWristHand.C4ShldrShrugStr = GetIdForAns(testId, 147);
            ElbowWristHand.C4ShldrShrug = MakeSelectList(147, ElbowWristHand.C4ShldrShrugStr);
            ElbowWristHand.C5ShldrAbdStr = GetIdForAns(testId, 148);
            ElbowWristHand.C5ShldrAbd = MakeSelectList(148, ElbowWristHand.C5ShldrAbdStr);
            ElbowWristHand.C6WristExt_ElbflexStr = GetIdForAns(testId, 149);
            ElbowWristHand.C6WristExt_Elbflex = MakeSelectList(149, ElbowWristHand.C6WristExt_ElbflexStr);
            ElbowWristHand.C7Wristflex_ElbExtStr = GetIdForAns(testId, 150);
            ElbowWristHand.C7Wristflex_ElbExt = MakeSelectList(150, ElbowWristHand.C7Wristflex_ElbExtStr);
            ElbowWristHand.C8FingerFlexStr = GetIdForAns(testId, 151);
            ElbowWristHand.C8FingerFlex = MakeSelectList(151, ElbowWristHand.C8FingerFlexStr);
            ElbowWristHand.T1DigitalAdd_AbdStr = GetIdForAns(testId, 152);
            ElbowWristHand.T1DigitalAdd_Abd = MakeSelectList(152, ElbowWristHand.T1DigitalAdd_AbdStr);

            // List data
            ElbowWristHand.RehabPotentialStr = GetIdForAns(testId, 153);
            ElbowWristHand.RehabPotential = MakeSelectList(153, ElbowWristHand.RehabPotentialStr);
            ElbowWristHand.Goalstomet = GetAnsDesForAns(testId, 154);
            ElbowWristHand.Biometricscore = GetAnsDesForAns(testId, 155);

            ElbowWristHand.PainPresent = GetAnsDesForAns(testId, 98);
            ElbowWristHand.PainWorst = GetAnsDesForAns(testId, 100);

            ElbowWristHand.WNLtoimproveStr = GetIdForAns(testId, 156);
            ElbowWristHand.WNLtoimprove = MakeSelectList(156, ElbowWristHand.WNLtoimproveStr);
            ElbowWristHand.GoalsactivitiesStr = GetIdForAns(testId, 165);
            ElbowWristHand.Goalsactivities = MakeSelectList(165, ElbowWristHand.GoalsactivitiesStr);
            ElbowWristHand.functionalcapacityStr = GetIdForAns(testId, 157);
            ElbowWristHand.functionalcapacity = MakeSelectList(157, ElbowWristHand.functionalcapacityStr);

            ElbowWristHand.sitting = GetAnsDesForAns(testId, 158);



            ElbowWristHand.PlanofCareStr = GetIdForAns(testId, 161);
            ElbowWristHand.PlanofCare = MakeSelectList(161, ElbowWristHand.PlanofCareStr);
            ElbowWristHand.ModalitiesStr = GetIdForAns(testId, 162);
            ElbowWristHand.Modalities = MakeSelectList(162, ElbowWristHand.ModalitiesStr);
            ElbowWristHand._DryNeedling = GetAnsDesForAns(testId, 163);
            ElbowWristHand.AddDMEbox = GetAnsDesForAns(testId, 164);

            // List of Exercises

            //Table 1
            ElbowWristHand.TherapeuticExerciseTime = GetAnsDesForAns(testId, 168);
            ElbowWristHand.TherapeuticExerciseUnits = GetAnsDesForAns(testId, 169);
            ElbowWristHand.TherapeuticExercise1 = GetAnsDesForAns(testId, 170);
            ElbowWristHand.TherapeuticExercise2 = GetAnsDesForAns(testId, 171);
            ElbowWristHand.TherapeuticExercise3 = GetAnsDesForAns(testId, 172);
            ElbowWristHand.TherapeuticExerciseSet1 = GetAnsDesForAns(testId, 173);
            ElbowWristHand.TherapeuticExerciseSet2 = GetAnsDesForAns(testId, 174);
            ElbowWristHand.TherapeuticExerciseSet3 = GetAnsDesForAns(testId, 175);
            ElbowWristHand.TherapeuticExerciseRep1 = GetAnsDesForAns(testId, 176);
            ElbowWristHand.TherapeuticExerciseRep2 = GetAnsDesForAns(testId, 177);
            ElbowWristHand.TherapeuticExerciseRep3 = GetAnsDesForAns(testId, 178);
            ElbowWristHand.TherapeuticExerciseResistanc1 = GetAnsDesForAns(testId, 179);
            ElbowWristHand.TherapeuticExerciseResistanc2 = GetAnsDesForAns(testId, 180);
            ElbowWristHand.TherapeuticExerciseResistanc3 = GetAnsDesForAns(testId, 181);
            ElbowWristHand.TherapeuticExerciseComments1 = GetAnsDesForAns(testId, 182);
            ElbowWristHand.TherapeuticExerciseComments2 = GetAnsDesForAns(testId, 183);
            ElbowWristHand.TherapeuticExerciseComments3 = GetAnsDesForAns(testId, 184);

            //Table 2
            ElbowWristHand.TherapeuticActivityTime = GetAnsDesForAns(testId, 185);
            ElbowWristHand.TherapeuticActivityUnits = GetAnsDesForAns(testId, 186);
            ElbowWristHand.TherapeuticActivityExercise1 = GetAnsDesForAns(testId, 187);
            ElbowWristHand.TherapeuticActivityExercise2 = GetAnsDesForAns(testId, 188);
            ElbowWristHand.TherapeuticActivityExercise3 = GetAnsDesForAns(testId, 189);
            ElbowWristHand.TherapeuticActivitySet1 = GetAnsDesForAns(testId, 190);
            ElbowWristHand.TherapeuticActivitySet2 = GetAnsDesForAns(testId, 191);
            ElbowWristHand.TherapeuticActivitySet3 = GetAnsDesForAns(testId, 192);
            ElbowWristHand.TherapeuticActivityRep1 = GetAnsDesForAns(testId, 193);
            ElbowWristHand.TherapeuticActivityRep2 = GetAnsDesForAns(testId, 194);
            ElbowWristHand.TherapeuticActivityRep3 = GetAnsDesForAns(testId, 195);
            ElbowWristHand.TherapeuticActivityResistanc1 = GetAnsDesForAns(testId, 196);
            ElbowWristHand.TherapeuticActivityResistanc2 = GetAnsDesForAns(testId, 197);
            ElbowWristHand.TherapeuticActivityResistanc3 = GetAnsDesForAns(testId, 198);
            ElbowWristHand.TherapeuticActivityComments1 = GetAnsDesForAns(testId, 199);
            ElbowWristHand.TherapeuticActivityComments2 = GetAnsDesForAns(testId, 200);
            ElbowWristHand.TherapeuticActivityComments3 = GetAnsDesForAns(testId, 201);

            //Table 3
            ElbowWristHand.NeuromuscularReeducationTime = GetAnsDesForAns(testId, 202);
            ElbowWristHand.NeuromuscularReeducationUnits = GetAnsDesForAns(testId, 203);
            ElbowWristHand.NeuromuscularReeducationExercise1 = GetAnsDesForAns(testId, 204);
            ElbowWristHand.NeuromuscularReeducationExercise2 = GetAnsDesForAns(testId, 205);
            ElbowWristHand.NeuromuscularReeducationExercise3 = GetAnsDesForAns(testId, 206);
            ElbowWristHand.NeuromuscularReeducationSet1 = GetAnsDesForAns(testId, 207);
            ElbowWristHand.NeuromuscularReeducationSet2 = GetAnsDesForAns(testId, 208);
            ElbowWristHand.NeuromuscularReeducationSet3 = GetAnsDesForAns(testId, 209);
            ElbowWristHand.NeuromuscularReeducationRep1 = GetAnsDesForAns(testId, 210);
            ElbowWristHand.NeuromuscularReeducationRep2 = GetAnsDesForAns(testId, 211);
            ElbowWristHand.NeuromuscularReeducationRep3 = GetAnsDesForAns(testId, 212);
            ElbowWristHand.NeuromuscularReeducationResistanc1 = GetAnsDesForAns(testId, 213);
            ElbowWristHand.NeuromuscularReeducationResistanc2 = GetAnsDesForAns(testId, 214);
            ElbowWristHand.NeuromuscularReeducationResistanc3 = GetAnsDesForAns(testId, 215);
            ElbowWristHand.NeuromuscularReeducationComments1 = GetAnsDesForAns(testId, 216);
            ElbowWristHand.NeuromuscularReeducationComments2 = GetAnsDesForAns(testId, 217);
            ElbowWristHand.NeuromuscularReeducationComments3 = GetAnsDesForAns(testId, 218);

            //Others Exercise list

            ElbowWristHand.ManualTherapyTime = GetAnsDesForAns(testId, 219);
            ElbowWristHand.ManualTherapyUnits = GetAnsDesForAns(testId, 220);
            ElbowWristHand.ManualTherapyStr = GetIdForAns(testId, 221);
            ElbowWristHand.ManualTherapy = MakeSelectList(221, ElbowWristHand.ManualTherapyStr);
            ElbowWristHand.Suboccipitals_ope = GetAnsDesForAns(testId, 222);
            ElbowWristHand.Cervicalmobilizationsgrade = GetAnsDesForAns(testId, 223);
            ElbowWristHand.Cervicalmobilizationsopen = GetAnsDesForAns(testId, 224);
            ElbowWristHand.Thoracicmobilizationgrade = GetAnsDesForAns(testId, 225);
            ElbowWristHand.Thoracicmobilizationopen = GetAnsDesForAns(testId, 226);
            ElbowWristHand.SelfCareTime = GetAnsDesForAns(testId, 227);
            ElbowWristHand.SelfCareStr = GetIdForAns(testId, 228);
            ElbowWristHand.SelfCare = MakeSelectList(228, ElbowWristHand.SelfCareStr);

            ElbowWristHand.MechanicalTractionTime = GetAnsDesForAns(testId, 229);
            ElbowWristHand.MechanicalTractionConstant = GetAnsDesForAns(testId, 230);
            ElbowWristHand.ElectricalStimulationTime = GetAnsDesForAns(testId, 231);
            ElbowWristHand.ElectricalStimulationStr = GetIdForAns(testId, 232);
            ElbowWristHand.ElectricalStimulation = MakeSelectList(232, ElbowWristHand.ElectricalStimulationStr);

            ElbowWristHand.UltrasoundTime = GetAnsDesForAns(testId, 233);
            ElbowWristHand.UltrasoundLocation = GetAnsDesForAns(testId, 234);
            ElbowWristHand.UltrasoundMHz = GetAnsDesForAns(testId, 235);
            ElbowWristHand.UltrasoundW_cm2 = GetAnsDesForAns(testId, 236);
            ElbowWristHand.Hot_ColdPackTime = GetAnsDesForAns(testId, 237);

            ElbowWristHand.Hot_ColdPackStr = GetIdForAns(testId, 238);
            ElbowWristHand.Hot_ColdPack = MakeSelectList(238, ElbowWristHand.Hot_ColdPackStr);
            ElbowWristHand.Hot_ColdPackTotalTime = GetAnsDesForAns(testId, 239);
            ElbowWristHand.ManualElectricalStimStr = GetIdForAns(testId, 240);
            ElbowWristHand.ManualElectricalStim = MakeSelectList(240, ElbowWristHand.ManualElectricalStimStr);
            ElbowWristHand.ManualElectricalStimCPTcodes = GetAnsDesForAns(testId, 241);
            ElbowWristHand.ExerciseTimeIn = GetAnsDesForAns(testId, 242);
            ElbowWristHand.ExerciseTimeOut = GetAnsDesForAns(testId, 243);


            return View(ElbowWristHand);
        }
        [HttpPost]
        public ActionResult ElbowWristHandEvaluation(ElbowWristHandEvaluation model)
        {
            string testId = model.TestId;

            model.TestId = model.TestId;



            //checkbox
            model.Sensation = MakeSelectListfromList(444, model.SensationStr);
            insertTestAnswerTblList(testId, 444, model.SensationStr);

            model.Therapeuticexercise = MakeSelectListfromList(445, model.TherapeuticexerciseStr);
            insertTestAnswerTblList(testId, 445, model.TherapeuticexerciseStr);
            //radio
            model.DOMINANCE = MakeSelectList(446, model.DOMINANCEStr);
            insertTestAnswerTbl(testId, 446, model.DOMINANCEStr);


            //start-add
            insertTestAnswerTblDesc(testId, 447, model.FLEXIONAElbowRightROM);
            insertTestAnswerTblDesc(testId, 448, model.FLEXIONAElbowRightStrength);
            insertTestAnswerTblDesc(testId, 449, model.FLEXIONAElbowLeftRom);
            insertTestAnswerTblDesc(testId, 450, model.FLEXIONAElbowLeftStrength);
            insertTestAnswerTblDesc(testId, 451, model.ExtensionElbow1);
            insertTestAnswerTblDesc(testId, 452, model.ExtensionElbow2);
            insertTestAnswerTblDesc(testId, 453, model.ExtensionElbow3);
            insertTestAnswerTblDesc(testId, 454, model.ExtensionElbow4);
            insertTestAnswerTblDesc(testId, 455, model.SupinationElbow1);
            insertTestAnswerTblDesc(testId, 456, model.SupinationElbow2);
            insertTestAnswerTblDesc(testId, 457, model.SupinationElbow3);
            insertTestAnswerTblDesc(testId, 458, model.SupinationElbow4);
            insertTestAnswerTblDesc(testId, 459, model.PronationElbow1);
            insertTestAnswerTblDesc(testId, 460, model.PronationElbow2);
            insertTestAnswerTblDesc(testId, 461, model.PronationElbow3);
            insertTestAnswerTblDesc(testId, 462, model.PronationElbow4);
            insertTestAnswerTblDesc(testId, 463, model.FlexionWrist1);
            insertTestAnswerTblDesc(testId, 464, model.FlexionWrist2);
            insertTestAnswerTblDesc(testId, 465, model.FlexionWrist3);
            insertTestAnswerTblDesc(testId, 466, model.FlexionWrist4);
            insertTestAnswerTblDesc(testId, 467, model.ExtensionWrist1);
            insertTestAnswerTblDesc(testId, 468, model.ExtensionWrist2);
            insertTestAnswerTblDesc(testId, 469, model.ExtensionWrist3);
            insertTestAnswerTblDesc(testId, 470, model.ExtensionWrist4);
            insertTestAnswerTblDesc(testId, 471, model.Ulnar1);
            insertTestAnswerTblDesc(testId, 472, model.Ulnar2);
            insertTestAnswerTblDesc(testId, 473, model.Ulnar3);
            insertTestAnswerTblDesc(testId, 474, model.Ulnar4);
            insertTestAnswerTblDesc(testId, 475, model.Radial1);
            insertTestAnswerTblDesc(testId, 476, model.Radial2);
            insertTestAnswerTblDesc(testId, 477, model.Radial3);
            insertTestAnswerTblDesc(testId, 478, model.Radial4);
            insertTestAnswerTblDesc(testId, 479, model.CMCFlex1);
            insertTestAnswerTblDesc(testId, 480, model.CMCFlex2);
            insertTestAnswerTblDesc(testId, 481, model.CMCFlex3);
            insertTestAnswerTblDesc(testId, 482, model.CMCFlex4);
            insertTestAnswerTblDesc(testId, 483, model.CMCExt1);
            insertTestAnswerTblDesc(testId, 484, model.CMCExt2);
            insertTestAnswerTblDesc(testId, 485, model.CMCExt3);
            insertTestAnswerTblDesc(testId, 486, model.CMCExt4);
            insertTestAnswerTblDesc(testId, 487, model.CMCAbd1);
            insertTestAnswerTblDesc(testId, 488, model.CMCAbd2);
            insertTestAnswerTblDesc(testId, 489, model.CMCAbd3);
            insertTestAnswerTblDesc(testId, 490, model.CMCAbd4);
            insertTestAnswerTblDesc(testId, 491, model.Opposition1);
            insertTestAnswerTblDesc(testId, 492, model.Opposition2);
            insertTestAnswerTblDesc(testId, 493, model.Opposition3);
            insertTestAnswerTblDesc(testId, 494, model.Opposition4);
            insertTestAnswerTblDesc(testId, 495, model.MCPFlex1);
            insertTestAnswerTblDesc(testId, 496, model.MCPFlex2);
            insertTestAnswerTblDesc(testId, 497, model.MCPFlex3);
            insertTestAnswerTblDesc(testId, 498, model.MCPFlex4);
            insertTestAnswerTblDesc(testId, 499, model.MCPExt1);
            insertTestAnswerTblDesc(testId, 500, model.MCPExt2);
            insertTestAnswerTblDesc(testId, 501, model.MCPExt3);
            insertTestAnswerTblDesc(testId, 502, model.MCPExt4);
            insertTestAnswerTblDesc(testId, 503, model.IPFlex1);
            insertTestAnswerTblDesc(testId, 504, model.IPFlex2);
            insertTestAnswerTblDesc(testId, 505, model.IPFlex3);
            insertTestAnswerTblDesc(testId, 506, model.IPFlex4);
            insertTestAnswerTblDesc(testId, 507, model.IPExt1);
            insertTestAnswerTblDesc(testId, 508, model.IPExt2);
            insertTestAnswerTblDesc(testId, 509, model.IPExt3);
            insertTestAnswerTblDesc(testId, 510, model.IPExt4);
            insertTestAnswerTblDesc(testId, 511, model.MCPFlexDigits1);
            insertTestAnswerTblDesc(testId, 512, model.MCPFlexDigits2);
            insertTestAnswerTblDesc(testId, 513, model.MCPFlexDigits3);
            insertTestAnswerTblDesc(testId, 514, model.MCPFlexDigits4);
            insertTestAnswerTblDesc(testId, 515, model.MCPExtDigits1);
            insertTestAnswerTblDesc(testId, 516, model.MCPExtDigits2);
            insertTestAnswerTblDesc(testId, 517, model.MCPExtDigits3);
            insertTestAnswerTblDesc(testId, 518, model.MCPExtDigits4);
            insertTestAnswerTblDesc(testId, 519, model.MCPAbdDigits1);
            insertTestAnswerTblDesc(testId, 520, model.MCPAbdDigits2);
            insertTestAnswerTblDesc(testId, 521, model.MCPAbdDigits3);
            insertTestAnswerTblDesc(testId, 522, model.MCPAbdDigits4);
            insertTestAnswerTblDesc(testId, 523, model.PIPFlexDigits1);
            insertTestAnswerTblDesc(testId, 524, model.PIPFlexDigits2);
            insertTestAnswerTblDesc(testId, 525, model.PIPFlexDigits3);
            insertTestAnswerTblDesc(testId, 526, model.PIPFlexDigits4);
            insertTestAnswerTblDesc(testId, 527, model.PIPExtDigits1);
            insertTestAnswerTblDesc(testId, 528, model.PIPExtDigits2);
            insertTestAnswerTblDesc(testId, 529, model.PIPExtDigits3);
            insertTestAnswerTblDesc(testId, 530, model.PIPExtDigits4);
            insertTestAnswerTblDesc(testId, 531, model.DIPFlexDigits1);
            insertTestAnswerTblDesc(testId, 532, model.DIPFlexDigits2);
            insertTestAnswerTblDesc(testId, 533, model.DIPFlexDigits3);
            insertTestAnswerTblDesc(testId, 534, model.DIPFlexDigits4);
            insertTestAnswerTblDesc(testId, 535, model.DIPExtDigits1);
            insertTestAnswerTblDesc(testId, 536, model.DIPExtDigits2);
            insertTestAnswerTblDesc(testId, 537, model.DIPExtDigits3);
            insertTestAnswerTblDesc(testId, 538, model.DIPExtDigits4);
            insertTestAnswerTblDesc(testId, 539, model.GRIPRight);
            insertTestAnswerTblDesc(testId, 540, model.GRIPLeft);
            insertTestAnswerTblDesc(testId, 541, model.PINCHRight);
            insertTestAnswerTblDesc(testId, 542, model.PINCHLeft);

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