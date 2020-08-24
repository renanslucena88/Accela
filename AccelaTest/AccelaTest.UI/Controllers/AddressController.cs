using AccelaTest.Domain.Entities;
using AccelaTest.Domain.Interfaces.IServices;
using AccelaTest.UI.Helpers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AccelaTest.UI.Controllers
{
    public class AddressController : Controller
    {
        private readonly IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        // GET: AddressController
        public ActionResult Index()
        {
            IList<Address> model = _addressService.SelectAll();
            return View(model.ToList().OrderBy(x => x.IdPerson));
        }

        // GET: AddressController/Details/5
        public ActionResult Details(Guid id)
        {
            var model = _addressService.Select(id);
            model.Person = PersonHelper.GetPerson(model.IdPerson);
            return View(model);
        }

        // GET: AddressController/Create
        public ActionResult Create(Guid id)
        {
            Address model = new Address();
            model.IdPerson = id;
            return View(model);
        }

        // POST: AddressController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Address model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model.Id = Guid.NewGuid();
                    var result = _addressService.Insert(model);
                    _addressService.SaveChanges();
                    return RedirectToAction("Details", "Person", new { id = model.IdPerson });
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: AddressController/Edit/5
        public ActionResult Edit(Guid id)
        {
            var model = _addressService.Select(id);
            model.Person = PersonHelper.GetPerson(model.IdPerson);
            return View(model);
        }

        // POST: AddressController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Address model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = _addressService.Update(model);
                    _addressService.SaveChanges();
                    return RedirectToAction("Details", "Person", new { id = model.IdPerson });
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: AddressController/Delete/5
        public ActionResult Delete(Guid id)
        {
            var result = _addressService.Delete(id);
            _addressService.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}