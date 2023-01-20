class velero:barco{
    public int cantidadmastiles{get;set;}

    public velero(string matricula,double largoxmetros, int añofabrica,int cantidadmastiles,alquiler alquiler):base(matricula,largoxmetros,añofabrica,alquiler)
    {
        this.cantidadmastiles=cantidadmastiles;
    }
    public override void imprimirbarco()
    {
        double funcion=0.2*largoxmetros*cantidadmastiles;
        double alquilerprecio=alquiler.diasocupacion*funcion*alquiler.preciofijoalquiler;
        Console.WriteLine("Barco alquilado:");
        Console.WriteLine("Barco :Velero|Fecha inicial del alquiler:"+alquiler.Fechainicial+"|Fecha final del alquiler:"+alquiler.Fechafinal+"|Cliente:"+alquiler.clientee.nombre+" "+alquiler.clientee.apellido+"|Dias de ocupacion:"+alquiler.diasocupacion+"|Precio del alquiler:"+alquilerprecio);
    }
}