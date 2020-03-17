using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cachipun
{
    public class Person
    {
        public string name;
        public string surname;


        public void Play()
        {
            Random r = new Random();
            int random = r.Next(0, 3);
            Console.WriteLine(random);
        }


    }
}