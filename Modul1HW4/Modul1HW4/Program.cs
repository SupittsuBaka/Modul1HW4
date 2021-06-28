using System;
using System.Text;

Task();

void Task()
{
    InputArrLenght(out var length);
    var firstArr = FillArr(length);
    EvenOddDivision(firstArr, out var evenArr, out var oddArr);
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