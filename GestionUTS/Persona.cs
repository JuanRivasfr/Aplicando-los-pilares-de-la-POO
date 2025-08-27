using System;

public abstract class Persona
{
    public string Nombre { get; private set; }
    public string Apellido { get; private set; }
    public string Documento { get; private set; }

    public Persona(string nombre, string apellido, string documento)
    {
        Nombre = nombre;
        Apellido = apellido;
        Documento = documento;
    }

    public abstract void MostrarInformacion();
}
