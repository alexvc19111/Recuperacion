abstract class barco{
    public string matricula{get;set;}
    public double largoxmetros{get;set;}
    public int añofabrica{get;set;}
    public alquiler alquiler{get;set;}
    public barco(string matricula,double largoxmetros, int añofabrica,alquiler alquiler)
    {
        this.matricula=matricula;
        this.largoxmetros=largoxmetros;
        this.añofabrica=añofabrica;
        this.alquiler=alquiler;
    }
    public abstract void imprimirbarco();

}