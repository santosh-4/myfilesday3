using System;

    class Program 
    {
  
    // Main Method
    public static void Main()
    {
        char ch;
        string str1 = "Santosh KUMAR";
        for(int i=0; i <str1.Length; i++)
         {
           if (Char.IsLower(str1[i])) 
           {
              Console.Write(Char.ToUpper(str1[i])); 
           }
              else
              {
              Console.Write(Char.ToLower(str1[i]));
              }
         }
    }
    
    
    }