Console.Write("Insert username, please ");
string username = Console.ReadLine();

if(username.ToLower() == "anya")
{
    Console.WriteLine("Hey, dear Anya!");
}
else
{
    Console.Write("Oh, that's just you ");
    Console.WriteLine(username);
}