
// 1.Tính chu vi và diện tích của một hình chữ nhật, sử dụng các phép toán +, *, và lưu kết quả trong các biến tương ứng.
#region 1
Console.WriteLine("Nhập chiều dài: ");
double length = double.Parse(Console.ReadLine());
Console.WriteLine("Nhập chiều rộng: ");
double width = double.Parse(Console.ReadLine());

double perimeter = 2 * (length + width);
double area = length * width;

Console.WriteLine($"Chu vi: {perimeter}");
Console.WriteLine($"Diện tích: {area}");
#endregion

// 2.Kiểm tra xem một số nguyên nhập vào từ bàn phím có phải là số chẵn hay số lẻ.
#region 2
Console.WriteLine("\nNhập một số nguyên: ");
int number = int.Parse(Console.ReadLine());
if (number % 2 == 0)
    Console.WriteLine($"{number} là số chẵn");
else
    Console.WriteLine($"{number} là số lẻ");
#endregion

// 3.Tính toán biểu thức: (a + b) * (c - d) với các giá trị a, b, c, d nhập từ bàn phím.
#region 3
Console.WriteLine("\nNhập giá trị a: ");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Nhập giá trị b: ");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Nhập giá trị c: ");
double c = double.Parse(Console.ReadLine());
Console.WriteLine("Nhập giá trị d: ");
double d = double.Parse(Console.ReadLine());
double result = (a + b) * (c - d);
Console.WriteLine($"Kết quả biểu thức: {result}");
#endregion

// 4.Viết chương trình kiểm tra xem một số nhập vào có phải là số chia hết cho 5 và 7 hay không.
#region 4
Console.WriteLine("\nNhập một số nguyên: ");
int numCheck = int.Parse(Console.ReadLine());
if (numCheck % 5 == 0 && numCheck % 7 == 0)
    Console.WriteLine($"{numCheck} chia hết cho 5 và 7");
else
    Console.WriteLine($"{numCheck} không chia hết cho 5 và 7");
#endregion

// 5.Tính tổng của các số từ 1 đến n (với n nhập từ bàn phím), sử dụng toán tử +=.
#region 5
Console.WriteLine("\nNhập số n: ");
int n = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 1; i <= n; i++)
{
    sum += i;
}
Console.WriteLine($"Tổng các số từ 1 đến {n} là: {sum}");
#endregion
