// Câu 1 (5 điểm)
// a) Viết hàm tính giai thừa của một số nguyên n.
// b) Sử dụng hàm vừa viết, tính tổng giai thừa từ 1 đến n.
// c) Tìm số đảo ngược của n (ví dụ n=123 ra 321).
// d) Kiểm tra n có phải là số đối xứng không.

// Câu 2 (5 điểm)
// a) Tạo mảng số nguyên, nhập n phần tử.
// b) Đếm số lượng số âm trong mảng.
// c) In ra các số dương chia hết cho 4.
// d) Tìm chỉ số của phần tử lớn nhất.
using System;
class Program
{
    static void Main(string[] args)
    {
        // Câu 1
        Console.WriteLine("Nhập vào một số nguyên n:");
        int n = int.Parse(Console.ReadLine());

        // a) Tính giai thừa của n
        long Factorial(int number)
        {
            long result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        // b) Tính tổng giai thừa từ 1 đến n
        long sumFactorial = 0;
        for (int i = 1; i <= n; i++)
        {
            sumFactorial += Factorial(i);
        }
        Console.WriteLine($"Tổng giai thừa từ 1 đến {n} là: {sumFactorial}");

        // c) Tìm số đảo ngược của n
        int ReverseNumber(int number)
        {
            int reversed = 0;
            while (number > 0)
            {
                reversed = reversed * 10 + number % 10;
                number /= 10;
            }
            return reversed;
        }
        Console.WriteLine($"Số đảo ngược của {n} là: {ReverseNumber(n)}");

        // d) Kiểm tra n có phải là số đối xứng không
        bool IsPalindrome(int number)
        {
            return number == ReverseNumber(number);
        }
        Console.WriteLine($"{n} có phải là số đối xứng không: {IsPalindrome(n)}");

        // Câu 2
        Console.WriteLine("Nhập vào số lượng phần tử của mảng:");
        int m = int.Parse(Console.ReadLine());
        int[] arr = new int[m];

        Console.WriteLine("Nhập các phần tử của mảng:");
        for (int i = 0; i < m; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        // b) Đếm số lượng số âm trong mảng
        int negativeCount = 0;
        foreach (var item in arr)
        {
            if (item < 0)
            {
                negativeCount++;
            }
        }
        Console.WriteLine($"Số lượng số âm trong mảng: {negativeCount}");

        // c) In ra các số dương chia hết cho 4
        Console.WriteLine("Các số dương chia hết cho 4:");
        foreach (var item in arr)
        {
            if (item > 0 && item % 4 == 0)
            {
                Console.Write(item + " ");
            }
        }
        Console.WriteLine();

        // d) Tìm chỉ số của phần tử lớn nhất
        int maxIndex = Array.IndexOf(arr, arr.Max());
        Console.WriteLine($"Chỉ số của phần tử lớn nhất là: {maxIndex}");

        // cau 2
        Console.WriteLine("Nhập vào số lượng phần tử của mảng:");
        int m = int.Parse(Console.ReadLine());
        int[] arr = new int[m];

        Console.WriteLine("Nhập các phần tử của mảng:");
        for (int i = 0; i < m; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        // b) Đếm số lượng số âm trong mảng
        int negativeCount = 0;
        foreach (var item in arr)
        {
            if (item < 0)
            {
                negativeCount++;
            }
        }
        Console.WriteLine($"Số lượng số âm trong mảng: {negativeCount}");

        // c) In ra các số dương chia hết cho 4
        Console.WriteLine("Các số dương chia hết cho 4:");
        foreach (var item in arr)
        {
            if (item > 0 && item % 4 == 0)
            {
                Console.Write(item + " ");
            }
        }
        Console.WriteLine();

        // d) Tìm chỉ số của phần tử lớn nhất
        int maxIndex = Array.IndexOf(arr, arr.Max());
        Console.WriteLine($"Chỉ số của phần tử lớn nhất là: {maxIndex}");
    }
}