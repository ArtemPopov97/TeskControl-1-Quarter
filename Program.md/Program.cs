string [] Array1 = new string [4] {"1234", "1567", "-2", "computer science"};
string [] Array2 = new string [Array1.Length];
int count = 0;

void CheckingArray (string [] Array1, string [] Array2)
{
    for (int i = 0; i < Array1.Length; i++)
    {
        if (Array1[i].Length <= 3)
        {
            Array2[count] = Array1[i];
            count++;
        }
    }
}

void PrintMassiv (string [] Array2)
{
    for (int i = 0; i < Array2.Length; i++)
    {
        Console.WriteLine($"{Array2[i]} ");
    }
}

CheckingArray(Array1,Array2);
PrintMassiv(Array2);
