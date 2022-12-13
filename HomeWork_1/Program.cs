//Задача 2
/*
Console.WriteLine("Введите первое число: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int B = int.Parse(Console.ReadLine()!);
if (A>B){
    Console.WriteLine($"max = {A}");
}else{
    Console.WriteLine($"max = {B}");
}*/

//Задача 4
/*
Console.WriteLine("Введите первое число: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число: ");
int C = int.Parse(Console.ReadLine()!);
if (A>B && A>C){
    Console.WriteLine($"max = {A}");
}else if (B>A && B>C){
    Console.WriteLine($"max = {B}");
}else if (C>A && C>B){
    Console.WriteLine($"max = {C}");
}*/

//Задача 6
/*
Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine()!);
if (A%2==0){
    Console.WriteLine("Да");
}else{
    Console.WriteLine("Нет");
}*/

//Задача 8
/*
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
for(int i = 2; i<N+1; i+=2){
    Console.Write($"{i}  ");
}*/
//




//Домашнее задание 2
// Задача 10
/*
Console.WriteLine("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine()!);
if (num<1000 && num>99){
    num = num/10;
    int a = num%10;
    Console.WriteLine($"Третья цифра числа: {a}");
}else{
    Console.WriteLine("Вы ввели нетрёхзначное число");
}
*/