// Câu 1 (5 điểm)
// a) Viết hàm kiểm tra năm nhuận.
// b) Nhập vào ngày, tháng, năm. Kiểm tra ngày tháng năm hợp lệ.
// c) Tính số ngày của tháng đó.
// d) Kiểm tra nếu ngày là chủ nhật (gợi ý: sử dụng lớp DateTime).

// Câu 2 (5 điểm)
// a) Nhập vào mảng tên của n sinh viên.
// b) In ra tên có độ dài ngắn nhất.
// c) In ra các tên bắt đầu bằng ký tự 'H'.
// d) Sắp xếp tên theo thứ tự bảng chữ cái.
using System;
class Program
{
    static void Main(string[] args)
    {
        //cau 1
        Console.WriteLine("Nhập vào năm:");
        int year = int.Parse(Console.ReadLine());
        bool isLeapYear = DateTime.IsLeapYear(year);
        Console.WriteLine($"{year} có phải là năm nhuận không: {isLeapYear}");

        // b) Nhập vào ngày, tháng, năm. Kiểm tra ngày tháng năm hợp lệ.
        Console.WriteLine("Nhập vào ngày:");
        int day = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhập vào tháng:");
        int month = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhập vào năm:");
        year = int.Parse(Console.ReadLine());
        bool isValidDate = DateTime.TryParse($"{day}/{month}/{year}", out DateTime validDate);
        Console.WriteLine($"Ngày tháng năm có hợp lệ không: {isValidDate}");

        // c) Tính số ngày của tháng đó.
        int daysInMonth = DateTime.DaysInMonth(year, month);
        Console.WriteLine($"Số ngày của tháng {month} năm {year} là: {daysInMonth}");

        // d) Kiểm tra nếu ngày là chủ nhật (gợi ý: sử dụng lớp DateTime).
        Console.WriteLine("Nhập vào ngày:");
        day = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhập vào tháng:");
        month = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhập vào năm:");
        year = int.Parse(Console.ReadLine());
        DateTime date = new DateTime(year, month, day);
        bool isSunday = date.DayOfWeek == DayOfWeek.Sunday;
        Console.WriteLine($"Ngày {day}/{month}/{year} có phải là chủ nhật không: {isSunday}");

        // cau 2
        Console.WriteLine("Nhập vào số lượng sinh viên:");
        int n = int.Parse(Console.ReadLine());
        string[] studentNames = new string[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhập tên sinh viên thứ {i + 1}:");
            studentNames[i] = Console.ReadLine();
        }

        // b) In ra tên có độ dài ngắn nhất.
        string shortestName = studentNames[0];
        foreach (var name in studentNames)
        {
            if (name.Length < shortestName.Length)
            {
                shortestName = name;
            }
        }
        Console.WriteLine($"Tên có độ dài ngắn nhất là: {shortestName}");

        // c) In ra các tên bắt đầu bằng ký tự 'H'.
        Console.WriteLine("Các tên bắt đầu bằng ký tự 'H':");
        foreach (var name in studentNames)
        {
            if (name.StartsWith("H"))
            {
                Console.WriteLine(name);
            }
        }

        // d) Sắp xếp tên theo thứ tự bảng chữ cái.
        Array.Sort(studentNames);
        Console.WriteLine("Danh sách tên sau khi sắp xếp:");
        foreach (var name in studentNames)
        {
            Console.WriteLine(name);
        }
    }
}