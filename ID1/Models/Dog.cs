using ID1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ID1.Models
{
    public class Dog : Animal, IAnimal
    {
        override
       public String getVoice()
        {
            return "hauu";
        }

        public String getName()
        {
            return "Dog";
        }
    }
}