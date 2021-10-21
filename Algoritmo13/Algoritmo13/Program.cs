Console.WriteLine("Ingrese Un Valor Numerico");
int Num = Convert.ToInt32(Console.ReadLine());

int Factorial = 1;

while (Num != 0)
{
    Factorial = Factorial * Num;
    Num = Num - 1;
}
Console.WriteLine("El Factorial Del Numero Puesto es: " + Factorial);