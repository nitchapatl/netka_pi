using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using netka_pi.Models;
using Firebase.Database;
using Firebase.Database.Query;

namespace netka_pi.Controllers
{
    public class PIController : Controller
    {
        public async Task<ActionResult> Index()
        {

            var firebaseClient = new FirebaseClient("https://netkapifirebase.firebaseio.com");

            //get auto increment id issuelog_cnt from firebase
            var fbIssueLog_cnt = await firebaseClient
                .Child("IssueLog_auto")
                .OnceAsync<AutoIncrementIssueLog>();

            AutoIncrementIssueLog cnt = new AutoIncrementIssueLog();


            //Convert JSON data to original datatype
            foreach (var IssueLog_cnt in fbIssueLog_cnt)
            {
                cnt.IssueLog_cnt = (Convert.ToString(IssueLog_cnt.Object.IssueLog_cnt));
            }

            var recvIssueLog_List = new List<IssueLogData>();

            for (int i = 1; i <= Convert.ToInt32(cnt.IssueLog_cnt); i++)
            {
                var IssueLog = await firebaseClient
                .Child("IssueLog/" + i)
                .OnceAsync<IssueLogData>();


                foreach (var data in IssueLog)
                {

                    recvIssueLog_List.Add(new IssueLogData()
                    {
                        Issue_No = data.Object.Issue_No,
                        Title = data.Object.Title,
                        Originator_Name = data.Object.Originator_Name,
                        Date_Raised = data.Object.Date_Raised,
                        Date_Resolved = data.Object.Date_Resolved,
                        Item_Name = data.Object.Item_Name,
                        Issue_Description = data.Object.Issue_Description,
                        Process = data.Object.Process,
                        Category = data.Object.Category,
                        Severity = data.Object.Severity,
                        Status = data.Object.Status,
                        TimestampUtc = data.Object.TimestampUtc
                    });
                }

            }


            ViewBag.IssueLog = recvIssueLog_List;

            return View();
        }

        [HttpGet]
        public async Task<ActionResult> Add_PI()
        {
            var firebaseClient = new FirebaseClient("https://netkapifirebase.firebaseio.com");

            //get auto increment id issuelog_cnt from firebase
            var fbIssueLog_cnt = await firebaseClient
                .Child("IssueLog_auto")
                .OnceAsync<AutoIncrementIssueLog>();

            AutoIncrementIssueLog cnt = new AutoIncrementIssueLog();
            
            //Convert JSON data to original datatype
            foreach (var IssueLog_cnt in fbIssueLog_cnt)
            {
                cnt.IssueLog_cnt = Convert.ToString(Convert.ToInt64(IssueLog_cnt.Object.IssueLog_cnt) + 1);
                
            }

            ViewBag.new_issue_no = cnt.IssueLog_cnt;
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> add_pi_process(string Issue_No, string Originator_Name, string Date_Raised, string Item_Name, string Title, string Process, string Issue_Description)
        {
            var currentTimestamp = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            var addPIData = new IssueLogData() {
                Issue_No = Issue_No,
                Title = Title,
                Originator_Name = Originator_Name,
                Date_Raised = Date_Raised,
                Date_Resolved = null,
                Item_Name = Item_Name,
                Issue_Description = Issue_Description,
                Process = Process,
                Category = null,
                Severity = null,
                Status = "NEW",
                TimestampUtc = currentTimestamp
            };

            var firebaseClient = new FirebaseClient("https://netkapifirebase.firebaseio.com");
            var result = await firebaseClient
              .Child("IssueLog/" + Issue_No)
              .PostAsync(addPIData);

            await firebaseClient
              .Child("IssueLog_auto")
              .Child("id")
              .Child("IssueLog_cnt")
              .PutAsync(addPIData.Issue_No);

            return RedirectToAction("IssueLog", "PI");
        }
        
        public async Task<ActionResult> IssueLog()
        {
            var firebaseClient = new FirebaseClient("https://netkapifirebase.firebaseio.com");

            //get auto increment id issuelog_cnt from firebase
            var fbIssueLog_cnt = await firebaseClient
                .Child("IssueLog_auto")
                .OnceAsync<AutoIncrementIssueLog>();

            AutoIncrementIssueLog cnt = new AutoIncrementIssueLog();


            //Convert JSON data to original datatype
            foreach (var IssueLog_cnt in fbIssueLog_cnt)
            {
                cnt.IssueLog_cnt = (Convert.ToString(IssueLog_cnt.Object.IssueLog_cnt));
            }

            var recvIssueLog_List = new List<IssueLogData>();

            for (int i = 1; i <= Convert.ToInt32(cnt.IssueLog_cnt); i++)
            {
                var IssueLog = await firebaseClient
                .Child("IssueLog/" + i)
                .OnceAsync<IssueLogData>();


                foreach (var data in IssueLog)
                {

                    recvIssueLog_List.Add(new IssueLogData()
                    {
                        Issue_No = data.Object.Issue_No,
                        Title = data.Object.Title,
                        Originator_Name = data.Object.Originator_Name,
                        Date_Raised = data.Object.Date_Raised,
                        Date_Resolved = data.Object.Date_Resolved,
                        Item_Name = data.Object.Item_Name,
                        Issue_Description = data.Object.Issue_Description,
                        Process = data.Object.Process,
                        Category = data.Object.Category,
                        Severity = data.Object.Severity,
                        Status = data.Object.Status,
                        TimestampUtc = data.Object.TimestampUtc
                    });
                }

            }


            ViewBag.IssueLog = recvIssueLog_List;

            return View();
        }

    }
}