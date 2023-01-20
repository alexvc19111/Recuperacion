class deportivo:barco{
    public double potenciacvd{get;set;}
    public deportivo(string matricula,double largoxmetros, int añofabrica,double potenciacvd,alquiler alquiler):base(matricula,largoxmetros,añofabrica,alquiler)
    {
        this.potenciacvd=potenciacvd;
        this.alquiler=alquiler;
    }
    public override void imprimirbarco()
    {
        double funcion=0.2*(largoxmetros)*(potenciacvd);
        double alquilerprecio=alquiler.diasocupacion*funcion*alquiler.preciofijoalquiler;
        Console.WriteLine("Barco alquilado:");
        Console.WriteLine("Barco :Deportivo|Fecha inicial del alquiler:"+alquiler.Fechainicial+"|Fecha final del alquiler"+alquiler.Fechafinal+"|Cliente"+alquiler.clientee.nombre+" "+alquiler.clientee.apellido+"|Precio del alquiler:"+alquilerprecio);
    }
}