int rdm = new Random().Next(1, 1000000);
Console.WriteLine(rdm);
if (rdm % 7 == 0 && rdm % 23 == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine("Некратно");
}