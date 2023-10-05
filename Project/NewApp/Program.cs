﻿using System.Collections;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks.Dataflow;
using NewApp.Models;
public class Program {
    private static void Main(string[] args){
        int n;
        System.Console.WriteLine("Nhap kich thuoc danh sach: ");
        n = Convert.ToInt32(Console.ReadLine());
      ArrayList stdList = new ArrayList();
      for(int i = 0; i < n; i++){
        System.Console.WriteLine("Nhap thong tin sinh vien thu {0}", i+1);
        Student std = new Student();
        std.Nhapthongtin();
        stdList.Add(std);
        }
        System.Console.WriteLine("Hien thi danh sach");
        foreach(Student std in stdList){
            std.HienThi();
        }

        int indexToEdit = 0;
        if (indexToEdit >=0 && indexToEdit < stdList.Count)
        {
            System.Console.WriteLine("Nhap thong tin moi cho sinh vien thu {0}", indexToEdit +1);
            Student newStudentInfo = new Student();
            newStudentInfo.Nhapthongtin();
            stdList[indexToEdit] = newStudentInfo;
        }
        else{
            System.Console.WriteLine("Vi tri khong hop le.");        
        }
        int indexToDelete =1;
        if(indexToDelete >= 0 && indexToDelete <stdList.Count){
            stdList.RemoveAt(indexToDelete);
            System.Console.WriteLine("Da xoa sinh vien thu {0}", indexToDelete+1);
        }
        else{
            System.Console.WriteLine("Vi tri khong hop le.");
        }

    }
}
