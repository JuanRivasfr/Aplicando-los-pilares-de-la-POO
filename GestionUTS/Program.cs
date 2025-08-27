using System;
using System.Collections.Generic;

class Program
{
    static List<Persona> personas = new List<Persona>();
    static List<Curso> cursos = new List<Curso>();

    static void Main()
    {
        Console.WriteLine("=== Sistema de Gestión UTS ===");

        // Crear un curso para gestionar
        Console.Write("Ingrese el nombre del curso a crear: ");
        string nombreCurso = Console.ReadLine();
        Curso curso = new Curso(nombreCurso);
        cursos.Add(curso);

        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("\nMenú:");
            Console.WriteLine("1. Registrar Profesor");
            Console.WriteLine("2. Registrar Estudiante");
            Console.WriteLine("3. Asignar Profesor a Curso");
            Console.WriteLine("4. Inscribir Estudiante en Curso");
            Console.WriteLine("5. Mostrar información del Curso");
            Console.WriteLine("6. Salir");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    RegistrarProfesor();
                    break;
                case "2":
                    RegistrarEstudiante();
                    break;
                case "3":
                    AsignarProfesor(curso);
                    break;
                case "4":
                    InscribirEstudiante(curso);
                    break;
                case "5":
                    curso.MostrarInformacion();
                    break;
                case "6":
                    salir = true;
                    Console.WriteLine("Saliendo del sistema...");
                    break;
                default:
                    Console.WriteLine("Opción inválida, intente de nuevo.");
                    break;
            }
        }
    }

    static void RegistrarProfesor()
    {
        Console.WriteLine("\n--- Registrar Profesor ---");
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Apellido: ");
        string apellido = Console.ReadLine();

        Console.Write("Documento: ");
        string documento = Console.ReadLine();

        Console.Write("Departamento: ");
        string departamento = Console.ReadLine();

        Profesor prof = new Profesor(nombre, apellido, documento, departamento);
        personas.Add(prof);
        Console.WriteLine("Profesor registrado correctamente.");
    }

    static void RegistrarEstudiante()
    {
        Console.WriteLine("\n--- Registrar Estudiante ---");
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Apellido: ");
        string apellido = Console.ReadLine();

        Console.Write("Documento: ");
        string documento = Console.ReadLine();

        Console.Write("Carrera: ");
        string carrera = Console.ReadLine();

        Estudiante est = new Estudiante(nombre, apellido, documento, carrera);
        personas.Add(est);
        Console.WriteLine("Estudiante registrado correctamente.");
    }

    static void AsignarProfesor(Curso curso)
    {
        Console.WriteLine("\n--- Asignar Profesor a Curso ---");
        List<Profesor> profesores = new List<Profesor>();

        // Filtrar profesores de la lista personas
        foreach (var persona in personas)
        {
            if (persona is Profesor prof)
            {
                profesores.Add(prof);
            }
        }

        if (profesores.Count == 0)
        {
            Console.WriteLine("No hay profesores registrados.");
            return;
        }

        Console.WriteLine("Profesores disponibles:");
        for (int i = 0; i < profesores.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            profesores[i].MostrarInformacion();
        }

        Console.Write("Seleccione el número del profesor para asignar: ");
        if (int.TryParse(Console.ReadLine(), out int seleccion) && seleccion > 0 && seleccion <= profesores.Count)
        {
            curso.AsignarProfesor(profesores[seleccion - 1]);
            Console.WriteLine("Profesor asignado al curso correctamente.");
        }
        else
        {
            Console.WriteLine("Selección inválida.");
        }
    }

    static void InscribirEstudiante(Curso curso)
    {
        Console.WriteLine("\n--- Inscribir Estudiante en Curso ---");
        List<Estudiante> estudiantes = new List<Estudiante>();

        // Filtrar estudiantes de la lista personas
        foreach (var persona in personas)
        {
            if (persona is Estudiante est)
            {
                estudiantes.Add(est);
            }
        }

        if (estudiantes.Count == 0)
        {
            Console.WriteLine("No hay estudiantes registrados.");
            return;
        }

        Console.WriteLine("Estudiantes disponibles:");
        for (int i = 0; i < estudiantes.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            estudiantes[i].MostrarInformacion();
        }

        Console.Write("Seleccione el número del estudiante para inscribir: ");
        if (int.TryParse(Console.ReadLine(), out int seleccion) && seleccion > 0 && seleccion <= estudiantes.Count)
        {
            curso.InscribirEstudiante(estudiantes[seleccion - 1]);
            Console.WriteLine("Estudiante inscrito en el curso correctamente.");
        }
        else
        {
            Console.WriteLine("Selección inválida.");
        }
    }
}
