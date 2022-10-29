using Idont;

Algoritm algoritm = new Algoritm();
Console.WriteLine("Введите число");
string count1= Console.ReadLine();
bool parse=int.TryParse(count1,out var count);
if (!parse)
{
    Console.WriteLine("Ошибка");
    return;
}
Console.WriteLine();
Console.WriteLine("Введите строку");
string enter=Console.ReadLine();
if(parse) 
{
    algoritm.funk(count, enter);
}
