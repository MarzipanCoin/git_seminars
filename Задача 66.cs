using System;
class HelloWorld {
  static void Main() {
    int M = Convert.ToInt32(Console.ReadLine());
    int N = Convert.ToInt32(Console.ReadLine());
    rec(M,N);
  }
  static void rec(int M, int N)
  {
    int sum = 0;
    for (int i=M;i<=N;i++)
    sum = sum + i;
    Console.WriteLine(sum);
  }
}