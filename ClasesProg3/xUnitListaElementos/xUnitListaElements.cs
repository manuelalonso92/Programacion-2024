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
            var query = from j in act where j.Universidad.Contains("UTN") select j.Universidad;

            var query2 = from j in act
                         where j.Universidad == "UTN" && j.Edad <= 20
                         orderby j.Nombre

                         select new { j.Nombre, j.Edad };

            var query3 = from j in act
                         where j.Universidad == "UTN" && j.Edad <= 20
                         orderby j.Nombre
                         select new { j.Nombre, j.Edad };


            var count = query3.Count();
            Assert.NotEmpty(query3);
            
        }
    }
}