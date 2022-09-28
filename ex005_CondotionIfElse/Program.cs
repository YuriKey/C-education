Console.Write("Введите Ваше имя: ");
string userName = Console.ReadLine();

if (userName.ToLower() == "маша")
{
    Console.WriteLine ("Ура! Это снова ты!");
}
else
{
    Console.WriteLine ("Опять ты... Что надо?");
    Console.WriteLine (userName);
}