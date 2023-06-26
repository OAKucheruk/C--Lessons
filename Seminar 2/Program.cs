/*

int Line(){
    int num = new Random().Next(10,100);
    Console.WriteLine("Your num is " + num);
    int dec = num/10;
    int ed = num%10;
    if(dec>ed){
        return dec;
    }
    else{
        return ed;
    }
}

Console.WriteLine("Result is - "+ Line());

*/

// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа

/*
int num = new Random().Next(100, 1000);
Console.WriteLine("Your number is " + num);
int num1 = num/100;
int num3 = num%10;

Console.WriteLine($"Result is {num1}{num3}");
*/

// Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому.
// Если число 2 не кратно числу 1,
// то программа выводит остаток от деления.

/*
Console.WriteLine("Please input number 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please input number 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if(number2!= 0 && number1 != 0){
    if(number2%number1 == 0){
    Console.WriteLine($"{number2} is multiple to {number1}");
    }
    else{
    Console.WriteLine("Остаток = " + number2 % number1);
    }
}
else{
    Console.WriteLine("Нельзя вводить 0");
}

*/

// Напишите программу которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23

/*
Console.WriteLine("Please input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 7 == 0 && number % 23 == 0){
    Console.WriteLine($"Your number is multiple to 7 and 23");
}
else{
    Console.WriteLine($"Your number is NOT multiple to 7 and 23");
}


Console.WriteLine("Please input number: ");
int num = Convert.ToInt32(Console.ReadLine());

void getNumberDiv(int num){
    if(num % 7 == 0 && num % 23 == 0){
    Console.WriteLine($"Your number is multiple to 7 and 23");
    }
    else{
    Console.WriteLine($"Your number is NOT multiple to 7 and 23");
    }
}

getNumberDiv(num);

*/

// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратиом другого 

Console.WriteLine("Please input number 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please input number 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

void getSqr(int a, int b){
    if(num1 * num1 == num2 || num2 * num2 == num1){
        Console.WriteLine("it is square");
    }
    else{
        Console.WriteLine("It is NOT a square");
    }
}

getSqr(num1, num2);



