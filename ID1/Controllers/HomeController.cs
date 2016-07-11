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
        private IAnimal ianimal;
        private IZOO izoo;
        private Dog dog;
        private Cat cat;
        private Bird bird;
        private ZOO zoo;

        Dog dogO = new Dog();
        Bird birdO = new Bird();
        Cat catO = new Cat();
        ZOO zooO = new ZOO();

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

        public ZOO Zoo
        {
            get
            {
                return zoo;
            }

            set
            {
                zoo = value;
            }
        }

        public HomeController()
        {
            this.Dog = dogO;
            this.Bird = birdO;
            this.Cat = catO;
            this.Zoo = zooO;
        }

        public void message(IAnimal a)
        {
            this.ianimal = a;
            ViewData["aaa"] = ianimal.getName();
            ViewData["voice"] = ianimal.getVoice();
        }

        public void addAnimalToList(IZOO z, IAnimal a) 
        {
            ianimal = a;
            izoo = z;
            z.addToZOO(ianimal);
        }

        public void giveInformation(IZOO z)
        {
            izoo = z; //nie wykorzystywane
            ViewData["count"] = zoo.listOfAnimal.Count;
            ViewData["list"] = zoo.ShowAnimals();
            
            //ViewData["howmuch"] = zoo.HowMuchItCost();
            //ViewData["czymjade"] = spc.products; 
            //_shoppingcart.ShowVehicles();
        }

        public void fillAction()
        {
            this.addAnimalToList(zoo, bird);
            this.addAnimalToList(zoo, dog);
            this.addAnimalToList(zoo, cat);
            this.giveInformation(izoo);
        }

        public ActionResult Index()
        {
            fillAction();
            //this.message(Dog);
            // this.message(Bird);

            return View();
        }
        public ActionResult Dogg()
        {
            this.addAnimalToList(zoo, dog);
            fillAction();
            this.message(dog);
            ViewBag.Message = "DOGggg";

            return View("Index");
        }
        public ActionResult Birdd()
        {
            fillAction();
            this.message(bird);
            ViewBag.Message = "Birdddd";

            return View("Index");
        }

        public ActionResult Catt()
        {
            fillAction();
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