using System;
class HelloWorld {
static void Main() {
int size = 4;
int[,] nums = new int[size, size];
int num = 1;
int i = 0;
int j = 0;
while (num <= size * size)
{
    nums[i, j] = num;
    if (i <= j + 1 && i + j < size - 1)
        ++j;
    else if (i < j && i + j >= size - 1)
        ++i;
    else if (i >= j && i + j > size - 1)
        --j;
    else
        --i;
    ++num;
}
    for (i = 0; i < nums.GetLength(0); i++)
    {
        for (j = 0; j < nums.GetLength(1); j++)
        {
            if (nums[i,j] < 10)
                 Console.Write("0");
            Console.Write(nums[i, j] + " ");
        }
        Console.WriteLine("");
    }
  }
}