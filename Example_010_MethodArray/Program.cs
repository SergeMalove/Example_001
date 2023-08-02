int[] numbers = {23, 44, 28, 36, 12, 47, 18, 31, 15};

int n = numbers.Length;
int find = 36;

int index = 0;

while (index < n) {
    if (numbers[index] == find) {
        Console.WriteLine(index);
        break;
    }
    index++;
}