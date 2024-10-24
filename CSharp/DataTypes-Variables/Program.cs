
// 1.Khai báo biến int, float, double, bool và gán giá trị cho chúng. In giá trị của chúng ra màn hình.
#region 1
using System.Net.NetworkInformation;

int variableInt = 21;
float variableFloat = 9.3f;
double variableDouble = 9.9;
bool variableBool = true;
Console.WriteLine($"Int: {variableInt}\nFloat: {variableFloat}\nDouble: {variableDouble}\nBool: {variableBool}");
#endregion

// 2.Khai báo biến string để lưu tên của bạn và in ra màn hình kèm theo thông điệp: "Xin chào, [tên của bạn]".
#region 2
string? name = Console.ReadLine();
Console.WriteLine($"Xin chào, {name}");
#endregion

// 3.Chuyển đổi từ double sang int và in kết quả ra màn hình.
#region 3
double doubleToInt = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Int = {doubleToInt}");
#endregion

// 4.Viết chương trình nhập vào tuổi của bạn, tính toán và in ra số năm còn lại đến khi bạn 60 tuổi.
#region 4
if (!int.TryParse(Console.ReadLine(), out int age))
{
    Console.WriteLine("Vui lòng nhập tuổi hợp lệ");
}
int results = 60 - age;
Console.WriteLine($"Còn {results} đến khi bạn 60 tuổi");
#endregion

// 5.Khai báo biến kiểu const và sử dụng trong một phép toán đơn giản.
#region 5
const double pi = 3.14;
double radius = 5;
double area = pi * radius * radius;
Console.WriteLine("Diện tích hình tròn với bán kính 5 là: " + area);
#endregion