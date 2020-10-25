﻿using System;
using CoreEscuela.Entidades;
using static System.Console;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy", 2010, TiposEscuela.PreEscolar, ciudad: "Bogotá");
            Console.WriteLine(escuela);
            Console.WriteLine(escuela.Pais == null);

            escuela.Cursos = new Curso[]
            {
                new Curso {Nombre = "101"},
                new Curso {Nombre = "201"},
                new Curso {Nombre = "301"}
            };

            ImprimirCursosEscuela(escuela);

            
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            if (escuela?.Cursos != null)
            {
                foreach (var Curso in escuela.Cursos)
                {
                    Console.WriteLine(Curso.Nombre);
                }
            }
        }
    }
}

