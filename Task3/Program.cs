double[] array = new double[4];

for (int i = 0; i < array.Length; i++)
{
    double number = new Random().Next(10, 20) + new Random().NextDouble();
    array[i] = Math.Round(number, 2);
}

Console.WriteLine("[" + String.Join(", ", array) + "]");
double max = 0;
double min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max) 
        max = array[i];
    else if (array[i] < min)
        min = array[i];
    
}

Console.WriteLine($"Разница между max и min = {max - min}");
