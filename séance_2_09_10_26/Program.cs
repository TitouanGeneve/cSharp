//Programmes supplémentaires


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
