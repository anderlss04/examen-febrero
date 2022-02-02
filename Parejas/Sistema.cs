using System.Collections.Generic;

using Parejas;
namespace Parejas
{
    public class Sistema
    {

        public List<Persona> Personas { get; } = new()
        {
            new Persona("Luis", Sexo.H, 23),
            new Persona("Marta", Sexo.M, 20),
            new Persona("Pedro", Sexo.H, 21),
            new Persona("María", Sexo.M, 27),
        };

        public bool AdmitenDescendencia(Persona a, Persona b)
        {
            if (a.Sexo == b.Sexo) return false;
            if (System.Math.Abs(a.Edad - b.Edad) > 5) return false;
            return true;
        }

        public List<(Persona, Persona)> PosibleParejas(List<Persona> personas)
        {

            var parejas = new List<(Persona, Persona)>();

            for (var i = 0; i < personas.Count - 1; i++)
            {
                for (var j = i + 1; j < personas.Count; j++)
                {
                    if (AdmitenDescendencia(personas[i], personas[j]))
                    {
                        // Coloco primero el hombre
                        if (personas[i].Sexo == Sexo.H)
                            parejas.Add((personas[i], personas[j]));
                        else
                            parejas.Add((personas[j], personas[i]));

                    }
                }
            }
            return parejas;
        }

        public string Saludo(string nombre) => $"Saludos {nombre}!";


    }
}