﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TableSource_CLE.CustomFilters;
using TableSource_CLE.Models;
using PostmarkDotNet;
using System.Threading.Tasks;


namespace TableSource_CLE.Controllers
{
    public class DonationsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
       

        // GET: Donations
        //Added authentication roles
        [AuthLog(Roles = "Recipient Organization, Donor Organization")]
        public ActionResult Index()
        {
            var donations = db.Donations.Include(d => d.Category);
            return View(donations.ToList());
        }

        // GET: Donations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Donation donation = db.Donations.Find(id);
            if (donation == null)
            {
                return HttpNotFound();
            }
            return View(donation);
        }

        // GET: Donations/Create
        //Added authentication roles
        [AuthLog(Roles = "Recipient Organization, Donor Organization")]
        public ActionResult Create()
        {
            ViewBag.categoryID = new SelectList(db.Categories, "categoryID", "categoryName");
            return View();
        }

        // POST: Donations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "donationID,type,pickUpDate,pickupTime,weight,ExpirationDate,organizationName,organizationAddress,organizationCity,organizationState,organizationZip,organizationPhone,organizationEmail,categoryID")] Donation donation)
        {
            try
            {
                db.Donations.Add(donation);
                db.SaveChanges();
                TempData["notice"] = "Successfully Donated!";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.categoryID = new SelectList(db.Categories, "categoryID", "categoryName", donation.categoryID);
                return View("Error", new HandleErrorInfo (ex, "Donation", "Create"));
            }
            //if (ModelState.IsValid)
            //{
            //    db.Donations.Add(donation);
            //    db.SaveChanges();
            //    TempData["notice"] = "Successfully Donated!";
            //    return RedirectToAction("Index");
            //}

            
        }

        // GET: Donations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Donation donation = db.Donations.Find(id);
            if (donation == null)
            {
                return HttpNotFound();
            }
            ViewBag.categoryID = new SelectList(db.Categories, "categoryID", "categoryName", donation.categoryID);
            return View(donation);
        }

        // POST: Donations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "donationID,type,pickUpDate,pickupTime,weight,ExpirationDate,organizationName,organizationAddress,organizationCity,organizationState,organizationZip,organizationPhone,organizationEmail,categoryID")] Donation donation)
        {
            //if (ModelState.IsValid)
            try
            {
                db.Entry(donation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception exception)
            {
                ViewBag.categoryID = new SelectList(db.Categories, "categoryID", "categoryName", donation.categoryID);
                return View("Error", new HandleErrorInfo(exception, "Donation", "Edit"));
                //return View(donation);
            }
        }



        // GET: Donations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Donation donation = db.Donations.Find(id);
            if (donation == null)
            {
                return HttpNotFound();
            }
            return View(donation);
        }

        // POST: Donations/Delete/5
        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Donation donation = db.Donations.Find(id);
            db.Donations.Remove(donation);
            db.SaveChanges();
           
            TempData["notice2"] = "Donation Claimed!";
            return RedirectToAction("SendTestMessage");
        }






        //Email Function

        public async Task<ActionResult> SendTestMessage(int? id)
        {

            if (!ModelState.IsValid)
            {
                
                var message = new PostmarkMessage()
                {

                    To = User.Identity.Name,
                    //Cc = donation.organizationEmail,
                    From = "account.admin@alexischandler.com",
                    TrackOpens = true,
                    Subject = "TableSource CLE: Donation Confirmation",
                    TextBody = "Thank you for using TableSource, your pick-up information is: ",
                    HtmlBody = "<html><body>Hello, thank you for donating! Here is your receipt:</body></html>",
                    Tag = "Welcome"


                };
                var client = new PostmarkClient("fa8d86f7-930b-4ce1-8f9d-1dec86d91054");
                var sendResult = await client.SendMessageAsync(message);
             
                //if (sendResult.Status == PostmarkStatus.Success) { /* Handle success */ }
                if (sendResult.Status == PostmarkStatus.Success)
                {
                    return RedirectToAction("Index");
                }
                else { /* Resolve issue.*/ }
            }
            return View();
        }




        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }





    }
}
