﻿int NUM1, NUM2, NUM3;
string linea;
Console.Write("PRIMER NÚMERO :"); linea = Console.ReadLine();
NUM1 = int.Parse(linea);
Console.Write("SEGUNDO NÚMERO :"); linea = Console.ReadLine();
NUM2 = int.Parse(linea);
Console.Write("TERCER NÚMERO :"); linea = Console.ReadLine();
NUM3 = int.Parse(linea);
Console.WriteLine();
Console.Write("EL INTERMEDIO ES: ");
if ((NUM1 > NUM2))
{
    if ((NUM1 < NUM3))
    {
        Console.WriteLine(NUM1);
    }
    else
    {
        if ((NUM2 < NUM3))
        {
            Console.WriteLine(NUM3);
        }
        else
        {
            Console.WriteLine(NUM2);
        }
    }
}
else
{
    if ((NUM2 < NUM3))
    {
        Console.WriteLine(NUM2);
    }
    else
    {
        if ((NUM1 < NUM3))
        {
            Console.WriteLine(NUM3);
        }
        else
        {
            Console.WriteLine(NUM1);
        }
    }
}