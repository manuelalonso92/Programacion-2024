namespace listaElementos
{

    public class Lista_Generar_Elementos
    {
        
        List<Alumno> listaAlumnos = new List<Alumno>();
        Random rnd = new Random();
        
        public List<Alumno> Generar()
        {
            string[] nombres = { "Rodolfo", "Carlos", "Martin", "Rodrigo", "Florencia", "Lucia", "Micaela", "Juana", "Marta", "Ramon", "Gonzalo", "Daniel" };
            string[] univ = { "UTN", "UBA", "UNNE" };
            
            for (int i = 1; i <= 1000; i++) {

                
                listaAlumnos.Add(new Alumno {Nombre = nombres[rnd.Next(nombres.Length)], Edad = rnd.Next(1,40), Universidad = univ[rnd.Next(univ.Length)] });
                
            }

            return listaAlumnos;
        }


    }

        public class Alumno 
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }

            public string Universidad { get; set;}



        }

   
}

        

        
   
