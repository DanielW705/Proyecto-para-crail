using System;
namespace guardarCalificaciones
{
    class Program
    {
        // Generamos nuestra estructura para guardar los datos
        struct Alumno
        {
            public int boleta;
            public decimal parcial1;
            public decimal parcial2;
            public decimal parcial3;
            // Es necesario que tenga un constructor para que se le asigne valores a la estructura
            public Alumno(int b, decimal p1, decimal p2, decimal p3)
            {
                this.boleta = b;
                this.parcial1 = p1;
                this.parcial2 = p2;
                this.parcial3 = p3;
            }
        }
        static void Main(string[] args)
        {
            //Inicializamos los datos del arreglo para y aplicamos el constructor para que el arreglo tenga valores

            Alumno[] alumnos = {
                new Alumno(2018137211, 3.5m, 5.5m, 10m),
                new Alumno(2018137212, 4.5m, 6.5m, 10m),
                new Alumno(2018137213, 5.5m, 7.5m, 10m),
                new Alumno(2018137214, 6.5m, 4.5m, 10m),
                new Alumno(2018137215, 7.5m, 8.5m, 10m),
                new Alumno(2018137216, 8.5m, 4.5m, 10m),
                new Alumno(2018137217, 9.5m, 6.5m, 10m),
                new Alumno(2018137218, 2.5m, 2.5m, 10m),
                new Alumno(2018137219, 3.5m, 1.5m, 10m),
                new Alumno(2018137220, 4.5m, 3.5m, 10m)
            };
            // Mapeamos todo el arreglo
            foreach (Alumno alumno in alumnos)
            {
                decimal promedio = (alumno.parcial1 + alumno.parcial2 + alumno.parcial3) / 3;
                Console.WriteLine($"La boleta: {alumno.boleta}, tiene calificacion del primer parcial: {alumno.parcial1}\ndel segundo parcial: {alumno.parcial2}\ndel tercer parcial: {alumno.parcial3}\nsu promedio es {promedio}\nel alumno esta: {(promedio > 6 ? "aprobado" : "reprobado")}");
            }
            Console.ReadKey();
        }
    }
}
