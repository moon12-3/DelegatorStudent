using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatorStudent
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Students students = new Students();
            students.Add(new Student("박나경", 4));
            students.Add(new Student("김태연", 4));
            students.Add(new Student("김하늘", 4));

            students.Print();
            students.Print((student) =>
            {
                Console.WriteLine("*********");
                Console.WriteLine(" 이름 : " + student.Name);
                Console.WriteLine(" 학점 : " + student.Score);
            });
            students.Print((s) =>
            {
                Console.WriteLine("<student>");
                Console.WriteLine("  <name>" + s.Name + "</name>");
                Console.WriteLine("  <score>" + s.Score + "</score>");
                Console.WriteLine("</student>");
            });
            Console.WriteLine("</student>");
        }
    }
}
