//Programmes supplémentaires

//========================================================

//Vérification de doublons
Console.WriteLine("Veuillez saisir une phrase : ");
string Phrase = Console.ReadLine();

for (int i = 0; i < Phrase.Length; i++) // Parcours chaque caractère de la phrase
{
    bool dejaVu = false; // Variable pour vérifier si le caractère a déjà été vu


    for (int j = 0; j < i; j++) // Vérifie si le caractère a déjà été vu avant l'itération actuelle
    {
        if (Phrase[i] == Phrase[j]) // Vérifie si le caractère est un doublon
        {
            dejaVu = true; // Met la variable dejaVu à true si le caractère a déjà été vu
            break; // arrète le code
        }
    }

    if (dejaVu) // Vérifie si le caractère a déjà été vu
        continue; // passe à l'itération suivante si le caractère a déjà été vu

    for (int j = i + 1; j < Phrase.Length; j++) // Vérifier si le caractère apparaît encore après

    {
        if (Phrase[i] == Phrase[j]) // Vérifie si le caractère est un doublon
        {
            Console.WriteLine("Doublon : " + Phrase[i]); // affiche le doublon
            break; // arrète le code
        }
    }
}

//========================================================

// Compter les caractères
Console.WriteLine("Veuillez saisir une phrase : "); 
string Phrase = Console.ReadLine(); //Lit la phrase saisie par l'utilisateur

Console.WriteLine("La longeur de la phrase est : " + Phrase.Length); //Affiche la longeur de la phrase

//========================================================

//Retourner la phrase
Console.WriteLine("Veuillez saisir une phrase : "); 
string Phrase = Console.ReadLine(); //Lit la phrase saisie par l'utilisateur

for (int i = Phrase.Length - 1; i >= 0; i--) //Boucle pour parcourir la phrase à l'envers
{
    Console.Write(Phrase[i]); //Affiche chaque caractère de la phrase à l'envers
}

//========================================================

//Calculatrice
Console.WriteLine("Calculatire chargée");
Console.WriteLine("Entrez le premier nombre :");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Entrez le deuxième nombre :");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Entrez l'opération à effectuer (+,-,/,*,^^,%)");
string operation = Console.ReadLine();
if (operation == "+")
{
    Console.WriteLine("Le résultat de " + a + " plus " + b + " est :");
    Console.WriteLine(a + b); // Affiche la somme de a et b
}
else if (operation == "-")
{
    Console.WriteLine("Le résultat de " + a + " moins " + b + " est :");
    Console.WriteLine(a - b); // Affiche la différence entre a et b
}
else if (operation == "/")
{
    Console.WriteLine("Le résultat de " + a + " divisé par " + b + " est :");
    Console.WriteLine(a / b); // Affiche le quotient de a et b
}
else if (operation == "*")
{
    Console.WriteLine("Le résultat de " + a + " multiplié par " + b + " est :");
    Console.WriteLine(a * b); // Affiche le produit de a et b
}
else if (operation == "^^")
{
    Console.WriteLine("Le résultat de " + a + " à la puissance " + b + " est :");
    Console.WriteLine(Math.Pow(a, b)); // Affiche a à la puissance b
}
else if (operation == "%")
{
    Console.WriteLine("Le résultat de " + a + " modulo " + b + " est :");
    Console.WriteLine(a % b); // Affiche le reste de la division de a par b
}
else
{
    Console.WriteLine("Opération non reconnue");
}

//========================================================

//Convertisseur
Console.WriteLine("Convertisseur d'unités chargé");
Console.WriteLine("Entrez la valeur à convertir (distance) :");
double a = double.Parse(Console.ReadLine()); // Lecture de la valeur à convertir (virgule acceptée)
Console.WriteLine("Entrez l'unité de départ (m, cm, mm) :");
string unit1 = Console.ReadLine();
Console.WriteLine("Entrez l'unité d'arrivée (m, cm, mm) :");
string unit2 = Console.ReadLine();
if (unit1 == "m" && unit2 == "cm")
{
    double result = a * 100; // Conversion de mètres en centimètres
    Console.WriteLine($"{a} m = {result} cm");
}
else if (unit1 == "cm" && unit2 == "m")
{
    double result = a / 100; // Conversion de centimètres en mètres
    Console.WriteLine($"{a} cm = {result} m");
}
else if (unit1 == "m" && unit2 == "mm")
{
    double result = a * 1000; // Conversion de mètres en millimètres
    Console.WriteLine($"{a} m = {result} mm");
}
else if (unit1 == "mm" && unit2 == "m")
{
    double result = a / 1000; // Conversion de millimètres en mètres
    Console.WriteLine($"{a} mm = {result} m");
}
else if (unit1 == "cm" && unit2 == "mm")
{
    double result = a * 10; // Conversion de centimètres en millimètres
    Console.WriteLine($"{a} cm = {result} mm");
}
else if (unit1 == "mm" && unit2 == "cm")
{
    double result = a / 10; // Conversion de millimètres en centimètres
    Console.WriteLine($"{a} mm = {result} cm");
}
else
{
    Console.WriteLine("Conversion non supportée.");
}

//========================================================

//Jeu du nombre mystère
Console.WriteLine("Jeu du nombre mystère");
Console.WriteLine("Veuillez entrer un nombre entre 1 et 100 :");

int Nombre = int.Parse(Console.ReadLine());
int i = 0;
Random random = new Random();
int NombreMystere = random.Next(1, 101);

while (Nombre != NombreMystere)
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
}

Console.WriteLine("Félicitations ! Vous avez trouvé le nombre mystère en " + i + " tentatives !");
