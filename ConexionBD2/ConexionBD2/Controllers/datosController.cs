using ConexionBD2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConexionBD2.Controllers
{
    public class datosController : Controller
    {
        datosPersonalesContex obj = new datosPersonalesContex();

        // GET: datos
        public ActionResult Index()
        {
            return View(obj.datosPersonales.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(datosPersonales datosP)
        {
            if (ModelState.IsValid)
            {
                obj.datosPersonales.Add(datosP);
                obj.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(datosP);
        }
        public ActionResult Details(int Id)
        {
            var regitro = obj.datosPersonales.Find(Id);

            return View(regitro);
        }
        public ActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                return Content("<center><font color = 'red'><h1>Registro no encontrado</h1></font></center>");
            }
            var registro = obj.datosPersonales.Find(Id);
            return View(registro);
        }
        [HttpPost]
        public ActionResult Delete(int Id, datosPersonales datos)
        {
            var eliminar = obj.datosPersonales.Find(Id);
            obj.datosPersonales.Remove(eliminar);
            obj.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int? Id)
        {
            if (Id == null)
            {
                return Content("<center><font color = 'red'><h1>Registro no encontrado</h1></font></center>");
            }
            var registro = obj.datosPersonales.Find(Id);
            return View(registro);
        }
        [HttpPost]
        public ActionResult Edit(datosPersonales datos)
        {
            obj.Entry(datos).State = System.Data.Entity.EntityState.Modified;
            obj.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}