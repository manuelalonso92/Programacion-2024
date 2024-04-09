namespace MiCumpleanios
{
    public class Nacimiento
    {
        

        public string Cumpleanios(DateTime dt) 
        {
            int añoAct = 2024;
            dt = dt.AddYears(añoAct - dt.Year);
            string msg = "Mi cumpleaños es el dia "+ dt.ToString("dddd, dd/MMMM 'de' yyyy");
            
            return msg;
        }
    }
}
