using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP.Models;

namespace TP1_CHATS.Controllers
{
    public class ChatController : Controller
    {

        List<Chat> model = Chat.GetMeuteDeChats();

        // GET: Chat
        public ActionResult Index()
        {
         

            return View(model);
        }

        // GET: Chat/Details/5
        public ActionResult Details(int id)
        {
            return View(model.Find(x => x.Id == id));
        }


        // GET: Chat/Delete/5
        public ActionResult Delete(int id)
        {

            return View();
        }

        // POST: Chat/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                bool b = model.Remove(model.Find(x => x.Id == id));

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
