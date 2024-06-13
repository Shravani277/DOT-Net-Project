using System;

class Hello
{
    class Student
    {
        public int SrNo ;
        public string Name;
        public string Branch ;
        public int Sem ;
        public string College ;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("****** STUDENT MANAGEMENT SYSTEM ******");
        Console.WriteLine("Enter number of student records ::");
        int number = Convert.ToInt32(Console.ReadLine());
        Student[] obj = new Student[number];

        for (int i = 0; i < number; i++)
        {
            obj[i] = new Student();
            Console.WriteLine("STUDENT NUMBER : " + (i + 1));
            Console.WriteLine("Enter student information as name, branch, sem, college :: ");
            obj[i].SrNo = i + 1;
            obj[i].Name = Console.ReadLine();
            obj[i].Branch = Console.ReadLine();
            obj[i].Sem = Convert.ToInt32(Console.ReadLine());
            obj[i].College = Console.ReadLine();
        }

        Console.WriteLine("** STUDENT MANAGEMENT SYSTEM : PRINTING STUDENTS INFORMATION **");
        Console.WriteLine("========================================================================");
        Console.WriteLine("{0,-10} {1,-20} {2,-15} {3,-10} {4,-20}", "SR.NO", "NAME", "BRANCH", "SEM", "COLLEGE");
        Console.WriteLine("========================================================================");

        for (int i = 0; i < number; i++)
        {
            Console.WriteLine("{0,-10} {1,-20} {2,-15} {3,-10} {4,-20}", obj[i].SrNo, obj[i].Name, obj[i].Branch, obj[i].Sem, obj[i].College);
        }

        Console.WriteLine("========================================================================");
    }
}