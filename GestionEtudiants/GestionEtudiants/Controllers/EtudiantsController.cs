using GestionEtudiants.Models;
using GestionEtudiants.Models.Repozitories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionEtudiants.Controllers
{
    public class EtudiantsController : Controller
    {
        private readonly IStoreEtudiants<Etudiants> etudiantRepository;

        public EtudiantsController(IStoreEtudiants<Etudiants> etudiantRepository)
        {
            this.etudiantRepository = etudiantRepository;
        }
        // GET: EtudiantsController
        public ActionResult Index()
        {
            var etudi = etudiantRepository.List();
            return View(etudi);
        }

        // GET: EtudiantsController/Details/5
        public ActionResult Details(int id)
        {
            var Et = etudiantRepository.List();
            return View(Et);
        }

        // GET: EtudiantsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EtudiantsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Etudiants etudiants)
        {
            try
            {
                etudiantRepository.Add(etudiants);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EtudiantsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EtudiantsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EtudiantsController/Delete/5
        public ActionResult Delete(int Id)
        {
            return View();
        }

        // POST: EtudiantsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int Id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
