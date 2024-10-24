// 1.Viết chương trình kiểm tra số nhập vào từ bàn phím là số dương, âm hay bằng 0.
#region Kiểm tra số dương, âm hay bằng 0
Console.WriteLine("Nhập một số nguyên: ");
string? input = Console.ReadLine();

if (!string.IsNullOrWhiteSpace(input) && int.TryParse(input, out int number))
{
    if (number > 0)
        Console.WriteLine($"{number} là số dương.");
    else if (number < 0)
        Console.WriteLine($"{number} là số âm.");
    else
        Console.WriteLine($"{number} bằng 0.");
}
else
{
    Console.WriteLine("Giá trị không hợp lệ.");
}
#endregion

// 2.Viết chương trình kiểm tra xem một năm có phải là năm nhuận hay không.
#region Kiểm tra năm nhuận
Console.WriteLine("\nNhập một năm: ");
input = Console.ReadLine();

if (!string.IsNullOrWhiteSpace(input) && int.TryParse(input, out int year))
{
    if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
        Console.WriteLine($"{year} là năm nhuận.");
    else
        Console.WriteLine($"{year} không phải là năm nhuận.");
}
else
{
    Console.WriteLine("Giá trị không hợp lệ.");
}
#endregion

// 3.Nhập vào hai số nguyên và kiểm tra xem số nào lớn hơn.
#region So sánh hai số nguyên
Console.WriteLine("\nNhập số nguyên thứ nhất: ");
string? input1 = Console.ReadLine();
Console.WriteLine("Nhập số nguyên thứ hai: ");
string? input2 = Console.ReadLine();

if (!string.IsNullOrWhiteSpace(input1) && int.TryParse(input1, out int number1) &&
    !string.IsNullOrWhiteSpace(input2) && int.TryParse(input2, out int number2))
{
    if (number1 > number2)
        Console.WriteLine($"{number1} lớn hơn {number2}.");
    else if (number1 < number2)
        Console.WriteLine($"{number1} nhỏ hơn {number2}.");
    else
        Console.WriteLine($"{number1} bằng {number2}.");
}
else
{
    Console.WriteLine("Giá trị không hợp lệ.");
}
#endregion

// 4.Viết chương trình kiểm tra một số có phải là số nguyên tố hay không.
#region Kiểm tra số nguyên tố
Console.WriteLine("\nNhập một số nguyên: ");
input = Console.ReadLine();

if (!string.IsNullOrWhiteSpace(input) && int.TryParse(input, out int primeCheck))
{
    bool isPrime = true;
    if (primeCheck <= 1)
    {
        isPrime = false;
    }
    else
    {
        for (int i = 2; i <= Math.Sqrt(primeCheck); i++)
        {
            if (primeCheck % i == 0)
            {
                isPrime = false;
                break;
            }
        }
    }

    if (isPrime)
        Console.WriteLine($"{primeCheck} là số nguyên tố.");
    else
        Console.WriteLine($"{primeCheck} không phải là số nguyên tố.");
}
else
{
    Console.WriteLine("Giá trị không hợp lệ.");
}
#endregion

// 5.Tính giá điện tiêu thụ theo các bậc, dựa trên số điện tiêu thụ nhập vào từ bàn phím.
#region Tính giá điện tiêu thụ
Console.WriteLine("\nNhập số kWh tiêu thụ: ");
input = Console.ReadLine();

if (!string.IsNullOrWhiteSpace(input) && double.TryParse(input, out double kWh))
{
    double bill = 0;

    if (kWh <= 100)
        bill = kWh * 1500;
    else if (kWh <= 200)
        bill = 100 * 1500 + (kWh - 100) * 2000;
    else
        bill = 100 * 1500 + 100 * 2000 + (kWh - 200) * 2500;

    Console.WriteLine($"Số tiền điện phải trả: {bill} VND");
}
else
{
    Console.WriteLine("Giá trị không hợp lệ.");
}
#endregion