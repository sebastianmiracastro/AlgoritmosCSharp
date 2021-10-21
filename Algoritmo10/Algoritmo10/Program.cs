int NumDia;
string linea;
Console.WriteLine();
Console.WriteLine("DIAS DE LA SEMANA");
Console.WriteLine();
Console.Write("Ingrese un numero del 1 al 7 :");
linea = Console.ReadLine();
NumDia = int.Parse(linea);
switch (NumDia)
{
    case 1:
        Console.WriteLine();
        Console.WriteLine("El numero que ingreso corresponde al dia Lunes");
 break;
    case 2:
        Console.WriteLine();
        Console.WriteLine("El numero que ingreso corresponde al dia Martes");
        break;
    case 3:
        Console.WriteLine();
        Console.WriteLine("El numero que ingreso corresponde al dia Miercoles");
        break;
    case 4:
        Console.WriteLine();
        Console.WriteLine("El numero que ingreso corresponde al dia Jueves");
 break;
    case 5:
        Console.WriteLine();
        Console.WriteLine("El numero que ingreso corresponde al dia Viernes");
        break;
    case 6:
        Console.WriteLine();
        Console.WriteLine("El numero que ingreso corresponde al dia Sabado");
 break;
    case 7:
        Console.WriteLine();
        Console.WriteLine("El numero que ingreso corresponde al dia Domingo");
        break;
    default:
        Console.WriteLine();
        Console.WriteLine("El numero que ingreso esta fuera de rango");
        break;
}