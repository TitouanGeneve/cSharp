//========================================================
//========================================================
//====Programme réalisé le 13/11/26 par Titouan Genève ===
//========================================================
//========================================================

//Exercice 1 - La pyramide d'étoiles

Console.Write("Hauteur : ");
int hauteur = int.Parse(Console.ReadLine());

for (int n = 1; n <= hauteur; n++)
{
    // Étape 1 : les espaces
    for (int i = 0; i < hauteur - n; i++)
    {
        Console.Write(" ");
    }

    // Étape 2 : les étoiles
    for (int i = 0; i < 2 * n - 1; i++)
    {
        Console.Write("*");
    }

    Console.WriteLine(); // retour à la ligne
}

//========================================================

//Exercice 2 - Les nombres premiers

Console.WriteLine("Afficher les nombres premiers jusqu'au nombre : ");
int nombre = int.Parse(Console.ReadLine()); // Demande à l'utilisateur le nombre maximum à tester
for (int i = 2; i <= nombre; i++)// On parcourt tous les nombres de 2 jusqu'à "nombre"
{
    bool estPremier = true; // On suppose que le nombre est premier au début
    for (int j = 2; j <= Math.Sqrt(i); j++) // On teste si i est divisible par un nombre entre 2 et sqrt(i)
    {
        if (i % j == 0) // Si i est divisible par j, alors il n'est pas premier
        {
            estPremier = false; // On change l'état
            break; // On arrête de tester ce nombre
        }
    }

    // Si le nombre est toujours premier, on l'affiche
    if (estPremier)
    {
        Console.WriteLine(i);
    }
}

//========================================================

//Exercice 3 - Le jeu du nombre mystère

Console.WriteLine("Jeu du nombre mystère");
Console.WriteLine("Veuillez entrer un nombre entre 1 et 100 :");

int Nombre = int.Parse(Console.ReadLine());
Console.WriteLine("Votre proposition est : " + Nombre);
int i = 0;
Random random = new Random(); // Création d'un objet Random pour générer un nombre aléatoire
int NombreMystere = random.Next(1, 101);

while (Nombre != NombreMystere) // Tant que le nombre proposé n'est pas le nombre mystère
{
    if (Nombre > NombreMystere)
    {
        Console.WriteLine("Le nombre mystère est plus petit !");
        i = i + 1;
    }
    else if (Nombre < NombreMystere)
    {
        Console.WriteLine("Le nombre mystère est plus grand !");
        i = i + 1;
    }

    Console.WriteLine("Veuillez entrer un nouveau nombre :");
    Nombre = int.Parse(Console.ReadLine());
    Console.WriteLine("Votre proposition est : " + Nombre);
}

Console.WriteLine("Félicitations ! Vous avez trouvé le nombre mystère en " + i + " tentatives !");

//========================================================

//Exercice 4 - Le damier

Console.WriteLine("Quel taille de carré voulez-vous ?");
int taille = int.Parse(Console.ReadLine());
int x = 0;
for (int i = 0; i < taille; i++)
{
    for (int j = 0; j < taille; j++) // Boucle pour créer le damier
    {
        if (x==0)
        {
            Console.Write("#"); // Affiche un caractère pour le damier
            x = 1;
        }
        else
        {
            Console.Write("."); // Affiche un autre caractère pour le damier
            x = 0;
        }
    }
    Console.WriteLine();
}

//========================================================

//Exercice 5 - La suite de Syracuse

Console.WriteLine("Quel nombre voulez-vous ?");
int N = int.Parse(Console.ReadLine());
int max = 0;
int step = 0;
int nb_max = 0;

while (N > 1)
{
    Console.Write(N + " "); // affiche la valeur actuelle
    max = max + N; // ajoute la valeur actuelle à la somme
    if (N % 2 == 0)
    {
        N = N / 2;
    }
    else
    {
        N = N * 3 + 1;
    }
    step++;

    if (N > nb_max) // vérifie si la valeur actuelle est plus grande que le maximum précédent
    {
        nb_max = N; // met à jour le maximum si la valeur actuelle est plus grande
    }

}
Console.WriteLine();
Console.WriteLine("Le nombre d'étapes est : " + step);
Console.WriteLine("La somme des valeurs est : " + max);
Console.WriteLine("La valeur maximale est : " + nb_max);

//========================================================

//Exercice 6 - Le PGCD par soustractions

Console.WriteLine("PGCD par soustractions successives");

int a;
int b;

do // On demande à l'utilisateur de saisir deux entiers strictement positifs
{
    Console.Write("a : ");
    a = int.Parse(Console.ReadLine());

    Console.Write("b : ");
    b = int.Parse(Console.ReadLine());

    if (a <= 0 || b <= 0)
    {
        Console.WriteLine("Erreur : veuillez saisir deux entiers strictement positifs.");
    }
}
while (a <= 0 || b <= 0); // On répète la saisie tant que les conditions ne sont pas respectées

// On garde les valeurs originales pour la fraction simplifiée
int aInitial = a;
int bInitial = b;

// Algorithme des soustractions successives
while (a != b)
{
    if (a > b)
    {
        a = a - b;
    }
    else
    {
        b = b - a;
    }
}

// a et b sont maintenant égaux : c'est le PGCD
int pgcd = a;

Console.WriteLine($"PGCD({aInitial}, {bInitial}) = {pgcd}"); // Affiche le PGCD
Console.WriteLine($"Fraction simplifiée : {aInitial}/{bInitial} = {aInitial / pgcd}/{bInitial / pgcd}"); // Affiche la fraction simplifiée