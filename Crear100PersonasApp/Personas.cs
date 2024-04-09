// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Globalization;

for (int i = 1; i <= 10; i++)
{
    
    Console.WriteLine("Ingrese fec nac: ");
    DateTime fecNac = DateTime.Parse(Console.ReadLine());
    //Persona x = new Persona(fecNac);
    //Console.WriteLine("Nombre:" + $"{x.nombre}" + "\nApellido:" + $"{x.apellido}" + "\nEdad:" + $"{x.edad}\n"); 
}

    public class Persona
{
    public Random rnd = new Random();
    public string nombre;
    public string apellido;
    public int edad;
    public DateTime dt;
   

    public Persona()
    { 
        this.nombre = Nombres();
        this.apellido = Apellido(); 
        //this.dt = fecNac.ToUniversalTime();
        this.edad = Edad();

    }

    
    public string Nombres() 
    {
        string[] nombres = { "Juan", "María", "Pedro", "Ana", "Luis", "Sofía", "Carlos", "Laura", "Javier", "Elena" };
        return nombres[rnd.Next(nombres.Length)];
    }

    public string Apellido() 
    {
        string[] apellidos = { "García", "Martínez", "Fernández", "López", "González", "Rodríguez", "Pérez", "Sánchez", "Ramírez", "Torres" };
        return (apellidos[rnd.Next(apellidos.Length)]);
    }

    public int Edad() 
    {
        
        int edad = DateTime.Now.Year - dt.Year;
        if ((dt.Month > DateTime.Now.Month) || (dt.Month == DateTime.Now.Month && dt.Day > DateTime.Now.Day)) { --edad; }
        return edad;
    }


}


