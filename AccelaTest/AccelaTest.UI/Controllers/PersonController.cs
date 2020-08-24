using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccelaTest.Application.Services;
using AccelaTest.Domain.Entities;
using AccelaTest.Domain.Interfaces.IServices;
using AccelaTest.UI.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AccelaTest.UI.Controllers
{
    public class PersonController : Controller
    {

        private IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        // GET: PersonController
        public ActionResult Index()
        {
            IList<Person> model = _personService.SelectAll();
            return View(model.ToList());
        }

        // GET: PersonController/Details/5
        public ActionResult Details(Guid id)
        {
            var model = _personService.Select(id);
            model.Address = AddressHelper.GetAddressList(id).ToList();
            return View(model);
        }

        // GET: PersonController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Person model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = _personService.Insert(model);
                    _personService.SaveChanges();
                    return RedirectToAction(nameof(Index));
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

        // GET: PersonController/Edit/5
        public ActionResult Edit(Guid id)
        {
            var model = _personService.Select(id);
            model.Address = AddressHelper.GetAddressList(id).ToList();
            return View(model);
        }

        // POST: PersonController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Person model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = _personService.Update(model);
                    _personService.SaveChanges();
                    return RedirectToAction(nameof(Index));
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

        // GET: PersonController/Delete/5
        public ActionResult Delete(Guid id)
        {
            _personService.Delete(id);
            _personService.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
