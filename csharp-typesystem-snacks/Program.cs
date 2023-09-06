// See https://aka.ms/new-console-template for more information

// Snack 1
// L’utente inserisce due numeri in successione. Il software stampa il maggiore.

Console.Write("Inserire il primo numero: ");
int primoNumero = int.Parse(Console.ReadLine());

Console.Write("Inserie il secondo numero: ");
int secondoNumero = int.Parse(Console.ReadLine());

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


