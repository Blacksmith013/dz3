Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine()!);
int count = 1;

if (number < 0)
    Console.WriteLine("Введите положительное число");

while (number >= count)
{
    double result = Math.Pow(count, 3);
    count++;
    Console.Write(result + " ");
}