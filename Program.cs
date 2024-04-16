using System;

namespace extra01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int notaLengua, notaMatematica, notaHistoria;
            bool notaValida = false;
            do
            {
                (notaLengua, notaMatematica, notaHistoria) = IngresoNotas("Ingrese su nota de Lengua", "Ingrese su nota de Matemática", "Ingrese su nota de Historia");
                notaValida = ValidarNota(notaLengua, notaMatematica, notaHistoria);

                if (!notaValida)
                {
                    Console.WriteLine("Valor/es inválido/s, vuelva a ingresar sus notas");
                }
            }
            while (!notaValida);
            int promedioNotas = CalcularPromedio(notaLengua, notaMatematica, notaHistoria);
            Mostrar(promedioNotas);
            string mensaje= AprobeONo(promedioNotas, "Aprobaste :)", "Desaprobaste...");
            Console.WriteLine(mensaje);
        }
        //modulos
        static void Mostrar(int promedio)
        {
            Console.WriteLine($"Tu nota promedio es {promedio}");
        }
        static string AprobeONo(int promedio, string mensaje1, string mensaje2)
        {
            if (promedio >= 60)
            { 
            return (mensaje1);
            }
            return (mensaje2);
        }
        static int CalcularPromedio(int nota1, int nota2, int nota3)
        {
            const int cantidadNotas = 3;
            return (nota1 + nota2 + nota3) / cantidadNotas;
        }
        static bool ValidarNota(int nota1, int nota2, int nota3)
        { 
            if (nota1 < 0 || nota1 > 100 || nota2 < 0 || nota2 > 100 || nota3 < 0 || nota3 > 100)
            {
                return false;
            }
            return true;
        }
        static (int, int, int) IngresoNotas(string mensaje1, string mensaje2, string mensaje3)
        {
            Console.WriteLine(mensaje1);
            int nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine(mensaje2);
            int nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine(mensaje3);
            int nota3 = int.Parse(Console.ReadLine());
             return (nota1, nota2, nota3);
        }
    }
}
