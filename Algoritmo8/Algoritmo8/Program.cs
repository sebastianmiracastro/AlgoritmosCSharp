int KilovateCant;
double Total, CostoKilovate;
CostoKilovate = 0;
string linea;
Console.Write("Cantidad de Kilovatios :"); linea = Console.ReadLine();
KilovateCant = int.Parse(linea);
if ((KilovateCant <= 1000)) CostoKilovate = 0.14;
if (((KilovateCant > 1000) & (KilovateCant <= 1800))) CostoKilovate = 0.12;
if ((KilovateCant > 1800)) CostoKilovate = 0.8;
Total = KilovateCant * CostoKilovate;
Console.WriteLine("A PAGAR: " + Total);