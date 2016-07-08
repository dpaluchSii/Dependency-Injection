using ID1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ID1.Models
{
    public class Cat : Animal, IAnimal
    {
        override
        public String getVoice()
        {
            return "miau";
        }

        public String getName()
        {
            return "Cat";
        }
    }

    
}