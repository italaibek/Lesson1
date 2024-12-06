using System;
Console.Clear();
Console.Write("Введите А:");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите В:");
int B = int.Parse(Console.ReadLine());

if(B*B==A){
    Console.WriteLine("А является квадратом В");
}
else
{
    Console.WriteLine("А не является квадратом В");
}

