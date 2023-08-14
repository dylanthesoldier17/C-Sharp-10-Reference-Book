int x = 12 * 30;
Console.WriteLine(x);

Console.WriteLine(FeetToInches(30));
Console.WriteLine(FeetToInches(100));

SayHello();

int FeetToInches(int feet)
{
   return feet * 12;
}

void SayHello()
{
   Console.WriteLine("Hello World!");
}