// Exercice 1 — Jour de la semaine (switch simple)

Console.WriteLine("Entrez le jour 1 à 7");
string jourStr = Console.ReadLine();
int jour = int.Parse(jourStr);
switch (jour)
{
    case 1:
        Console.WriteLine("Lundi");
        break;
    case 2:
        Console.WriteLine("Mardi");
        break;
    case 3:
        Console.WriteLine("Mercredi");
        break;
    case 4:
        Console.WriteLine("Jeudi");
        break;
    case 5:
        Console.WriteLine("Vendredi");
        break;
    case 6:
        Console.WriteLine("Samedi");
        break;
    case 7:
        Console.WriteLine("Dimanche");
        break;
}

//========================================================

// Exercice 2 — Calculatrice simple (switch + opérateurs)

Console.WriteLine("Calculatire chargée");
Console.WriteLine("Entrez le premier nombre :");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Entrez le deuxième nombre :");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Entrez l'opération à effectuer (+,-,/,*,^^,%)");
string operation = Console.ReadLine();
switch(operation) // switch pour choisir l'opération à effectuer
{
    case "*": // si l'opération est une multiplication
        Console.WriteLine("Le résultat de " + a + " multiplié par " + b + " est :");
        Console.WriteLine(a * b);
        break;
    case "+": // si l'opération est une addition
        Console.WriteLine("Le résultat de " + a + " additionné à " + b + " est :");
        Console.WriteLine(a + b);
        break;
    case "-": // si l'opération est une soustraction
        Console.WriteLine("Le résultat de " + a + " moins " + b + " est :");
        Console.WriteLine(a - b);
        break;
    case "/": // si l'opération est une division
        if (b == 0) // vérification de la division par zéro
        {
            Console.WriteLine("Erreur : division par zéro impossible.");
        }
        else
        {
            Console.WriteLine("Le résultat de " + a + " divisé par " + b + " est :");
            Console.WriteLine(a / b);
        }
        break;
    case "^^": // si l'opération est une puissance
        Console.WriteLine("Le résultat de " + a + " à la puissance " + b + " est :");
        Console.WriteLine(Math.Pow(a, b));
        break;
    case "%": // si l'opération est un modulo
        Console.WriteLine("Le résultat de " + a + " modulo " + b + " est :");
        Console.WriteLine(a % b);
        break;
    default:// si l'opération n'est pas reconnue
        Console.WriteLine("Opération non reconnue");
        break;
}

//========================================================

// Exercice 3 — Catégorie d’âge (switch avec intervalles simulés)

Console.WriteLine("Entrez votre àge (nombre entier) : ");
int age = int.Parse(Console.ReadLine());
switch (age)
{
    case int n when n <= 12: // utilisation d'int n when n <= 12 pour simuler un intervalle
        Console.WriteLine("Vous êtes un enfant.");
        break;
    case int n when n >= 13 && n <= 17:
        Console.WriteLine("Vous êtes un adolescent.");
        break;
    case int n when n >= 18 && n < 65:
        Console.WriteLine("Vous êtes un adulte.");
        break;
    case int n when n >= 65:
        Console.WriteLine("Vous êtes un senior.");
        break;
    default:
        Console.WriteLine("Valeur d'âge invalide.");
        break;
}

//========================================================

// Exercice 4 — Menu texte (switch + sous-menus possibles)

Console.WriteLine("Que souhaitez vous faire ? (1) Démarrer, (2) Arrêter, (3) Redémarrer, (4) Quitter");
string choix = Console.ReadLine();
switch (choix)
{
    case "1":
        Console.WriteLine("Démarrage du programme...");
        break;
    case "2":
        Console.WriteLine("Arrêt du programme...");
        break;
    case "3":
        Console.WriteLine("Redémarrage du programme...");
        break;
    case "4":
        Console.WriteLine("Fermeture du programme...");
        break;
    default:
        Console.WriteLine("Choix invalide.");
        break;
}

//========================================================

// Exercice 5 — Equivalent IF vs SWITCH

// Switch case

Console.WriteLine("Saisir une note (A, B, C, D, E ou F) : ");
string note = Console.ReadLine();
switch (note)
{
    case "A":
        Console.WriteLine("Excellent !");
        break;
    case "B": 
        Console.WriteLine("Très bien !");
        break;
    case "C": 
        Console.WriteLine("Bien !");
        break;
    case "D": 
        Console.WriteLine("Passable !");
        break;
    case "E": 
        Console.WriteLine("Insuffisant !");
        break;
    case "F": 
        Console.WriteLine("Échec !");
        break;
    default:
        Console.WriteLine("Note invalide.");
        break;
}

// Equivalent IF else

Console.WriteLine("Saisir une note (A, B, C, D, E ou F) : ");
string note = Console.ReadLine();
if (note == "A")
{
    Console.WriteLine("Excellent !");
}
else if (note == "B")
{
    Console.WriteLine("Très bien !");
}
else if (note == "C")
{
    Console.WriteLine("Bien !");
}
else if (note == "D")
{
    Console.WriteLine("Passable !");
}
else if (note == "E")
{
    Console.WriteLine("Insuffisant !");
}
else if (note == "F")
{
    Console.WriteLine("Échec !");
}
else
{
    Console.WriteLine("Note invalide.");
}