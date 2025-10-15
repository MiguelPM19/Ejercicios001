using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios001
{
    internal class Persona
    {
        public string Name { get; set; }

        //Constructor
        public Persona(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return "¡Hola! Mi nombre es " + Name;
        }
        //Destructor
        ~Persona()
        {
            Name = string.Empty;
        }
    }
}
