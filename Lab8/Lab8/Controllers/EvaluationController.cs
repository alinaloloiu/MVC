using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab8.Controllers
{
    public class EvaluationController : Controller
    {

        public static List<ProjectEvaluation> list = new List<ProjectEvaluation>
        {
            new ProjectEvaluation() {Name="Transilvania", City = "Cluj", Country="Romania", Rating= 10, Id=1},
            new ProjectEvaluation() {Name="Transilvania", City = "<script> alert('xss'); </script>", Country="Romania", Rating=7, Id=2 },
            new ProjectEvaluation() {Name="Transilvania", City = "ALba Iulia", Country="Romania", Rating= 8,Id=3 }
        };


        public ActionResult Index()
        {
            return View(list);
        }


        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Evaluation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Evaluation/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Evaluation/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Evaluation/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var evaluation = list.Single(e => e.Id == id);

            if (TryUpdateModel(evaluation))
            {
                return RedirectToAction("Index");
            }
            return View(evaluation);

            //try
            //{
            //    // TODO: Add update logic here

            //    return RedirectToAction("Index");
            //}
            //catch
            //{
            //    return View();
            //}
        }

        // GET: Evaluation/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Evaluation/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

