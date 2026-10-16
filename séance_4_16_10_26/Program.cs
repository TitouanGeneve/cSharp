//========================================================
//Calculatrice

const string MENU = "+ - * /";
Console.Write("Premier nombre : ");
double a = double.Parse(Console.ReadLine());
Console.Write("Second nombre : ");
double b = double.Parse(Console.ReadLine());
Console.Write("Opération (" + MENU + ") : ");
char operation = Console.ReadLine()[0]; // premier caractère saisi
switch (operation)
{
    case '+':
        Console.WriteLine("Résultat : " + (a + b));
        break;
    case '-':
        Console.WriteLine("Résultat : " + (a - b));
        break;
    case '*':
        Console.WriteLine("Résultat : " + (a * b));
        break;
    case '/':
        if (b != 0)
        {
            Console.WriteLine("Résultat : " + (a / b));
        }
        else
        {
            Console.WriteLine("Erreur : division par zéro.");
        }
        break;
    default:
        Console.WriteLine("Opération inconnue.");
        break;
}

//========================================================
//Jour ouvré

int jour = 3;
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
    default:
        Console.WriteLine("Week-end !");
        break;
}

//Nombre en lettres

int nombre = 3;
switch (nombre)
{
    case 0:
        Console.WriteLine("zéro");
        break;
    case 1:
        Console.WriteLine("un");
        break;
    case 2:
        Console.WriteLine("deux");
        break;
    case 3:
        Console.WriteLine("trois");
        break;
    case 4:
        Console.WriteLine("quatre");
        break;
    case 5:
        Console.WriteLine("cinq");
        break;
    case 6:
        Console.WriteLine("six");
        break;
    case 7:
        Console.WriteLine("sept");
        break;
    case 8:
        Console.WriteLine("huit");
        break;
    case 9:
        Console.WriteLine("neuf");
        break;
}

//========================================================
//Voyelle ou consonne

char lettre = 'a';
switch (lettre)
{
    case 'a':
    case 'o':
    case 'i':
    case 'e':
    case 'u':
    case 'y':
        Console.WriteLine("Voyelle");
        break;
    default :
        Console.WriteLine("Consonne");
        break;
}
