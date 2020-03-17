using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cachipun
{
    public class Persona
    {
        private string name;
        private string surname;

        public Persona(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
 

        public int Lanzar()
        {
            Random r = new Random();
            int random = r.Next(0, 3);
            return random;
        }


    }
}