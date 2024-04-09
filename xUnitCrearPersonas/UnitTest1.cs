using Xunit.Abstractions;

namespace xUnitCrearPersonas
{
    public class UnitTest1
    {
      
        [Fact]
        public void Comprobar_Nombre_Apellido()
        {

            //Arrange: Instanciamos las clases que vamos a utilizar para el test
            var x = new Persona();

            //Act: Declaramos los metodos que vamos a llamr y completamos con los datos para el test
            string nom = x.nombre;
            string ape = x.apellido;
            int age = x.edad;
            string[] nombres = { "Juan", "María", "Pedro", "Ana", "Luis", "Sofía", "Carlos", "Laura", "Javier", "Elena" };

            //Assert: Metodos para testear
            Assert.True(nombres.Any(s => s.Contains("Pedro")),nom);
            Assert.NotNull(ape);
            
            
        }
    }
}
