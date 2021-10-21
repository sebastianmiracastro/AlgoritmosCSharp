int L1, L2, L3;
string linea;
Console.Write("Digite lado 1 :"); linea = Console.ReadLine();
L1 = int.Parse(linea);
Console.Write("Digite lado 2 :"); linea = Console.ReadLine();
L2 = int.Parse(linea);
Console.Write("Digite lado 3 :"); linea = Console.ReadLine();
L3 = int.Parse(linea);
if ((L1 == L2) & (L2 == L3))
{
    Console.WriteLine("Triangulo EQUILÁTERO (Todos los lados iguales)");
}
 else
{
    if ((L1 != L2) & (L1 != L3) & (L2 != L3))
    {
        Console.WriteLine("Triangulo ESCALENO (Ningun lado igual)");
    }
    else
    {
        Console.WriteLine("Triangulo ISÓSCELES (Dos lados iguales)");
    }
}
