
Console.WriteLine("TESTE DE CLASSES");

userA = new Usuario();
userB = new Usuario();

System.Console.WriteLine("Informe o nome do usuário A:");
userA.Nome = Console.ReadLine();
System.Console.WriteLine("Informe o nome do usuário B:");
userB.Nome = Console.ReadLine();

System.Console.WriteLine($"O nome do usuário A é {userA.Nome} e o nome do usuário B é {userB.Nome}");

