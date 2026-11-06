# Utilisation du switch case 

## Exercices :

- Jour de la semaine
- Calculatrice
- Catégorie d'âge
- Menu
- Équivalent if vs switch

### Exercices while

- La facture avec remise
- Le distributeur de boissons
- Tic et tac
- La caisse du marché
- L'accès au gymnase


## Microsoft

https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/overview

### Découverte writeline $

**En C# :**
```csharp
Console.WriteLine($"Salut, le nombre est {x}");
```
**En python :**
```python
print(f"Salut, le nombre est {x})
```

### Découverte de l'incrémentation

```chsarp
int counter = 0;
while (counter < 10)
{
    Console.WriteLine($"Hello World! The counter is {counter}");
    counter++;
}
```
Ici, <code>counter</code> S'incrémente de 1

### Découverte du do...while

```csharp
int counter = 0;
do
{
    Console.WriteLine($"Hello World! The counter is {counter}");
    counter++;
} while (counter < 10);
```

Le do...while execute le code **puis** vérifie la condition

### Boucle for 

```chsarp
for (int counter = 0; counter < 10; counter++)
{
    Console.WriteLine($"Hello World! The counter is {counter}");
}
```

Ici, <code>int counter</code> intialise le compteur, <code>counter <10 </code> indique que le code continue de tourner tant que counter est inférieur à 10.
Et enfin <code>counter++</code> qui s'incrémente de 1 à chaque boucle

## Découverte du [while](Program_while.cs) :

While veut dire "tant que" tel condition n'est pas faite, le code continue d'iterer

## Microsoft

Les différent éléments de comparaison :

- <code>==</code>: Vérifie si deux valeurs sont égales.
- <code>!=</code>: Vérifie si deux valeurs sont différentes.
- <code>></code>: Vérifie si une valeur est supérieure à une autre.
- <code><</code>: Vérifie si une valeur est inférieure à une autre.
- <code>>=</code>: Vérifie si une valeur est supérieure ou égale à une autre.
- <code><=</code>: Vérifie si une valeur est inférieure ou égale à une autre.

Les différent opérateurs :

- L'opérateur "et" se note && (AND)
```csharp
a && b
```
- L'opérateur "ou" se note || (OR)
```csharp
a || b
```
- L'opérateur "non" se note ! (NOT)
```csharp
 !a
```
### Listes

en python :
```python
liste = ["a","b","c"]
```
en csharp
```csharp
List<string> names = ["<name>", "Ana", "Felipe"];
```
| Fonction dans les listes | python | csharp |
|-----------|-----|-------------|
| ajout     | <code>liste.append()</code> | <code>liste.Add</code> |
| Retirer   | <code>liste.pop()</code> | <code>liste.Remove</code> |
| Longeur   | <code>len(liste)</code> | <code>liste.Count</code>   |


