Console.WriteLine("Enter a number");

int userNum = Convert.ToInt32(Console.ReadLine());

// arv on paaris voi paaritu 

int result = userNum % 2;

Console.WriteLine(result);

if (result != 0)
{
    Console.WriteLine("user num is odd.");

} else
{
    Console.WriteLine("user num is even.");
}