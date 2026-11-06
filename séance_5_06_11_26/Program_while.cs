//========================================================
//========================================================
//====Programme réalisé le 05/06/26 par Titouan Genève ====
//========================================================
//========================================================


//Exemple 1 :

int compteur = 1; // initialisation : on part de 1
while (compteur <= 5) // condition : on s'arrête après 5
{
    Console.WriteLine("Tour numéro " + compteur);
    compteur = compteur + 1; // ne jamais oublier le progrès !
}

//========================================================

//Exemple 2 :

double total = 0; // l'accumulateur démarre à zéro
int compteur = 1;
while (compteur <= 5)
{
Console.Write("Note " + compteur + " : ");
double note = double.Parse(Console.ReadLine());
total = total + note; // on ajoute la note au total
compteur++;
}
Console.WriteLine("Somme : " + total);
Console.WriteLine("Moyenne : " + (total / 5));

//========================================================

//Exemple 3 :

const double FIN = -1.0;
double total = 0;
int nbNotes = 0;
Console.Write("Une note (" + FIN + " pour terminer) : ");
double note = double.Parse(Console.ReadLine());
while (note != FIN) // tant que la note n'est pas égale à -1
{
if (note >= 0 && note <= 20)
{
total = total + note;
nbNotes++; // on compte le nombre de notes valides
}
else
{
Console.WriteLine("Note ignorée (hors 0 à 20).");
}
Console.Write("Une note (" + FIN + " pour terminer) : ");
note = double.Parse(Console.ReadLine());
}
if (nbNotes > 0)
{
Console.WriteLine("Moyenne : " + (total / nbNotes));
}
else
{
Console.WriteLine("Aucune note saisie.");
}

//========================================================
//========================================================

//Exercice 1 :

double prixUnitaire = 0;
double prixTotal = 0;
double prixFinal = 0;
const double TVA = 0.2; // Taux de TVA de 20%
const double REMISE = 0.05; // Taux de remise de 5%

Console.WriteLine("Quel est le prix unitaire du produit ?");
prixUnitaire = double.Parse(Console.ReadLine());
Console.WriteLine("Quel est le nombre d'articles ?");
int nombreArticles = int.Parse(Console.ReadLine());
if (prixUnitaire * nombreArticles > 50)
{
    Console.WriteLine("Vous bénéficiez d'une remise de 5%");
    prixTotal = prixUnitaire * nombreArticles; // Calcul du prix total avant remise
    double remise = prixTotal * REMISE; // Calcul de la remise
    prixFinal = (prixTotal - remise) * (1 + TVA); // Ajout de la TVA
    Console.WriteLine($"Le prix final est : {prixFinal}");
}
else
{
    prixFinal = (prixUnitaire * nombreArticles) * (1 + TVA); // Ajout de la TVA
    Console.WriteLine($"Vous ne bénéficiez pas d'une remise, le prix final est : {prixFinal}");
}

//========================================================

//Exercice 2 :

Console.WriteLine("Choissisez votre gobelet : (p), petit 1 euros, (m), moyen 1.5 euros, (g), grand 2 euros");
char goblet = Convert.ToChar(Console.ReadLine()); // on récupère le caractère saisi par l'utilisateur
switch (gobelet)
{
    case 'p':
        Console.WriteLine("Vous avez choisi le gobelet petit, le prix est de 1 euros");
        break;
    case 'm':
        Console.WriteLine("Vous avez choisi le gobelet moyen, le prix est de 1.5 euros");
        break;
    case 'g':
        Console.WriteLine("Vous avez choisi le gobelet grand, le prix est de 2 euros");
        break;
    default:
        Console.WriteLine("Choix invalide, pièce rendue");
        break;
}

//========================================================

//Exercice 3 :

int compteur = 1;
while (compteur < 21)
{
    if (compteur % 3 == 0 && compteur % 5 == 0) // si le compteur est divisible par 3 et 5
    {
        Console.WriteLine("Tic Tac");
    }
    else if (compteur % 5 == 0) // si le compteur est divisible par 5
    {
        Console.WriteLine("Tac");
    }
    else if (compteur % 3 == 0) // si le compteur est divisible par 3
    {
        Console.WriteLine("Tic");
    }
    else
    {
        Console.WriteLine(compteur);
    }
    compteur++;

}

//========================================================

//Exercice 4 :

Console.WriteLine("Entrez le prix des articles (0 pour terminer) :");
double prix = Convert.ToDouble(Console.ReadLine());
double prix_total = 0;
int nb_articles = 0;
const double frais_livraison = 4.90;
const double seuil_livraison_gratuite = 30.00;
while (prix != 0) // tant que le prix n'est pas égal à 0
{
    if (prix < 0)
    {
        Console.WriteLine("Le prix ne peut pas être négatif. Veuillez entrer un prix valide.");
    }
    else
    {
        prix_total = prix_total + prix;
        nb_articles++;
    }
    prix = Convert.ToDouble(Console.ReadLine());
}

if (prix_total > seuil_livraison_gratuite) // si le prix total est supérieur à 30, la livraison est gratuite
{
    Console.WriteLine("Vous bénéficiez de la livraison gratuite !");
    Console.WriteLine($"Nombre d'articles : {nb_articles}");
    Console.WriteLine($"Prix total : {prix_total}");
}
else
{
    Console.WriteLine("Vous devez payer les frais de livraison de 4,90 euros.");
    Console.WriteLine($"Nombre d'articles : {nb_articles}");
    Console.WriteLine($"Prix total : {prix_total + frais_livraison}"); // on ajoute les frais de livraison
}

//========================================================

//Exercice 5 :

Console.WriteLine("Quel est votre âge ?");
int age = int.Parse(Console.ReadLine());
while (age < 0 || age == 0 || age > 99)
{
    Console.WriteLine("L'âge doit être compris entre 1 et 99. Veuillez entrer un âge valide.");
    age = int.Parse(Console.ReadLine());
}

switch (age)
{
    case int n when (n < 12):
        Console.WriteLine("gratuit");
        break;
    case int n when (n >= 12 && n <= 17):
        Console.WriteLine("Tarif jeune, 3 euros");
        break;
    case int n when (n >= 18 && n <= 64):
        Console.WriteLine("Tarif plein, 6 euros");
        break;
    case int n when (n >= 65):
        Console.WriteLine("Tarif senior, 4 euros");
        break;
}