// Câu 1 (5 điểm)
// a) Viết đoạn chương trình in bảng cửu chương của số n (với n nhập từ bàn phím).
// b) Tính tổng các chữ số của n.
// c) Kiểm tra n có phải là số nguyên tố hay không.
// d) Nhập thêm m, kiểm tra n có chia hết cho m không.

// Câu 2 (5 điểm)
// a) Nhập vào một dãy số thực gồm n phần tử.
// b) Tìm giá trị trung bình cộng của dãy số.
// c) Đếm số phần tử lớn hơn trung bình cộng.
// d) Tính tổng các phần tử âm trong dãy số.
using System;
class Program
{
    static void Main(string[] args)
    {
        // cau 1
        Console.WriteLine("Nhập vào một số nguyên:");
        int n = int.Parse(Console.ReadLine() ?? "0");

        // a) In bảng cửu chương của số n
        Console.WriteLine($"Bảng cửu chương của {n}:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{n} x {i} = {n * i}");
        }

        // b) Tính tổng các chữ số của n
        int sum = 0;
        int temp = n;
        while (temp > 0)
        {
            sum += temp % 10;
            temp /= 10;
        }
        Console.WriteLine($"Tổng các chữ số của {n} là: {sum}");

        // c) Kiểm tra n có phải là số nguyên tố hay không
        bool isPrime = true;
        if (n < 2) isPrime = false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        Console.WriteLine($"{n} có phải là số nguyên tố không: {isPrime}");

        // d) Nhập thêm m, kiểm tra n có chia hết cho m không
        Console.WriteLine("Nhập vào một số nguyên m:");
        int m = int.Parse(Console.ReadLine() ?? "0");
        bool isDivisible = n % m == 0;
        Console.WriteLine($"{n} có chia hết cho {m} không: {isDivisible}");

        // cau 2
        Console.WriteLine("Nhập vào số lượng phần tử:");
        int count = int.Parse(Console.ReadLine() ?? "0");
        double[] arr = new double[count];
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"Nhập phần tử thứ {i + 1}:");
            arr[i] = double.Parse(Console.ReadLine() ?? "0");
        }

        // b) Tìm giá trị trung bình cộng của dãy số.
        double average = arr.Average();
        Console.WriteLine($"Giá trị trung bình cộng của dãy số là: {average}");

        // c) Đếm số phần tử lớn hơn trung bình cộng.
        int countAboveAverage = arr.Count(x => x > average);
        Console.WriteLine($"Số phần tử lớn hơn trung bình cộng là: {countAboveAverage}");

        // d) Tính tổng các phần tử âm trong dãy số.
        double sumNegative = arr.Where(x => x < 0).Sum();
        Console.WriteLine($"Tổng các phần tử âm trong dãy số là: {sumNegative}");
    }
}