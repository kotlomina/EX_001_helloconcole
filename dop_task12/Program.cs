// SДва автомобиля едут навстречу друг другу с постоянными скоростями V1 и  V2 км/час. Определить, 
// через какое время автомобили встретятся, если расстояние между ними было S км.


//r=s/(v1+v2)

Console.WriteLine("Введите скорость 1 авто: ");
double v1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите скорость 2 авто: ");
double v2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите скорость расстояние: ");
double s = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Автомобили встретятся через: {s/(v1+v2)} часов");
