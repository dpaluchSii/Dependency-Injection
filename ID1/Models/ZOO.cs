using ID1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ID1.Models
{
    public class ZOO : IZOO
    {
        public List<IAnimal> listOfAnimal = new List<IAnimal>();

        public void addToZOO(IAnimal a)
        {
            listOfAnimal.Add(a);
        }

        public string ShowAnimals()
        {
            string animals = "";
            foreach (IAnimal a in listOfAnimal)
            {
                animals = animals + a.getName() + " ";
            }
            return animals;
            //Environment.NewLine
        }
    }
}