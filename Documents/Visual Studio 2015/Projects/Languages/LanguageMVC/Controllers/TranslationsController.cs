using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Languages.Classes;
using Languages.DataModel;

namespace LanguageMVC.Controllers
{
    public class TranslationsController : Controller
    {
        private LanguagesContext db = new LanguagesContext();

        // GET: Translations
        public ActionResult Index()
        {
            return View(db.Translations.ToList());
        }

        // GET: Translations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Translations translations = db.Translations.Find(id);
            if (translations == null)
            {
                return HttpNotFound();
            }
            return View(translations);
        }

        // GET: Translations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Translations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,EnglishWord,SpanishWord,GermanWord,ItalianWord")] Translations translations)
        {
            if (ModelState.IsValid)
            {
                db.Translations.Add(translations);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(translations);
        }

        // GET: Translations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Translations translations = db.Translations.Find(id);
            if (translations == null)
            {
                return HttpNotFound();
            }
            return View(translations);
        }

        // POST: Translations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,EnglishWord,SpanishWord,GermanWord,ItalianWord")] Translations translations)
        {
            if (ModelState.IsValid)
            {
                db.Entry(translations).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(translations);
        }

        // GET: Translations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Translations translations = db.Translations.Find(id);
            if (translations == null)
            {
                return HttpNotFound();
            }
            return View(translations);
        }

        // POST: Translations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Translations translations = db.Translations.Find(id);
            db.Translations.Remove(translations);
            db.SaveChanges();
            return RedirectToAction("Index");
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
