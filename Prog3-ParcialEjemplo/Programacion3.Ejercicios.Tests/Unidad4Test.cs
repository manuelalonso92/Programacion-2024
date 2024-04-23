using Programacion3.Ejercicios.Entidades;
using Programacion3.Ejercicios.Entidades.Interfaces;

namespace Programacion3.Ejercicios.Tests
{
    /// <summary>
    /// Unidad 4
    /// C#. Organización de proyectos avanzados. Estructura de Proyectos. Organización de espacio de nombres. Manejo de Fechas C# Conceptos intermedios. Collections. Generics. IO (Files)
    /// </summary>
    public class Unidad4Test

    {
        [Fact]
        public void unidad4_test1_DateTime_Formatting()
        {

            var finalWorldCupMatch = new DateTime(2022, 12, 18, 15, 30, 23);

            var value1 = finalWorldCupMatch.Year;

            Assert.Equal(2022, value1);
            Assert.Equal("18/12/22 15:30:23", finalWorldCupMatch.ToString("dd/MM/yy HH:mm:ss"));
            Assert.Equal("18/12/22 03:30 PM", finalWorldCupMatch.ToString("dd/MM/yy hh:mm tt"));
            Assert.Equal("18 de diciembre de 2022", finalWorldCupMatch.ToString("dd 'de' MMMM 'de' yyyy"));


        }

        [Fact]
        public void unidad4_test2_DateTime_Days()
        {


            var finalWorldCupMatch = new DateTime(2022, 12, 18, 15, 30, 23);
            var today = new DateTime(2024, 4, 16, 15, 00, 00);

            var result = (today.AddDays(1) - finalWorldCupMatch).Days;

            Assert.Equal("485 Días totales desde la final del mundo", $"{result}"+ " Días totales desde la final del mundo");

        }

    }
}