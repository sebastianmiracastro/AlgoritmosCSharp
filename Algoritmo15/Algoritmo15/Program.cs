Console.WriteLine("Ingrese Un Valor");
int Num = Convert.ToInt32(Console.ReadLine());

int Limite = 10; //Si quieres un valor de las tablas mas grande, cambialo
int Counter = 1;

while (Counter <= Limite)
{
    int resultado = Num * Counter;
    Console.WriteLine(Num + " x " + Counter +"=" + resultado);
    Counter++;
}