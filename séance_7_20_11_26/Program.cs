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

//========================================================
//========================================================
//========================================================

//Exercice 1 - Le taux de réussite

Console.WriteLine("Combien de notes voulez vous saisir ?");
int nb_notes = int.Parse(Console.ReadLine());
int admis = 0;
for (int i = 1; i <= nb_notes; i++)
{
    double note = double.Parse(Console.ReadLine());
    Console.WriteLine("Note : " + note);
    if (note>=10)
    {
        admis++;
    }
}
Console.WriteLine("Admis : " + admis + " sur " + nb_notes);

//========================================================

//Exercice 2 - Le record de la course

Console.WriteLine("Combien de coureurs ?");
int n = int.Parse(Console.ReadLine());

double meilleurTemps = double.MaxValue;
int coureurRecord = 0;

for (int i = 1; i <= n; i++)
{
    Console.WriteLine("Temps du coureur " + i + " (en secondes) :");
    double temps = double.Parse(Console.ReadLine());

    if (temps < meilleurTemps)
    {
        meilleurTemps = temps;
        coureurRecord = i;
    }
}
Console.WriteLine("Record : " + meilleurTemps + " secondes, réalisé par le coureur " + coureurRecord);

//========================================================

//Exercice 3 - Les années bissextiles

Console.WriteLine("Année de début :");
int anneeDebut = int.Parse(Console.ReadLine());

Console.WriteLine("Année de fin :");
int anneeFin = int.Parse(Console.ReadLine());

int totalBissextiles = 0;

for (int an = anneeDebut; an <= anneeFin; an++)
{
    if ((an % 4 == 0 && an % 100 != 0) || an % 400 == 0)
    {
        Console.WriteLine(an);
        totalBissextiles++;
    }
}

Console.WriteLine("Bissextiles trouvées : " + totalBissextiles);

//========================================================

//Exercice 4 - Le cadre vide

Console.WriteLine("Largeur :");
int largeurCadre = int.Parse(Console.ReadLine());
Console.WriteLine("Hauteur :");
int hauteurCadre = int.Parse(Console.ReadLine());
for (int ligne = 1; ligne <= hauteurCadre; ligne++)
{
    for (int colonne = 1; colonne <= largeurCadre; colonne++)
    {
        if (ligne == 1 || ligne == hauteurCadre ||colonne == 1 || colonne == largeurCadre)
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(".");
        }
    }

    Console.WriteLine();
}

//========================================================

//Exercice 5 - La somme des chiffres

Console.WriteLine("Nombre :");
int nombreA = int.Parse(Console.ReadLine());
int sommeDesChiffres = 0;

while (nombreA != 0)
{
    sommeDesChiffres += nombreA % 10;
    nombreA /= 10;
}

Console.WriteLine("Somme des chiffres : " + sommeDesChiffres);

//========================================================

// Exercice 6 - Le rendu de monnaie

Console.WriteLine("Montant à rendre :");
int resteMonnaie = int.Parse(Console.ReadLine());

int piecesDeCinq = 0;
int piecesDeDeux = 0;

while (resteMonnaie >= 5)
{
    resteMonnaie -= 5;
    piecesDeCinq++;
}

while (resteMonnaie >= 2)
{
    resteMonnaie -= 2;
    piecesDeDeux++;
}

Console.WriteLine("Pièces de 5 : " + piecesDeCinq);
Console.WriteLine("Pièces de 2 : " + piecesDeDeux);

if (resteMonnaie == 0)
{
    Console.WriteLine("Rendu exact.");
}
else
{
    Console.WriteLine("Impossible de rendre " + resteMonnaie + " euro(s) avec ces pièces.");
}

//========================================================

// Exercice 7 - La tirelire du vélo

const int versementMensuel = 30;
const int prixVelo = 250;

Console.WriteLine("Solde actuel :");
int soldeTirelire = int.Parse(Console.ReadLine());

int moisNecessaires = 0;

while (soldeTirelire < prixVelo)
{
    soldeTirelire += versementMensuel;
    moisNecessaires++;
}

Console.WriteLine("Mois nécessaires : " + moisNecessaires);

if (soldeTirelire > prixVelo)
{
    Console.WriteLine("Il restera " + (soldeTirelire - prixVelo) + " euros dans la tirelire.");
}
else
{
    Console.WriteLine("Pile le juste montant.");
}

//========================================================

//Exercice 8 - Le petit quiz

int scoreQuiz = 0;
int numeroQuestionQuiz = 1;
while (numeroQuestionQuiz <= 3)
{
    string reponseAttendueQuiz;
    if (numeroQuestionQuiz == 1)
    {
        Console.WriteLine("Quel mot-clé déclare une constante ?");
        reponseAttendueQuiz = "const";
    }
    else if (numeroQuestionQuiz == 2)
    {
        Console.WriteLine("Quel opérateur signifie « différent de » ?");
        reponseAttendueQuiz = "!=";
    }
    else
    {
        Console.WriteLine("Quelle boucle teste sa condition avant chaque tour ?");
        reponseAttendueQuiz = "while";
    }
    string reponseUtilisateurQuiz = Console.ReadLine().Trim().ToLower();

    if (reponseUtilisateurQuiz == reponseAttendueQuiz)
    {
        scoreQuiz++;
    }
    numeroQuestionQuiz++;
}
Console.WriteLine("Score : " + scoreQuiz + " / 3.");

