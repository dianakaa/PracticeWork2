int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int n = numbers.Length - 1;
int value = 8;

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"{numbers[i]}\t");
}

int previousStep = 0;

for (int jumpStep = (int)Math.Sqrt(n); numbers[jumpStep] < value; jumpStep += (int)Math.Sqrt(n))
{
    previousStep = jumpStep;
}

while (numbers[previousStep] < value)
{
    previousStep++;
}

Console.WriteLine($"Индекс элемента: {previousStep}");