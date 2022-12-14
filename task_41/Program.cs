// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 
//ввёл пользователь. Ввод чисел останавливается при помощи ввода стоп-слова "stop"

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// Console.Clear();
// int sum = 0;
// Console.WriteLine($"Введите числа:");
// int n = Convert.ToInt32(Console.ReadLine());
// while (Console.ReadLine() != "Стоп")
// {
    
    
//     if (n > 0)
//     {
//         sum = sum + 1;
//     }  
// }
// Console.WriteLine($"Чисел больше 0 введено {sum}"); 

Console.Clear();
int sum=0;
for (int i = 0; Console.ReadLine() != "Стоп"; i++)
{
    Console.Write($"Введите a{i} и нажмите клавишу ввод. Для прерывания ввода напишите 'Стоп'. ");
    int a = Convert.ToInt32(Console.ReadLine());
   
    if (a>0)
    {
        sum=sum+1;
    }
}
Console.WriteLine($"Чисел больше 0 введено {sum}");    
