int[] array = new int[4];

int even = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000); 
}

Console.WriteLine(String.Join(", ", array));
for (int j = 0; j< array.Length; j++)
    if (array[j] % 2 == 0)
        even++;

Console.WriteLine(even);

