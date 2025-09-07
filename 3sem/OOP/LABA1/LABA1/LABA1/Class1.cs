using System;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;

namespace LABA1
{
    //internal - класс доступен только внутри текущей сборки
    internal class Class1
    {

        //Модификатор static означает, что метод принадлежит самому классу, а не его экземпляру.
        static void Main()
        {
            /*Console.WriteLine("Введите ваше имя");
            string str = Console.ReadLine();
            Console.WriteLine("Привет " + str + "!!!");
            Console.WriteLine("Введите  один символ с клавитуры");
            int kod = Console.Read();
            char sim = (char)kod;
            Console.WriteLine("Код символа  " + sim + " = " + kod);
            Console.WriteLine("Код символа  {0} = {1}", sim, kod);
            int s1 = 255;
            int s2 = 32;
            Console.WriteLine(" \n{0,5}\n+{1,4}\n-----\n{2,5}", s1, s2, s1 + s2);
            Console.WriteLine(" \n{1,5}\n+{0,4}\n-----\n{2,5}", s1, s2, s1 + s2);*/

            //ЗАДАНИЕ 1

            //a

            bool boolVar = true;
            char charVar = 'Р';
            decimal decimalVar = 123.45m; // десятичные дробные числа с высокой точностью
            double doubleVar = 3.14159d;
            float floatVar = 2.718f;
            byte byteVar = 255;
            sbyte sbyteVar = -128;
            short shortVar = -32768;
            ushort ushortVar = 65535;
            int intVar = 52;
            uint uintVar = 100;
            long longVar = 1234567890L;
            ulong ulongVar = 9876543210UL;

            //$"bool: {boolVar}" - интерполированная строка, внутри будет переменная
            Console.WriteLine("Инициализированные значения:");
            Console.WriteLine($"bool: {boolVar}");
            Console.WriteLine($"char: {charVar}");
            Console.WriteLine($"decimal: {decimalVar}");
            Console.WriteLine($"double: {doubleVar}");
            Console.WriteLine($"float: {floatVar}");
            Console.WriteLine($"byte: {byteVar}");
            Console.WriteLine($"sbyte: {sbyteVar}");
            Console.WriteLine($"short: {shortVar}");
            Console.WriteLine($"ushort: {ushortVar}");
            Console.WriteLine($"int: {intVar}");
            Console.WriteLine($"uint: {uintVar}");
            Console.WriteLine($"long: {longVar}");
            Console.WriteLine($"ulong: {ulongVar}");

            Console.Write("Введите новый int: ");
            intVar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"int: {intVar}");

            Console.Write("Введите double: ");
            doubleVar = double.Parse(Console.ReadLine().Replace('.', ','));
            Console.WriteLine($"double: {doubleVar}");

            Console.Write("Введите char: ");
            charVar = Convert.ToChar(Console.Read());
            Console.WriteLine($"char: {charVar}");
            Console.ReadLine();

            Console.Write("Введите bool: ");
            try
            {
                boolVar = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine($"bool: {boolVar}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка! Введите 'True' или 'False' (с большой буквы)");
            }

            //b

            //Неявные
            short a_short = 432; byte a_byte = 5;
            int a_int = a_short;
            long a_long = a_short;
            short a2_short = a_byte;
            uint a_uint = a_byte;
            a_long = a_uint;

            //Явные
            a_int = (int)a_short;
            a_long = (long)a_short;
            a2_short = (short)a_byte;
            a_uint = (uint)a_byte;
            a_long = (long)a_uint;


            /* Возможности класса Convert
            - Преобразование между базовыми типами
            - Поддержка разных систем счисления
            - Работа с DateTime
            - Обработка null
            - Обработка DBNull*/

            //с

            //Упаковка(Boxing) НЕЯВНО Что это: преобразование значимого типа в ссылочный.
            int num = 7;
            object box = num;

            // РАСПАКОВКА Что это: извлечение значения из объекта обратно в значимый тип. Требуется явное приведение типа.
            int unbox = (int)box;

            double value = 3.14;
            object boxedValue = value;
            double unboxedValue = (double)boxedValue;

            //d. Типизированная переменная

            var number = 10;
            var message = "Привет";
            var pi = 3.1415;
            var isActive = true;

            //e

            /*Тип Nullable<T> — это обёртка над значимым типом, позволяющая ему быть null.Сокращённая запись — int?, double?, bool?*/

