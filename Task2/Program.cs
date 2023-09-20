int[] array = new int[4];

int dotnEven = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(10, 20); 
}

Console.WriteLine("[" + String.Join(", ", array) + "]");
for (int j = 0; j< array.Length; j++)
    if (array[j] % 2 == 1)

        dotnEven=array[0]+array[2];

Console.WriteLine($"Сумма нечетных позиций = {dotnEven}");
