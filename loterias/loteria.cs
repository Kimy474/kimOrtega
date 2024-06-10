// See https://aka.ms/new-console-template for more information
List<int> numerosUsuario = new List<int>();
Console.Write("Hola, bienvenida(o) a tu loteria de confianza, por ingresa los 6 valores entre los numeros 1 y 49 que crees que son los numeros ganadores, recuerda no repetir el mismo numero. ¡Suerte!");
Console.WriteLine(" una vez ingresados los 6 numeros ingresa 0");
int usuario;
usuario = Convert.ToInt16(Console.ReadLine());

while (usuario != 0)
{
    if (usuario > 0)
    {
        numerosUsuario.Add(usuario);
    }
    usuario = Convert.ToInt16(Console.ReadLine());

}

int aleatorio_1, aleatorio_2, aleatorio_3, aleatorio_4, aleatorio_5, aleatorio_6;
Random rand= new Random();
aleatorio_1 = rand.Next(50);
aleatorio_2 = rand.Next(50);
aleatorio_3 = rand.Next(50);
aleatorio_4 = rand.Next(50);
aleatorio_5 = rand.Next(50);
aleatorio_6 = rand.Next(50);



int premio = 0;
int aciertos = 0;

if (numerosUsuario.Contains(aleatorio_1)){
    aciertos = aciertos + 1;
}
if (numerosUsuario.Contains(aleatorio_2) ){
    aciertos = aciertos + 1;
}
if (numerosUsuario.Contains(aleatorio_3) ){
    aciertos = aciertos + 1;
}
if (numerosUsuario.Contains(aleatorio_4) ){
    aciertos = aciertos + 1;
}
if (numerosUsuario.Contains(aleatorio_5) ){
    aciertos = aciertos + 1;
}
if (numerosUsuario.Contains(aleatorio_6)) {
    aciertos = aciertos + 1;
}


if (aciertos == 1)
    premio = 100;
if (aciertos == 2)
    premio = 450;
if (aciertos == 3)
    premio = 2000;
if (aciertos == 4)
    premio = 2100;
if (aciertos == 5)
    premio = 2200;
if (aciertos == 6)
    premio = 2300;

Console.WriteLine($"numeros ganadores son: {aleatorio_1}, {aleatorio_2}, {aleatorio_3}, {aleatorio_4}, {aleatorio_5}, {aleatorio_6}" );

foreach (var i in numerosUsuario)
{
    Console.Write("tus numeros fueron " + i + ",");
}

Console.WriteLine("Valor de aciertos: " + aciertos);
Console.WriteLine("Valor de premio: " + premio);
Console.Write("Podemos volver a intentarlo, presiona una tecla para terminar . . . ");
Console.ReadKey();