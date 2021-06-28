using System;
using System.Text;

Task();

void Task()
{
    InputArrLenght(out var lenght);
    var firstArr = FillArr(lenght);
}

void InputArrLenght(out int lenght)
{
    Console.WriteLine("Array lenght: ");
    var check = int.TryParse(Console.ReadLine(), out lenght);
    while (!check)
    {
        Console.WriteLine("Wrong option. Try again: ");
        check = int.TryParse(Console.ReadLine(), out lenght);
    }
}

int[] FillArr(int lenght)
{
    var minValue = 1;
    var maxValue = 26;
    var firstArr = new int[lenght];
    for (var i = 0; i < firstArr.Length; i++)
    {
        firstArr[i] = new Random().Next(minValue, maxValue);
    }

    return firstArr;
}