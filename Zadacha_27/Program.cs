Console.Clear ();
Console.Write("Введите число: ");

int number = int.Parse(Console.ReadLine());
int digit = 0;
int sum = 0;

while (number > 0)
{
    digit = number % 10;
    sum = sum +digit;
    number = number / 10;
}
Console.Write(sum);