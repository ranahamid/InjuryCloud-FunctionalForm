using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class CervicalEvalController :  Helper
    {
        // GET: CervicalEval
        public ActionResult Index()
        {
            return View();
        }
        // GET: FunctionalForm
 
        FunctionalFormDataContext db = new FunctionalFormDataContext();

        [HttpGet]
        public ActionResult CernivalEval(string id)
        {
            string testId = id;


            CervicalEval cernivalEval = new CervicalEval();
            cernivalEval.TestId = testId;

            cernivalEval.PatientName = GetAnsDesForAns(testId, 20) + " " + GetAnsDesForAns(testId, 21);
            cernivalEval.Dx_ICD_10 = GetAnsDesForAns(testId, 73);
            cernivalEval.Date = GetAnsDesForAns(testId, 74);
            cernivalEval.DOB = GetAnsDesForAns(testId, 23);
            cernivalEval.Therapist = GetAnsDesForAns(testId, 75);
            cernivalEval.Physician = GetAnsDesForAns(testId, 76);
            cernivalEval.NextMDApt = GetAnsDesForAns(testId, 77);
            cernivalEval.DateOnset = GetAnsDesForAns(testId, 78);
            cernivalEval.MOI = GetAnsDesForAns(testId, 79);
            cernivalEval.PreviousTreatment = GetAnsDesForAns(testId, 80);

            cernivalEval.DidItHelpStr = GetIdForAns(testId, 81);
            cernivalEval.DidItHelp = MakeSelectList(81, cernivalEval.DidItHelpStr);

            cernivalEval.History_ChiefComplaint = GetAnsDesForAns(testId, 82);
            cernivalEval.DiagnosticFindings = GetAnsDesForAns(testId, 83);
            cernivalEval.Meds = GetAnsDesForAns(testId, 84);
            cernivalEval.PastMedicalHistory = GetAnsDesForAns(testId, 85);
            cernivalEval.Surgeries1Type = GetAnsDesForAns(testId, 86);
            cernivalEval.Surgeries1Date = GetAnsDesForAns(testId, 87);
            cernivalEval.Surgeries2Type = GetAnsDesForAns(testId, 88);
            cernivalEval.Surgeries2Date = GetAnsDesForAns(testId, 89);
            cernivalEval.Surgeries3Type = GetAnsDesForAns(testId, 90);
            cernivalEval.Surgeries3Date = GetAnsDesForAns(testId, 91);
            cernivalEval.Occupation = GetAnsDesForAns(testId, 92);
            cernivalEval.PhysicalDemands = GetAnsDesForAns(testId, 93);

            cernivalEval.WorkStatusStr = GetIdForAns(testId, 94);
            cernivalEval.WorkStatus = MakeSelectList(94, cernivalEval.WorkStatusStr);

            cernivalEval.Reason = GetAnsDesForAns(testId, 95);

            cernivalEval.feet = GetAnsDesForAns(testId, 24) != string.Empty ? Int32.Parse(GetAnsDesForAns(testId, 24)) : 2; //24
            cernivalEval.inches = GetAnsDesForAns(testId, 25) != string.Empty ? Int32.Parse(GetAnsDesForAns(testId, 25)) : 0; //25
            cernivalEval.Weight = GetAnsDesForAns(testId, 27) != string.Empty ? Int32.Parse(GetAnsDesForAns(testId, 27)) : 2; //27

            cernivalEval.BMI = GetAnsDesForAns(testId, 101);

            cernivalEval.WhenWorse = GetAnsDesForAns(testId, 96);
            cernivalEval.WhenBetter = GetAnsDesForAns(testId, 97);
            cernivalEval.PainPresent = GetAnsDesForAns(testId, 98);
            cernivalEval.PainBest = GetAnsDesForAns(testId, 99);
            cernivalEval.PainWorst = GetAnsDesForAns(testId, 100);

            cernivalEval.QualityStr = GetIdForAns(testId, 102);
            cernivalEval.Quality = MakeSelectList(102, cernivalEval.QualityStr);

            //Table Data Left

            cernivalEval.FLEXIONAROM = GetAnsDesForAns(testId, 103);
            cernivalEval.FLEXIONPROM = GetAnsDesForAns(testId, 104);
            cernivalEval.FLEXIONTHORACICAROM = GetAnsDesForAns(testId, 105);
            cernivalEval.EXTENSIONAROM = GetAnsDesForAns(testId, 106);
            cernivalEval.EXTENSIONPROM = GetAnsDesForAns(testId, 107);
            cernivalEval.EXTENSIONTHORACICAROM = GetAnsDesForAns(testId, 108);
            cernivalEval.SIDEBENDRIGHTAROM = GetAnsDesForAns(testId, 109);
            cernivalEval.SIDEBENDRIGHTPROM = GetAnsDesForAns(testId, 110);
            cernivalEval.SIDEBENDRIGHTTHORACICAROM = GetAnsDesForAns(testId, 111);
            cernivalEval.SIDEBENDLEFTAROM = GetAnsDesForAns(testId, 112);
            cernivalEval.SIDEBENDLEFTPROM = GetAnsDesForAns(testId, 113);
            cernivalEval.SIDEBENDLEFTTHORACICAROM = GetAnsDesForAns(testId, 114);
            cernivalEval.ROTATERIGHTAROM = GetAnsDesForAns(testId, 115);
            cernivalEval.ROTATERIGHTPROM = GetAnsDesForAns(testId, 116);
            cernivalEval.ROTATERIGHTTHORACICAROM = GetAnsDesForAns(testId, 117);
            cernivalEval.ROTATELEFTAROM = GetAnsDesForAns(testId, 118);
            cernivalEval.ROTATELEFTPROM = GetAnsDesForAns(testId, 119);
            cernivalEval.ROTATELEFTTHORACICAROM = GetAnsDesForAns(testId, 120);


            cernivalEval.CervicalLordosisStr = GetIdForAns(testId, 121);
            cernivalEval.CervicalLordosis = MakeSelectList(121, cernivalEval.CervicalLordosisStr);
            cernivalEval.LumbarLordosisStr = GetIdForAns(testId, 122);
            cernivalEval.LumbarLordosis = MakeSelectList(122, cernivalEval.LumbarLordosisStr);
            cernivalEval.KyphosisStr = GetIdForAns(testId, 123);
            cernivalEval.Kyphosis = MakeSelectList(123, cernivalEval.KyphosisStr);
            cernivalEval.Scapulothoracic = GetAnsDesForAns(testId, 124);
            cernivalEval.Asymmetry = GetAnsDesForAns(testId, 125);
            cernivalEval.FirstRibStr = GetIdForAns(testId, 126);
            cernivalEval.FirstRib = MakeSelectList(126, cernivalEval.FirstRibStr);
            cernivalEval.NEURATTENSIONTESTINGStr = GetIdForAns(testId, 127);
            cernivalEval.NEURATTENSIONTESTING = MakeSelectList(127, cernivalEval.NEURATTENSIONTESTINGStr);

            //Table Data Right

            cernivalEval.UpperTrapStr = GetIdForAns(testId, 128);
            cernivalEval.UpperTrap = MakeSelectList(128, cernivalEval.UpperTrapStr);
            cernivalEval.MiddleTrapStr = GetIdForAns(testId, 129);
            cernivalEval.MiddleTrap = MakeSelectList(129, cernivalEval.MiddleTrapStr);
            cernivalEval.LowerTrapStr = GetIdForAns(testId, 130);
            cernivalEval.LowerTrap = MakeSelectList(130, cernivalEval.LowerTrapStr);
            cernivalEval.DeepNeckFlexorStr = GetIdForAns(testId, 131);
            cernivalEval.DeepNeckFlexor = MakeSelectList(131, cernivalEval.DeepNeckFlexorStr);
            cernivalEval.UEflexionStr = GetIdForAns(testId, 132);
            cernivalEval.UEflexion = MakeSelectList(132, cernivalEval.UEflexionStr);

            cernivalEval.HeadAcheStr = GetIdForAns(testId, 133);
            cernivalEval.HeadAche = MakeSelectList(133, cernivalEval.HeadAcheStr);
            cernivalEval.REFLEXESStr = GetIdForAns(testId, 134);
            cernivalEval.REFLEXES = MakeSelectList(134, cernivalEval.REFLEXESStr);
            cernivalEval.DERMATOMESStr = GetIdForAns(testId, 135);
            cernivalEval.DERMATOMES = MakeSelectList(135, cernivalEval.DERMATOMESStr);
            cernivalEval.RADICULARSYMPTOMSStr = GetIdForAns(testId, 136);
            cernivalEval.RADICULARSYMPTOMS = MakeSelectList(136, cernivalEval.RADICULARSYMPTOMSStr);

            cernivalEval.RADICULARSYMPTOMSOthers = GetAnsDesForAns(testId, 137);
            cernivalEval.RADICULARSYMPTOMSSite = GetAnsDesForAns(testId, 138);
            cernivalEval.RADICULARSYMPTOMSManualTraction = GetAnsDesForAns(testId, 139);


            cernivalEval.RepeatedMovementTestingStr = GetIdForAns(testId, 140);
            cernivalEval.RepeatedMovementTesting = MakeSelectList(140, cernivalEval.RepeatedMovementTestingStr);
            cernivalEval.SegmentalmobilityStr = GetIdForAns(testId, 141);
            cernivalEval.Segmentalmobility = MakeSelectList(141, cernivalEval.SegmentalmobilityStr);
            cernivalEval.UnderPain_TTPStr = GetIdForAns(testId, 253);
            cernivalEval.UnderPain_TTP = MakeSelectList(253, cernivalEval.UnderPain_TTPStr);

            cernivalEval.TriggerpointesnotedStr = GetIdForAns(testId, 142);
            cernivalEval.Triggerpointesnoted = MakeSelectList(142, cernivalEval.TriggerpointesnotedStr);
            cernivalEval.MusclelengthStr = GetIdForAns(testId, 143);
            cernivalEval.Musclelength = MakeSelectList(143, cernivalEval.MusclelengthStr);
            cernivalEval.WADDELLSSIGNStr = GetIdForAns(testId, 144);
            cernivalEval.WADDELLSSIGN = MakeSelectList(144, cernivalEval.WADDELLSSIGNStr);
            cernivalEval.OTHERFINDINGS_IMPAIRMENTSStr = GetIdForAns(testId, 145);
            cernivalEval.OTHERFINDINGS_IMPAIRMENTS = MakeSelectList(145, cernivalEval.OTHERFINDINGS_IMPAIRMENTSStr);

            cernivalEval.C1CervRotationStr = GetIdForAns(testId, 146);
            cernivalEval.C1CervRotation = MakeSelectList(146, cernivalEval.C1CervRotationStr);
            cernivalEval.C4ShldrShrugStr = GetIdForAns(testId, 147);
            cernivalEval.C4ShldrShrug = MakeSelectList(147, cernivalEval.C4ShldrShrugStr);
            cernivalEval.C5ShldrAbdStr = GetIdForAns(testId, 148);
            cernivalEval.C5ShldrAbd = MakeSelectList(148, cernivalEval.C5ShldrAbdStr);
            cernivalEval.C6WristExt_ElbflexStr = GetIdForAns(testId, 149);
            cernivalEval.C6WristExt_Elbflex = MakeSelectList(149, cernivalEval.C6WristExt_ElbflexStr);
            cernivalEval.C7Wristflex_ElbExtStr = GetIdForAns(testId, 150);
            cernivalEval.C7Wristflex_ElbExt = MakeSelectList(150, cernivalEval.C7Wristflex_ElbExtStr);
            cernivalEval.C8FingerFlexStr = GetIdForAns(testId, 151);
            cernivalEval.C8FingerFlex = MakeSelectList(151, cernivalEval.C8FingerFlexStr);
            cernivalEval.T1DigitalAdd_AbdStr = GetIdForAns(testId, 152);
            cernivalEval.T1DigitalAdd_Abd = MakeSelectList(152, cernivalEval.T1DigitalAdd_AbdStr);

            // List data
            cernivalEval.RehabPotentialStr = GetIdForAns(testId, 153);
            cernivalEval.RehabPotential = MakeSelectList(153, cernivalEval.RehabPotentialStr);
            cernivalEval.Goalstomet = GetAnsDesForAns(testId, 154);
            cernivalEval.Biometricscore = GetAnsDesForAns(testId, 155);

            cernivalEval.PainPresent = GetAnsDesForAns(testId, 98);
            cernivalEval.PainWorst = GetAnsDesForAns(testId, 100);

            cernivalEval.WNLtoimproveStr = GetIdForAns(testId, 156);
            cernivalEval.WNLtoimprove = MakeSelectList(156, cernivalEval.WNLtoimproveStr);
            cernivalEval.GoalsactivitiesStr = GetIdForAns(testId, 165);
            cernivalEval.Goalsactivities = MakeSelectList(165, cernivalEval.GoalsactivitiesStr);
            cernivalEval.functionalcapacityStr = GetIdForAns(testId, 157);
            cernivalEval.functionalcapacity = MakeSelectList(157, cernivalEval.functionalcapacityStr);

            cernivalEval.sitting = GetAnsDesForAns(testId, 158);
            cernivalEval.PhysicalTherapyTime = GetAnsDesForAns(testId, 159);
            cernivalEval.xperweek = GetAnsDesForAns(testId, 160);

            cernivalEval.PlanofCareStr = GetIdForAns(testId, 161);
            cernivalEval.PlanofCare = MakeSelectList(161, cernivalEval.PlanofCareStr);
            cernivalEval.ModalitiesStr = GetIdForAns(testId, 162);
            cernivalEval.Modalities = MakeSelectList(162, cernivalEval.ModalitiesStr);
            cernivalEval._DryNeedling = GetAnsDesForAns(testId, 163);
            cernivalEval.AddDMEbox = GetAnsDesForAns(testId, 164);

            // List of Exercises

            //Table 1
            cernivalEval.TherapeuticExerciseTime = GetAnsDesForAns(testId, 168);
            cernivalEval.TherapeuticExerciseUnits = GetAnsDesForAns(testId, 169);
            cernivalEval.TherapeuticExercise1 = GetAnsDesForAns(testId, 170);
            cernivalEval.TherapeuticExercise2 = GetAnsDesForAns(testId, 171);
            cernivalEval.TherapeuticExercise3 = GetAnsDesForAns(testId, 172);
            cernivalEval.TherapeuticExerciseSet1 = GetAnsDesForAns(testId, 173);
            cernivalEval.TherapeuticExerciseSet2 = GetAnsDesForAns(testId, 174);
            cernivalEval.TherapeuticExerciseSet3 = GetAnsDesForAns(testId, 175);
            cernivalEval.TherapeuticExerciseRep1 = GetAnsDesForAns(testId, 176);
            cernivalEval.TherapeuticExerciseRep2 = GetAnsDesForAns(testId, 177);
            cernivalEval.TherapeuticExerciseRep3 = GetAnsDesForAns(testId, 178);
            cernivalEval.TherapeuticExerciseResistanc1 = GetAnsDesForAns(testId, 179);
            cernivalEval.TherapeuticExerciseResistanc2 = GetAnsDesForAns(testId, 180);
            cernivalEval.TherapeuticExerciseResistanc3 = GetAnsDesForAns(testId, 181);
            cernivalEval.TherapeuticExerciseComments1 = GetAnsDesForAns(testId, 182);
            cernivalEval.TherapeuticExerciseComments2 = GetAnsDesForAns(testId, 183);
            cernivalEval.TherapeuticExerciseComments3 = GetAnsDesForAns(testId, 184);

            //Table 2
            cernivalEval.TherapeuticActivityTime = GetAnsDesForAns(testId, 185);
            cernivalEval.TherapeuticActivityUnits = GetAnsDesForAns(testId, 186);
            cernivalEval.TherapeuticActivityExercise1 = GetAnsDesForAns(testId, 187);
            cernivalEval.TherapeuticActivityExercise2 = GetAnsDesForAns(testId, 188);
            cernivalEval.TherapeuticActivityExercise3 = GetAnsDesForAns(testId, 189);
            cernivalEval.TherapeuticActivitySet1 = GetAnsDesForAns(testId, 190);
            cernivalEval.TherapeuticActivitySet2 = GetAnsDesForAns(testId, 191);
            cernivalEval.TherapeuticActivitySet3 = GetAnsDesForAns(testId, 192);
            cernivalEval.TherapeuticActivityRep1 = GetAnsDesForAns(testId, 193);
            cernivalEval.TherapeuticActivityRep2 = GetAnsDesForAns(testId, 194);
            cernivalEval.TherapeuticActivityRep3 = GetAnsDesForAns(testId, 195);
            cernivalEval.TherapeuticActivityResistanc1 = GetAnsDesForAns(testId, 196);
            cernivalEval.TherapeuticActivityResistanc2 = GetAnsDesForAns(testId, 197);
            cernivalEval.TherapeuticActivityResistanc3 = GetAnsDesForAns(testId, 198);
            cernivalEval.TherapeuticActivityComments1 = GetAnsDesForAns(testId, 199);
            cernivalEval.TherapeuticActivityComments2 = GetAnsDesForAns(testId, 200);
            cernivalEval.TherapeuticActivityComments3 = GetAnsDesForAns(testId, 201);

            //Table 3
            cernivalEval.NeuromuscularReeducationTime = GetAnsDesForAns(testId, 202);
            cernivalEval.NeuromuscularReeducationUnits = GetAnsDesForAns(testId, 203);
            cernivalEval.NeuromuscularReeducationExercise1 = GetAnsDesForAns(testId, 204);
            cernivalEval.NeuromuscularReeducationExercise2 = GetAnsDesForAns(testId, 205);
            cernivalEval.NeuromuscularReeducationExercise3 = GetAnsDesForAns(testId, 206);
            cernivalEval.NeuromuscularReeducationSet1 = GetAnsDesForAns(testId, 207);
            cernivalEval.NeuromuscularReeducationSet2 = GetAnsDesForAns(testId, 208);
            cernivalEval.NeuromuscularReeducationSet3 = GetAnsDesForAns(testId, 209);
            cernivalEval.NeuromuscularReeducationRep1 = GetAnsDesForAns(testId, 210);
            cernivalEval.NeuromuscularReeducationRep2 = GetAnsDesForAns(testId, 211);
            cernivalEval.NeuromuscularReeducationRep3 = GetAnsDesForAns(testId, 212);
            cernivalEval.NeuromuscularReeducationResistanc1 = GetAnsDesForAns(testId, 213);
            cernivalEval.NeuromuscularReeducationResistanc2 = GetAnsDesForAns(testId, 214);
            cernivalEval.NeuromuscularReeducationResistanc3 = GetAnsDesForAns(testId, 215);
            cernivalEval.NeuromuscularReeducationComments1 = GetAnsDesForAns(testId, 216);
            cernivalEval.NeuromuscularReeducationComments2 = GetAnsDesForAns(testId, 217);
            cernivalEval.NeuromuscularReeducationComments3 = GetAnsDesForAns(testId, 218);

            //Others Exercise list

            cernivalEval.ManualTherapyTime = GetAnsDesForAns(testId, 219);
            cernivalEval.ManualTherapyUnits = GetAnsDesForAns(testId, 220);
            cernivalEval.ManualTherapyStr = GetIdForAns(testId, 221);
            cernivalEval.ManualTherapy = MakeSelectList(221, cernivalEval.ManualTherapyStr);
            cernivalEval.Suboccipitals_ope = GetAnsDesForAns(testId, 222);
            cernivalEval.Cervicalmobilizationsgrade = GetAnsDesForAns(testId, 223);
            cernivalEval.Cervicalmobilizationsopen = GetAnsDesForAns(testId, 224);
            cernivalEval.Thoracicmobilizationgrade = GetAnsDesForAns(testId, 225);
            cernivalEval.Thoracicmobilizationopen = GetAnsDesForAns(testId, 226);
            cernivalEval.SelfCareTime = GetAnsDesForAns(testId, 227);
            cernivalEval.SelfCareStr = GetIdForAns(testId, 228);
            cernivalEval.SelfCare = MakeSelectList(228, cernivalEval.SelfCareStr);

            cernivalEval.MechanicalTractionTime = GetAnsDesForAns(testId, 229);
            cernivalEval.MechanicalTractionConstant = GetAnsDesForAns(testId, 230);
            cernivalEval.ElectricalStimulationTime = GetAnsDesForAns(testId, 231);
            cernivalEval.ElectricalStimulationStr = GetIdForAns(testId, 232);
            cernivalEval.ElectricalStimulation = MakeSelectList(232, cernivalEval.ElectricalStimulationStr);

            cernivalEval.UltrasoundTime = GetAnsDesForAns(testId, 233);
            cernivalEval.UltrasoundLocation = GetAnsDesForAns(testId, 234);
            cernivalEval.UltrasoundMHz = GetAnsDesForAns(testId, 235);
            cernivalEval.UltrasoundW_cm2 = GetAnsDesForAns(testId, 236);
            cernivalEval.Hot_ColdPackTime = GetAnsDesForAns(testId, 237);

            cernivalEval.Hot_ColdPackStr = GetIdForAns(testId, 238);
            cernivalEval.Hot_ColdPack = MakeSelectList(238, cernivalEval.Hot_ColdPackStr);
            cernivalEval.Hot_ColdPackTotalTime = GetAnsDesForAns(testId, 239);
            cernivalEval.ManualElectricalStimStr = GetIdForAns(testId, 240);
            cernivalEval.ManualElectricalStim = MakeSelectList(240, cernivalEval.ManualElectricalStimStr);
            cernivalEval.ManualElectricalStimCPTcodes = GetAnsDesForAns(testId, 241);
            cernivalEval.ExerciseTimeIn = GetAnsDesForAns(testId, 242);
            cernivalEval.ExerciseTimeOut = GetAnsDesForAns(testId, 243);


            return View(cernivalEval);
        }
        [HttpPost]
        public ActionResult CernivalEval(CervicalEval model)
        {
            string testId = model.TestId;

            model.TestId = model.TestId;
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
            insertTestAnswerTblDesc(testId, 159, model.PhysicalTherapyTime);
            insertTestAnswerTblDesc(testId, 160, model.xperweek);

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