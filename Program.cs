Console.Clear();
Console.WriteLine("Введите значения к1 в1 для первой прямой");
int k1 = int.Parse(Console.ReadLine());
int b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значения к2 в2 для первой прямой");
int k2 = int.Parse(Console.ReadLine());
int b2 = int.Parse(Console.ReadLine());
bool ProvPer(int a, int b)
{
    if (a != b) return true;
    else return false;
}
if (ProvPer(k1, k2))
{
    double x = (b1 - b2);
    x = x / (k2 - k1);
    double y = k1 * x + b1;
    Console.WriteLine(x);
    Console.WriteLine(y);
}
else
{
    Console.WriteLine("Прямые не пересекаются");
}