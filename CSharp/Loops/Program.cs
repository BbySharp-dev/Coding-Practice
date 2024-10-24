// 1. Viết chương trình in các số từ 1 đến 100.
#region In các số từ 1 đến 100
for (int i = 1; i <= 100; i++)
{
    Console.WriteLine(i);
}
#endregion

// 2. Viết chương trình tính tổng các số chẵn từ 1 đến 100.
#region Tính tổng các số chẵn từ 1 đến 100
int sum = 0;
for (int i = 2; i <= 100; i += 2)
{
    sum += i;
}
Console.WriteLine($"Tổng các số chẵn từ 1 đến 100 là: {sum}");
#endregion

// 3. Viết chương trình tính giai thừa của một số nguyên n nhập từ bàn phím.
#region Tính giai thừa của một số nguyên
Console.WriteLine("\nNhập một số nguyên dương: ");
string? input = Console.ReadLine();

if (!string.IsNullOrWhiteSpace(input) && int.TryParse(input, out int n) && n >= 0)
{
    long factorial = 1;
    for (int i = 2; i <= n; i++)
    {
        factorial *= i;
    }
    Console.WriteLine($"Giai thừa của {n} là: {factorial}");
}
else
{
    Console.WriteLine("Giá trị không hợp lệ.");
}
#endregion

// 4. Viết chương trình in ra dãy số Fibonacci với n phần tử.
#region In dãy số Fibonacci
Console.WriteLine("\nNhập số phần tử của dãy Fibonacci: ");
input = Console.ReadLine();

if (!string.IsNullOrWhiteSpace(input) && int.TryParse(input, out n) && n > 0)
{
    int first = 0, second = 1, next;
    Console.Write($"{first} {second} ");

    for (int i = 3; i <= n; i++)
    {
        next = first + second;
        Console.Write($"{next} ");
        first = second;
        second = next;
    }
    Console.WriteLine();
}
else
{
    Console.WriteLine("Giá trị không hợp lệ.");
}
#endregion

// 5. Viết chương trình in ra bảng cửu chương từ 1 đến 10.
#region In bảng cửu chương từ 1 đến 10
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"\nBảng cửu chương của {i}:");
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
}
#endregion