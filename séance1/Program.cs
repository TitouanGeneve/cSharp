string monPrenom = "";
int monAge = 0;
Console.Write(1);
Console.Write("Bonjour !");
Console.WriteLine("Comment t'appelles tu ?");
monPrenom = Console.ReadLine();
Console.WriteLine("Quel est on âge" + monPrenom + " ?");
monAge = int.Parse(Console.ReadLine()); //int.Parse chaine de caractère vers int
monAge = monAge + 2;
Console.WriteLine("Dans 2 ans tu auras : " + monAge + "ans");
Console.WriteLine("Hello World!");
Console.ReadKey();
Console.WriteLine("tu as clic sur une touche");
string name = Console.ReadLine();
Console.WriteLine($"tu as ecrit {name}");