            int? score = 100;
            Console.WriteLine(score ?? 0); // если score == null, то будет 0
            score = null;
            Console.WriteLine(score ?? 0);

            //f

            var j = 4654;
            //j = "tartaria";

            // 2 ЗАДАНИЕ

            //a
            string str1 = "Привет свет!";
            string? str2 = null;
            var str3 = "Можно и так!";
            var str1_1 = "Привет свет!";
            var str3_1 = "можно и так!";

            //Дословные строковые литералы @
            string str4 = @"C:\\Program Files\\App";
            string str5 = @"Строка 1
Строка 2
Строка 3";
            Console.WriteLine(str5);

            //Необработанные строковые литералы
            string str6 = """
                Точно
                Также
                Как и @
                """;
            Console.WriteLine(str6);

            //Интерполированная строковый литерал
            string name = "Poma";
            string greeting = $"Привет, {name}!";

            Console.WriteLine(str1_1 == str1);
            Console.WriteLine(str1 == str4);
            Console.WriteLine(str6.Contains("Точно"));
            Console.WriteLine(str3.Equals(str3_1));
            Console.WriteLine(str3.Equals(str3_1, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(str6.CompareTo(str4));

            //b
            Console.WriteLine(str1 + str3 + "Опа");
            string copy = String.Copy(str4);
            Console.WriteLine(copy);
            string copy2 = str4;
            Console.WriteLine(copy2);
            string substr = greeting.Substring(3, 6); //С 3 индекса 6 символов
            Console.WriteLine(substr);
            string example = "Яблоко Груша Клубника Помидор";
            string[] split = example.Split(' ');
            foreach (string s in split)
                Console.WriteLine(s + ". \n");
            string insert_str = example.Insert(7, str3); //на 7 индекс = str3
            Console.WriteLine(insert_str);
            string remove_str = example.Remove(2, 3);
            Console.WriteLine(remove_str);
            Console.WriteLine(greeting);

            //c
            string nullString = null;
            string emptyString = "";
            string whitespaceString = "   ";
            string regularString = "Hello, World!";

            Console.WriteLine("--- Демонстрация string.IsNullOrEmpty ---");

            // проверка null-строки
            bool isNullOrEmpty1 = string.IsNullOrEmpty(nullString);
            Console.WriteLine($"Является ли nullString (null) пустой или null? -> {isNullOrEmpty1}");

            // проверка пустой строки
            bool isNullOrEmpty2 = string.IsNullOrEmpty(emptyString);
            Console.WriteLine($"Является ли emptyString (\"\") пустой или null? -> {isNullOrEmpty2}");

            // проверка строки с пробелами
            bool isNullOrEmpty3 = string.IsNullOrEmpty(whitespaceString);
            Console.WriteLine($"Является ли whitespaceString (\"   \") пустой или null? -> {isNullOrEmpty3}");

            // проверка обычной строки
            bool isNullOrEmpty4 = string.IsNullOrEmpty(regularString);
            Console.WriteLine($"Является ли regularString (\"Hello, World!\") пустой или null? -> {isNullOrEmpty4}");

            // еще есть метод string.IsNullOrWhiteSpace(), который также считает пробелы "пустотой"
            Console.WriteLine("\n--- Демонстрация string.IsNullOrWhiteSpace ---");
            bool isNullOrWhitespace = string.IsNullOrWhiteSpace(whitespaceString);
            Console.WriteLine($"Является ли whitespaceString (\"   \") пустой, null или с пробелами? -> {isNullOrWhitespace}");

            //d
            StringBuilder sb = new StringBuilder("Пример строки");
            Console.WriteLine($"Исходная строка: {sb}");

            sb.Remove(7, 6);
            Console.WriteLine($"После удаления: {sb}");

            sb.Insert(0, ">> ");
            Console.WriteLine($"После вставки в начало: {sb}");

            sb.Append(" <<");
            Console.WriteLine($"После вставки в конец: {sb}");

            //ЗАДАНИЕ 3

            //a

            int[,] matrix ={
            { 1,   2,  3,  4 },
            { 5,   6,  7,  8 },
            { 9,  10, 11, 12 } };

            Console.WriteLine("Вывод матрицы на консоль:");

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int g = 0; g < cols; g++)
                {
                    Console.Write($"{matrix[i, g],4} ");
                }
                Console.WriteLine();
            }

