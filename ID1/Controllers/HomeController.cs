using ID1.Interface;
using ID1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ID1.Controllers
{
    public class HomeController : Controller
    {

        private IAnimal animal;
        private IZOO zoo;
        private Dog dog = new Dog();
        private Cat cat = new Cat();
        private Bird bird = new Bird();

        public Dog Dog
        {
            get
            {
                return dog;
            }

            set
            {
                dog = value;
            }
        }

        public Cat Cat
        {
            get
            {
                return cat;
            }

            set
            {
                cat = value;
            }
        }

        public Bird Bird
        {
            get
            {
                return bird;
            }

            set
            {
                bird = value;
            }
        }

        public void message(IAnimal a)
        {
            this.animal = a;
            ViewData["aaa"] = animal.getName();
            ViewData["voice"] = animal.getVoice();
        }



        //public void addAnimalToList(IAnimal a, IZOO listOfAnimals)
        //{
        //    animal = a;
        //    zoo = listOfAnimals;
        //    listOfAnimals.addToZOO(animal);
        //}

        public ActionResult Index()
        {
            //this.message(Dog);
           // this.message(Bird);

            return View();
        }
        public ActionResult Dogg()
        {
            this.message(dog);
            ViewBag.Message = "DOGggg";

            return View("Index");
        }
        public ActionResult Birdd()
        {
            this.message(bird);
            ViewBag.Message = "Birdddd";

            return View("Index");
        }

        public ActionResult Catt()
        {
            this.message(cat);
            ViewBag.Message = "Cattttt";

            return View("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}