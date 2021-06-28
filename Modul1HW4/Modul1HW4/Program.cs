using System;
using System.Text;

Task();

void Task()
{
    InputArrLenght(out var lenght);
    Console.WriteLine(lenght);
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