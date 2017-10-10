using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TemporomandibularEvaluationController : Helper
    {
        // GET: TemporomandibularEvaluation
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult TemporomandibularEvaluation(string id)
        {
            string testId = id;

            TemporomandibularEvaluation Temporomandibular = new TemporomandibularEvaluation();
            Temporomandibular.TestId = testId;



            //checkbox
            Temporomandibular.TherapeuticexerciseStr = GetIdListForAns(testId, 577);
            Temporomandibular.Therapeuticexercise = MakeSelectListfromList(577, Temporomandibular.TherapeuticexerciseStr);

            Temporomandibular.SensationRightStr = GetIdListForAns(testId, 579);
            Temporomandibular.SensationRight = MakeSelectListfromList(579, Temporomandibular.SensationRightStr);


            Temporomandibular.SensationLeftStr = GetIdListForAns(testId, 580);
            Temporomandibular.SensationLeft = MakeSelectListfromList(580, Temporomandibular.SensationLeftStr);





            //radio
            Temporomandibular.HeadacheStr = GetIdForAns(testId, 581);
            Temporomandibular.Headache = MakeSelectList(581, Temporomandibular.HeadacheStr);

            Temporomandibular.MOUTHGUARDStr = GetIdForAns(testId, 582);
            Temporomandibular.MOUTHGUARD = MakeSelectList(582, Temporomandibular.MOUTHGUARDStr);

            Temporomandibular.TOOTHGRINDERStr = GetIdForAns(testId, 583);
            Temporomandibular.TOOTHGRINDER = MakeSelectList(583, Temporomandibular.TOOTHGRINDERStr);


            Temporomandibular.VocationalStr = GetIdForAns(testId, 584);
            Temporomandibular.Vocational = MakeSelectList(584, Temporomandibular.VocationalStr);

            //add
            Temporomandibular.Location = GetAnsDesForAns(testId, 585);
            Temporomandibular.Depression = GetAnsDesForAns(testId, 586);
            Temporomandibular.Anterior = GetAnsDesForAns(testId, 587);
            Temporomandibular.Lateralright = GetAnsDesForAns(testId, 588);
            Temporomandibular.Lateralleft = GetAnsDesForAns(testId, 589);
            Temporomandibular.CERVICALSHOULDER = GetAnsDesForAns(testId, 590);
            Temporomandibular.CRANIALNERVE = GetAnsDesForAns(testId, 591);
            Temporomandibular.descriptionNo4 = GetAnsDesForAns(testId, 592);


            
            //add
            Temporomandibular.Claim = GetAnsDesForAns(testId, 375);
            Temporomandibular.DateOfSurgery = GetAnsDesForAns(testId, 376);
            Temporomandibular.HR = GetAnsDesForAns(testId, 377);
            Temporomandibular.BP = GetAnsDesForAns(testId, 378);
            Temporomandibular.AssessmentDesc = GetAnsDesForAns(testId, 379);
            Temporomandibular.pulling = GetAnsDesForAns(testId, 380);
            Temporomandibular.descriptionNo5 = GetAnsDesForAns(testId, 381);

            Temporomandibular.UEFUNCTIONALINDEXSCORE = GetAnsDesForAns(testId, 382);




            //redefine
            Temporomandibular.PhysicalTherapyTime = GetAnsDesForAns(testId, 385);
            Temporomandibular.xperweek = GetAnsDesForAns(testId, 386);


            
            //finish table -1
            //table-2
            Temporomandibular.POSTURE = GetAnsDesForAns(testId, 433);
            Temporomandibular.PALPATION = GetAnsDesForAns(testId, 434);
            Temporomandibular.GHAC = GetAnsDesForAns(testId, 435);
            Temporomandibular.SCAPULARMOBILITY = GetAnsDesForAns(testId, 436);
            Temporomandibular.SPECIALTESTS = GetAnsDesForAns(testId, 437);
            Temporomandibular.OTHERFINDINGS = GetAnsDesForAns(testId, 438);






            Temporomandibular.PatientName = GetAnsDesForAns(testId, 20) + " " + GetAnsDesForAns(testId, 21);
            Temporomandibular.Dx_ICD_10 = GetAnsDesForAns(testId, 73);
            Temporomandibular.Date = GetAnsDesForAns(testId, 74);
            Temporomandibular.DOB = GetAnsDesForAns(testId, 23);
            Temporomandibular.Therapist = GetAnsDesForAns(testId, 75);
            Temporomandibular.Physician = GetAnsDesForAns(testId, 76);
            Temporomandibular.NextMDApt = GetAnsDesForAns(testId, 77);
            Temporomandibular.DateOnset = GetAnsDesForAns(testId, 78);
            Temporomandibular.MOI = GetAnsDesForAns(testId, 79);
            Temporomandibular.PreviousTreatment = GetAnsDesForAns(testId, 80);

            Temporomandibular.DidItHelpStr = GetIdForAns(testId, 81);
            Temporomandibular.DidItHelp = MakeSelectList(81, Temporomandibular.DidItHelpStr);

            Temporomandibular.History_ChiefComplaint = GetAnsDesForAns(testId, 82);
            Temporomandibular.DiagnosticFindings = GetAnsDesForAns(testId, 83);
            Temporomandibular.Meds = GetAnsDesForAns(testId, 84);
            Temporomandibular.PastMedicalHistory = GetAnsDesForAns(testId, 85);
            Temporomandibular.Surgeries1Type = GetAnsDesForAns(testId, 86);
            Temporomandibular.Surgeries1Date = GetAnsDesForAns(testId, 87);
            Temporomandibular.Surgeries2Type = GetAnsDesForAns(testId, 88);
            Temporomandibular.Surgeries2Date = GetAnsDesForAns(testId, 89);
            Temporomandibular.Surgeries3Type = GetAnsDesForAns(testId, 90);
            Temporomandibular.Surgeries3Date = GetAnsDesForAns(testId, 91);
            Temporomandibular.Occupation = GetAnsDesForAns(testId, 92);
            Temporomandibular.PhysicalDemands = GetAnsDesForAns(testId, 93);

            Temporomandibular.WorkStatusStr = GetIdForAns(testId, 94);
            Temporomandibular.WorkStatus = MakeSelectList(94, Temporomandibular.WorkStatusStr);

            Temporomandibular.Reason = GetAnsDesForAns(testId, 95);
            
            Temporomandibular.WhenWorse = GetAnsDesForAns(testId, 96);
            Temporomandibular.WhenBetter = GetAnsDesForAns(testId, 97);
            Temporomandibular.PainPresent = GetAnsDesForAns(testId, 98);
            Temporomandibular.PainBest = GetAnsDesForAns(testId, 99);
            Temporomandibular.PainWorst = GetAnsDesForAns(testId, 100);

            Temporomandibular.QualityStr = GetIdForAns(testId, 102);
            Temporomandibular.Quality = MakeSelectList(102, Temporomandibular.QualityStr);
            
            // List data
            Temporomandibular.RehabPotentialStr = GetIdForAns(testId, 153);
            Temporomandibular.RehabPotential = MakeSelectList(153, Temporomandibular.RehabPotentialStr);
            Temporomandibular.Goalstomet = GetAnsDesForAns(testId, 154);
            Temporomandibular.PainPresent = GetAnsDesForAns(testId, 98);
            Temporomandibular.PainWorst = GetAnsDesForAns(testId, 100);
            return View(Temporomandibular);
        }
        [HttpPost]
        public ActionResult TemporomandibularEvaluation(TemporomandibularEvaluation model)
        {
            string testId = model.TestId;

            model.TestId = model.TestId;

            //checkbox
            model.Therapeuticexercise = MakeSelectListfromList(577, model.TherapeuticexerciseStr);
            insertTestAnswerTblList(testId, 577, model.TherapeuticexerciseStr);

            model.SensationRight = MakeSelectListfromList(579, model.SensationRightStr);
            insertTestAnswerTblList(testId, 579, model.SensationRightStr);

            model.SensationLeft = MakeSelectListfromList(580, model.SensationLeftStr);
            insertTestAnswerTblList(testId, 580, model.SensationLeftStr);

            //radio
            model.Headache = MakeSelectList(581, model.HeadacheStr);
            insertTestAnswerTbl(testId, 581, model.HeadacheStr);

            model.MOUTHGUARD = MakeSelectList(582, model.MOUTHGUARDStr);
            insertTestAnswerTbl(testId, 582, model.MOUTHGUARDStr);

            model.TOOTHGRINDER = MakeSelectList(583, model.TOOTHGRINDERStr);
            insertTestAnswerTbl(testId, 583, model.TOOTHGRINDERStr);


            model.Vocational = MakeSelectList(584, model.VocationalStr);
            insertTestAnswerTbl(testId, 584, model.VocationalStr);

            //string

            insertTestAnswerTblDesc(testId, 585, model.Location);
            insertTestAnswerTblDesc(testId, 586, model.Depression);
            insertTestAnswerTblDesc(testId, 587, model.Anterior);
            insertTestAnswerTblDesc(testId, 588, model.Lateralright);
            insertTestAnswerTblDesc(testId, 589, model.Lateralleft);
            insertTestAnswerTblDesc(testId, 590, model.CERVICALSHOULDER);
            insertTestAnswerTblDesc(testId, 591, model.CRANIALNERVE);
            insertTestAnswerTblDesc(testId, 592, model.descriptionNo4);

            ////////finish

            //checkbox
            model.Sensation = MakeSelectListfromList(444, model.SensationStr);
            insertTestAnswerTblList(testId, 446, model.SensationStr);

            //radio
            model.DOMINANCE = MakeSelectList(446, model.DOMINANCEStr);
            insertTestAnswerTbl(testId, 446, model.DOMINANCEStr);



            //done
            insertTestAnswerTblDesc(testId, 382, model.UEFUNCTIONALINDEXSCORE);
          
            insertTestAnswerTblDesc(testId, 381, model.descriptionNo5);

            insertTestAnswerTblDesc(testId, 380, model.pulling);

            insertTestAnswerTblDesc(testId, 379, model.AssessmentDesc);
            
            insertTestAnswerTblDesc(testId, 376, model.DateOfSurgery);
            insertTestAnswerTblDesc(testId, 375, model.Claim);

            //redefine
            insertTestAnswerTblDesc(testId, 385, model.PhysicalTherapyTime);
            insertTestAnswerTblDesc(testId, 386, model.xperweek);




            //table-2
            insertTestAnswerTblDesc(testId, 433, model.POSTURE);
            insertTestAnswerTblDesc(testId, 434, model.PALPATION);
            insertTestAnswerTblDesc(testId, 435, model.GHAC);
            insertTestAnswerTblDesc(testId, 436, model.SCAPULARMOBILITY);
            insertTestAnswerTblDesc(testId, 437, model.SPECIALTESTS);
            insertTestAnswerTblDesc(testId, 438, model.OTHERFINDINGS);
            //end of table -2



           
            insertTestAnswerTblDesc(testId, 73, model.Dx_ICD_10);
            insertTestAnswerTblDesc(testId, 74, model.Date);
            insertTestAnswerTblDesc(testId, 23, model.DOB);
            insertTestAnswerTblDesc(testId, 75, model.Therapist);
            insertTestAnswerTblDesc(testId, 76, model.Physician);
            insertTestAnswerTblDesc(testId, 77, model.NextMDApt);
            insertTestAnswerTblDesc(testId, 78, model.DateOnset);
            insertTestAnswerTblDesc(testId, 79, model.MOI);
            insertTestAnswerTblDesc(testId, 80, model.PreviousTreatment);

           
            insertTestAnswerTblDesc(testId, 82, model.History_ChiefComplaint);
            insertTestAnswerTblDesc(testId, 83, model.DiagnosticFindings);
            insertTestAnswerTblDesc(testId, 84, model.Meds);
            insertTestAnswerTblDesc(testId, 85, model.PastMedicalHistory);
           

            insertTestAnswerTblDesc(testId, 92, model.Occupation);
            insertTestAnswerTblDesc(testId, 93, model.PhysicalDemands);

            model.WorkStatus = MakeSelectList(94, model.WorkStatusStr);
            insertTestAnswerTbl(testId, 94, model.WorkStatusStr);

            insertTestAnswerTblDesc(testId, 95, model.Reason);
            

            insertTestAnswerTblDesc(testId, 96, model.WhenWorse);
            insertTestAnswerTblDesc(testId, 97, model.WhenBetter);
            insertTestAnswerTblDesc(testId, 98, model.PainPresent);
            insertTestAnswerTblDesc(testId, 99, model.PainBest);
            insertTestAnswerTblDesc(testId, 100, model.PainWorst);

            model.Quality = MakeSelectList(94, model.QualityStr);
            insertTestAnswerTbl(testId, 94, model.QualityStr);

            



            //List data
            model.RehabPotential = MakeSelectList(153, model.RehabPotentialStr);
            insertTestAnswerTbl(testId, 153, model.RehabPotentialStr);
            insertTestAnswerTblDesc(testId, 154, model.Goalstomet);
           


            return RedirectToAction("DailyNoteCervical", "Intake", new { id = model.TestId });
            //return RedirectToAction("PatientList", "Intake");
        }




    }
}