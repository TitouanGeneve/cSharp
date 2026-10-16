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
