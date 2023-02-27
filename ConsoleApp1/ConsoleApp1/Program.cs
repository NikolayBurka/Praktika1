for (int i = 10; i <= 99; i++)
    if (i % 10 + i / 10 == (i * 2) % 10 + (i * 2) / 10 % 10 + (i * 2) / 100)
    {
        Console.Write("{0}\t", i);
    }
int count = 0;
for (int x = 2; x <= 99; x++)
{
    if (x % 2 == 0)
    {
        Console.WriteLine(x); count++;
    }
}
Console.WriteLine($"кол-во={count}");