Console.Clear();

int xA = 40, yA = 1,
    xB = 1, yB = 30,
    xC = 80, yC = 30;

int x = xA, y = yA;
int count = 0;

Console.SetCursorPosition(xA, yA);
Console.WriteLine("+");

Console.SetCursorPosition(xB, yB);
Console.WriteLine("+");

Console.SetCursorPosition(xC, yC);
Console.WriteLine("+");

while (count < 10000) {
    int rand = new Random().Next(0, 3); // [0, 3)

    if (rand == 0) {
        x = (x + xA)/2;
        y = (y + yA)/2;
    }

    if (rand == 1) {
        x = (x + xB)/2;
        y = (y + yB)/2;
    }

    if (rand == 2) {
        x = (x + xC)/2;
        y = (y + yC)/2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}