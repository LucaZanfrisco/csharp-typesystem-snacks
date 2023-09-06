// See https://aka.ms/new-console-template for more information

// Snack 1
// L’utente inserisce due numeri in successione. Il software stampa il maggiore.

Console.Write("Inserire il primo numero: ");
float primoNumero = float.Parse(Console.ReadLine());

Console.Write("Inserie il secondo numero: ");
float secondoNumero = float.Parse(Console.ReadLine());

if(primoNumero > secondoNumero)
{
    Console.WriteLine($"Il primo numero '{primoNumero}' è il maggiore");
}else
{
    Console.WriteLine($"Il secondo numero '{secondoNumero}' è il maggiore");
}

Console.WriteLine("\n------------------------\n");

// Snack 2
// L’utente inserisce due parole in successione. Il software stampa prima la parola più corta, poi la parola più lunga.

Console.Write("Inserire la prima parola: ");
string primaParola = Console.ReadLine();

Console.Write("Inserire la seconda parola: ");
string secondaParola = Console.ReadLine();

if (primaParola.Length > secondaParola.Length)
{
    Console.WriteLine($"La prima parola '{primaParola}' è la più lunga");
}
else
{
    Console.WriteLine($"La seconda parola '{secondaParola}' è la piu lunga");
}

Console.WriteLine("\n------------------------\n");

// Snack 3
// Il software deve chiedere per 10 volte all’utente di inserire un numero. Il programma stampa la somma di tutti i numeri inseriti.

int i = 1;
float somma = 0;
while(i <= 10)
{
    Console.Write($"Inserire il numero {i} :");
    somma += float.Parse(Console.ReadLine());
    i++;
}

Console.WriteLine($"La somma di tutti i numeri inseriti è: {somma}");

Console.WriteLine("\n------------------------\n");