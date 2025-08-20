namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Câu 1(5 điểm)
            // a) Viết chương trình nhập vào một số nguyên n.
            // b) Kiểm tra n có phải là số chẵn hay không.
            // c) Tính tổng các số từ 1 đến n.
            // d) In ra các số nguyên tố nhỏ hơn n.

            // Câu 2(5 điểm)
            // a) Nhập vào một mảng số nguyên gồm n phần tử.
            // b) Tìm phần tử lớn nhất và nhỏ nhất trong mảng.
            // c) Tính tổng các phần tử chia hết cho 3 trong mảng.
            // d) Sắp xếp mảng tăng dần.

            Console.WriteLine("Nhập vào một số nguyên n:");
            int n = int.Parse(Console.ReadLine());
            // Kiểm tra n có phải là số chẵn hay không
            if (n % 2 == 0)
            {
                Console.WriteLine($"{n} là số chẵn.");
            }
            else
            {
                Console.WriteLine($"{n} là số lẻ.");
            }
            // Tính tổng các số từ 1 đến n
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine($"Tổng các số từ 1 đến {n} là: {sum}");
            // In ra các số nguyên tố nhỏ hơn n
            Console.WriteLine($"Các số nguyên tố nhỏ hơn {n} là:");
            for (int i = 2; i < n; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine("\n\nNhập vào một mảng số nguyên gồm n phần tử:");
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            // Tìm phần tử lớn nhất và nhỏ nhất trong mảng
            int max = arr[0];
            int min = arr[0];
            foreach (var item in arr)
            {
                if (item > max) max = item;
                if (item < min) min = item;
            }
            Console.WriteLine($"Phần tử lớn nhất trong mảng: {max}");
            Console.WriteLine($"Phần tử nhỏ nhất trong mảng: {min}");
            // Tính tổng các phần tử chia hết cho 3 trong mảng
            int sumDiv3 = 0;
            foreach (var item in arr)
            {
                if (item % 3 == 0)
                {
                    sumDiv3 += item;
                }
            }
            Console.WriteLine($"Tổng các phần tử chia hết cho 3 trong mảng: {sumDiv3}");

            // Sắp xếp mảng tăng dần
            Array.Sort(arr);
            Console.WriteLine("Mảng sau khi sắp xếp tăng dần:");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}