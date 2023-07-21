namespace sem4_hw;
class Program
{
    static void Main(string[] args)
    {
        void PrintResult(string Msg)
        {
            Console.Clear();
            Console.WriteLine(Msg);
        }
        //Задача 25: Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
        void Task25(int NumA, int NumB)
        {
            PrintResult($"{NumA} ^ {NumB} = {Math.Pow(NumA, NumB)}");
        }
        //Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
        void Task27(int Num)
        {
            int Sum = 0;
            for (int Temp = Num; Temp > 0; Temp /= 10)
                Sum = Sum + Temp % 10;
            PrintResult($"{Sum}");
        }
        //Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
        void Task29()
        {
            int[] Arr = new int[8];
            Random Rnd = new Random();
            for (int i = 0; i < Arr.Length; i++)
                Arr[i] = Rnd.Next(-50, 50);
            string ArrSring = string.Join(" ", Arr);
            bool Sort = true;
            while (Sort)
            {
                Sort = false;
                for (int i = 1; i < Arr.Length; i++)
                {
                    if (Math.Abs(Arr[i - 1]) > Math.Abs(Arr[i]))
                    {
                        int tmp = Arr[i - 1];
                        Arr[i - 1] = Arr[i];
                        Arr[i] = tmp;
                        Sort = true;
                    }
                }
            }

            PrintResult($"Сгенерирован массив {ArrSring}\r\nОтсортированный по модулю {string.Join(" ", Arr)}");
        }



        /* void SelMenu(int Index)
        {
            Console.SetCursorPosition(1, Index);
            Console.Write("+");
            Console.SetCursorPosition(1, Index);
        }
        // void UnSelMenu(int Index)
        {
            Console.SetCursorPosition(1, Index);
            Console.Write(" ");
            Console.SetCursorPosition(1, Index);
        }
        //int[] Input(string Mssg)
        {
            Console.Write(Mssg + ">");
            string InputText = Console.ReadLine(); // ввод пользовательских данных
            string[] InputWords = InputText.Split(" "); // парсинг введенного текста. раскладываем строку на слова
            int[] arr = new int[InputWords.Length];
            for (int i = 0; i < InputWords.Length; i++)
                int.TryParse(InputWords[i], out arr[i]);
            return arr;
        }*/
        void PrintMenu(int MenuSelIndex)
        {
            for (int i = 0; i < 20; i++)
            {
                Console.SetCursorPosition(1, i);
                Console.Write(" ");
            }
            Console.SetCursorPosition(1, MenuSelIndex);
            Console.Write("+");
            Console.SetCursorPosition(1, MenuSelIndex);
        }

        void ExecuteItem(int Index, string[] Arguments)
        {

            switch (Index)
            {
                case 0:
                    Task25(Convert.ToInt32(Arguments[0]),
                        Convert.ToInt32(Arguments[1])); break;
                case 1: Task27(Convert.ToInt32(Arguments[0])); break;
                case 2: Task29(); break;

            }
        }
        Console.Clear();
        Console.WriteLine("[ ] Задача 25: Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.");
        Console.WriteLine("[ ] Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
        Console.WriteLine("[ ] Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.");
        Console.WriteLine("[ ] Тестовый текст и всякое всякое");
        Console.WriteLine("[ ] Тестовый текст и всякое всякое");
        Console.WriteLine("[ ] Тестовый текст и всякое всякое");
        Console.WriteLine("[ ] Тестовый текст и всякое всякое");

        int MenuSelIndex = 0;

        ConsoleKeyInfo KeyInfo;

        PrintMenu(MenuSelIndex);
        while (true)
        {
            if (Console.KeyAvailable) // Обработка нажатия клавиш
            {
                KeyInfo = Console.ReadKey(true);
                PrintMenu(MenuSelIndex);
                if (KeyInfo.Key == ConsoleKey.DownArrow)
                {
                    MenuSelIndex++;
                }

                if (KeyInfo.Key == ConsoleKey.UpArrow)
                {
                    MenuSelIndex--;
                }
                if (KeyInfo.Key == ConsoleKey.Enter)
                {
                    string InputText = Console.ReadLine(); // ввод пользовательских данных
                    string[] InputWords = InputText.Split(" "); // парсинг введенного текста. раскладываем строку на слова
                    ExecuteItem(MenuSelIndex, InputWords);// вызывается выполнение задачи

                }
                if (MenuSelIndex < 0)
                    MenuSelIndex = 0;
                PrintMenu(MenuSelIndex);
            }

        }
        int num = 123;
        BitArray ba = new BitArray(num);

    }
}
