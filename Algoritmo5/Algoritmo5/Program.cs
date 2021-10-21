int NUM1, NUM2;
string linea;

Console.Write("NÚMERO 1 :"); linea = Console.ReadLine();
NUM1 = int.Parse(linea);
Console.Write("NÚMERO 2 :"); linea = Console.ReadLine();
NUM2 = int.Parse(linea);
if ((NUM1 > NUM2))
{
    Console.WriteLine("{0} ES MAYOR QUE {1}", NUM1, NUM2);
}
else if ((NUM1 == NUM2))
    {
        Console.WriteLine("{0} ES IGUAL A {1}", NUM1, NUM2);
    }
else
    {
        Console.WriteLine("{0} ES MENOR QUE {1}", NUM1, NUM2);
    }
