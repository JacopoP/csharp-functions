void StampaArray(int[] Array)
{
    Console.Write("[");
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write(Array[i]);
        if (i < Array.Length - 1)
            Console.Write(',');
    }
    Console.WriteLine("]");
}