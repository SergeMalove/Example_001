int Max(int arg1, int arg2, int arg3) {
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 34;
int b1 = 12;
int c1 = 45;
int a2 = 18;
int b2 = 56;
int c2 = 87;
int a3 = 23;
int b3 = 19;
int c3 = 41;

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine(max);