Console.Write("Введите имя пользователя: ");
string userName = Console.ReadLine();

if (userName.ToLower() == "маша") {
    Console.WriteLine("Ура! Это же Маша!");
}
else{
    Console.WriteLine("Привет, " + userName);
}