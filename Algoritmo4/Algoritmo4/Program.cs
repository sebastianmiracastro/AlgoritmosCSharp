﻿double BASE, ALTURA, RESUL;
string linea;
Console.Write("DIGITE LA BASE :"); linea = Console.ReadLine();
BASE = double.Parse(linea);
Console.Write("DIGITE LA ALTURA:"); linea = Console.ReadLine();
ALTURA = double.Parse(linea);
RESUL = (BASE * ALTURA) / 2;
Console.WriteLine("AREA TRIANGULO :" + String.Format("{0:####.00}", RESUL));
Console.WriteLine();
Console.WriteLine("HOY ES: " + String.Format("Hoy es {0:F}", DateTime.Now));