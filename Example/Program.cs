void PrintArray(string[] array)
{   
    Console.Write("Массив из строк, длина которых меньше или равна 3: "); 
    for (int i = 0; i < array.Length; i++)
    {
        
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


Console.Write("Введите необходимое кол-во элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());

string[] array = new string[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Введите {i+1}-й элемент: ");
    string element = Convert.ToString(Console.ReadLine());
    array[i] = element;
}

string[] arrayResult = new string[n];
int k = 0;

for (int j = 0; j < n; j++)
{
    if (array[j].Length <= 3)
    {
        arrayResult[k] = array[j];
      k++;
    }
}

Console.WriteLine();
PrintArray(arrayResult);
