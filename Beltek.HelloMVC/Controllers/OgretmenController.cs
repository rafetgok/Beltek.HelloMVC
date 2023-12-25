using Beltek.HelloMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Beltek.HelloMVC.Controllers
{
    public class OgretmenController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ViewResult AddTeacher()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult AddTeacher(Ogretmen ogrt)
        {
            using (var ctx = new OkulDbContext())
            {
                ctx.Ogretmenler.Add(ogrt);
                ctx.SaveChanges();
            }
            return RedirectToAction("ListTeacher");
            //return View();
        }


        public IActionResult ListTeacher()
        {

            List<Ogretmen> lst1;

            using (var ctx = new OkulDbContext())
            {
                lst1 = ctx.Ogretmenler.ToList();
            }
            return View(lst1);
        }

        public IActionResult DeleteStudent(string id) //bunun viewi yok çünkü return olarak silip liststudent döndüryor
        {
            using (var ctx = new OkulDbContext())
            {
                Ogretmen ogrt = ctx.Ogretmenler.Find(id);
                ctx.Ogretmenler.Remove(ogrt);
                ctx.SaveChanges();
            }
            return RedirectToAction("listTeacher");
        }



        public IActionResult UpdateTeacher(string id)
        {
            Ogretmen ogrt;
            using (var ctx = new OkulDbContext())
            {
                ogrt = ctx.Ogretmenler.Find(id);
            }
            return View(ogrt);
        }


        [HttpPost] //post yazmazsak düzenle çalışmaz
        public IActionResult UpdateStudent(Ogretmen ogrt)
        {
            using (var ctx = new OkulDbContext())

            {
                ctx.Entry(ogrt).State = EntityState.Modified;
                ctx.SaveChanges();
            }
            return RedirectToAction("listTeacher");
        }

    }
}
