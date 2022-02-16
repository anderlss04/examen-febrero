namespace Parejas
{
    public class Persona
    {
        public string nombre { get; set; }
        public int edad { get; set; }
        public string sexo { get; set; }

        public Persona(string nombre, int edad, string sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
        }

        public enum RangoEdad
        {
            muyJoven,
            joven,
            plenitud,
            madurez,
            vejez
        }

        public virtual int Edad{get;}
        public RangoEdad Rango
        {
            get => edad switch
            {
                < 19 => RangoEdad.muyJoven,
                < 29 => RangoEdad.joven,
                < 39 => RangoEdad.plenitud,
                < 49 => RangoEdad.madurez,
                _ => RangoEdad.vejez
            };
        }

        public override string ToString() => $"A codificar";
    }
}