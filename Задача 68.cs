using System;

class AC 
{
  
static int Akkerman_function (int m, int n) 
  {
    
if (m == 0)
      
      {
	
return n + 1;
      
}
    
    else if ((m > 0) && (n == 0))
      
      {
	
return Akkerman_function (m - 1, 1);
}
    
    else if ((m > 0) && (n > 0))
      
      {
	
return Akkerman_function (m - 1, Akkerman_function (m, n - 1));
      
}
    else
      
return n + 1;
  
}
  
public static void Main () 
  {
    
Console.WriteLine ("Введите m: ");
    
int m = Convert.ToInt32 (Console.ReadLine ());
    
Console.WriteLine ("Введите n: ");
    
int n = Convert.ToInt32 (Console.ReadLine ());
    
Console.WriteLine (Akkerman_function (m, n));

} 
}