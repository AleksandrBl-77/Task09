System.Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(n > 99 ? n.ToString()[2] : "нет третьего числа");
