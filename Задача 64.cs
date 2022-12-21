using System;
class HelloWorld {
  static void Main() {
    int N = Convert.ToInt32(Console.ReadLine());
    rec(N);
  }
  static void rec(int N)
  {
      Console.WriteLine(N);
      N--;
      if (N>=1)
      rec(N);
  }
}