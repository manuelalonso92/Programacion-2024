using CuentasBancarias;

namespace xUnitTestCtasBancaris
{
    public class xUnitCuentasBancarias
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            var persona1 = new CuentaBancaria()
            {
                nombre = "Manuel",
                edad = 31
            };



            //Act



            //Assert
            Assert.NotNull(persona1.nombre);
            Assert.NotEqual(0, persona1.edad);
            Assert.Equal("Manuel", persona1.nombre);
        }
    }
}