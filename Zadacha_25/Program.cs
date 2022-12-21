Console.Clear ();
Console.Write("Введите числа: ");

double numberA = double.Parse(Console.ReadLine());
double numberB = double.Parse(Console.ReadLine());
double stepen = 1;
while (stepen > 0)
{
    stepen = Math.Pow(numberA,numberB);
    Console.WriteLine(stepen);
    break;
}