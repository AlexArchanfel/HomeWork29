// Задача 29 Напишите программу которая задаёт массив из 8 элементов и выводит их на экран

void Check(int nums)
{
    if (nums == 0 || nums == 1 || nums == 2) 
    { }
    else
    {
        Console.WriteLine($"Введите данные.");
    }
}

int [] numsArray(string newNums)
{
    int[] newNumsArray = new int[1];

    int j = 0;

    for (int i = 0; i < newNums.Length; i++)
    {
        string newNums1 = "";

        while (newNums[i] != ',' && i < newNums.Length)
        {
            newNums1 += newNums[i];
            Check(newNums[i]);

            i++;
        }
        newNumsArray[j] = Convert.ToInt32(newNums1);
        if (i < newNums.Length - 1)
        {
            newNumsArray = newNumsArray.Concat(new int[] { 0 }).ToArray();
        }
        j++;  
        }
        return newNumsArray;
}

Console.Clear();
Console.Write ("Введите не более 8 чисел через запятую: ");
string Numbers = Console.ReadLine();
Numbers = Numbers + ",";
int[] NumZArray = numsArray(Numbers);

if(NumZArray.Length > 8)
{
    Console.WriteLine("Ввелите корректное количество чисел");
}
else 
{
    int[] newNumsArray = numsArray(Numbers);
    PrintArry(newNumsArray);
}
