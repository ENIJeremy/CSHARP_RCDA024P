using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TP2_PIZZA.Controllers
{
    public class PizzaController : Controller
    {

        static readonly List<Pizza> m_Pizzas = new List<Pizza>();
        // GET: Pizza
        public ActionResult Index()
        {
            return View(m_Pizzas);
        }

        // GET: Pizza/Details/5
        public ActionResult Details(int id)
        {

            Pizza l_pizza = m_Pizzas.Find(x => x.Id == id);
            return View(l_pizza);
        }

        // GET: Pizza/Create
        public ActionResult Create()
        {


            return View();
        }

        // POST: Pizza/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                var pizza = new Pizza();

                pizza.Nom = collection["Nom"];


                // TODO: Add insert logic here
                m_Pizzas.Add(pizza);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pizza/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Pizza/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                var pizza = m_Pizzas.Find(x => x.Id == id);
                pizza.Nom = collection["Nom"];
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pizza/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Pizza/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                m_Pizzas.Remove(m_Pizzas.Find(x => x.Id == id));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
