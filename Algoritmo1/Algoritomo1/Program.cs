int NUM, AUX, DEC, UNI, CEN;
string linea;
Console.WriteLine("Ingrese un numero");
linea = Console.ReadLine();
NUM = int.Parse(linea);
CEN = NUM / 100;
NUM = NUM % 100;
DEC = NUM / 10;
UNI = NUM % 10;
AUX = (UNI * 100) + (DEC * 10) + CEN;

Console.WriteLine("Numero Invertido: " + AUX);
Console.WriteLine();