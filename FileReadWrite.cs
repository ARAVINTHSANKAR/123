using System;
using System.IO;


namespace day_1 
{
    public class FileReadWrite
    {
        public void read()
        {
            FileStream f = new FileStream("D:\\dotnet\\day_1\\read.txt" , FileMode.Open);
        
         int i = 0;  
        while ((i = f.ReadByte()) != -1)  
        {  
            Console.Write((char)i);  
        }  
        f.Close();  
        }

        public void write()
        {
             FileStream f = new FileStream("D:\\dotnet\\day_1\\write.txt", FileMode.Open);  
        Console.WriteLine("Enter your text");  
          for (int i = 0; i <= 7; i++)
            {
                char a = Convert.ToChar(Console.ReadLine());  
                f.WriteByte((byte)a);    
            }
            f.Close();
            Console.WriteLine("Go see the file");
        }     
    }
}