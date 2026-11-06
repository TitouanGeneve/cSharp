# Utilisation du switch case 

## Exercices :

- Jour de la semaine
- Calculatrice
- Catégorie d'âge
- Menu
- Équivalent if vs switch

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

While veut dire "tant que"

