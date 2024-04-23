using Programacion3.Ejercicios.Entidades;
using Programacion3.Ejercicios.Entidades.Interfaces;
using System;
using System.Linq;
using Xunit.Sdk;

namespace Programacion3.Ejercicios.Tests
{
    /// <summary>
    /// Unidad 5
    /// 
    /// </summary>
    public class Unidad5LINQv2
{

       


        [Fact]
        public void unidad5_test8_equipos()
        {
            //var equipos = GenerarEquipos();


            ////Obtener los nombres de equipos con el jugador con el nombre "J 1"
            //var equiposConJ1 = from e in equipos
            //                   where e.Jugadores.Any(x => x.Nombre == "J 1")
            //                   select e.Nombre;

            //Assert.Equal(new List<string> { "Equipo 1" }, equiposConJ1);
        }


        [Fact]
        public void unidad5_test9_golestotales()
        {
            var equipos = GenerarEquipos();


            //Obtener la cantidad de goles totales realizados

            //Version 1
            //var demo1 = equipos.Sum(x => x.Jugadores.Sum(j => j.Goles));


            //Version 2
            //var golesTotales = (from e in equipos
            //                   select e.Jugadores.Sum(x => x.Goles)).Sum();


            //Version 3
            //var demo2_parte1 = from e in equipos
            //                    select e.Jugadores.Sum(x => x.Goles);

            //var demo2_parte2 = demo2_parte1.Sum();



            //Assert.Equal(5, demo1);
            //Assert.Equal(5, golesTotales);
        }

        [Fact]
        public void unidad5_test10111213() 
        {
            var equipos = GenerarEquipos();

            //10: Cuantos jugadores tiene el equipo que esta segundo en el ranking >> 4 jugadores
            var jugaRank2 = (from x in equipos
                             where x.Ranking == 2
                             select x.Jugadores.Count);

            Assert.Equal(4, jugaRank2.First());


            //11: Cual es el Ranking del equipo con mas jugadores >> 2do ranking
            var rankConMasJug = equipos.OrderByDescending(e => e.Jugadores.Count()).First().Ranking;


            Assert.Equal(2, rankConMasJug);



            //12: Cual es el promedio de goles de jugadores que parte del nombre sea "J 1"

            double promedio = equipos.SelectMany(equipo => equipo.Jugadores)
                                     .Where(jugador => jugador.Nombre.Contains("J 1"))
                                     .Average(jugador => jugador.Goles);
            
            

            Assert.NotEmpty(promedio.ToString());









            //13: Cual de los equipos posee el nombre de jugador mas largo

        }


        private List<Equipo> GenerarEquipos()
        {

 
            var equipos = new List<Equipo> {
                        new Equipo() { Nombre = "Equipo 1",  Ranking = 3 },
                        new Equipo() { Nombre = "Equipo 2",  Ranking = 1},
                        new Equipo() { Nombre = "Equipo 3",  Ranking = 2},
            };

            var jugadoresEquipo1 = new List<Jugador> {
                        new Jugador("J 1", "A 1"){ 
                            Goles  = 3
                        },
                        new Jugador("J 2", "A 2"){ 
                            Goles = 2
                        }
            };

            var jugadoresEquipo2 = new List<Jugador> {
                        new Jugador("J 1 E2", "A 1 E2"){
                            Goles  = 4
                        },
                        new Jugador("J 2 E2", "A 2 E2"){
                            Goles = 0
                        }
            };

            var jugadoresEquipo3 = new List<Jugador> {
                        new Jugador("J 1 E3", "A 1 E3"){
                            Goles  = 4
                        },
                        new Jugador("J 2 E3", "A 2 E3"){
                            Goles = 0
                        },
                        new Jugador("J 3 E3", "A 3 E3"){
                            Goles = 8
                        },
                        new Jugador("Juan de los Palotes", "A 3 E3"){
                            Goles = 1
                        }
            };

            //equipos[0].Jugadores = jugadoresEquipo1;
            equipos[0].Jugadores.AddRange(jugadoresEquipo1);
            equipos[1].Jugadores.AddRange(jugadoresEquipo2);
            equipos[2].Jugadores.AddRange(jugadoresEquipo3);





            

            return equipos;
        }



    }
}