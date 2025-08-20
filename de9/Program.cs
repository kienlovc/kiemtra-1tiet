// Câu 1 (5 điểm)
// a) Viết hàm tính tổng các ước số thực sự của một số n.
// b) Kiểm tra n có phải là số hoàn hảo không.
// c) Tìm tất cả số hoàn hảo nhỏ hơn n.
// d) Đếm các ước số lẻ của n.

// Câu 2 (5 điểm)
// a) Nhập vào n số, lưu vào mảng.
// b) Tìm và in ra các số lớn hơn giá trị trung bình cộng của mảng.
// c) Đếm số lượng số âm.
// d) In ra các số ở vị trí chẵn trong mảng.
using System;
class Program
{
    static void Main(string[] args)
    {
        // cau 1
        Console.WriteLine("Nhập vào số nguyên dương n:");
        int n = int.Parse(Console.ReadLine());

        // a) Viết hàm tính tổng các ước số thực sự của một số n.
        int SumOfDivisors(int num)
        {
            int sum = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
        Console.WriteLine($"Tổng các ước số thực sự của {n}: {SumOfDivisors(n)}");

        // b) Kiểm tra n có phải là số hoàn hảo không.
        bool IsPerfectNumber(int num)
        {
            return SumOfDivisors(num) == num;
        }
        Console.WriteLine($"{n} có phải là số hoàn hảo không: {IsPerfectNumber(n)}");

        // c) Tìm tất cả số hoàn hảo nhỏ hơn n.
        Console.WriteLine($"Các số hoàn hảo nhỏ hơn {n}:");
        for (int i = 1; i < n; i++)
        {
            if (IsPerfectNumber(i))
            {
                Console.WriteLine(i);
            }
        }

        // d) Đếm các ước số lẻ của n.
        int CountOddDivisors(int num)
        {
            int count = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0 && i % 2 != 0)
                {
                    count++;
                }
            }
            return count;
        }
        Console.WriteLine($"Số lượng ước số lẻ của {n}: {CountOddDivisors(n)}");
        // CAU 2
        Console.WriteLine("Nhập vào số lượng phần tử của mảng:");
        int m = int.Parse(Console.ReadLine());
        int[] arr = new int[m];
        for (int i = 0; i < m; i++)
        {
            Console.WriteLine($"Nhập phần tử thứ {i + 1}:");
            arr[i] = int.Parse(Console.ReadLine());
        }

        // b) Tìm và in ra các số lớn hơn giá trị trung bình cộng của mảng.
        double average = arr.Average();
        Console.WriteLine($"Các số lớn hơn giá trị trung bình cộng ({average}):");
        foreach (var num in arr)
        {
            if (num > average)
            {
                Console.WriteLine(num);
            }
        }

        // c) Đếm số lượng số âm.
        int countNegative = arr.Count(x => x < 0);
        Console.WriteLine($"Số lượng số âm trong mảng: {countNegative}");

        // d) In ra các số ở vị trí chẵn trong mảng.
        Console.WriteLine("Các số ở vị trí chẵn trong mảng:");
        for (int i = 0; i < arr.Length; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}