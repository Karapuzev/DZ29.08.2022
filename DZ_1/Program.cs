Console.Clear();

void CubedNumbersTable(int number)

{
    for(int i = 1; i <= number; i++)
    {
        int cubedNumber = i * i * i;
        Console.WriteLine($"{i}->3 = {cubedNumber}");
    }       
}

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
CubedNumbersTable(number);