// Напишите программу, которая принимает на вход точки (х и у)
// причем х не равно 0 и выдает номер четверти плоскости, в которой находится эта точка

/*
int Koord(int x, int y){
    int numberQuater;
    if(x > 0 && y >0)
        numberQuater = 1;
    else if(x > 0 && y < 0)
        numberQuater = 4;
    else if(x < 0 && y > 0)
        numberQuater = 2;
    else
        numberQuater = 3;
    return numberQuater;
}

Console.WriteLine("Enter x coord: ");
int xCoord = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter y coord: ");
int yCoord = Convert.ToInt32(Console.ReadLine());
int numbQuat;

if (xCoord == 0 || yCoord == 0)
    Console.WriteLine("Error!");
else{
        numbQuat = Koord(xCoord, yCoord);
        Console.WriteLine($"Number of quater is {numbQuat}");
}
    
*/

// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (х и у).

/*
int Diapason(int quadro){
    if(quadro == 1){
        return 1;
    }   
    else if(quadro == 2){
        return 2;
    }
    else if(quadro == 3){
        return 3;
    }
    else{
        return 4;
    }
}


System.Console.WriteLine("Please input number: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a <= 0 || a > 4){
    System.Console.WriteLine("ERROR");
}     
else{
    int result = Diapason(a);



if(result == 1){
    System.Console.WriteLine("x > 0, y > 0");
}
else if(result == 2){
    System.Console.WriteLine("x < 0, y > 0");
}
else if(result == 3){
    System.Console.WriteLine("x < 0, y < 0");
}
else{
    System.Console.WriteLine("x > 0, y < 0");
}
}

*/

// Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 2D пространстве
// A(x1, y1) ; B(x2, y2)

/*
double LongLineAB(int xA, int xB, int yA, int yB){
    double longLine = Math.Sqrt((xB - xA)*(xB - xA)+(yB - yA)*(yB - yA));
    longLine = Math.Round(longLine, 2);
    return longLine;
}

Console.WriteLine("Please input x of A: ");
int xCoordA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please input y of A: ");
int yCoordA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please input x of B: ");
int xCoordB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please input y of B: ");
int yCoordB = Convert.ToInt32(Console.ReadLine());

double dist = LongLineAB(xCoordA, xCoordB, yCoordA, yCoordB);

Console.WriteLine($"Distance is: {dist}");

*/

// Напишите программу, которая принимает на вход число (N) и
// выдает ряд квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1, 4.

void NumSqr(int N){
    int current = 1;
    while(current <= N){
        double res = Math.Pow(current, 2);
        Console.Write($"{res:f0}, ");
        current ++;
    }
    Console.WriteLine("\b\b.");
}

Console.Write("Please input number: ");
int number = Convert.ToInt32(Console.ReadLine());

NumSqr(number);