using System;
class HelloWorld {
  static void Main() {
      
       int[,] A = new int[2, 2];
       A[0,0] = 2;
       A[0,1] = 4;
       A[1,0] = 3;
       A[1,1] = 2;
        Console.WriteLine("Массив А: ");
        for(int i=0; i < 2; i++) {
            for(int j=0; j < 2; j++) {
                Console.Write(A[i,j] + " ");
            }
            Console.WriteLine();
        }
        
     
      int[,] B = new int[2, 2];
       B[0,0] = 3;
       B[0,1] = 4;
       B[1,0] = 3;
       B[1,1] = 3;
        Console.WriteLine("Массив В: ");
        for(int i=0; i < 2; i++) {
            for(int j=0; j < 2; j++) {
                Console.Write(B[i,j] + " ");
            }
            Console.WriteLine();
        }
         Console.WriteLine();
      
      
      
       int rA = A.GetLength(0);
        int cA = A.GetLength(1);
        int rB = B.GetLength(0);
        int cB = B.GetLength(1);

      Console.WriteLine("A * В: ");
      
      
                  int temp = 0;
            int[,] kHasil = new int[rA, cB];

            for (int i = 0; i < rA; i++)
            {
                for (int j = 0; j < cB; j++)
                {
                    temp = 0;
                    for (int k = 0; k < cA; k++)
                    {
                        temp += A[i, k] * B[k, j];
                    }
                    kHasil[i, j] = temp;
                }
            }

       for(int i=0; i < 2; i++) {
            for(int j=0; j < 2; j++) {
                Console.Write(kHasil[i,j] + " ");
            }
            Console.WriteLine();
        }
         Console.WriteLine();
      
      
  }
}



