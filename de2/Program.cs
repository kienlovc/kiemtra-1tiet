// See https://aka.ms/new-console-template for more information
// Câu 1 (5 điểm)
// a) Nhập vào một chuỗi ký tự.
// b) Đếm số lượng ký tự 'a' trong chuỗi.
// c) Đảo ngược chuỗi vừa nhập.
// d) Kiểm tra chuỗi có đối xứng không.

// Câu 2 (5 điểm)
// a) Viết hàm kiểm tra số hoàn hảo.
// b) Nhập vào n số nguyên. Đếm xem có bao nhiêu số hoàn hảo.
// c) Tính trung bình cộng các số lẻ trong mảng.
// d) In ra các số chia hết cho 5 nhưng không chia hết cho 2.
// cau 1
using System;
class Program
{
    static void Main(string[] args)
    {
        // Câu 1 (5 điểm)
        // a) Nhập vào một chuỗi ký tự.
        Console.WriteLine("Nhập vào một chuỗi ký tự:");
        string input = Console.ReadLine();

        // b) Đếm số lượng ký tự 'a' trong chuỗi.
        int countA = 0;
        foreach (char c in input)
        {
            if (c == 'a' || c == 'A')
            {
                countA++;
            }
        }
        Console.WriteLine($"Số lượng ký tự 'a' trong chuỗi: {countA}");

        // c) Đảo ngược chuỗi vừa nhập.
        char[] reversedArray = input.ToCharArray();
        Array.Reverse(reversedArray);
        string reversedString = new string(reversedArray);
        Console.WriteLine($"Chuỗi đảo ngược: {reversedString}");

        // d) Kiểm tra chuỗi có đối xứng không.
        bool isPalindrome = input.Equals(reversedString, StringComparison.OrdinalIgnoreCase);
        Console.WriteLine($"Chuỗi có đối xứng không: {isPalindrome}");

        // Câu 2 (5 điểm)
        // a) Viết hàm kiểm tra số hoàn hảo.
        bool IsPerfectNumber(int number)
        {
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            return sum == number;
        }

        // b) Nhập vào n số nguyên. Đếm xem có bao nhiêu số hoàn hảo.
        Console.WriteLine("Nhập vào số lượng số nguyên:");
        int n = int.Parse(Console.ReadLine());
        int perfectCount = 0;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhập số thứ {i + 1}:");
            int num = int.Parse(Console.ReadLine());
            if (IsPerfectNumber(num))
            {
                perfectCount++;
            }
        }
        Console.WriteLine($"Số lượng số hoàn hảo: {perfectCount}");

        // c) Tính trung bình cộng các số lẻ trong mảng.
        int[] numbers = new int[n];
        int sumOdd = 0;
        int countOdd = 0;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhập số thứ {i + 1}:");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        foreach (var item in numbers)
        {
            if (item % 2 != 0)
            {
                sumOdd += item;
                countOdd++;
            }
        }

        if (countOdd > 0)
        {
            double averageOdd = (double)sumOdd / countOdd;
            Console.WriteLine($"Trung bình cộng các số lẻ trong mảng: {averageOdd}");
        }
        else
        {
            Console.WriteLine("Không có số lẻ trong mảng.");
        }
        // d) In ra các số chia hết cho 5 nhưng không chia hết cho 2.
        Console.WriteLine("Các số chia hết cho 5 nhưng không chia hết cho 2:");
        foreach (var item in numbers)
        {
            if (item % 5 == 0 && item % 2 != 0)
            {
                Console.Write(item + " ");
            }
        }

    }
}