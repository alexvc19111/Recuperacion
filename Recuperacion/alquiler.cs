class alquiler
{
    public DateOnly Fechainicial{get;set;}
    public DateOnly Fechafinal{get;set;}
    public int diasocupacion{get;set;}
    public string Posicionamarre{get;set;}
    public cliente clientee{get;set;}
    public double preciofijoalquiler{get;set;}
    public alquiler(DateOnly Fechainicial,DateOnly Fechafinal,int diasocupacion,string Posicionamarre,cliente clientee,double preciofijoalquiler)
    {
        this.Fechainicial=Fechainicial;
        this.Fechafinal=Fechafinal;
        this.diasocupacion=diasocupacion;
        this.Posicionamarre=Posicionamarre;
        this.clientee=clientee;
    }  
}