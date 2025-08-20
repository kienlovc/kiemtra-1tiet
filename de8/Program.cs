// Câu 1 (5 điểm)
// a) Viết chương trình xuất bảng các số và bình phương (từ 1 đến n).
// b) Tính tổng bình phương các số chia hết cho 3.
// c) In ra các số chia hết cho 2 và 5.
// d) Nhập m, tìm m số lẻ liên tiếp lớn hơn n.

// Câu 2 (5 điểm)
// a) Nhập mảng số nguyên.
// b) Đếm số lượng số có chữ số tận cùng là 5.
// c) In ra các phần tử phân biệt trong mảng.
// d) Tìm phần tử xuất hiện nhiều lần nhất.
using System;
class Program
{
    static void Main(string[] args)
    {
        // cau 1
        // a) Viết chương trình xuất bảng các số và bình phương (từ 1 đến n).
        Console.WriteLine("Nhập vào số nguyên dương n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Bảng số và bình phương:");
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"{i} \t {i * i}");
        }
        // b) Tính tổng bình phương các số chia hết cho 3.
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0)
            {
                sum += i * i;
            }
        }
        Console.WriteLine($"Tổng bình phương các số chia hết cho 3: {sum}");
        // c) In ra các số chia hết cho 2 và 5.
        Console.WriteLine("Các số chia hết cho 2 và 5:");
        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0 && i % 5 == 0)
            {
                Console.WriteLine(i);
            }
        }
        // d) Nhập m, tìm m số lẻ liên tiếp lớn hơn n.
        Console.WriteLine("Nhập vào số nguyên dương m:");
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine($"Các số lẻ liên tiếp lớn hơn {n}:");
        int count = 0;
        int odd = n + 1;
        while (count < m)
        {
            if (odd % 2 != 0)
            {
                Console.WriteLine(odd);
                count++;
            }
            odd++;
        }
        // d) Tìm m số lẻ liên tiếp lớn hơn n.
        Console.WriteLine($"Các số lẻ liên tiếp lớn hơn {n}:");
        for (int i = n + 1; count < m; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
                count++;
            }
        }
        // cau 2
        Console.WriteLine("Nhập vào số lượng phần tử của mảng:");
        int m = int.Parse(Console.ReadLine());
        int[] arr = new int[m];
        for (int i = 0; i < m; i++)
        {
            Console.WriteLine($"Nhập phần tử thứ {i + 1}:");
            arr[i] = int.Parse(Console.ReadLine());
        }

        // b) Đếm số lượng số có chữ số tận cùng là 5.
        int count5 = 0;
        foreach (var num in arr)
        {
            if (num % 10 == 5)
            {
                count5++;
            }
        }
        Console.WriteLine($"Số lượng số có chữ số tận cùng là 5: {count5}");

        // c) In ra các phần tử phân biệt trong mảng.
        Console.WriteLine("Các phần tử phân biệt trong mảng:");
        var distinctElements = arr.Distinct();
        foreach (var num in distinctElements)
        {
            Console.WriteLine(num);
        }

        // d) Tìm phần tử xuất hiện nhiều lần nhất.
        var mostFrequent = arr.GroupBy(x => x)
                               .OrderByDescending(g => g.Count())
                               .FirstOrDefault();
        if (mostFrequent != null)
        {
            Console.WriteLine($"Phần tử xuất hiện nhiều lần nhất: {mostFrequent.Key}");
        }
    }
}