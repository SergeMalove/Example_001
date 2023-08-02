int[] numbers = {23, 44, 28, 36, 12, 47, 18, 31, 15};

int find = 36;

for (int i = 0; i < numbers.Length; i++) {
    if (numbers[i] == find) {
        Console.WriteLine(i);
        break;
    }
}