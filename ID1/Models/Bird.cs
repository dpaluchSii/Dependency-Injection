using ID1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ID1.Models
{
    public class Bird : Animal, IAnimal
    {
       override
       public String getVoice()
        {
            return "ćwir ćwir";
        }

        public String getName()
        {
            return "Bird";
        }
    }
}