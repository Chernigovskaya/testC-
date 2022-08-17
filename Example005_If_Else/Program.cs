
Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if (username.ToLower == "Маша") // переводит в строчные буквы
{
    Console.WriteLine("Ура, Это Маша!");
}
else
{
    Console.Write("Привет!");
    Console.WriteLine(username);
}
