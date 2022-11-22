using System;
class Programm
{
    public static void Main(string[] args)
    {

        var someName = "Дмитрий";
        Console.WriteLine(someName);

        GetName(someName);

        Console.WriteLine(someName);

        Console.ReadKey();
    }

    static void GetName(string name)
    {
        Console.WriteLine("Введите имя");
       
        name = Console.ReadLine();

    }

}