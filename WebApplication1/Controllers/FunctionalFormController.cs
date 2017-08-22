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
                    ListItm.Add(new SelectListItem
                    {
                        Text = item.AnswerDesc,
                        Value = item.Id.ToString(),
                        Selected = (item.Id.ToString() == inputValue) ? true : false
                    });

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
            medicalHistory.Today = GetAnsDesForAns(testId, 23) != string.Empty ? DateTime.Parse(GetAnsDesForAns(testId, 28)) : DateTime.Now;//28


            return View(medicalHistory);
        }

   
        [HttpPost]
        public ActionResult Test(Medical model)
        {
            //pain description

            model.BestDescribesPain = MakeSelectList(1, model.BestDescribesPainStr);
            model.BestDescribesFrequencyPain = MakeSelectList(2, model.BestDescribesPainStr);
            model.PainFeelWorse = MakeSelectList(3, model.BestDescribesPainStr);
            
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

            //load medical history
            return RedirectToAction("Index", "Home");
        }


    }
}