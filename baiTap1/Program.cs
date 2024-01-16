using baiTap1.Modules;
using System;
using System.Collections.Generic;
using System.Text;
class program
{
    public static void displayList(List<NhanVien> listNV)
    {
        Console.WriteLine("Danh sach nhan vien:");
       
        for(int i = 0; i< 5; i++)
        {

            Console.WriteLine(listNV[i].MaNV);
        }

        Console.WriteLine("Press ESc to quit");
        var keyInfo = Console.ReadKey();
        if (keyInfo.Key == ConsoleKey.Escape)
        {

            displayChoose();
        }
        else
        {
            Console.WriteLine("tiếp tục");
            Console.WriteLine("ádghasjgyu");
        }

    }
    public static void addmember()
    {
        Console.WriteLine("2- Thêm mới nhân viên:");
        Console.ReadKey();

    }
    public static void editMember()
    {
        Console.WriteLine("3- Sửa thông tin nhân viên:");

        Console.ReadKey();

    }
    public static void clear()
    {
        Console.WriteLine("Xóa nhân viên:");

        Console.ReadKey();


    }
    public static void exit()
    {
        Console.Clear();
   
        displayChoose();


    }

            public static void displayChoose() {

        Console.WriteLine("DANH SÁCH CÔNG VIỆC\n" +
            "1- Hiện thị danh sách nhân viên" +
           "\n2- Thêm mới nhân viên" +
           "\n3- Sửa thông tin nhân viên" +
           "\n4- Xóa nhân viên" +
           "\n5- Thoát" +
           "\nVui lòng lựa chọn");
       
        int num = int.Parse(Console.ReadLine());
        Console.Write("Bạn đã chọn: ");
        switch (num)
            {
                case 1:

              //  displayList();
                    break;
                case 2:
                    addmember();
                    break;
                case 3:
                    editMember();
                    break;
                case 4:
                    clear();
                    break;
                case 5:
                    exit();
                    break;
                default:
                    
                    Console.WriteLine("vui long nhap lai");
                break;
            }
        }
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        var listNV = new List<NhanVien>
        {
            new NhanVien("NV-001", "A", "020202", "0333", "na", "NV", 2),
       new  NhanVien("NV-002", "B", "020202", "0333", "na", "NV", 2),
       new  NhanVien("NV-003", "C", "020202", "0333", "na", "NV", 2),
        new NhanVien("NV-004", "D", "020202", "0333", "na", "NV", 2),
         new NhanVien("Nv-005", "E", "020202", "0333", "na", "NV", 2),
    };
    
        displayChoose();
        var keyInfo = Console.ReadKey();
       
        do
        {
            displayList(listNV);

            displayChoose();
        }

        while (keyInfo.Key != ConsoleKey.Escape);
        
    }
}