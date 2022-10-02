//Задача №2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*Console.WriteLine("Введите первое число ");
int N1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число ");
int N2 = int.Parse(Console.ReadLine()!);

if (N1 > N2) { Console.WriteLine($"Max={N1}, Min={N2}"); }
if (N2 > N1) { Console.WriteLine($"Max={N2}, Min={N1}"); }
if (N1 == N2) { Console.WriteLine("Введены одинаковые числа"); }
*/

//Задача №4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.WriteLine("Введите первое число ");
int N1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число ");
int N2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число ");
int N3 = int.Parse(Console.ReadLine()!);
int Max = N1;


if (N2 >= Max) { Max=N2; }
if (N3 >= Max) { Max=N3; }

Console.WriteLine($"Максимальное число = {Max}");   
*/

//Задача №6 Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.WriteLine("Введите число ");
int N1 = int.Parse(Console.ReadLine()!);

if (N1 % 2 == 0) { Console.WriteLine($"Число {N1} является четным"); }
else { Console.WriteLine($"Число {N1} является нечетным"); }
*/

// Задание №8 Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число ");
int N = int.Parse(Console.ReadLine()!);
int i = 1;

while (i<=N){
if (i%2==0) {
    Console.WriteLine(i);
} 
i++;
}