using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Models;
using BLL;

namespace WebGUI.Controllers
{
    public class CustomerController : Controller
    {
        private CustomerBLL ctrl = new CustomerBLL();

        // GET: Customer
        public ActionResult Index()
        {
            return View(ctrl.GetAll());
        }

        // GET: Customer/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = ctrl.GetById(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Address,PhoneNumber")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                ctrl.Create(customer);
                return RedirectToAction("Index");
            }

            return View(customer);
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = ctrl.GetById(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customer/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Address,PhoneNumber")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                ctrl.Edit(customer);
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = ctrl.GetById(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Customer customer = ctrl.GetById(id);
            ctrl.Delete(customer);
            return RedirectToAction("Index");
        }
    }
}
