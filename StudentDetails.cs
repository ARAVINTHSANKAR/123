using System;

namespace day_1
{
    struct Base 
        {
            public String name;
            public String universityName;
            public String stream;
            public int rollNum;
            public int age;
        }
    public class StudentDetails
    {
        Base obj_2 = new Base();
        public void details() 
         {
            Console.WriteLine("Enter the Details");
            obj_2.name = Console.ReadLine();
            obj_2.universityName = Console.ReadLine();
            obj_2.stream = Console.ReadLine();
            obj_2.rollNum = Convert.ToInt32(Console.ReadLine());
            obj_2.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Student Details");
            Console.WriteLine("Name : "      + obj_2.name);
            Console.WriteLine("College : "   + obj_2.universityName);
            Console.WriteLine("Department :" + obj_2.stream);
            Console.WriteLine("RollNum : "   + obj_2.rollNum);
            Console.WriteLine("Age :"        + obj_2.age);
        }
    }
}
