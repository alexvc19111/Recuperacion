class yatedelujo:barco{
    public double potenciacvy{get;set;}
    public int camarotes{get;set;}
    public yatedelujo(string matricula,double largoxmetros, int añofabrica,double potenciacvy,int camarotes,alquiler alquiler):base(matricula,largoxmetros,añofabrica,alquiler)
    {
        this.potenciacvy=potenciacvy;
        this.camarotes=camarotes;
    }

    public override void imprimirbarco()
    {
        double funcion=0.2*(largoxmetros)*(potenciacvy+camarotes);
        double alquilerprecio=alquiler.diasocupacion*funcion*alquiler.preciofijoalquiler;
        Console.WriteLine("Barco alquilado:");
        Console.WriteLine("Barco :Yate de lujo|Fecha inicial del alquiler:"+alquiler.Fechainicial+"|Fecha final del alquiler:"+alquiler.Fechafinal+"|Cliente:"+alquiler.clientee.nombre+" "+alquiler.clientee.apellido+"|Precio del alquiler:"+alquilerprecio);
    }
}