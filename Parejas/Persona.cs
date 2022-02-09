namespace Parejas
{
    public enum Sexo
    {
        H,
        M
    }
    public enum RangoDeEdad
    {
        MuyJoven, Joven, Plenitud,
        Madurez, Vejez
    }

    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public Sexo Sexo { get; set; }

        public Persona(string nombre, Sexo sexo, int edad)
        {
            Nombre = nombre;
            Sexo = sexo;
            Edad = edad;
        }

        public RangoDeEdad Rango
        {
            get =>
                Edad switch
                {
                    < 20 => RangoDeEdad.MuyJoven,
                    _ when Edad < 30 => RangoDeEdad.Joven,
                    _ when Edad < 40 => RangoDeEdad.Plenitud,
                    _ when Edad < 50 => RangoDeEdad.Madurez,
                    _ => RangoDeEdad.Vejez
                };
        }

        public override string ToString() => $"{Sexo}:{Nombre} ({Edad} {Rango})";
    }
}