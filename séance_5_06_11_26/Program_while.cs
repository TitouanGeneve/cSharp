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
