﻿double SUELDO, ARECIBIR;
int NHIJO, BONO;
string NOM, linea;
Console.Write("NOMBRE EMPLEADO :"); NOM = Console.ReadLine();
Console.Write("SUELDO EMPLEADO :"); linea = Console.ReadLine();
SUELDO = double.Parse(linea);
Console.Write("NÚMERO DE HIJOS :"); linea = Console.ReadLine();
NHIJO = int.Parse(linea);
if (NHIJO >= 3) { BONO = NHIJO * 10; } else { BONO = NHIJO * 20; }
ARECIBIR = SUELDO + BONO;
Console.WriteLine("RECIBE :" + String.Format("{0:c}", ARECIBIR));