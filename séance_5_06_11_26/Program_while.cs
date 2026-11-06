//========================================================
//========================================================
//====Programme réalisé le 5/06/26 par Titouan Genève ====
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


