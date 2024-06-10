// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hola Bienvenido(a), por favor ingresa las calificaciones de los estudiantes:");
List<double> estudiantes = new List<double>();

double usuario;
usuario = Convert.ToDouble(Console.ReadLine());

while (usuario != 0)
{
    if (usuario > 0)
    {
        estudiantes.Add(usuario);
    }
    Console.WriteLine("Cuando ya no quieras agregar mas estudiantes, escribe 0");
    usuario = Convert.ToDouble(Console.ReadLine());

}

double calificacionMasAlta = estudiantes.Max();
double menorCalificacion = estudiantes.Min();
double Promedio = estudiantes.Sum() / estudiantes.Count();

Console.WriteLine("la mejor calificacion es : " + calificacionMasAlta);
Console.WriteLine("la calificacion mas baja es: " + menorCalificacion);
Console.WriteLine("Y el promedio de todos los estudiantes es: " + Promedio);