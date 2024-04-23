using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Programacion3.Ejercicios.Entidades.Interfaces;

namespace Programacion3.Ejercicios.Entidades
{

    public abstract class Persona : INombreCompleto
    {
        public string Nombre { get; }
        public string Apellido { get; }

        public string NombreCompleto { get { return $"{Nombre} {Apellido}"; } }

        protected Persona(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;

        }

        

       
        
}
}
