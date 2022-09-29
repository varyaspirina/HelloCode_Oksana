Console.Write("Enter USER name:");
string username = Console.ReadLine();

if(username.ToLower() == "oksana")
{
    Console.WriteLine("Hello, Oksana! It's a great pleasure to see you again.");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}