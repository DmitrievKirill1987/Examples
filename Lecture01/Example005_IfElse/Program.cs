Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "анита")
{
    Console.WriteLine("Ура, это же Анита!");

}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}