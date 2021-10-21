int numero, i;

Console.WriteLine("Ingrese Un Numero");
numero = Convert.ToInt32(Console.ReadLine());

for(i = 1; i <= numero/2; i++)
{
    if(numero % i == 0)
    {
        Console.WriteLine("Divisores "+ i);
    }
}