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

                double totalAhorrosSocio1 = CalcularTotalAhorrosSocio(ahorrosSocio1);
                double totalAhorrosSocio2 = CalcularTotalAhorrosSocio(ahorrosSocio2);
                double interesesSocio1 = (prestamoSocio1 > 0) ? CalcularIntereses(prestamoSocio1, DateTime.Now.Month) : 0;
                double interesesSocio2 = (prestamoSocio2 > 0) ? CalcularIntereses(prestamoSocio2, DateTime.Now.Month) : 0;
                double totalIntereses = interesesSocio1 + interesesSocio2;
                double totalMultas = MultaNoAporte * (multasSocio1 + multasSocio2);
                double totalPrestamos = prestamoSocio1 + prestamoSocio2;
                double valorNetoSocio1 = totalAhorrosSocio1 - prestamoSocio1 + interesesSocio1 - (multasSocio1 * MultaNoAporte);
                double valorNetoSocio2 = totalAhorrosSocio2 - prestamoSocio2 + interesesSocio2 - (multasSocio2 * MultaNoAporte);
                double valorNetoTotal = valorNetoSocio1 + valorNetoSocio2;

                Console.WriteLine($"Total ahorros socio 1: ${totalAhorrosSocio1}");
                Console.WriteLine($"Total ahorros socio 2: ${totalAhorrosSocio2}");
                Console.WriteLine($"Total intereses generados: ${totalIntereses}");
                Console.WriteLine($"Total multas pagadas: ${totalMultas}");
                Console.WriteLine($"Total préstamos: ${totalPrestamos}");
                Console.WriteLine($"Valor neto a liquidar a socio 1: ${valorNetoSocio1}");
                Console.WriteLine($"Valor neto a liquidar a socio 2: ${valorNetoSocio2}");
                Console.WriteLine($"Valor neto total a liquidar: ${valorNetoTotal}");
            }

            static double CalcularTotalAhorrosSocio(double[] ahorros)
            {
                double total = 0;
                foreach (var ahorro in ahorros)
                {
                    total += ahorro;
                }
                return total;
            }

            static double CalcularIntereses(double prestamo, int mesInicio)
            {
                double intereses = 0;
                for (int i = mesInicio; i <= 12; i++)
                {
                    intereses += prestamo * TasaInteresMensual;
                }
                return intereses;
            }
        }
    }
}

