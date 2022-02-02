namespace Parejas
{
    public enum Sexo{
        H,
        M
    }

    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public Sexo Sexo { get; set; }

        public Persona (string nombre, Sexo sexo, int edad){
            Nombre = nombre;
            Sexo = sexo;
            Edad = edad;
        }

        public override string ToString() => $"{Sexo}:{Nombre} ({Edad})";
    }
}