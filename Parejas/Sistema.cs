using System.Collections.Generic;

using Parejas;
namespace Parejas
{
    public class Sistema
    {
        public List<Persona> Personas { get; } = new()
        {
            
        };

        public bool AdmitenDescendencia(Persona a, Persona b)
        {
            return true;
        }

        public List<(Persona, Persona)> PosibleParejas(List<Persona> personas)
        {

            var parejas = new List<(Persona, Persona)>();

           
            return parejas;
        }

        public string Saludo(string nombre) => $"Saludos {nombre}!";


    }
}