int a = 1;
int b = 1;
int counter = 0;   

Console.WriteLine("Limite Para La Suma De Fibonacci: ");
int Num = Convert.ToInt32(Console.ReadLine());

while (counter < Num)
{
    int s = a + b;
    a = b;
    b = s;
    Console.WriteLine(s);
    counter++;
}