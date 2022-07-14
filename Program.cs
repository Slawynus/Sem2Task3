Console.Write("введите число");
int numD = Convert.ToInt32(Console.ReadLine());

if (numD ==6 || numD == 7)
{
    Console.WriteLine("выходной");
    return;
}
if (numD < 6 && numD > 0)
{
    Console.WriteLine("рабочий день");
    return;
}
if (numD > 7 || numD < 1)
{
    Console.WriteLine("нет такого дня");
    return;
}
