//Пользователь вводит с клавиатуры М чисел. Посчитать, сколько чисел больше нуля ввел пользователь


Console.Write("Введите количество чисел: ");
int M = Convert.ToInt32 (Console.ReadLine());//ввод количества М чисел
int[] a = new int [M];//объявления массива для хранения чисел
int count = 0;//создания счетчика
Console.WriteLine ("Ввод "+M+"-и целых чисел: ");
for (int i=0;i<M;i++)
{
    a[i]=Convert.ToInt32(Console.ReadLine());
    if (a[i]>0)                //проверка, положительно ли введенное число
    {
        count=count+1;
    }
}
Console.WriteLine ("Из введенных "+M+"-и целых чисел положительных "+count);