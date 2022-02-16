using Xunit;

namespace Parejas
{

    public class SistemaTest
    {

        [Fact]
        public void SaludoTest()
        {
            // Given
            var sis = new Sistema();
            var param1 = new Persona("Santi",25,"h") ;
            var param2 = new Persona("Santi",22,"m");
            var esperado = true;
            // When
            var result = sis.AdmitenDescendencia(param1,param2);
            // Then
            Assert.Equal(result, esperado);
        }

        [Theory]
        [InlineData(new Persona("Santi",25,"h") ,new Persona("Ane", 21,"m"), true)]
        [InlineData(new Persona("Santi",25,"h") ,new Persona("Ane", 41,"m"), false)]
        [InlineData(new Persona("Santi",25,"h") ,new Persona("Ane", 21,"h"), false)]
        [InlineData(new Persona("Santi",25,"h") ,new Persona("Ane", 1,"h"), false)]
        public void AdmitenDescendenciaTest(Persona a, Persona b, bool esperado)
        {
            // Given
            var sis = new Sistema();
            // When
            var result = sis.AdmitenDescendencia(a,b);
            // Then
            Assert.Equal(result, esperado);
        }

        // public static IEnumerable<object[]> Data =>
        // new List<object[]>
        // {
        //     new object[] { new Persona() , new Persona(), false},
        //     // new object[] { new Persona("A", Sexo.H, 20) , new Persona("B", Sexo.M, 26), false},
        //     // new object[] { new Persona("A", Sexo.H, 20) , new Persona("B", Sexo.M, 21), true},
        // };

    }
}