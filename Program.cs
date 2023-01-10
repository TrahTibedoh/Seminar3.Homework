//Напишите программу, которая принимает на вход число и проверяет, является ли оно палиндромом.
/*
bool Pallindrom(int num)
{
    int revers = 0;
    int count = num;
    while(num > 0)
    {
        revers = revers * 10 + num % 10;
        num = num / 10;
    }
    return revers == count;
}

Console.WriteLine("Input number ");
int number = Convert.ToInt32(Console.ReadLine());

if (Pallindrom(number)) Console.WriteLine($"This is number {number} is a Pallindrom");
else Console.WriteLine($"This number {number} is not Pallindrom");
*/

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Funct(double xPos1, double yPos1,double zPos1, double xPos2,double yPos2, double zPos2)
{  
    return Math.Sqrt(Math.Pow(xPos2 - xPos1, 2) + Math.Pow(yPos2 - yPos1, 2) + Math.Pow(zPos2 - zPos1, 2));
}
 Console.WriteLine("Input x1");
 double x1 = Convert.ToDouble(Console.ReadLine());

 Console.WriteLine("Input x2");
 double x2 = Convert.ToDouble(Console.ReadLine());

 Console.WriteLine("Input y1");
 double y1 = Convert.ToDouble(Console.ReadLine());

 Console.WriteLine("Input y2");
 double y2 = Convert.ToDouble(Console.ReadLine());

 Console.WriteLine("Input z1");
 double z1 = Convert.ToDouble(Console.ReadLine());

 Console.WriteLine("Input z2");
 double z2 = Convert.ToDouble(Console.ReadLine());

 Console.WriteLine(Funct(x1,y1,z1,x2,y2,z2));
 */

 //Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*
 void N(int n)
 {
    int count = 1;
    while (count < n)
    {
        int cub = count * count * count;
        Console.WriteLine($"{count} = {cub}");
        count++;
    }
 }
 Console.WriteLine("Input number ");
 int number = Convert.ToInt32(Console.ReadLine());
N(number);
*/