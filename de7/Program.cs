// Câu 1 (5 điểm)
// a) Viết chương trình chuyển đổi nhiệt độ từ Celsius sang Fahrenheit và ngược lại.
// b) Nhập danh sách nhiệt độ của 7 ngày.
// c) Tìm nhiệt độ cao nhất, thấp nhất trong tuần.
// d) Tính nhiệt độ trung bình cả tuần.

// Câu 2 (5 điểm)
// a) Nhập chuỗi ký tự.
// b) Đếm số lượng chữ hoa, chữ thường.
// c) Viết hàm kiểm tra chuỗi có phải chỉ gồm số không.
// d) In ra các ký tự khác ký tự số.
using System;
class Program
{
    static void Main(string[] args)
    {
        //cau1
        Console.WriteLine("Nhập nhiệt độ (Celsius):");
        double celsius = double.Parse(Console.ReadLine());
        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine($"Nhiệt độ (Fahrenheit): {fahrenheit}");
        double celsius2 = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine($"Nhiệt độ (Celsius): {celsius2}");

        // b) Nhập danh sách nhiệt độ của 7 ngày.
        double[] temperatures = new double[7];
        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine($"Nhập nhiệt độ ngày {i + 1}:");
            temperatures[i] = double.Parse(Console.ReadLine());
        }

        // c) Tìm nhiệt độ cao nhất, thấp nhất trong tuần.
        double maxTemp = temperatures[0];
        double minTemp = temperatures[0];
        double sum = 0;
        foreach (var temp in temperatures)
        {
            if (temp > maxTemp) maxTemp = temp;
            if (temp < minTemp) minTemp = temp;
            sum += temp;
        }
        Console.WriteLine($"Nhiệt độ cao nhất: {maxTemp}");
        Console.WriteLine($"Nhiệt độ thấp nhất: {minTemp}");

        // d) Tính nhiệt độ trung bình cả tuần.
        double average = sum / 7;
        Console.WriteLine($"Nhiệt độ trung bình: {average}");
        // cau2
        // a) Nhập chuỗi ký tự.
        Console.WriteLine("Nhập chuỗi ký tự:");
        string input = Console.ReadLine();

        // b) Đếm số lượng chữ hoa, chữ thường.
        int upperCount = 0;
        int lowerCount = 0;
        foreach (char c in input)
        {
            if (char.IsUpper(c)) upperCount++;
            if (char.IsLower(c)) lowerCount++;
        }
        Console.WriteLine($"Số lượng chữ hoa: {upperCount}");
        Console.WriteLine($"Số lượng chữ thường: {lowerCount}");

        // c) Viết hàm kiểm tra chuỗi có phải chỉ gồm số không.
        bool isNumeric = IsNumeric(input);
        Console.WriteLine($"Chuỗi có phải chỉ gồm số không: {isNumeric}");

        // d) In ra các ký tự khác ký tự số.
        Console.WriteLine("Các ký tự khác ký tự số:");
        foreach (char c in input)
        {
            if (!char.IsDigit(c))
            {
                Console.Write(c);
            }
        }
    }

    static bool IsNumeric(string str)
    {
        foreach (char c in str)
        {
            if (!char.IsDigit(c)) return false;
        }
        return true;
    }
}