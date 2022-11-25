/* Напишите программу, которая на вход принимает чисдщ (N), а на выходе показывает
все четные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int min = 2;
int nextNumber = new int();
while(min <= num)
{
    if(min % 2 ==0)
    {
        nextNumber = min;
    }
min +=2;
Console.WriteLine(nextNumber);
}
