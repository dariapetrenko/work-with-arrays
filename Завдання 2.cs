/* Вивести довжину і початкові індекси всіх неперервних послідовностей чисел, які утворюють зростаючу послідовність. */ 

using System; 

namespace IncreasingSequence

{

    class Program

    {

        static void Main(string[] args)

        {

            // Розмір масиву та діапазон значень 

            const int size = 200;

            const int min = -50;

            const int max = 50;



            // Створення та заповнення масиву випадковими значеннями 

            int[] arr = new int[size];

            Random rand = new Random();

            for (int i = 0; i < size; i++)

            {

                arr[i] = rand.Next(min, max + 1);

            }



            // Виведення початкового масиву на екран 

            Console.WriteLine("Початковий масив: ");

            Console.WriteLine(string.Join(" ", arr));



            // Пошук найдовшої зростаючої послідовності та її початкового індексу 

            int maxLength = 1;

            int maxStartIndex = 0;

            int length = 1;

            int startIndex = 0;



            for (int i = 1; i < size; i++)

            {

                if (arr[i] > arr[i - 1])

                {

                    length++;

                }

                else

                {

                    if (length > maxLength)

                    {

                        maxLength = length;

                        maxStartIndex = startIndex;

                    }

                    length = 1;

                    startIndex = i;

                }

            }



            // Перевірка, чи остання зростаюча послідовність найдовша 

            if (length > maxLength)

            {

                maxLength = length;

                maxStartIndex = startIndex;

            }



            // Виведення результатів на екран 

            Console.WriteLine($"Довжина найдовшої зростаючої послідовності: {maxLength}");

            Console.WriteLine("Початковий індекс та значення зростаючої послідовності(по індексу):");

            for (int i = maxStartIndex; i < maxStartIndex + maxLength; i++)

            {

                Console.WriteLine($"Index: {i}, Value: {arr[i]}");

            }



            Console.ReadKey();

        }
    }
}