using System.Collections.Generic;
using System.Linq;
using System;


using Parejas;
namespace Parejas
{
    public class Sistema
    {
        public List<Persona> Personas { get; set; } = new()
        {
        new Persona("ander", 30, "h"),
        new Persona("jairo", 15, "h"),
        new Persona("martin", 25, "h"),
        new Persona("tatao", 45, "h"),
        new Persona("ane", 22, "m"),
        new Persona("felia", 31, "m"),
        new Persona("leticia", 26, "m"),
        new Persona("gustabo", 44, "h"),
        new Persona("helen", 20, "m"),
        new Persona("heidi", 25, "m")
        };

        public bool AdmitenDescendencia(Persona a, Persona b)
        {
            if (a.edad - b.edad <= 12 && a.edad - b.edad >= -12)
            {
                if (a.sexo != b.sexo)
                {
                    if (a.Rango - b.Rango <= 1 && a.Rango - b.Rango >= -1)
                        return true;
                }
            }

            return false;
        }

        public List<(Persona, Persona)> PosibleParejas(List<Persona> personas)
        {

            var parejas = new List<(Persona, Persona)>();


            return parejas;
        }

        public string Saludo(string nombre) => $"Saludos {nombre}!";


    }
}