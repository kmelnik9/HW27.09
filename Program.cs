//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> ""1, 2, 3, 4, 5""
//M = 4; N = 8. -> ""4, 6, 7, 8""

System.Console.WriteLine("Задача 46");

string GetNum(int n, int m)
{
if (m == n) return Convert.ToString(m);
return n + ", " + GetNum(n + 1, m);
}

System.Console.WriteLine(GetNum(4,8));

System.Console.WriteLine();

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

System.Console.WriteLine("Задача 66");

int SumRec(int N, int M)
{
    if (N==M) return M;
    else return N+SumRec(N+1, M);
}

System.Console.WriteLine(SumRec(4,8));

System.Console.WriteLine();

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 29

System.Console.WriteLine("Задача 68");

int AkkermanRec(int m, int n)
{
if (m == 0) return n + 1;
if (n == 0) return AkkermanRec(m - 1, 1);
return AkkermanRec(m-1, AkkermanRec(m, n-1));
}
System.Console.WriteLine(AkkermanRec(2,3));