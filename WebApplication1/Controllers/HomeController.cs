using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    /// <summary>
    /// HomeController
    /// </summary>
    public class HomeController : Helper
    {
        FunctionalFormDataContext db = new FunctionalFormDataContext();

        /// <summary>
        /// Index
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// ExportPdf1
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult ExportPdf1(string id)
        {
            List<EmailData> lstemail = new List<EmailData>();
            lstemail.Add(new EmailData { FirstName = "JOhn", LastName = "Smith", Location = "Los Angeles" });



            ReportDocument report = new ReportDocument();
            report.Load(Path.Combine(Server.MapPath("~/Report"), "CrystalReport1.rpt"));
            report.SetDataSource(lstemail);


            Response.Buffer = false;
            Response.ClearContent();
            Response.ClearHeaders();

            Stream stream = report.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);

            stream.Seek(0, SeekOrigin.Begin);
            var rndValue = DateTime.Now.Millisecond;
            string dwName = string.Format("Report-{0}", rndValue);
            return File(stream, "application/pdf", dwName);
        }


        /// <summary>
        /// ExportPdf
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult ExportPdf(string id)
        {
            Medical model = new Medical();
            string testId = id;
            Medical medicalHistory = new Medical();

            medicalHistory.TestId = testId;

            //pain description
            medicalHistory.BestDescribesPainStr = GetIdForAns(testId, 1);
            medicalHistory.BestDescribesPain = MakeSelectList(1, medicalHistory.BestDescribesPainStr);

            medicalHistory.BestDescribesFrequencyPainStr = GetIdForAns(testId, 2);
            medicalHistory.BestDescribesFrequencyPain = MakeSelectList(2, medicalHistory.BestDescribesPainStr);

          //  medicalHistory.PainFeelWorseStr = GetIdForAns(testId, 3);
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
            medicalHistory.DateOfBirth = GetAnsDesForAns(testId, 23) != string.Empty ? DateTime.Parse(GetAnsDesForAns(testId, 23)) : DateTime.Now; //23
            medicalHistory.feet = GetAnsDesForAns(testId, 24) != string.Empty ? Int32.Parse(GetAnsDesForAns(testId, 24)) : 0; //24
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

            //report
            ReportDocument report = new ReportDocument();
            report.Load(Path.Combine(Server.MapPath("~/Report"), "CrystalReport1.rpt"));

            List<Medical> m = new List<Medical>();
            m.Add(medicalHistory);

            report.SetDataSource(m);

            //

            report.SetParameterValue("testId", testId);

            Response.Buffer = false;
            Response.ClearContent();
            Response.ClearHeaders();

            Stream stream = report.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);

            stream.Seek(0, SeekOrigin.Begin);
            var rndValue = DateTime.Now.Millisecond;
            string dwName = string.Format("Report-{0}", rndValue);
            return File(stream, "application/pdf", dwName);


        }
        public ActionResult Export(string id)
        {
            var q = from ans in db.TestAnswers
                    select new
                    {
                        Id = ans.Id,
                        TestId = ans.TestId ?? string.Empty,
                        QuestionId = ans.QuestionId,
                        AnswerId = ans.AnswerId ?? 0,
                        AnswerDesc = ans.AnswerDesc ?? string.Empty,
                    };

            //var q = from info in db.Answers
            //        select info;


            ReportDocument report = new ReportDocument();
            report.Load(Path.Combine(Server.MapPath("~/Report"), "CrystalReport1.rpt"));
            report.SetDataSource(q.ToList());

            report.SetParameterValue("Id", 32);

            Response.Buffer = false;
            Response.ClearContent();
            Response.ClearHeaders();

            Stream stream = report.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);

            stream.Seek(0, SeekOrigin.Begin);
            var rndValue = DateTime.Now.Millisecond;
            string dwName = string.Format("Report-{0}", rndValue);
            return File(stream, "application/pdf", dwName);
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}