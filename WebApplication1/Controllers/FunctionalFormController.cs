using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class FunctionalFormController : Controller
    {
        // GET: FunctionalForm
        public ActionResult Index()
        {
            return View();
        }
        FunctionalFormDataContext db = new FunctionalFormDataContext();

        public string GetIdForAns(string testId, int qId)
        {

            var q = (from ans in db.TestAnswers
                     where ans.TestId == testId && ans.QuestionId == qId
                     select ans.AnswerId).FirstOrDefault();
            if (q != null)
            {
                return ((int)q).ToString();
            }
            else
                return string.Empty;
        }

        public string GetAnsDesForAns(string testId, int qId)
        {
            var q = (from ans in db.TestAnswers
                     where ans.TestId == testId && ans.QuestionId == qId
                     select ans.AnswerDesc).FirstOrDefault();
            if (q != null && q != string.Empty)
                return q;
            else
                return string.Empty;
        }
        public void insertTestAnswerTbl(string test_id, int question_id, string answerIDstr)
        {
            if (test_id != null && answerIDstr != null)
            {

                var q = from ans in db.TestAnswers
                        where ans.TestId == test_id && ans.QuestionId == question_id
                        select ans;

                //update
                if (q != null && q.Count() == 1)
                {
                    TestAnswer testAns = q.Single();
                    testAns.AnswerId = Int32.Parse(answerIDstr);
                }
                else 
                {
                    //insert
                    db.TestAnswers.InsertOnSubmit(new TestAnswer
                    {
                        TestId = test_id,
                        QuestionId = question_id,
                        AnswerId = Int32.Parse(answerIDstr)
                    });
                }
                try
                {
                    db.SubmitChanges();
                }
                catch (Exception e)
                {

                }
            }
            
        }

        public void insertTestAnswerTblDesc(string test_id, int question_id, string answeDescription)
        {
            if (test_id != null && answeDescription != null)
            {
                var q = from ans in db.TestAnswers
                        where ans.TestId == test_id && ans.QuestionId == question_id
                        select ans;

                //update
                if (q != null && q.Count() == 1)
                {
                    TestAnswer testAns = q.Single();
                    testAns.AnswerDesc = answeDescription;
                }
                else 
                {
                    //insert
                    db.TestAnswers.InsertOnSubmit(new TestAnswer
                    {
                        TestId = test_id,
                        QuestionId = question_id,
                        AnswerDesc = answeDescription
                    });
                }

            }
            try
            {
                db.SubmitChanges();
            }
            catch (Exception e)
            {

            }
        }


        public List<SelectListItem> MakeSelectList(int inputId, string inputValue)
        {
            var q = from ans in db.Answers
                    where ans.QuestionId == inputId
                    select ans;
            List<SelectListItem> ListItm = new List<SelectListItem>();


            if (q != null)
            {
                foreach (var item in q)
                {
                    if( item!=null && item.AnswerDesc != null &&  item.AnswerDesc!=string.Empty && item.Id.ToString() != string.Empty)
                    {
                        ListItm.Add(new SelectListItem
                        {
                            Text = item.AnswerDesc,
                            Value = item.Id.ToString(),
                            Selected = (item.Id.ToString() == inputValue) ? true : false
                        });
                    }

                }
            }

            return ListItm;
        }

        [HttpGet]
        public ActionResult Test(string id)
        {
            string testId = id;
            Medical medicalHistory = new Medical();

            medicalHistory.TestId = testId;

            //pain description
            medicalHistory.BestDescribesPainStr = GetIdForAns(testId, 1);
            medicalHistory.BestDescribesPain = MakeSelectList(1, medicalHistory.BestDescribesPainStr);

            medicalHistory.BestDescribesPainStr = GetIdForAns(testId, 2);
            medicalHistory.BestDescribesFrequencyPain = MakeSelectList(2, medicalHistory.BestDescribesPainStr);

            medicalHistory.BestDescribesPainStr = GetIdForAns(testId, 3);
            medicalHistory.PainFeelWorse = MakeSelectList(3, medicalHistory.BestDescribesPainStr);

            //5,6,7

            medicalHistory.BestDescribesPainrightNowStr = GetIdForAns(testId, 5);
            medicalHistory.BestDescribesPainrightNow = MakeSelectList(5, medicalHistory.BestDescribesPainrightNowStr);

            medicalHistory.WorstPainOverPastStr = GetIdForAns(testId, 6);
            medicalHistory.WorstPainOverPast = MakeSelectList(6, medicalHistory.WorstPainOverPastStr);

            medicalHistory.LeastPainOverPastStr = GetIdForAns(testId, 7);
            medicalHistory.LeastPainOverPast = MakeSelectList(7, medicalHistory.LeastPainOverPastStr);


            medicalHistory.makesPainFeelBetter = GetAnsDesForAns(testId, 4);



            //medical history
            medicalHistory.HistoryOfCancerStr = GetIdForAns(testId, 8);
            medicalHistory.HistoryOfCancer = MakeSelectList(8, medicalHistory.HistoryOfCancerStr);

            medicalHistory.PacemakerStr = GetIdForAns(testId, 9);
            medicalHistory.Pacemaker = MakeSelectList(9, medicalHistory.PacemakerStr);

            medicalHistory.HypertensionStr = GetIdForAns(testId, 10);
            medicalHistory.Hypertension = MakeSelectList(10, medicalHistory.HypertensionStr);

            medicalHistory.Bowel_bladderStr = GetIdForAns(testId, 11);
            medicalHistory.Bowel_bladder = MakeSelectList(11, medicalHistory.Bowel_bladderStr);

            medicalHistory.DiabeticStr = GetIdForAns(testId, 12);
            medicalHistory.Diabetic = MakeSelectList(12, medicalHistory.DiabeticStr);

            medicalHistory.PregnantStr = GetIdForAns(testId, 13);
            medicalHistory.Pregnant = MakeSelectList(13, medicalHistory.PregnantStr);


            medicalHistory.PastMedicalHistory = GetAnsDesForAns(testId, 14);

            //BIOGRAPHIC INFORMATION
            medicalHistory.SexStr = GetIdForAns(testId, 18);
            medicalHistory.Sex = MakeSelectList(18, medicalHistory.SexStr);

            medicalHistory.DominantHandStr = GetIdForAns(testId, 19);
            medicalHistory.DominantHand = MakeSelectList(19, medicalHistory.DominantHandStr);


            medicalHistory.FirstName = GetAnsDesForAns(testId, 20);  //20
            medicalHistory.LastName = GetAnsDesForAns(testId, 21); //21
            medicalHistory.Pin = GetAnsDesForAns(testId, 22) != string.Empty ? Int32.Parse(GetAnsDesForAns(testId, 22)) : 0; //22
            medicalHistory.DateOfBirth = GetAnsDesForAns(testId, 23) != string.Empty ? DateTime.Parse(GetAnsDesForAns(testId, 23)):DateTime.Now; //23
            medicalHistory.feet = GetAnsDesForAns(testId, 24) != string.Empty ? Int32.Parse(GetAnsDesForAns(testId, 24)) :0; //24
            medicalHistory.inches = GetAnsDesForAns(testId, 25) != string.Empty ? Int32.Parse(GetAnsDesForAns(testId, 25)) : 0; //25
            medicalHistory.Email = GetAnsDesForAns(testId, 26); //26
            medicalHistory.Weight = GetAnsDesForAns(testId, 27) != string.Empty ? Int32.Parse(GetAnsDesForAns(testId, 27)) : 0; //27
            medicalHistory.Today = GetAnsDesForAns(testId, 28) != string.Empty ? DateTime.Parse(GetAnsDesForAns(testId, 28)) : DateTime.Now;//28

            //PERSONAL HEALTH HISTORY
            medicalHistory.DoYouSmokeStr = GetIdForAns(testId, 29);
            medicalHistory.DoYouSmoke = MakeSelectList(29, medicalHistory.DoYouSmokeStr);

            medicalHistory.LastPhysicalExamStr = GetIdForAns(testId, 30);
            medicalHistory.LastPhysicalExam = MakeSelectList(30, medicalHistory.LastPhysicalExamStr);

            medicalHistory.ReachedMenopauseStr = GetIdForAns(testId, 31);
            medicalHistory.ReachedMenopause = MakeSelectList(31, medicalHistory.ReachedMenopauseStr);

            medicalHistory.PSATestWithinTheLastYearStr = GetIdForAns(testId, 32);
            medicalHistory.PSATestWithinTheLastYear = MakeSelectList(32, medicalHistory.PSATestWithinTheLastYearStr);

            medicalHistory.ThyroidDysfunctionStr = GetIdForAns(testId, 33);
            medicalHistory.ThyroidDysfunction = MakeSelectList(33, medicalHistory.ThyroidDysfunctionStr);

            medicalHistory.RheumatoidArthritisStr = GetIdForAns(testId, 34);
            medicalHistory.RheumatoidArthritis = MakeSelectList(34, medicalHistory.RheumatoidArthritisStr);

            medicalHistory.OsteoarthritisStr = GetIdForAns(testId, 35);
            medicalHistory.Osteoarthritis = MakeSelectList(35, medicalHistory.OsteoarthritisStr);

            medicalHistory.OsteoporosisStr = GetIdForAns(testId, 36);
            medicalHistory.Osteoporosis = MakeSelectList(36, medicalHistory.OsteoporosisStr);

            medicalHistory.CancerStr = GetIdForAns(testId, 37);
            medicalHistory.Cancer = MakeSelectList(37, medicalHistory.CancerStr);

            medicalHistory.StrokeStr = GetIdForAns(testId, 38);
            medicalHistory.Stroke = MakeSelectList(38, medicalHistory.StrokeStr);

            medicalHistory.HighCholesterolStr = GetIdForAns(testId, 39);
            medicalHistory.HighCholesterol = MakeSelectList(39, medicalHistory.HighCholesterolStr);

            medicalHistory.HighBloodPressureStr = GetIdForAns(testId, 40);
            medicalHistory.HighBloodPressure = MakeSelectList(40, medicalHistory.HighBloodPressureStr);

            medicalHistory.DiabetesPersonalHistoryStr = GetIdForAns(testId, 41);
            medicalHistory.DiabetesPersonalHistory = MakeSelectList(41, medicalHistory.DiabetesPersonalHistoryStr);

            //MEDICATIONS

            medicalHistory.OTCStr = GetIdForAns(testId, 42);
            medicalHistory.OTC = MakeSelectList(42, medicalHistory.OTCStr);

            medicalHistory.PrescriptionNonSteroidalStr = GetIdForAns(testId, 43);
            medicalHistory.PrescriptionNonSteroidal = MakeSelectList(43, medicalHistory.PrescriptionNonSteroidalStr);

            medicalHistory.NarcoticPainMedicationsStr = GetIdForAns(testId, 44);
            medicalHistory.NarcoticPainMedications = MakeSelectList(44, medicalHistory.NarcoticPainMedicationsStr);

            //SURGERY

            medicalHistory.HeadStr = GetIdForAns(testId, 45);
            medicalHistory.Head = MakeSelectList(45, medicalHistory.HeadStr);

            medicalHistory.CardiovascularPulmonaryStr = GetIdForAns(testId, 46);
            medicalHistory.CardiovascularPulmonary = MakeSelectList(46, medicalHistory.CardiovascularPulmonaryStr);

            medicalHistory.AbdominalStr = GetIdForAns(testId, 47);
            medicalHistory.Abdominal = MakeSelectList(47, medicalHistory.AbdominalStr);

            medicalHistory.GenitoUrinaryStr = GetIdForAns(testId, 48);
            medicalHistory.GenitoUrinary = MakeSelectList(48, medicalHistory.GenitoUrinaryStr);

            medicalHistory.SpineStr = GetIdForAns(testId, 49);
            medicalHistory.Spine = MakeSelectList(49, medicalHistory.SpineStr);

            medicalHistory.PastSurgeryHadPerformDailyActivitiesStr = GetIdForAns(testId, 57);
            medicalHistory.PastSurgeryHadPerformDailyActivities = MakeSelectList(57, medicalHistory.PastSurgeryHadPerformDailyActivitiesStr);




            //FAMILY HISTORY

            medicalHistory.DiabetesFamilyHistoryStr = GetIdForAns(testId, 50);
            medicalHistory.DiabetesFamilyHistory = MakeSelectList(50, medicalHistory.DiabetesFamilyHistoryStr);

            medicalHistory.ThyroidDysfunctionFamilyHistoryStr = GetIdForAns(testId, 51);
            medicalHistory.ThyroidDysfunctionFamilyHistory = MakeSelectList(51, medicalHistory.ThyroidDysfunctionFamilyHistoryStr);

            medicalHistory.RheumatoidArthritisLupusPsoriaticStr = GetIdForAns(testId, 52);
            medicalHistory.RheumatoidArthritisLupusPsoriatic = MakeSelectList(52, medicalHistory.RheumatoidArthritisLupusPsoriaticStr);

            medicalHistory.OsteoarthritisFamilyHistoryStr = GetIdForAns(testId, 53);
            medicalHistory.OsteoarthritisFamilyHistory = MakeSelectList(53, medicalHistory.OsteoarthritisFamilyHistoryStr);

            medicalHistory.OsteoporosisFamilyHistoryStr = GetIdForAns(testId, 54);
            medicalHistory.OsteoporosisFamilyHistory = MakeSelectList(54, medicalHistory.OsteoporosisFamilyHistoryStr);

            medicalHistory.CancerFamilyHistoryStr = GetIdForAns(testId, 55);
            medicalHistory.CancerFamilyHistory = MakeSelectList(55, medicalHistory.CancerFamilyHistoryStr);

            medicalHistory.StrokeFamilyHistoryStr = GetIdForAns(testId, 56);
            medicalHistory.StrokeFamilyHistory = MakeSelectList(56, medicalHistory.StrokeFamilyHistoryStr);


            //Oswestry Neck Pain Questionnaire
          

            medicalHistory.Section1Str = GetIdForAns(testId, 58);
            medicalHistory.Section1 = MakeSelectList(58, medicalHistory.Section1Str);

            medicalHistory.Section2Str = GetIdForAns(testId, 59);
            medicalHistory.Section2 = MakeSelectList(59, medicalHistory.Section2Str);

            medicalHistory.Section3Str = GetIdForAns(testId, 60);
            medicalHistory.Section3 = MakeSelectList(60, medicalHistory.Section3Str);

            medicalHistory.Section4Str = GetIdForAns(testId, 61);
            medicalHistory.Section4 = MakeSelectList(61, medicalHistory.Section4Str);

            medicalHistory.Section5Str = GetIdForAns(testId, 62);
            medicalHistory.Section5 = MakeSelectList(62, medicalHistory.Section5Str);

            medicalHistory.Section6Str = GetIdForAns(testId, 63);
            medicalHistory.Section6 = MakeSelectList(63, medicalHistory.Section6Str);

            medicalHistory.Section7Str = GetIdForAns(testId, 64);
            medicalHistory.Section7 = MakeSelectList(64, medicalHistory.Section7Str);

            medicalHistory.Section8Str = GetIdForAns(testId, 65);
            medicalHistory.Section8 = MakeSelectList(65, medicalHistory.Section8Str);

            medicalHistory.Section9Str = GetIdForAns(testId, 66);
            medicalHistory.Section9 = MakeSelectList(66, medicalHistory.Section9Str);

            medicalHistory.Section10Str = GetIdForAns(testId, 67);
            medicalHistory.Section10 = MakeSelectList(67, medicalHistory.Section10Str);

            medicalHistory.Section11Str = GetIdForAns(testId, 68);
            medicalHistory.Section11 = MakeSelectList(68, medicalHistory.Section11Str);

            medicalHistory.OswestryName = GetAnsDesForAns(testId, 69); //69
            medicalHistory.OswestryDate = GetAnsDesForAns(testId, 70) != string.Empty ? DateTime.Parse(GetAnsDesForAns(testId, 70)) : DateTime.Now; //70
            medicalHistory.OswestryOSWSCORE = GetAnsDesForAns(testId, 71); //71
            medicalHistory.OswestryPSCORE = GetAnsDesForAns(testId, 72); //12





            return View(medicalHistory);
        }

   
        [HttpPost]
        public ActionResult Test(Medical model)
        {
            //pain description

            model.BestDescribesPain = MakeSelectList(1, model.BestDescribesPainStr);
            model.BestDescribesFrequencyPain = MakeSelectList(2, model.BestDescribesPainStr);
            model.PainFeelWorse = MakeSelectList(3, model.BestDescribesPainStr);

            model.BestDescribesPainrightNow= MakeSelectList(5, model.BestDescribesPainrightNowStr);
            model.WorstPainOverPast = MakeSelectList(6, model.WorstPainOverPastStr);
            model.LeastPainOverPast = MakeSelectList(7, model.LeastPainOverPastStr);
            //medical history

            model.HistoryOfCancer = MakeSelectList(8, model.HistoryOfCancerStr);
            model.Pacemaker = MakeSelectList(9, model.PacemakerStr);
            model.Hypertension = MakeSelectList(10, model.HypertensionStr);
            model.Bowel_bladder = MakeSelectList(11, model.Bowel_bladderStr);
            model.Diabetic = MakeSelectList(12, model.DiabeticStr);
            model.Pregnant = MakeSelectList(13, model.PregnantStr);
            //BIOGRAPHIC INFORMATION;
            model.Sex = MakeSelectList(18, model.SexStr);
            model.DominantHand = MakeSelectList(19, model.DominantHandStr);

            //personal history


            model.DoYouSmoke = MakeSelectList(29, model.DoYouSmokeStr);
            model.LastPhysicalExam = MakeSelectList(30, model.LastPhysicalExamStr);
            model.ReachedMenopause = MakeSelectList(31, model.ReachedMenopauseStr);
            model.PSATestWithinTheLastYear = MakeSelectList(32, model.PSATestWithinTheLastYearStr);
            model.ThyroidDysfunction = MakeSelectList(33, model.ThyroidDysfunctionStr);
            model.RheumatoidArthritis = MakeSelectList(34, model.RheumatoidArthritisStr);
            model.Osteoarthritis = MakeSelectList(35, model.OsteoarthritisStr);
            model.Osteoporosis = MakeSelectList(36, model.OsteoporosisStr);
            model.Cancer = MakeSelectList(37, model.CancerStr);
            model.Stroke = MakeSelectList(38, model.StrokeStr);
            model.HighCholesterol = MakeSelectList(39, model.HighCholesterolStr);
            model.HighBloodPressure = MakeSelectList(40, model.HighBloodPressureStr);
            model.DiabetesPersonalHistory = MakeSelectList(41, model.DiabetesPersonalHistoryStr);

            //MEDICATIONS
            model.OTC = MakeSelectList(42, model.OTCStr);
            model.PrescriptionNonSteroidal = MakeSelectList(43, model.PrescriptionNonSteroidalStr);
            model.NarcoticPainMedications = MakeSelectList(44, model.NarcoticPainMedicationsStr);


            //SURGERY
       
            model.Head = MakeSelectList(45, model.HeadStr);
            model.CardiovascularPulmonary = MakeSelectList(46, model.CardiovascularPulmonaryStr);
            model.Abdominal = MakeSelectList(47, model.AbdominalStr);
            model.GenitoUrinary = MakeSelectList(48, model.GenitoUrinaryStr);
            model.Spine = MakeSelectList(49, model.SpineStr);
            model.PastSurgeryHadPerformDailyActivities = MakeSelectList(57, model.PastSurgeryHadPerformDailyActivitiesStr);



            //FAMILY HISTORY


            model.DiabetesFamilyHistory = MakeSelectList(50, model.DiabetesFamilyHistoryStr);
            model.ThyroidDysfunctionFamilyHistory = MakeSelectList(51, model.ThyroidDysfunctionFamilyHistoryStr);
            model.RheumatoidArthritisLupusPsoriatic = MakeSelectList(52, model.RheumatoidArthritisLupusPsoriaticStr);
            model.OsteoarthritisFamilyHistory = MakeSelectList(53, model.OsteoarthritisFamilyHistoryStr);
            model.OsteoporosisFamilyHistory = MakeSelectList(54, model.OsteoporosisFamilyHistoryStr);
            model.CancerFamilyHistory = MakeSelectList(55, model.CancerFamilyHistoryStr);
            model.StrokeFamilyHistory = MakeSelectList(56, model.StrokeFamilyHistoryStr);

            //Oswestry Neck Pain Questionnaire


            model.Section1 = MakeSelectList(58, model.Section1Str);
            model.Section2 = MakeSelectList(59, model.Section2Str);
            model.Section3 = MakeSelectList(60, model.Section3Str);
            model.Section4 = MakeSelectList(61, model.Section4Str);
            model.Section5 = MakeSelectList(62, model.Section5Str);
            model.Section6 = MakeSelectList(63, model.Section6Str);
            model.Section7 = MakeSelectList(64, model.Section7Str);
            model.Section8 = MakeSelectList(65, model.Section8Str);
            model.Section9 = MakeSelectList(66, model.Section9Str);
            model.Section10 = MakeSelectList(67, model.Section10Str);
            model.Section11 = MakeSelectList(68, model.Section11Str);

            

            if (!ModelState.IsValid)
            {
                return View(model);
            }
            //save into db
            string testId = model.TestId;
            //pain description
            insertTestAnswerTbl(testId, 1, model.BestDescribesPainStr);
            insertTestAnswerTbl(testId, 2, model.BestDescribesFrequencyPainStr);
            insertTestAnswerTbl(testId, 3, model.PainFeelWorseStr);

            insertTestAnswerTblDesc(testId, 4, model.makesPainFeelBetter);

            insertTestAnswerTbl(testId, 5, model.BestDescribesPainrightNowStr);
            insertTestAnswerTbl(testId, 6, model.WorstPainOverPastStr);
            insertTestAnswerTbl(testId, 7, model.LeastPainOverPastStr);



            //medical history

            insertTestAnswerTbl(testId, 8, model.HistoryOfCancerStr);
            insertTestAnswerTbl(testId, 9, model.PacemakerStr);
            insertTestAnswerTbl(testId, 10, model.HypertensionStr);
            insertTestAnswerTbl(testId, 11, model.Bowel_bladderStr);
            insertTestAnswerTbl(testId, 12, model.DiabeticStr);
            insertTestAnswerTbl(testId, 13, model.PregnantStr);

            insertTestAnswerTblDesc(testId, 14, model.makesPainFeelBetter);
            //BIOGRAPHIC INFORMATION

            insertTestAnswerTbl(testId, 18, model.SexStr);
            insertTestAnswerTbl(testId, 19, model.DominantHandStr);

            insertTestAnswerTblDesc(testId, 20, model.FirstName);
            insertTestAnswerTblDesc(testId, 21, model.LastName);
            insertTestAnswerTblDesc(testId, 22, model.Pin.ToString());
            insertTestAnswerTblDesc(testId, 23, model.DateOfBirth.ToString());
            insertTestAnswerTblDesc(testId, 24, model.feet.ToString());
            insertTestAnswerTblDesc(testId, 25, model.inches.ToString());
            insertTestAnswerTblDesc(testId, 26, model.Email);
            insertTestAnswerTblDesc(testId, 27, model.Weight.ToString());
            insertTestAnswerTblDesc(testId, 28, model.Today.ToString());

            //personal history


            insertTestAnswerTbl(testId, 29, model.DoYouSmokeStr);
            insertTestAnswerTbl(testId, 30, model.LastPhysicalExamStr);
            insertTestAnswerTbl(testId, 31, model.ReachedMenopauseStr);
            insertTestAnswerTbl(testId, 32, model.PSATestWithinTheLastYearStr);
            insertTestAnswerTbl(testId, 33, model.ThyroidDysfunctionStr);
            insertTestAnswerTbl(testId, 34, model.RheumatoidArthritisStr);
            insertTestAnswerTbl(testId, 35, model.OsteoarthritisStr);
            insertTestAnswerTbl(testId, 36, model.OsteoporosisStr);
            insertTestAnswerTbl(testId, 37, model.CancerStr);
            insertTestAnswerTbl(testId, 38, model.StrokeStr);
            insertTestAnswerTbl(testId, 39, model.HighCholesterolStr);
            insertTestAnswerTbl(testId, 40, model.HighBloodPressureStr);
            insertTestAnswerTbl(testId, 41, model.DiabetesPersonalHistoryStr);

            //MEDICATIONS
            insertTestAnswerTbl(testId, 42, model.OTCStr);
            insertTestAnswerTbl(testId, 43, model.PrescriptionNonSteroidalStr);
            insertTestAnswerTbl(testId, 44, model.NarcoticPainMedicationsStr);

            //SURGERY

            insertTestAnswerTbl(testId, 45, model.HeadStr);
            insertTestAnswerTbl(testId, 46, model.CardiovascularPulmonaryStr);
            insertTestAnswerTbl(testId, 47, model.AbdominalStr);
            insertTestAnswerTbl(testId, 48, model.GenitoUrinaryStr);
            insertTestAnswerTbl(testId, 49, model.SpineStr);
            insertTestAnswerTbl(testId, 57, model.PastSurgeryHadPerformDailyActivitiesStr);




            //FAMILY HISTORY

            insertTestAnswerTbl(testId, 50, model.DiabetesFamilyHistoryStr);
            insertTestAnswerTbl(testId, 51, model.ThyroidDysfunctionFamilyHistoryStr);
            insertTestAnswerTbl(testId, 52, model.RheumatoidArthritisLupusPsoriaticStr);
            insertTestAnswerTbl(testId, 53, model.OsteoarthritisFamilyHistoryStr);
            insertTestAnswerTbl(testId, 54, model.OsteoporosisFamilyHistoryStr);
            insertTestAnswerTbl(testId, 55, model.CancerFamilyHistoryStr);
            insertTestAnswerTbl(testId, 56, model.StrokeFamilyHistoryStr);



            //Oswestry Neck Pain Questionnaire

            insertTestAnswerTbl(testId, 58, model.Section1Str);
            insertTestAnswerTbl(testId, 59, model.Section2Str);
            insertTestAnswerTbl(testId, 60, model.Section3Str);
            insertTestAnswerTbl(testId, 61, model.Section4Str);
            insertTestAnswerTbl(testId, 62, model.Section5Str);
            insertTestAnswerTbl(testId, 63, model.Section6Str);
            insertTestAnswerTbl(testId, 64, model.Section7Str);
            insertTestAnswerTbl(testId, 65, model.Section8Str);
            insertTestAnswerTbl(testId, 66, model.Section9Str);
            insertTestAnswerTbl(testId, 67, model.Section10Str);
            insertTestAnswerTbl(testId, 68, model.Section11Str);

     

            insertTestAnswerTblDesc(testId, 69, model.OswestryName);
            insertTestAnswerTblDesc(testId, 70, model.OswestryDate.ToString());
            insertTestAnswerTblDesc(testId, 71, model.OswestryOSWSCORE);
            insertTestAnswerTblDesc(testId, 72, model.OswestryPSCORE);


            //load medical history
            return RedirectToAction("Index", "Home");
        }


    }
}