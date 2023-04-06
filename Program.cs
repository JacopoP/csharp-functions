void StampaArray(int[] numbers)
{
    Console.Write("[");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i]);
        if (i < numbers.Length - 1)
            Console.Write(',');
    }
    Console.WriteLine("]");
}

int Quadrato(int n)
{
    return n * n;
}

int[] ElevaArrayAlQuadrato(int[] Numbers)
{
    int[] CloneArr = (int[])Numbers.Clone();

    for (int i = 0; i < CloneArr.Length; i++)
        CloneArr[i] = Quadrato(CloneArr[i]);

    return CloneArr;
}

int sommaElementiArray(int[] numbers)
{
    int somma = 0;
    for (int i = 0;i < numbers.Length; i++) 
        somma += numbers[i];
    return somma;
}

Console.WriteLine("Su quanti numeri vuoi lavorare?");

int n;

while(!int.TryParse(Console.ReadLine(), out n))
    Console.WriteLine("Inserisci un numero valido!");

int[] numbers = new int[n];

Console.WriteLine("Inserisci ora i numeri");

for (int i = 0; i < n; i++)
{
    if (!int.TryParse(Console.ReadLine(), out numbers[i]))
    {
        Console.WriteLine("Numero non valido. Riprovare");
        i--;
    }
    else
        Console.WriteLine("Numero salvato!");
}

StampaArray(numbers);

StampaArray(ElevaArrayAlQuadrato(numbers));

Console.WriteLine(sommaElementiArray(numbers));

Console.WriteLine(sommaElementiArray(ElevaArrayAlQuadrato(numbers)));