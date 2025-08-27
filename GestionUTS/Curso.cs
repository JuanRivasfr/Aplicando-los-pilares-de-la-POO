using System;
using System.Collections.Generic;

public class Curso
{
    public string NombreCurso { get; private set; }
    public Profesor ProfesorAsignado { get; private set; }
    private List<Estudiante> estudiantes;

    public Curso(string nombreCurso)
    {
        NombreCurso = nombreCurso;
        estudiantes = new List<Estudiante>();
    }

    public void AsignarProfesor(Profesor profesor)
    {
        ProfesorAsignado = profesor;
    }

    public void InscribirEstudiante(Estudiante estudiante)
    {
        estudiantes.Add(estudiante);
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"\nCurso: {NombreCurso}");
        if (ProfesorAsignado != null)
        {
            Console.WriteLine("Profesor asignado:");
            ProfesorAsignado.MostrarInformacion();
        }
        else
        {
            Console.WriteLine("No hay profesor asignado.");
        }

        Console.WriteLine("Estudiantes inscritos:");
        if (estudiantes.Count == 0)
        {
            Console.WriteLine("No hay estudiantes inscritos.");
        }
        else
        {
            foreach (var estudiante in estudiantes)
            {
                estudiante.MostrarInformacion();
            }
        }
    }
}
