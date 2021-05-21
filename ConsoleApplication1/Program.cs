using System;
using System.Security.Cryptography;

namespace ConsoleApplication1
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            Student[] studentList = new Student[5];
            Console.Write("Ban muon quan ly bao nhieu sinh vien: ");
            int length = int.Parse(Console.ReadLine());
            studentList = new Student[length];
            int index = 0;
 
        Menu:
            Console.Clear();
            Console.WriteLine("1. Them Sinh Vien");
            Console.WriteLine("2. Danh sach Sinh Vien");
            Console.WriteLine("3. Tim sinh vien theo ID");
            Console.WriteLine("4. Xoa Sinh vien theo ID");
            Console.WriteLine("5. Exit");
            Console.Write("Ban hay lua chon 1 so: ");
            string number = Console.ReadLine();
 
            switch (number)
            {
                case "1":
                    Student s = new Student();
                    Console.Write("Nhap Ten: ");
                    string name = Console.ReadLine();
                    s.SetName(name);
                    Console.Write("Nhap dia chi: ");
                    string address = Console.ReadLine();
                    s.SetAddress(address);
                    DateTime birthday = DateTime.Now;
                NhapBirthDay:
                    Console.Write("Nhap ngay sinh: ");
                    try
                    {
                        birthday = DateTime.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Sai dinh dang ngay thang");
                        Console.ReadLine();
                        goto NhapBirthDay;
                    }
                    s.SetBirthday(birthday);
                    s.SetID(index + 1);
                    studentList[index] = s;
                    index++;
                    goto Menu;
                case "2":
                    Console.WriteLine("Danh Sach Sinh Vien\n---------------------\n");
                    foreach (Student s1 in studentList)
                    {
                        if (s1 != null)
                        {
                            s1.Display();
                        }
                    }
                    Console.ReadLine();
                    goto Menu;
                case "3":
                    Console.WriteLine("nhap id sinh vien muon tim :");
                    string tk = Console.ReadLine();
                    foreach (Student s2 in studentList)
                    {
                        if (s2 == null)
                        {
                            Console.WriteLine("khong tim thay sv");
                        }
                        else
                        {
                            s2.Display();
                        }
                    }
                    Console.ReadLine();
                    goto Menu;
                case "4":
                    goto Menu;
                case "5":
                    break;
                default:
                    Console.WriteLine("Nhap sai so, chi nhan cac gia tri tu 1-5");
                    Console.ReadLine();
                    goto Menu;
 
            }
        }
    }
 
    public class Student
    {
        int id;
        string name;
        string address;
        DateTime birthDay;
 
        public void SetID(int id)
        {
            this.id = id;
        }
 
        public int GetID()
        {
            return this.id;
        }
 
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetAddress(string add)
        {
            address = add;
        }
        public void SetBirthday(DateTime birthday)
        {
            this.birthDay = birthDay;
        }
 
        public void Display()
        {
            Console.WriteLine("Student ID: {0}", id);
            Console.WriteLine("Studdent Name: {0}", name);
            Console.WriteLine("Studnent Address: {0}", address);
            Console.WriteLine("\n--------------------------\n");
        }
 
    }
}