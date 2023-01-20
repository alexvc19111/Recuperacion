internal class Program
{
    private static void Main(string[] args)
    {
        DateOnly f1=new DateOnly( 2012,03,12);
        DateOnly f2=new DateOnly(2012,03,29);
        cliente c1=new cliente("Pedro","Fernandez",123456789);
        alquiler a1=new alquiler(f1,f2,15,"En la orilla",c1,1.8);
        velero v1=new velero("ABC123",22,2003,3,a1);
        List<barco>a=new List<barco>();
        a.Add(v1);
        Console.WriteLine("Lista de barcos alquilados");
        foreach (barco x in a)
        {
            x.imprimirbarco();
        }
        List<barco>la=new List<barco>();
        foreach (barco x in la)
        {
            DateOnly buscar=new DateOnly(2012,03,12);
            if(buscar==x.alquiler.Fechainicial)
            {
                Console.WriteLine("Barcos alquilados el mismo día ");
                x.imprimirbarco();
            }
        }
    }
}