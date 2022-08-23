int rdm = new Random().Next(100, 1000);
Console.WriteLine(rdm);
int digit_second = (rdm / 10) % 10;
Console.WriteLine(digit_second);