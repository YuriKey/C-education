Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");

int xa = 40, ya = 1,                //вводим переменные для постановки точек
    xb = 1, yb = 30,
    xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya); //определяем позицию курсора для написания первой точки
Console.WriteLine("+");            //Ставим первую точку

Console.SetCursorPosition(xb, yb); //определяем позицию курсора для написания второй точки
Console.WriteLine("+");            //Ставим вторую точку

Console.SetCursorPosition(xc, yc); //определяем позицию курсора для написания третьей точки
Console.WriteLine("+");            //Ставим третью точку

int x = xa, y = xb;                //Для определенности кладем в переменные первую точку

int count = 0;                    //определяем количество итераций

while (count < 1000000)
{
    int what = new Random().Next(0, 3); //[0;3) 0 1 2
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition (x,y);
    Console.WriteLine("+");
    count = count + 1;

}