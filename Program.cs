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