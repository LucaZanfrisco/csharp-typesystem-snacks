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

// Snack 4
// Calcola la somma e la media dei numeri da 2 a 10.

int sommaSnack4 = 0;
int mediaSnack4 = 0;

for(int i = 2; i <= 10; i++)
{
    sommaSnack4 += i;
}

mediaSnack4 = sommaSnack4 / 9;

Console.WriteLine($"La sommad dei numeri da 2 a 10 è: {sommaSnack4}");
Console.WriteLine($"La media dei numeri da 2 a 10 è: {mediaSnack4}");

Console.WriteLine("\n------------------------\n");

// Snack 5
//  Il software chiede all’utente di inserire un numero. Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.

Console.Write("Inserire un numero: ");
int numeroUtente = int.Parse(Console.ReadLine());

if(numeroUtente % 2 == 0)
{
    Console.WriteLine($"Numero: {numeroUtente}");
}
else
{
    Console.WriteLine($"Numero: {numeroUtente + 1}");
}

Console.WriteLine("\n------------------------\n");

// Snack 6
// In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.

string[] invitatiFesta = { "Antonio", "Giovanni", "Gianni", "Matteo", "Piero", "Astrubale", "Gino" };

Console.Write("Inserire il proprio nome: ");
string nomeUtente = Console.ReadLine();

Random random = new Random();
bool risultatoRandom = random.Next(2) == 1;

Console.WriteLine($"{(risultatoRandom ? $"{nomeUtente} puoi partecipare alla festa" : $"{nomeUtente} non puoi partecipare alla festa")}");



