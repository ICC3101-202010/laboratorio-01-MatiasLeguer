using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cachipun
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            int random = person.Lanzar();
            Console.WriteLine(random);

        }
    }
}

