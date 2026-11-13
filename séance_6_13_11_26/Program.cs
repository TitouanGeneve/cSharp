//========================================================
//========================================================
//====Programme réalisé le 13/11/26 par Titouan Genève ===
//========================================================
//========================================================

// Exercice 5 Program_while.cs

//Modification du switch case pour l'utilisation de if, else au lieu de switch case

Console.WriteLine("Quel est votre âge ?");
int age = int.Parse(Console.ReadLine());
while (age < 0 || age == 0 || age > 99)
{
    Console.WriteLine("L'âge doit être compris entre 1 et 99. Veuillez entrer un âge valide.");
    age = int.Parse(Console.ReadLine());
}

if (age < 12)
{
    Console.WriteLine("gratuit");
}
else if (age >= 12 && age <= 17)
{
    Console.WriteLine("Tarif jeune, 3 euros");
}
else if (age >= 18 && age <= 64)
{
    Console.WriteLine("Tarif plein, 6 euros");
}
else
{
    Console.WriteLine("Tarif senior, 4 euros");
}

//========================================================

//Exemple cours :

Console.Write("Hauteur du triangle : ");
int hauteur = int.Parse(Console.ReadLine());
for (int ligne = 1; ligne <= hauteur; ligne++)
{
    for (int etoile = 1; etoile <= ligne; etoile++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

//========================================================

//Exercice 1 - Ligne sur mesure

//Avec for

Console.WriteLine("Choissisez un caractère :");
char a = char.Parse(Console.ReadLine());
Console.WriteLine("Combien de fois répeter ce caractère ?");
int nbRepetitions = int.Parse(Console.ReadLine());
for (int i = 0; i < nbRepetitions; i++) // Boucle for pour répéter le caractère
{
    Console.Write(a);
}

// Avec While

Console.WriteLine("Choissisez un caractère :");
char a = char.Parse(Console.ReadLine());
Console.WriteLine("Combien de fois répeter ce caractère ?");
int nbRepetitions = int.Parse(Console.ReadLine());
int i = 0;
while (i < nbRepetitions) // Boucle while pour répéter le caractère
{
    Console.Write(a);
    i++;
}

//========================================================

//Exercice 2 - Factorielle

//Avec for

Console.WriteLine("De quel nombre voulez vous la factorielle ?");
int n = int.Parse(Console.ReadLine());
int produit = 1;
    Console.WriteLine("N: " + n);
for (int i = 1; i <= n; i++) // Boucle for pour calculer la factorielle
{
    produit *= i;
}
Console.WriteLine($"La factorielle de {n} est {produit}");

//Avec while

Console.WriteLine("De quel nombre voulez vous la factorielle ?");
int n = int.Parse(Console.ReadLine());
int produit = 1;
Console.WriteLine("N: " + n);
while (n > 1)
{
    produit *= n;
    n--; // Décrémenter n pour continuer la boucle
}
Console.WriteLine($"La factorielle de {n} est : {produit}");

//========================================================

//Exercice 3 - Somme des nombres pairs

//Avec for (un for qui avance de 2 en 2 (de i = 2 avec i += 2 ) ;)

int sum = 0;
for (int i = 2; i <= 100; i+=2) // Boucle for pour calculer la somme des nombres pairs
{
    sum += i;
}
Console.WriteLine("La somme des nombres pairs de 2 à 100 est : " + sum);

//Avec for (un for normal (de 1 à 100) qui ajoute i seulement si i % 2 == 0 ;)

int sum = 0;
for (int i = 1; i <= 100; i++) // Boucle for pour calculer la somme des nombres pairs
{
    if (i % 2 == 0)
    {
        sum += i;
    }
}
Console.WriteLine("La somme des nombres pairs de 1 à 100 est : " + sum);

//Avec while

int sum = 0;
int i = 0;
while (i <= 100) // Boucle while pour calculer la somme des nombres pairs
{
    if (i % 2 == 0)
    {
        sum += i;
    }
    i++;
}
Console.WriteLine("La somme des nombres pairs de 1 à 100 est : " + sum);

//========================================================

//Exercice 4 - Rectangle d'étoiles

// Avec for

Console.WriteLine("Quel est la largeur du rectangle ?");
int largeur = int.Parse(Console.ReadLine());
Console.WriteLine("Quel est la hauteur du rectangle ?");
int hauteur = int.Parse(Console.ReadLine());
for (int i = 0; i < hauteur; i++) // Boucle for pour dessiner le rectangle
{
    for (int j = 0; j < largeur; j++) // Boucle for pour dessiner les étoiles sur chaque ligne
    {
        Console.Write("*" + " ");
    }
    Console.WriteLine();
}

// Avec while

Console.WriteLine("Quelle est la largeur du rectangle ?");
int largeur = int.Parse(Console.ReadLine());
Console.WriteLine("Quelle est la hauteur du rectangle ?");
int hauteur = int.Parse(Console.ReadLine());
if (largeur > 0 && hauteur > 0)
{
    int i = 0;
    while (i < hauteur)
    {
        int j = 0;
        while (j < largeur)
        {
            Console.Write("* ");
            j++; // Incrémenter j pour continuer la boucle
        }

        Console.WriteLine();
        i++; // Incrémenter i pour continuer la boucle
    }
}
else
{
    Console.WriteLine("La largeur et la hauteur doivent être positives.");
}

//========================================================

//Exercice 5 - Tables Ascii

//Ordre croissant (A à Z)

for (int code = 65; code <= 90; code++) // Boucle for pour afficher les codes ASCII de A à Z
{
    Console.WriteLine($"{code} : {(char)code}"); // Afficher le code ASCII et le caractère correspondant
}

//Ordre décroissant (Z à A)

for (int code = 90; code >= 65; code--) // Boucle for pour afficher les codes ASCII de Z à A
{
    Console.WriteLine($"{code} : {(char)code}"); // Afficher le code ASCII et le caractère correspondant
}