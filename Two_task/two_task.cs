int rdm = new Random().Next(1, 65536);
Console.WriteLine(rdm);
int digit_index = 2;

if (rdm > 99)
{
    int digit_third = rdm.ToString()[digit_index] - '0';
    Console.WriteLine(digit_third);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}



