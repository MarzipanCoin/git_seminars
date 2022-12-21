using System;

class TwoD {
    static void Main() {
        int t, i;
        int[,] table = new int[3, 4];
        int count = 100;
        Console.WriteLine("Исходный массив");
        for(t=0; t < 3; ++t) {
            for(i=0; i < 4; ++i) {
                count++;
                table[t,i] = count;
                Console.Write(table[t,i] + " ");
            }
            Console.WriteLine();
        }
        
     
         Console.WriteLine();
        
        
        
        int temp;
            for(int i1=0; i1 < 3; i1++)
            {
            for(i=0; i < 4; ++i) {
                for (int j=i; j<4;j++){
                    if (table[i1,i] < table[i1,j])
                    {
                        temp = table[i1,i];
                        table[i1,i] = table[i1,j];
                        table[i1,j] = temp;
                    }
                }
              //  Console.Write(table[0,i] + " ");
            }
            }
            
        Console.WriteLine("Отсортированный массив");
         for(t=0; t < 3; ++t) {
            for(i=0; i < 4; ++i) {
                Console.Write(table[t,i] + " ");
            }
            Console.WriteLine();
        }
        
        
        
    }
}