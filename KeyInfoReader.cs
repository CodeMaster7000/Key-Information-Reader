using System; 

class GFG { 
  
    public static void Main() 
    { 
      
        DateTime d = DateTime.Now; 
    
        Console.WriteLine("System date: {0:d}\n"+ 
                          
                        "System time: {0:t}", d); 
      
        Console.Write("Press 'E' to exit the process."); 

        while (Console.ReadKey(false).Key != ConsoleKey.E) { 

        } 
    } 
} 
