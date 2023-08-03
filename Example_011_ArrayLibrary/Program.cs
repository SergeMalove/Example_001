void FillArray(int[] array) {
    for (int i = 0; i < array.Length; i++) {
        array[i] = new Random().Next(1, 10);
    }
}

void PrintArray(int[] array) {
    for (int i = 0; i < array.Length; i++) {
        Console.WriteLine(array[i]);
    }
}

int IndexOf(int[] array, int find) {
    int result = -1;
    
    for (int i = 0; i < array.Length; i++) {
        if (array[i] == find) {
            result = i;
            break;
        }
    }
    return result;
}

int[] numbers = new int[10];

FillArray(numbers);
PrintArray(numbers);
Console.WriteLine();

int position = IndexOf(numbers, 4);

Console.WriteLine(position);