            //b
            string[] words = { "яблоко", "банан", "киви", "груша", "апельсин" };

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine($"Длина массива: {words.Length}");

            Console.WriteLine("Введите индекс, который хотите поменять (до 4):");
            int index = Convert.ToInt32(Console.ReadLine());

            if (index >= 0 && index < words.Length)
            {
                Console.Write("Введите новое значение: ");
                string newValue = Console.ReadLine();

                words[index] = newValue;
                Console.WriteLine("\nОбновлённый массив:");
                foreach (string word in words)
                {
                    Console.WriteLine(word);
                }
            }
            else
            {
                Console.WriteLine("Ошибка: индекс вне диапазона.");
            }

            //c
            double[][] values = new double[3][];
            values[0] = new double[2];
            values[1] = new double[3];
            values[2] = new double[4];


            Console.WriteLine("Введите вещественное числа для массива");
            for (int i = 0; i < values.Length; i++)
            {
                for (int g = 0; g < values[i].Length; g++)
                {
                    values[i][g] = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
                }
                Console.WriteLine("Следующая строка");
            }

            for (int i = 0; i < values.Length; i++)
            {
                for (int g = 0; g < values[i].Length; g++)
                {
                    Console.Write($"{values[i][g],8:F2} ");
                }
                Console.WriteLine();
            }

            //d
            var mes = "Привет";
            var mas_str = new[] { "Красный", "Синий", "Зелёный" };
            Console.WriteLine($"{message}");
            foreach (string word in mas_str)
            {
                Console.WriteLine(word);
            }

            //ЗАДАНИЕ 4

            //a

            var person = (id: 0, name: "Паша", gender: 'M', role: "Посетитель", balance: 93295394UL);

            //b
            Console.WriteLine("\n" + person);

            Console.Write("\n" + person.id + ", ");
            Console.Write(person.name + ", ");
            Console.Write(person.gender + ", ");
            Console.Write(person.Item4 + ", ");
            Console.Write(person.balance);

            //c
            (int id_1, string text1, char symbol, string text2, ulong bigNumber) = person;
            Console.WriteLine("\n" + id_1 + ", " + text1 + ", " + symbol + ", " + text2 + ", " + bigNumber);
            var (id_2, text3, symbol_1, text4, bigNumber_1) = person;
            Console.WriteLine(id_2 + ", " + text3 + ", " + symbol_1 + ", " + text4 + ", " + bigNumber_1);
            var (_, _, symb, _, _) = person;
            Console.WriteLine(symb);

            int num1 = 2, num2 = 7;
            (num1, num2) = (num2, num1);
            Console.WriteLine($"num1 = {num1}, num2 = {num2}");

            //d
            var tuple1 = (42, "Пример", 'A');
            var tuple2 = (42, "Пример", 'A');
            var tuple3 = (99, "Тест", 'B');

            Console.WriteLine($"tuple1 == tuple2: {tuple1 == tuple2}"); // true

            Console.WriteLine($"tuple1 == tuple3: {tuple1 == tuple3}"); // false

            // ЗАДАНИЕ 5
            int[] arr = { 4, 34, 64, 3, 7 };
            string str_5 = "Пример";

            var res = Loc_func(arr, str_5);
            Console.WriteLine(res);

            (int max, int min, int sum, char sym) Loc_func(int[] arr, string str)
            {
                int max_mas = arr[0];
                int min_mas = arr[0];
                int sum_mas = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    sum_mas += arr[i];
                    if (arr[i] > max_mas)
                    {
                        max_mas = arr[i];
                    }
                    if (arr[i] < min_mas)
                    {
                        min_mas = arr[i];
                    }
                }

                char sym_char = str.Length > 0 ? str[0] : '_';
                return (max_mas, min_mas, sum_mas, sym_char);
            }

            //ЗАДАНИЕ 6
            Checked_func();
            UnChecked_func();

            void Checked_func()
            {
                try
                {
                    checked //Проверка переполнения
                    {
                        int num = int.MaxValue;
                        num += 1;
                        Console.WriteLine(num);
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Переполнение обнаружено! " + e.ToString());
                }
            }
            void UnChecked_func()
            {
                try
                {
                    unchecked
                    {
                        int num = int.MaxValue;
                        num += 1;
                        Console.WriteLine("\n"+ num);
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Переполнение обнаружено! " + e.ToString());
                }
            }
        }
    }
}
