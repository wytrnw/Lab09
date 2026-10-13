using System.Runtime.Serialization.Formatters;
using System.Security.AccessControl;

int totalExercises = 8;

for (int number = totalExercises; number >=1; number--)
{
    Console.WriteLine($"Упражнение {number}");
}

Console.WriteLine("Домашнее задание готово");



for (int room = 5; room <= 50; room += 5)
{
    Console.WriteLine($"Кабинет{room}");
}

