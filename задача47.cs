using System;
class HelloWorld {
  static void Main() {
Console.Write("m = ");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.Write("n = ");
int columnsVol = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[linesVol, columnsVol];

 for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }


for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write(numbers[i, j] + " ");
        }
        Console.WriteLine("");
    }


  }
}
