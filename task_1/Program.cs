// Задача №18. 
// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат
// точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти от 1 до 4: ");
int a = int.Parse(Console.ReadLine()!);

if (a == 1) Console.WriteLine("Диапозон возможных координат от X до Y ");
if (a == 2) Console.WriteLine("Диапозон возможных координат от -X до Y");
if (a == 3) Console.WriteLine("Диапозон возможных координат от -X до -Y");
if (a == 4) Console.WriteLine("Диапозон возможных координат от X до -Y");
