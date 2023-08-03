void FillArray(int[] array) {
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] array) {
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        Console.WriteLine(array[index]);
        index++;
    }
}

int[] numbers = new int[10];

FillArray(numbers);
PrintArray(numbers);
