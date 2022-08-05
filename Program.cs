void task19()
{
    int number = 15951;
    
    if (number > 9999 && number < 100000)
    {
        int digitOne = number % 10;
        int digitTen = number / 10 % 10;
        int digitThousand = number / 1000 % 10;
        int digitTenThousand = number / 10000;
        if (digitOne == digitTenThousand && digitTen == digitThousand)
        {
            Console.WriteLine("Число палиндром");
        }
        else
        {
            Console.WriteLine("число не палиндром");
        }
    }
}
task19();

void task21()
{
    int a_x = 3;
    int a_y = 1;
    int a_z = 5;
    int b_x = 0;
    int b_y = 6;
    int b_z = 0;
    double distance = Math.Sqrt(Math.Pow(a_x - b_x, 2) + Math.Pow(a_y - b_y, 2) + Math.Pow(a_z - b_z, 2));
    Console.WriteLine(distance);
}
task21();

void task23()
{
    int number = 9;
    for (int i = 1; i <= number; i++)
    {
        Console.WriteLine($"{i} * {i} * {i} = {Math.Pow(i, 3)}");
    }
}
task23();