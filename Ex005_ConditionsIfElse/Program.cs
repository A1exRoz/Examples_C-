Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура, так это же МАША!");    
}
else
{
    Console.Write("Салют, ");
    Console.WriteLine(username);
}