using System;
using System.Text;

Task();

void Task()
{
    InputArrLenght(out var length);
    var firstArr = FillArr(length);
    EvenOddDivision(firstArr, out var evenArr, out var oddArr);
    ChangeToLetters(ref evenArr, ref oddArr, out var evenStr, out var oddStr);
    Console.WriteLine(evenStr);
    Console.WriteLine(oddStr);
}

void InputArrLenght(out int length)
{
    Console.WriteLine("Array lenght: ");
    var check = int.TryParse(Console.ReadLine(), out length);
    while (!check)
    {
        Console.WriteLine("Wrong option. Try again: ");
        check = int.TryParse(Console.ReadLine(), out length);
    }
}

int[] FillArr(int length)
{
    var minValue = 1;
    var maxValue = 27;
    var firstArr = new int[length];
    for (var i = 0; i < firstArr.Length; i++)
    {
        firstArr[i] = new Random().Next(minValue, maxValue);
    }

    return firstArr;
}

void EvenOddDivision(int[] firstArr, out int[] evenArr, out int[] oddArr)
{
    var evenCounter = 0;
    var oddCounter = 0;

    for (var i = 0; i < firstArr.Length; i++)
    {
        if (firstArr[i] % 2 == 0)
        {
            evenCounter++;
        }
        else
        {
            oddCounter++;
        }
    }

    evenArr = new int[evenCounter];
    oddArr = new int[oddCounter];

    for (var i = 0; i < firstArr.Length; i++)
    {
        if (firstArr[i] % 2 == 0)
        {
            evenCounter--;
            evenArr[evenCounter] = firstArr[i];
        }
        else
        {
            oddCounter--;
            oddArr[oddCounter] = firstArr[i];
        }
    }
}

void ChangeToLetters(ref int[] evenArr, ref int[] oddArr, out string evenStr, out string oddStr)
{
    evenStr = CaseChange(ref evenArr, Alphabet.D, Alphabet.H, Alphabet.J, out var evenUpCounter);
    oddStr = CaseChange(ref oddArr, Alphabet.A, Alphabet.E, Alphabet.I, out var oddUpCounter);

    CompareUpCounters(evenUpCounter, oddUpCounter);
}

string CaseChange(ref int[] arr, Alphabet letter1, Alphabet letter2, Alphabet letter3, out int upCounter)
{
    var sb = new StringBuilder();
    upCounter = 0;
    for (var i = 0; i < arr.Length; i++)
    {
        if ((Alphabet)arr[i] == letter1 || (Alphabet)arr[i] == letter2 || (Alphabet)arr[i] == letter3)
        {
            sb.Append($"{(Alphabet)arr[i]} ");
            upCounter++;
        }
        else
        {
            sb.Append($"{(Alphabet)arr[i]} ".ToLower());
        }
    }

    return sb.ToString();
}

void CompareUpCounters(int evenUpCounter, int oddUpCounter)
{
    if (evenUpCounter > oddUpCounter)
    {
        Console.WriteLine("more even letters in upper case");
    }
    else if (evenUpCounter < oddUpCounter)
    {
        Console.WriteLine("more odd letters in upper case");
    }
    else
    {
        Console.WriteLine("equal number of uppercase letters");
    }
}