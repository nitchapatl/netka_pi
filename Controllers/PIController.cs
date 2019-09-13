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
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add_PI()
        {
            var client = new FirebaseClient("https://netkapifirebase.firebaseio.com");

            

            return View();
        }

        [HttpPost]
        public async Task<ActionResult> add_pi_process(string Issue_No, string Originator_Name, string Date_Raised, string Item_Name, string Title, string Process, string Issue_Description)
        {
            var currentTimestamp = DateTime.UtcNow.ToString("MM/dd/yyyy HH:mm:ss");
            var addPIData = new AddPIData() {
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

            return RedirectToAction("Index", "PI");
        }

    }
}