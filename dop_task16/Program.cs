// Cоставить программу обмена значениями трех переменных величин а, b, c по
// следующим двум схемам: 
//     а) b присвоить значение c, а присвоить значение b, с присвоить значение а;
//     б) b присвоить значение а, с присвоить значение b, а присвоить значение с.


int temp, a, b, c;

Console.WriteLine("Введите число a: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число c: ");
int C = Convert.ToInt32(Console.ReadLine());

a = A;
b = B;
c = C;

temp = b;
b = c;
c = a;
a = temp;

Console.WriteLine($"Число a: {a}, Число b: {b}, число с: {c}");

a = A;
b = B;
c = C;
//     б) b присвоить значение а, с присвоить значение b, а присвоить значение с.
temp = b;
b = a;
a = c;
c = temp;

Console.WriteLine($"Число a: {a}, Число b: {b}, число с: {c}");