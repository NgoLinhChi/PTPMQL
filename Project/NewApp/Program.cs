﻿using System.Collections;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks.Dataflow;
using NewApp.Models;
public class Program {
    private static void Main(string[] args){
        int n;
        System.Console.WriteLine("Nhap kich thuoc mang Person: ");
        n = Convert.ToInt32(Console.ReadLine());
        Person[] psArr = new Person[n];
        for(int i = 0; i < psArr.Length; i++)
        {
            Console.WriteLine("Nhap thong tin nguoi thu {0}", i+1);
        Person ps = new Person();
        ps.Nhapthongtin();
        psArr[i] = ps;
        }
        System.Console.WriteLine("Hien thi mang Person");
        foreach(Person ps in psArr){
            ps.HienThi();
        }

        System.Console.WriteLine("Nhap kich thuoc mang Student: ");
          n = Convert.ToInt32(Console.ReadLine());
        Student[] stdArr = new Student[n];
        for(int i = 0; i < stdArr.Length; i++)
        {
            Console.WriteLine("Nhap thong tin sinh vien thu {0}", i+1);
        Student std = new Student();
        std.Nhapthongtin();
        stdArr[i] = std;
        }
        System.Console.WriteLine("Hien thi mang Student");
        foreach(Student std in psArr){
            std.HienThi();
        }

        System.Console.WriteLine("Nhap kich thuoc mang Employee: ");
          n = Convert.ToInt32(Console.ReadLine());
        Employee[] empArr = new Employee[n];
        for(int i = 0; i < empArr.Length; i++)
        {
            Console.WriteLine("Nhap thong tin nhan vien thu {0}", i+1);
        Employee emp = new Employee();
        emp.Nhapthongtin();
        empArr[i] = emp;
        }
        System.Console.WriteLine("Hien thi mang Employee");
        foreach(Employee emp in empArr){
            emp.HienThi();
        }

        System.Console.WriteLine("Nhap kich thuoc mang Customer: ");
          n = Convert.ToInt32(Console.ReadLine());
        Customer[] ctmArr = new Customer[n];
        for(int i = 0; i < ctmArr.Length; i++)
        {
            Console.WriteLine("Nhap thong tin khach hang thu {0}", i+1);
        Customer ctm = new Customer();
        ctm.Nhapthongtin();
        ctmArr[i] = ctm;
        }
        System.Console.WriteLine("Hien thi mang Customer");
        foreach(Customer ctm in ctmArr){
            ctm.HienThi();
        }
    }
}
