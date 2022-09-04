Console.Write("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());

int second = (a / 10) % 10;
Console.WriteLine("Вторая цифра числа: "+ second);