//Написать программу нахождения точки пересечения двух прямх (коэффициенты уравнений прямых вводятся вручную)


//ввод коэффициентов уравнения первой прямой
Console.WriteLine("Введите коэффициенты уравнения первой прямой.");
Console.Write("k1 = " );
double k1 = Convert.ToDouble (Console.ReadLine());
Console.Write("b1 = " );
double b1 = Convert.ToDouble (Console.ReadLine());
//ввод коэффициентов уравнения второй прямой
Console.WriteLine("Введите коэффициенты уравнения второй прямой.");
Console.Write("k2 = " );
double k2 = Convert.ToDouble (Console.ReadLine());
Console.Write("b2 = " );
double b2 = Convert.ToDouble (Console.ReadLine());
//внешний вид уравнений
Console.WriteLine("Таким образом, необходимо определить точку пересечения прямых y="+k1+"x+"+b1+" и y="+k2+"x+"+b2);
//проверка прямых на совпадение
if ((k1==k2)&&(b1==b2))
{
    Console.WriteLine("Но прямые совпадают");
}
//проверка прямых на параллельность
else if (k1==k2)
{
    Console.WriteLine("Но прямые параллельны");
}
//вычисление точки пересечения
else
{
double x=(b2-b1)/(k1-k2);
double y=k1*x+b1;
Console.WriteLine($"Точка пересечения ({x}, {y})");
}