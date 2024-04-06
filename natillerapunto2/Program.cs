using System;

namespace natillerapunto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double TasaInteresMensual = 0.025;
            const double MultaNoAporte = 20000;

            static void Main(string[] args)
            {
                double[] ahorrosSocio1 = new double[12];
                double[] ahorrosSocio2 = new double[12];
                double prestamoSocio1 = 0;
                double prestamoSocio2 = 0;
                int multasSocio1 = 0;
                int multasSocio2 = 0;

                Console.WriteLine("Ingrese los aportes mensuales del primer socio:");
                for (int i = 0; i < 12; i++)
                {
                    Console.Write($"Mes {i + 1}: $");
                    double aporte = Convert.ToDouble(Console.ReadLine());
                    if (aporte == 0)
                        multasSocio1++;
                    else
                        ahorrosSocio1[i] = aporte;
                }

                Console.WriteLine("Ingrese los aportes mensuales del segundo socio:");
                for (int i = 0; i < 12; i++)
                {
                    Console.Write($"Mes {i + 1}: $");
                    double aporte = Convert.ToDouble(Console.ReadLine());
                    if (aporte == 0)
                        multasSocio2++;
                    else
                        ahorrosSocio2[i] = aporte;
                }

        
            }
        }
    }
}

