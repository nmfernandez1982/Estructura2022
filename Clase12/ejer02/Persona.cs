

public class Persona
{
    public string apellido{get;set;};
    public string nombre{get;set;};
    public int edad{get;set;};

    public string imprimir()
    {
        return("apellido: "+apellido+ " Nombre:"+nombre+" Edad"+edad);
    }
}