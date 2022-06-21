// Напишите программу, которая выводит третью цифру 
// слева заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Enter the number: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 100)
    Console.WriteLine("Wrong number!");
else
{
     while (n > 999) ;
     n = n / 10;
n = n % 100;
Console.WriteLine("Third number is" + n);
}
