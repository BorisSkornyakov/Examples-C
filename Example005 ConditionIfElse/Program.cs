Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();
if (username.ToLower() == "boris")
{
    Console.WriteLine("Здравствуйте, Борис Евгеньевич");
}
else 
{
    Console.Write("Привет ");
    Console.WriteLine(username);
}


