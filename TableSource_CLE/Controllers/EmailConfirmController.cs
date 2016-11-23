using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PostmarkDotNet;
using System.Threading.Tasks;
using TableSource_CLE.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System.Net;

namespace TableSource_CLE.Controllers
{

    public class EmailConfirmController : Controller
    {
        //private ApplicationDbContext db = new ApplicationDbContext();
        //public async Task SendTestMessage()
        //{
        //    var message = new PostmarkMessage(int? id)
        //    {
        //        To = User.Identity.Name,
        //        Cc = db.Donations.Find(id),
        //        From = "account.admin@alexischandler.com",
        //        TrackOpens = true,
        //        Subject = "TableSource CLE: Donation Confirmation",
        //        TextBody = "Thank you for using TableSource, your pick-up information is: ",
        //        HtmlBody = "<html><body><img src=\"cid:embed_name.jpg\"/></body></html>",
        //        Tag = "New Year's Email Campaign"

        //    };
        //    var client = new PostmarkClient("fa8d86f7-930b-4ce1-8f9d-1dec86d91054");
        //    var sendResult = await client.SendMessageAsync(message);

        //    //if (sendResult.Status == PostmarkStatus.Success) { /* Handle success */ }
        //    if (sendResult.Status == PostmarkStatus.Success)
        //    {
        //        Console.WriteLine("Check your email");
        //    }
        //    else { /* Resolve issue.*/ }
        //}




        //// GET: Donations/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Donation donation = db.Donations.Find(id);
        //    if (donation == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(donation);
        //}

        //// POST: Donations/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Donation donation = db.Donations.Find(id);
        //    db.Donations.Remove(donation);
        //    db.SaveChanges();
        //    TempData["notice2"] = "Donation Claimed!";
        //    return RedirectToAction("Claim Donation", "SendTestMessage", "EmailConfirm");
        //}
    }
    }

