Console.WriteLine("Ingrese Un Valor");
int Num = Convert.ToInt32(Console.ReadLine());

int suma = 0;
int numero = 0;

while (numero < Num)
{
    numero += 1;
    if(numero % 2 != 0)
    {
        Console.WriteLine(numero);
    }
    suma = suma + numero;
    numero++;
}
Console.WriteLine("La Suma De Los Valores Impares es: " + suma);