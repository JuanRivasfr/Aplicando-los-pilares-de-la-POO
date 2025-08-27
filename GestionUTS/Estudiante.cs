using System;

public class Estudiante : Persona
{
    public string Carrera { get; private set; }

    public Estudiante(string nombre, string apellido, string documento, string carrera)
        : base(nombre, apellido, documento)
    {
        Carrera = carrera;
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine($"Estudiante: {Nombre} {Apellido} | Documento: {Documento} | Carrera: {Carrera}");
    }
}
