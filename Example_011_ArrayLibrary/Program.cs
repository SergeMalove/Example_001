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

int IndexOf(int[] array, int find) {
    int length = array.Length;
    int index = 0;
    int result = -1;

    while (index < length) {
        if (array[index] == find) {
            result = index;
        }
        index++;
    }
    return result;
}

int[] numbers = new int[10];

FillArray(numbers);
PrintArray(numbers);
Console.WriteLine();

int position = IndexOf(numbers, 4);

Console.WriteLine(position);
