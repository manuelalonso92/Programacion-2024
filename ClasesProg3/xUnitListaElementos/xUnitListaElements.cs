using listaElementos;

namespace xUnitListaElementos
{
    public class xUnitListaElements
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            var x = new Lista_Generar_Elementos();


            //Act
            List<Alumno> act = x.Generar();


            //Assert
            var query = from j in act where j.Universidad.Contains("UTN") select j.Nombre;
            
            Assert.Equal("UTN", query.ToString());
        }
    }
}