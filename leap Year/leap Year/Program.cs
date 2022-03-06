Console.WriteLine("Leap year");

    Console.WriteLine("Enter Year : "); // constant
     int Year = int.Parse(Console.ReadLine());

if (((Year % 4 == 0) && (Year % 100 == 0)) || (Year % 400 == 0))
{
    Console.WriteLine("{0} is a Leap year.", Year);

}
else
{

    Console.WriteLine("{0} is not a Leap year.", Year);
    Console.ReadLine();
}