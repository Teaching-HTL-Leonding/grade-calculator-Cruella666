const int max_points = 20;
int points_reached = 0;
double percentage = 0;
int points_possible = 0;


Console.WriteLine("Did you participated in the first written exam ? (yes/no)");
string first_written_exam = Console.ReadLine()!;

if (first_written_exam == "yes")
{
    points_possible += max_points;
    Console.WriteLine("How many points did you have? (0/20) ");
    points_reached += int.Parse(Console.ReadLine()!);
}

Console.WriteLine("Did you participated in the second written exam (yes/no)");
string second_written_exam = (Console.ReadLine()!);

if (second_written_exam == "yes")
{
    points_possible += max_points;
    Console.WriteLine("How many points did you have? (0/20)");
    points_reached += int.Parse(Console.ReadLine()!);
}

Console.WriteLine("How many points do you have on the homework? (0/20)");
int homework_points = int.Parse(Console.ReadLine()!);
points_possible += max_points;
points_reached += homework_points;

Console.WriteLine("Did you take part in the oral exam! (yes/no)");
string oral_exam = Console.ReadLine()!;


if (oral_exam == "yes")
{
    Console.WriteLine("How many points did you have? (0/20)");
    points_possible += max_points;
    points_reached += int.Parse(Console.ReadLine()!);
}

percentage = 100 * points_reached/points_possible;

if (percentage >= 89)
{
    Console.Write("You have a 1");
}

else if (percentage >=76 && percentage <89 )
{
    Console.Write("You have a 2");
}

else if (percentage >= 63 && percentage < 76)
{
    Console.Write("You have a 3");
}

else if (percentage >= 50 && percentage < 63)
{
    Console.Write("You have a 4 ");
}

else if (percentage < 50 )
{
    Console.Write("You have a 5");
}

