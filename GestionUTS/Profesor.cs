using System;

public class Profesor : Persona
{
    public string Departamento { get; private set; }

    public Profesor(string nombre, string apellido, string documento, string departamento)
        : base(nombre, apellido, documento)
    {
        Departamento = departamento;
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine($"Profesor: {Nombre} {Apellido} | Documento: {Documento} | Departamento: {Departamento}");
    }
}
