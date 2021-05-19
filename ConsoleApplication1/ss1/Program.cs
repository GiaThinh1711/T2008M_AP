using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;

namespace ConsoleApplication1.ss1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Student s = new Student();
            s.name = "GT";
            Student.sName = "T2008M";
            ArrayList arrayList = new ArrayList();
            arrayList.Add("aa");
            arrayList.Add("1121");
            List<Student> students = new List<Student>();
            students.Add(s);
            List<int> ints = new List<int>();
            ints.Add(1);
            ints.Add(3);
        }
    }
}