if (scoreQuiz == 3)
{
    Console.WriteLine("Très bien !");
}
else if (scoreQuiz == 2)
{
    Console.WriteLine("Encore un petit effort");
}
else
{
    Console.WriteLine("À réviser");
}

//========================================================

//Exercice 9 - Le menu du jeu d'exploration

int or = 0;
int pv = 0;
char choixJeu = ' ';

while (choixJeu != 'q')
{
    Console.Write("(e) explorer, (c) combattre, (q) quitter : ");
    choixJeu = char.Parse(Console.ReadLine());

    switch (choixJeu)
    {
        case 'e':
            or += 10;
            Console.WriteLine("Vous explorez et trouvez 10 pièces d'or.");
            break;

        case 'c':
            pv += 2;
            Console.WriteLine("Vous combattez et perdez 2 points de vie.");
            break;

        case 'q':
            break;

        default:
            Console.WriteLine("Commande inconnue");
            break;
    }
}

Console.WriteLine("Fin de partie : " + or + " pièces d'or, " + pv + " points de vie perdus.");

//========================================================

//Exercice 10 - Le four

int temperatureFour = 20;
int maxiFour = 20;
int miniFour = 20;
char commandeFour = ' ';
while (commandeFour != 'a')
{
Console.Write("Commande (+, -, a) : ");
commandeFour = char.Parse(Console.ReadLine());
switch (commandeFour)
{
    case '+':
        if (temperatureFour >= 280)
        {
            Console.WriteLine("Le four est déjà au maximum.");
        }
        else
        {
            temperatureFour += 20;

            if (temperatureFour > maxiFour)
            {
                maxiFour = temperatureFour;
            }

            Console.WriteLine("Température : " + temperatureFour);
        }
        break;

    case '-':
        if (temperatureFour <= 20)
        {
            Console.WriteLine("Le four est déjà au minimum.");
        }
        else
        {
            temperatureFour -= 20;

            if (temperatureFour < miniFour)
            {
                miniFour = temperatureFour;
            }

            Console.WriteLine("Température : " + temperatureFour);
        }
        break;

    case 'a':
        break;

    default:
        Console.WriteLine("Commande invalide.");
        break;
}
}
Console.WriteLine("Arrêté à " + temperatureFour + " degrés. Max atteint : " + maxiFour + ", min : " + miniFour + ".");

//========================================================

//Exercice 11 - La serre connectée

 int mesuresValidesSerre = 0;
 int alertesSerre = 0;
 bool alerteTrouveeSerre = false;
 double temperatureExtremSerre = 0;
 double distanceExtremSerre = 0;
 Console.Write("Température : (-1 pour arréter les mesures)");
 double temperatureCapteur = double.Parse(Console.ReadLine());
 while (temperatureCapteur != -1)
 {
     if (temperatureCapteur >= 10 && temperatureCapteur <= 25)
     {
         mesuresValidesSerre++;
     }
     else
     {
         alertesSerre++;
         double distanceAlerteSerre;
         if (temperatureCapteur < 10)
         {
             distanceAlerteSerre = 10 - temperatureCapteur;
         }
         else
         {
             distanceAlerteSerre = temperatureCapteur - 25;
         }
         if (!alerteTrouveeSerre || distanceAlerteSerre > distanceExtremSerre)
         {
             alerteTrouveeSerre = true;
             temperatureExtremSerre = temperatureCapteur;
             distanceExtremSerre = distanceAlerteSerre;
         }
     }
     Console.Write("Température : ");
     temperatureCapteur = double.Parse(Console.ReadLine());
 }
 Console.WriteLine("Mesures valides : " + mesuresValidesSerre + ", alertes : " + alertesSerre + ".");
 if (alerteTrouveeSerre)
 {
     Console.WriteLine("La plus extrême : " + temperatureExtremSerre + " (à " + distanceExtremSerre + " degrés de la plage).");
 }
 else
 {
     Console.WriteLine("Aucune alerte relevée.");
 }

 //========================================================

 //Exercice 12 - Le distributeur de boissons version Écosse

const int prixBoissonDistributeur = 2;
Console.WriteLine("Crédit :");
int creditDistributeur = int.Parse(Console.ReadLine());
int boissonsServiesDistributeur = 0;
char choixBoisson = ' ';
while (choixBoisson != 'q')
{
    Console.Write("(t) thé, (a) eau, (s) soda, (q) partir : ");
    choixBoisson = char.Parse(Console.ReadLine());
    switch (choixBoisson)
    {
        case 't':
        case 'a':
        case 's':
            if (creditDistributeur >= prixBoissonDistributeur)
            {
                creditDistributeur -= prixBoissonDistributeur;
                boissonsServiesDistributeur++;

                if (choixBoisson == 't')
                {
                    Console.WriteLine("Thé servi, il reste " + creditDistributeur + " euros.");
                }
                else if (choixBoisson == 'a')
                {
                    Console.WriteLine("Eau servie, il reste " + creditDistributeur + " euros.");
                }
                else
                {
                    Console.WriteLine("Soda servi, il reste " + creditDistributeur + " euros.");
                }
            }
            else
            {
                Console.WriteLine("Crédit insuffisant, choisissez q ou ...");
            }
            break;

        case 'q':
            break;

        default:
            Console.WriteLine("Commande inconnue.");
            break;
    }
}
string uniteMonnaie = creditDistributeur == 1 ? "euro" : "euros";
Console.WriteLine("Monnaie rendue : " + creditDistributeur + " " + uniteMonnaie + ". Boissons servies : " + boissonsServiesDistributeur + ".");