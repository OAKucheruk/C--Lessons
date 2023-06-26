// Задача 1.
// Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А
/*
void FindSum1toA (int num_A){
    int sumElem = 0;
    for (int i = 1; i <= num_A; i++){
        sumElem += i; // sumElem = sumElem + i
        Console.Write(sumElem + " ");
    }
    Console.WriteLine();
    Console.WriteLine($"Sum of elements from 1 to {num_A} is {sumElem}");
}


void FindSumWhile (int user_number_a){
    int sum2 = 0;
    int i = 1;
    while (i <= user_number_a){
        sum2 += i;
        i++;
        Console.Write(sum2 + " ");
    }
    Console.WriteLine();
    Console.WriteLine($"Sum of elements from 1 to {user_number_a} is is {sum2}");
}

Console.WriteLine("Please input number: ");
int userNum = Convert.ToInt32(Console.ReadLine());

if (userNum > 0){
    FindSumWhile(userNum);
}
else 
    Console.WriteLine("Impossible vlaue");
*/

// Задача 2
// Напишите программу, которая принимает на вход число 
// И выдает количество цифр в числе.
// 456 -> 3
// -78 -> 2
// 89126 -> 5

/*
int CountOfDigits(int numUser){
    int count = 0;
    while (numUser > 0){
        numUser /= 10; // numUser = numUser / 10
        count++;
    }
    return count;
}

Console.WriteLine("Please input number: ");
int userNum = Convert.ToInt32(Console.ReadLine());

int count_res;

if (userNum >= 0)
    count_res = CountOfDigits(userNum);
else{
    int userNum1 = (-1) * userNum;
    count_res = CountOfDigits(userNum1);
}

Console.WriteLine(count_res);

// Math.Abs(аргумент) - убирает минус

*/

// Задача 3
// Напишите программу, которая принимает на вход число N
// и выдает произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

/*

int FindMulty (int user_n){
    int multy = 1;
    for(int i = 1; i <= user_n; i++){
        multy *= i;
    }
    return multy;
}

Console.WriteLine("Please input number: ");
int userNum = Convert.ToInt32(Console.ReadLine());

int multy_res = 0;

if(userNum <= 0)
    multy_res = 0;
else 
    multy_res = FindMulty(userNum);

Console.WriteLine(multy_res);

*/

// Задача 4
// Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int [] CreateNewArray (int size_array) // метод создания массива
{
    int [] random1array = new int[size_array];
    for (int i = 0; i < size_array; i++)
    {
        random1array[i] = new Random().Next(0,2); // рандом от 0 до 1
    }
    return random1array;
}

void PrintArray (int [] array_to_print) // показать массив
{
    Console.WriteLine("Your array is: ");
    for (int i = 0; i < array_to_print.Length; i++)
        Console.Write (array_to_print[i] + " ");
}

int size = 8;
int []firstArray = CreateNewArray(size);
PrintArray(firstArray);

