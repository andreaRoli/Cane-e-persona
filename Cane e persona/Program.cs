using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cane_e_persona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cane c = new Cane();
            c.Nome = "Ringhio";
            c.Razza="Labrador";

            c.Proprietario=new Persona();
            c.Proprietario.Nome = "Simone";

        }
    }
}
