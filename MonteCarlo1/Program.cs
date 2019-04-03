using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MonteCarlo
{

    public struct MC1
    {
        double x1;
        double y1;

        public MC1(Random RO1)
        {
            this.x1 = RO1.NextDouble();
            this.y1 = RO1.NextDouble();
        }

        static void Main(string[] args)
        {

            while (true)
            {

                try
                {
                    Random RanGen = new Random();

                    int input = int.Parse(Console.ReadLine());

                    double[] hypsArray = new double[input];

                    for (int i = 0; i < input; i++)
                    {
                        MC1 MonteCarlo = new MC1(RanGen);
                        double newValue = MonteCarlo.HypotenuseFunction1(MonteCarlo);
                        hypsArray.SetValue(newValue, i);
                    }

                    int counter = 0;
                    foreach (double point in hypsArray)
                    {
                        if (point <= 1)
                        {
                            counter++;
                        }
                    }

                    double ratio = (double)counter / hypsArray.Length * 4.0;

                    double difference = Math.Abs(Math.PI - ratio);

                    Console.WriteLine($"Number of valid points is {counter}\n" +
                        $"Estimated Pi: {ratio}\n" +
                        $"This estimate is {difference} off from Math.Pi");
                    break;

                }
                catch (FormatException)
                {
                    Console.WriteLine("Try entering an integer.");
                }
                catch (System.OverflowException)
                {
                    Console.WriteLine("Value entered was either too large or too small for an Int32. try a smaller number.");
                }
                catch (Exception)
                {
                    Console.WriteLine("Something went wrong. try again.");
                }
            }

        }
        public double HypotenuseFunction1(MC1 H1)
        {

            double hypo = Math.Sqrt(Math.Pow(H1.x1, 2) + Math.Pow(H1.y1, 2));
            return hypo;
        }
    }
}
