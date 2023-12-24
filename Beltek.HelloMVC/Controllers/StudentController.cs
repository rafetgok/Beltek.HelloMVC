using Beltek.HelloMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Beltek.HelloMVC.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("ListStudent");
        }
        [HttpGet] //sunucadan kullanıcaya getirilmesi işlemi için yazdık view getiriyor. Normalde varsayılan olarak vardır yazmasakta olur.
        public ViewResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(Ogrenci ogr)
        {
            using (var ctx = new OkulDbContext())
            {
                ctx.Ogrenciler.Add(ogr);
                ctx.SaveChanges();
            }
            return RedirectToAction("ListStudent"); //ekleme yaptıktan sonra direkt list studenta gönderir.
            //return View();
        }
        public IActionResult ListStudent()
        {
            List<Ogrenci> lst;

            using (var ctx = new OkulDbContext())
            {
                lst = ctx.Ogrenciler.ToList();
            }
            return View(lst);
        }

        public IActionResult DeleteStudent(int id)
        {
            using (var ctx = new OkulDbContext())
            {
                Ogrenci ogr = ctx.Ogrenciler.Find(id);
                ctx.Ogrenciler.Remove(ogr);
                ctx.SaveChanges();
            }
            return RedirectToAction("listStudent");
        }
        public IActionResult UpdateStudent(int id)
        {
            Ogrenci ogr;
            using (var ctx = new OkulDbContext())
            {
                ogr = ctx.Ogrenciler.Find(id);
            }

            return View(ogr);
        }
        [HttpPost] //post yazmazsak düzenle çalışmaz
        public IActionResult UpdateStudent(Ogrenci ogr)
        {
            using ( var ctx = new OkulDbContext())
            {
                ctx.Entry(ogr).State=EntityState.Modified;
                ctx.SaveChanges();  
            }
            return RedirectToAction("listStudent");
        }

    }
}
