//========================================================
//========================================================
//====Programme réalisé le 20/11/26 par Titouan Genève ===
//========================================================
//========================================================

//Exercice 1 - Alerte fièvre

Console.WriteLine("Quelle est votre température");
double temp = double.Parse(Console.ReadLine());
if (temp > 38)
{
    Console.WriteLine("Température :" + temp + "°c");
    Console.WriteLine("Vous avez de la fièvre, consultez.");
}
else
{
    Console.WriteLine("Température :" + temp + "°c");
}

//========================================================

//Exercice 2 - Le moins cher

Console.WriteLine("Entrez le prix du premier article :");
double arta = double.Parse(Console.ReadLine());
Console.WriteLine("Entrez le prix du deuxième article :");
double artb = double.Parse(Console.ReadLine());
Console.WriteLine("Prix de l'article A : " + arta);
Console.WriteLine("Prix de l'article B : " + artb);           
if (arta>artb)
{
    Console.WriteLine("L'article B est le moins cher.");
}
else
{
    Console.WriteLine("L'article A est le moins cher.");
}

//========================================================

//Exercice 3 - L'achat suffisant

double x = 0;
Console.WriteLine("Entrez le solde de votre compte");
double compte = double.Parse(Console.ReadLine());
Console.WriteLine("Entrez le prix de l'article :");
double art = double.Parse(Console.ReadLine());
Console.WriteLine("Solde du compte: " + compte);
Console.WriteLine("Prix de l'article: " + art);
if (art>compte)
{
    x = compte - art;
    Console.WriteLine("Soldes insuffisants, il manque " + x + "euros.");
}
else
{
    Console.WriteLine("Solde Suffisant, vous avez acheté l'article");
}

//========================================================

//Exercice 4 - Le menu du restaurant

Console.WriteLine("Choissisez votre menu : 1 (Entrée + plat, 12 euros), 2 (Plat + dessert, 14 euros), 3 (Entrée + plat + dessert, 18 euros)");
string num = Console.ReadLine();
Console.WriteLine("Numéro de formule: " + num);
switch (num)
{
    case "1":
        Console.WriteLine("Formule " + num + ": Entrée + plat, 12 euros");
        break;
    case "2":
        Console.WriteLine("Formule " + num + ": Plat + dessert, 14 euros");
        break;
    case "3":
        Console.WriteLine("Formule " + num + ": Entrée + plat + dessert, 18 euros");
        break;
    default:
        Console.WriteLine("Choix invalide.");
        break;
}

//========================================================

//Exercice 5 - Les codes d'erreur

Console.WriteLine("Entrez le code erreur :");
int code = int.Parse(Console.ReadLine());
switch (code)
{
    case 403:
    case 401:
        Console.WriteLine("Accès refusé.");
        break;
    case 404:
        Console.WriteLine("Page introuvable");
        break;
    case 500:
        Console.WriteLine("Erreur interne du serveur");
        break;
    default:
        Console.WriteLine("Code inconnu.");
        break;
}

//========================================================

//Exercice 6 - La location de véhicules

Console.WriteLine("Entrez le code du véhicule : 'v' (voiture, 45 euros par jour), 'm' (moto, 30\r\neuros), 'u' (utilitaire, 70 euros)");
char code = char.Parse(Console.ReadLine());
Console.WriteLine("Entrez la durée de la location");
int nbjours = int.Parse(Console.ReadLine());
Console.WriteLine("Type de véhicule :" + code);
Console.WriteLine("Nombre de jours :" + nbjours);
switch (code)
{
    case 'v':
        Console.WriteLine("Voiture, " + nbjours + "jour(s) : " + 45*nbjours + " euros");
        break;
    case 'm':
        Console.WriteLine("Moto, " + nbjours + "jour(s) : " + 30 * nbjours + " euros");
        break;
    case 'u':
        Console.WriteLine("Utilitaire, " + nbjours + "jour(s) : " + 70 * nbjours + " euros");
        break;
    default:
        Console.WriteLine("Type inconnu.");
        break;
}

//========================================================

//Exercice 7 - Le déverrouillage du téléphone

Console.WriteLine("Entrez le code PIN");
int code = int.Parse(Console.ReadLine());
const int pin = 1234;
while (code != pin)
{
    Console.WriteLine("Entrez le code PIN");
    code = int.Parse(Console.ReadLine());
}
Console.WriteLine("Vous avez trouvé le code");

//========================================================

//Exercice 8 - La monnaie en pièces de 2

Console.WriteLine("Montant à rendre: ");
int montant = int.Parse(Console.ReadLine());
Console.WriteLine("Montant à rendre: " + montant);
int counter = 0;
while (montant >= 2)
{
    counter++;
    montant -= 2;
}
Console.WriteLine("Le vendeur doit rendre: " + counter + " pièces de 2 euros");

//========================================================

//Exercice 9 - Le remplissage de la citerne

Console.WriteLine("Entrez la capacité de la citerne : ");
int capacité = int.Parse(Console.ReadLine());
int citerne = 0;
while (citerne < capacité)
{
    citerne += 5;
    if (citerne > capacité)
    {
        citerne = capacité;
    }
    Console.WriteLine("Niveau : " + citerne);
}
Console.WriteLine("Citerne pleine : " + citerne);

//========================================================

//Exercice 10 - Les carrés

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i + " au carré = " + (i * i));
}

//========================================================

//Exercice 11 - La table de conversion

for (int i = 10; i <= 100; i +=10)
{
    Console.WriteLine(i + " euros = " + i*1.08 + " dollards" );
}

//========================================================

//Exercice 12 - L'escalier de nombres

Console.WriteLine("Entrez un nombre : ");
int nombre = int.Parse(Console.ReadLine());

for (int i = 1; i <= nombre; i++)
{
    for (int n = 1; n <= i; n++)
    {
        Console.Write(i);
    }
    Console.WriteLine();
}