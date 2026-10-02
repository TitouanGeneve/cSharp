const string MESSAGE ="Bienvenue";
const int NOMBRE_MAX = 50;
const char CODE='z';


Console.WriteLine("Code initialisé");
Exercice 1
int NombreEntier = int.Parse(Console.ReadLine());
if (NombreEntier > 0)
{
    Console.WriteLine("Le nombre est positif");
}
else
{
}

//========================================================

//Exercice 2
int NombreEntier = int.Parse(Console.ReadLine());
if (NombreEntier > 0)
{
    Console.WriteLine("Le nombre est positif");
}
else if (NombreEntier == 0)
{
    Console.WriteLine("Nul");
}
else
{
    Console.WriteLine("Le nombre est négatif");
}

//========================================================

//Exercice 3
Console.WriteLine("Entrez votre âge :");
int age = int.Parse(Console.ReadLine());
if (age >= 18)
{
    Console.WriteLine("Vous êtes majeur");
}
else
{
    Console.WriteLine("Vous êtes mineur");
}

//========================================================

//Exercice 4
Console.WriteLine("Entrez votre mot de passe :");
string Password = Console.ReadLine();
if (Password == "secret")
{
    Console.WriteLine("Mot de passe correct");
}
else
{
    Console.WriteLine("Mot de passe incorrect");
}

//========================================================
  
//Exercice 5
Console.WriteLine("Entrez un nombre entier");
int NombreEntier = int.Parse(Console.ReadLine());
if (NombreEntier % 2 == 0)
{
    Console.WriteLine("Le nombre est pair");
}
else
{
    Console.WriteLine("Le nombre est impair");
}

//========================================================

//Exercice 6
Console.WriteLine("Entrez votre note :");
int Note = int.Parse(Console.ReadLine());
if (Note >= 10 && Note <= 20)
{
    Console.WriteLine("Validé");
}
else
{
    Console.WriteLine("Non validé");
}

//========================================================

//Exercice 7
Console.WriteLine("quel est le montant de votre achat ?");
int MontantAchat = int.Parse(Console.ReadLine());
if (MontantAchat >= 100)
{
    Console.WriteLine("Vous bénéficiez d'une remise de 10%");
}
else
{
    Console.WriteLine("Pas de réduction");
}

//========================================================

//Exercice 8
Console.WriteLine("Entrez un nombre entier :");
int NombreEntier = int.Parse(Console.ReadLine());
if (NombreEntier > 10 && NombreEntier < 20)
{
    Console.WriteLine(" Le nombre est dans l’intervalle [10 ; 20]");
}
else
{
    Console.WriteLine("Le nombre est en dehors de l’intervalle ");
}

//========================================================

//Exercice 9
Console.WriteLine("Entrez une année :");
int Annee = int.Parse(Console.ReadLine());
if (Annee % 4 == 0)
{
    Console.WriteLine("L'année est bissextile");
}
else
{
    Console.WriteLine("L'année n'est pas bissextile");
}

//========================================================

//Exercice 10
Console.WriteLine("Calculatire chargée");
Console.WriteLine("Entrez le premier nombre :");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Entrez le deuxième nombre :");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Entrez l'opération à effectuer + ou -");
string operation = Console.ReadLine();
if (operation == "+")
{
    Console.WriteLine(a + b);
}
else if (operation == "-")
{
    Console.WriteLine(a - b);
}
else
{
    Console.WriteLine("Opération non reconnue");
}
