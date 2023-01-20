class cliente
{
    public string nombre{get;set;}
    public string apellido{get;set;}
    public long cedula{get;set;}
    public cliente(string nombre,string apellido,long cedula)
    {
        this.nombre=nombre;
        this.apellido=apellido;
        this.cedula=cedula;
    }

}