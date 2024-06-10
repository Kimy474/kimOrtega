// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hola, por favor escribe algo de tu preferencia");
string texto = Console.ReadLine();

string[] par = texto.Split("");
int frecuencia = 0;
Dictionary<string, int> almacen = new Dictionary<string, int>() { };


foreach (var item in par) 
{
    if (almacen.ContainsKey(item))
    {
        almacen[item]++;
        frecuencia++;
    }
    else
    {
        almacen[item] = 1;
    }
}

foreach (var i in almacen)
{
    Console.WriteLine($"la frase : {i.Key}, y su frecuencia es:  {i.Value}");
}
