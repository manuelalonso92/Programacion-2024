using MiCumpleanios;
using System.Net.Http.Headers;

namespace xUnitCumpleanios
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange

            var miNacimiento = new Nacimiento();
            DateTime dt = new DateTime(1992, 11,21);
            string hola = "Probando commit de git";

            //Act
           
            string rsp = miNacimiento.Cumpleanios(dt);

            //Asert
            Assert.Equal("Mi cumpleaños es el dia jueves, 21/noviembre de 2024", rsp);
        }
    }
}