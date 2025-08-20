using System;

class Program
{
    static void Main(string[] args)
    {
        // ===== Câu 1 =====
        Console.WriteLine("Nhập vào số nguyên n:");
        int n = int.Parse(Console.ReadLine());

        // b) Kiểm tra n có phải là số Fibonacci không
        bool isFibonacci = IsFibonacci(n);
        Console.WriteLine($"{n} có phải là số Fibonacci không: {isFibonacci}");

        // c) In các số Fibonacci nhỏ hơn n
        Console.WriteLine($"Các số Fibonacci nhỏ hơn {n}:");
        PrintFibonacciLessThan(n);

        // d) Tính tổng các số Fibonacci nhỏ hơn n
        int sum = SumFibonacciLessThan(n);
        Console.WriteLine($"Tổng các số Fibonacci nhỏ hơn {n} là: {sum}");

        // ===== Câu 2 =====
        Console.WriteLine("Nhập vào số lượng phần tử của mảng:");
        int m = int.Parse(Console.ReadLine());
        int[] arr = new int[m];
        for (int i = 0; i < m; i++)
        {
            Console.WriteLine($"Nhập phần tử thứ {i + 1}:");
            arr[i] = int.Parse(Console.ReadLine());
        }

        // b) Đếm các phần tử là số nguyên tố
        int primeCount = 0;
        foreach (var num in arr)
        {
            if (IsPrime(num))
            {
                primeCount++;
            }
        }
        Console.WriteLine($"Số lượng phần tử là số nguyên tố: {primeCount}");

        // c) Đếm các phần tử là số chính phương
        int perfectSquareCount = 0;
        foreach (var num in arr)
        {
            if (IsPerfectSquare(num))
            {
                perfectSquareCount++;
            }
        }
        Console.WriteLine($"Số lượng phần tử là số chính phương: {perfectSquareCount}");

        // d) Tìm phần tử có giá trị tuyệt đối nhỏ nhất
        int minAbsValue = arr[0];
        foreach (var num in arr)
        {
            if (Math.Abs(num) < Math.Abs(minAbsValue))
            {
                minAbsValue = num;
            }
        }
        Console.WriteLine($"Phần tử có giá trị tuyệt đối nhỏ nhất: {minAbsValue}");
    }

    // ===== Hàm hỗ trợ =====
    static bool IsFibonacci(int n)
    {
        int a = 0, b = 1, c = 0;
        while (c < n)
        {
            c = a + b;
            a = b;
            b = c;
        }
        return c == n || n == 0;
    }

    static void PrintFibonacciLessThan(int n)
    {
        int a = 0, b = 1;
        while (a < n)
        {
            Console.WriteLine(a);
            int c = a + b;
            a = b;
            b = c;
        }
    }

    static int SumFibonacciLessThan(int n)
    {
        int sum = 0, a = 0, b = 1;
        while (a < n)
        {
            sum += a;
            int c = a + b;
            a = b;
            b = c;
        }
        return sum;
    }

    static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }

    static bool IsPerfectSquare(int n)
    {
        if (n < 0) return false;
        int sqrt = (int)Math.Sqrt(n);
        return sqrt * sqrt == n;
    }
}
