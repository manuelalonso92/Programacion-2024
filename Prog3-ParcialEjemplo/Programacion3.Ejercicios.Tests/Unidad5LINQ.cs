using Programacion3.Ejercicios.Entidades;
using Programacion3.Ejercicios.Entidades.Interfaces;

namespace Programacion3.Ejercicios.Tests
{
    /// <summary>
    /// Unidad 5
    /// 
    /// </summary>
    public class Unidad5LINQ

	{
        [Fact]
        public void unidad5_test1_numerospares_utilizacion_any()
        {
            var numeros = new List<int> { 1, 3, 5, 7, 9 };

            //Utilizar el metodo Any de LINQ para determinar si la lista contiene algún número par
            bool contieneNumerosPares = (from x in numeros
                                        select x).Any(x => x % 2 == 0) ;


            Assert.False(contieneNumerosPares);
            

        }


        [Fact]
        public void unidad5_test2_numerosmaximo_utilizacion_max()
        {
            var numeros = new List<int> { 1, 3, 5, 7, 9, 37 };

            //Utilizar el metodo Max de LINQ
            int maximoNumero = numeros.Max();

            Assert.Equal(37, maximoNumero);

        }


        [Fact]
        public void unidad5_test3_contarpalabrasquecomiencenconletraa_utilizacion_startWith()
        {
            var palabras = new List<string> { "Manzana", "Banana", "Pera", "Anana" };

            var cantidadPalabrasComienzanConA = (from x in palabras
                                                where x.StartsWith('a') || x.StartsWith('A')
                                                select x).Count();

            Assert.Equal(1, cantidadPalabrasComienzanConA); 

        }


        [Fact]
        public void unidad5_test4_obtenernumerosimpares_filtro_y_obtener_lista()
        {
            var numeros = new List<int> { 1, 2, 3, 4, 5 };

            //Se desea obtener una lista con los números impares utilizando LINQ
            var numerosImpares = new List<int>(from x in numeros
                                               where x % 2 == 1
                                               select x);
            


            Assert.Equal(new List<int> { 1, 3, 5 }, numerosImpares); 

        }


        [Fact]
        public void unidad5_test5_preguntasitodaslaspalabrasterminancona_utilizacion_all()
        {
            var palabras = new List<string> { "Manzana", "Banana", "Pera", "Anana" };

            //Utilizar el metodo All de LINQ para determinar si todas las palabras terminan con la letra "a"
            var todasTerminanConA = palabras.All(palabras => palabras.EndsWith('a'));

            Assert.True(todasTerminanConA);

        }


        [Fact]
        public void unidad5_test6_sumarl()
        {
            var numeros = new List<int> { 1, 2, 3, 4, 5 };

            //utilizar LINQ para sumar todos los números de la lista
            var suma = numeros.Sum();

            Assert.Equal(15, suma); 
        }


        [Fact]
        public void unidad5_test7_obtenerlapalabramaslarga()
        {
            var palabras = new List<string> { "Kiwi", "Manzana", "Banana", "Pera", "Anana" };

            //Utilizar LINQ para obtener la palabra más larga
            ////(NOTA: string tiene una propiedad Length para comparar, TIP. Se puede ordenar descendentemente)
            var palabraMasLarga = palabras.OrderByDescending(x => x.Length).First();
            
            //Assert.True("Manzana", palabraMasLarga);
            Assert.Equal("Manzana", palabraMasLarga);

        }


        [Fact]
        public void unidad5_test8_ordenarlistaalfabeticamente()
        {
         
            var letras = new List<string> { "z", "a", "d", "c" };

            //Utilizar LINQ para ordenar la lista alfabéticamente
            var letrasOrdenadas = letras.OrderBy(x => x).ToList();

            
            Assert.Equal(new List<string> { "a", "c", "d", "z" }, letrasOrdenadas); 
        }

    }
}