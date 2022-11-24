namespace ModuleItog5_6
{
   class Program
    {
        static void Main(string[] args)
        {
            ShowAnket(GetAnketa());
            Console.ReadKey();
        }
        static (string name, string surname, int age, bool ispet, int numofpets, string[] pets, int numofcolors, string[] favcolors) GetAnketa()
        {
            (string name, string surname, int age, bool ispet, int numofpets, string[] pets, int numofcolors, string[] favcolors) anketa;

            Console.Write("Введите ваше имя: ");
            anketa.name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            anketa.surname = Console.ReadLine();
            Console.Write("Укажите свой возраст: ");
            anketa.age = Convert.ToInt32(Console.ReadLine());

            Console.Write("У вас есть питомец? (ответьте да или нет) ");
            switch (Console.ReadLine())
            {
                case "Да":
                case "да":
                    anketa.ispet = true;
                    break;
                default:
                    anketa.ispet = false;
                    break;
            }
            if (anketa.ispet)
            {
                do
                {
                    Console.Write("Сколько у вас питомцев? (ответ напишити цифрами) ");
                    anketa.numofpets = Convert.ToInt32(Console.ReadLine());
                    if (!isCorrect(anketa.numofpets))
                    Console.WriteLine("Ошибка");
                } while (!isCorrect(anketa.numofpets));
                anketa.pets = GetPets(anketa.numofpets);
            }
            else
            {
                anketa.pets = new string[0];
                anketa.numofpets = 0;
            }
            Console.Write("У вас есть любимые цвет? (ответьте да или нет) ");
            switch (Console.ReadLine())
            {
                case "Да":
                case "да":
                    do
                    {
                     Console.Write("Сколько у вас любымых цвета(ов)? ");
                     anketa.numofcolors = Convert.ToInt32(Console.ReadLine());
                     if (!isCorrect(anketa.numofcolors))
                     Console.WriteLine("Ошибка");
                    } while (!isCorrect(anketa.numofcolors));
                    anketa.favcolors = GetColors(anketa.numofcolors);
                    break;
                default:
                    anketa.favcolors = new string[0];
                    anketa.numofcolors = 0;
                    break;
            }
            return anketa;
        }
        private static string[] GetColors(int numofcolors)
        {
            var colors = new string[numofcolors];

            for (int i = 0; i < numofcolors; i++)
            {
                Console.Write($"какой ваш {i + 1} любимый цвет? ");
                colors[i] = Console.ReadLine();
            }
            return colors;
        }
        static string[] GetPets(int numofpets)
        {
            var pets = new string[numofpets];
            for (int i = 0; i < numofpets; i++)
            {
                Console.Write($"какая кличка у вашего {i + 1} питомца? ");
                pets[i] = Console.ReadLine();
            }
            return pets;
        }
        static bool isCorrect(int number)
        {
            return (number > 0 && number < 200);
        }  
        static void ShowAnket((string name, string surname, int age, bool ispet, int numofpets, string[] pets, int numofcolors, string[] favcolors) anketa)
        {
            Console.WriteLine("\n-=ВАША АНКЕТА=-");
            Console.WriteLine($"Вас зовут {anketa.name} {anketa.surname} ваш возраст {anketa.age} лет");
            if (anketa.ispet)
            {
                Console.Write($"У вас {anketa.numofpets} питомца. Их клички - ");
                for (int i = 0; i < anketa.numofpets; i++)
                {
                Console.Write(anketa.pets[i]);

                if (i != anketa.pets.Length - 1)
                Console.Write(", ");
                }
                Console.WriteLine();
            }
            if (anketa.numofcolors > 0)
            {
                Console.Write($"У вас {anketa.numofcolors} любимых цвета - ");
                for (int i = 0; i < anketa.numofcolors; i++)
                {
                Console.Write(anketa.favcolors[i]);
                if (i != anketa.favcolors.Length - 1)
                Console.Write(", ");
                }
            }
        }
    }
}