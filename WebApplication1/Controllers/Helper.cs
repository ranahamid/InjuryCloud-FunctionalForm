using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
  

    public class Helper: Controller
    {

        FunctionalFormDataContext db = new FunctionalFormDataContext();

        //NEED TO ADD -1
        public List<string> GetIdListForAns(string testId, int qId)
        {

            var q = (from ans in db.TestAnswers
                     where ans.TestId == testId && ans.QuestionId == qId
                     select ans.AnswerId);

            List<string> stList=new List<string>();

            if (q != null)
            {         
                foreach(var itm in q)
                {
                    stList.Add(((int)itm).ToString());
                }
               
            }
           
            return stList;
        }
        //NEED TO ADD -2
        public void insertTestAnswerTblList(string test_id, int question_id, List<string> answerIDstr)
        {
            if (test_id != null )
            {
                //delete

                try
                {

                    db.TestAnswers.DeleteAllOnSubmit(from ans in db.TestAnswers
                                                     where ans.TestId == test_id
                                                     && ans.QuestionId == question_id
                                                     select ans);

                    db.SubmitChanges();
                }
                catch (Exception e)
                {

                }

                if(answerIDstr != null)
                {
                    //add
                    foreach (var item in answerIDstr)
                    {

                        db.TestAnswers.InsertOnSubmit(new TestAnswer
                        {
                            TestId = test_id,
                            QuestionId = question_id,
                            AnswerId = Int32.Parse(item),
                            AnswerDesc = string.Empty
                        });

                        try
                        {
                            db.SubmitChanges();
                        }
                        catch (Exception e)
                        {

                        }
                    }
                }
            }

        }
        //NEED TO ADD -3
        public List<SelectListItem> MakeSelectListfromList(int inputId, List<string> inputValue)
        {
            var q = from ans in db.AnswerTbls
                    where ans.QuestionId == inputId
                    select ans;
            List<SelectListItem> ListItm = new List<SelectListItem>();


            if (q != null)
            {
                foreach (var item in q)
                {
                    if (item != null && item.AnswerDesc != null)
                    {
                        ListItm.Add(new SelectListItem
                        {
                            Text = item.AnswerDesc,
                            Value = item.Id.ToString(),
                            Selected = (inputValue!=null && inputValue.Contains(item.Id.ToString())) ? true : false
                        });
                    }

                }
            }


            return ListItm;
        }







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
                    testAns.AnswerDesc = string.Empty;
                }
                else
                {
                    //insert
                    db.TestAnswers.InsertOnSubmit(new TestAnswer
                    {
                        TestId = test_id,
                        QuestionId = question_id,
                        AnswerId = Int32.Parse(answerIDstr),
                        AnswerDesc = string.Empty
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
                    testAns.AnswerId = 0;
                }
                else
                {
                    //insert
                    db.TestAnswers.InsertOnSubmit(new TestAnswer
                    {
                        TestId = test_id,
                        QuestionId = question_id,
                        AnswerDesc = answeDescription,
                        AnswerId=0
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
            var q = from ans in db.AnswerTbls
                    where ans.QuestionId == inputId
                    select ans;
            List<SelectListItem> ListItm = new List<SelectListItem>();


            if (q != null)
            {
                foreach (var item in q)
                {
                    if (item != null && item.AnswerDesc != null)
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



    }

   
    
}