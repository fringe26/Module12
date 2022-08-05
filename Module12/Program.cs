using Module12;

List<User> users = new List<User>();

for (int i = 0; i < 5; i++)
{
	Console.WriteLine("Enter Login,Name,Premis{0,1} - use space between fields :");
	var userString = Console.ReadLine()?.Split();
    try
    {
		users.Add(new User
		{
			Login = userString[0] ?? string.Empty,
			Name = userString[1] ?? string.Empty,
			IsPremium = userString[2].Equals("1") ? true : default(bool),

		});
	}catch (Exception ex)
    {
		Console.WriteLine(ex.Message);
        Console.WriteLine("We gonna add user with default fields - user, user, 0");
		users.Add(new User
		{
			Login = "user",
			Name = "user",
			IsPremium = default(bool),

		});
	}
	
}
    //Alghoritms realisation

foreach (var user in users)
{
    if (user.IsPremium)
    {
        Console.WriteLine($"Hello {user.Name}");

    }
    else
    {
		ShowAds();
    }
}










static void ShowAds()
{
	Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
	// Остановка на 1 с
	Thread.Sleep(1000);

	Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
	// Остановка на 2 с
	Thread.Sleep(2000);

	Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
	// Остановка на 3 с
	Thread.Sleep(3000);
}