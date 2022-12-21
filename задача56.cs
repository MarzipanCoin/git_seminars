using System;

class TwoD {
    static void Main() {
        int t, i;
        int[,] table = new int[3, 4];
        int count = 50,count2 = 20;
        Console.WriteLine("Исходный массив");
        for(t=0; t < 3; ++t) {
            for(i=0; i < 4; ++i) {
                count++;
                count2++;
                if (t<2)
                table[t,i] = count;
                else
                table[t,i] = count2;
                Console.Write(table[t,i] + " ");
            }
            Console.WriteLine();
        }
        
     
         Console.WriteLine();
        
        int suma = 0,min,index_rez=0;
        
        for(i=0; i < 4; ++i)
            suma = suma + table[0,i];
            
        min = suma+1;
        for (int j=0;j<3;j++)
        {
            suma = 0;
        for(i=0; i < 4; ++i){
            suma = suma + table[j,i];
        }
        if (suma < min)
        {
            min = suma;
            index_rez = j+1;
        }
        
       
        }
        Console.WriteLine("Номер строки с наименьшей суммой: ");
         Console.WriteLine(index_rez);
        
    }
}