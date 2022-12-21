using System;
class HelloWorld {
  static void Main() {
int x = 2;
int y = 2;
int z = 2;
Console.WriteLine($"");
int i,j,k;
int[,,] array3D = new int[x, y, z];
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (x = 0; x < array3D.GetLength(0); x++)
  {
    for (y = 0; y < array3D.GetLength(1); y++)
    {
      for (z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
 for (i = 0; i < array3D.GetLength(0); i++)
  {
    for (j = 0; j < array3D.GetLength(1); j++)
    {
      for (k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $"{array3D[i,j,k]}({i},{j},{k}) ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
  }
}