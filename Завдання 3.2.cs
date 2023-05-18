/* В програмі оголошено східчастий масив цілих чисел, які мають різну довжину рядків. int [][] jagged = new int[4][]; jagged[0] = new int[6]; jagged[1] = new int[2]; jagged[2] = new int[4]; jagged[3] = new int[11];

Необхідно: вивести довжину і початкові індекси всіх неперервних послідовностей чисел, які утворюють зростаючу послідовність в кожному рядку. */

using System; 


namespace JaggedArray

{

    class Program

    {

        static void Main(string[] args)

        {

            // Оголошення та ініціалізація східчастого масиву 

            int[][] jagged = new int[4][];

            jagged[0] = new int[] { 3, 4, 5, 6, 7, 8 };

            jagged[1] = new int[] { 2, 5 };

            jagged[2] = new int[] { 0, 1, 3, 7 };

            jagged[3] = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };



            // Виведення довжини та індексів зростаючих послідовностей в кожному рядку 

            Console.WriteLine("Довжина та індекси зростаючих послідовностей:");



            for (int i = 0; i < jagged.Length; i++)

            {

                int maxLength = 0;

                int startIndex = 0;

                int currentLength = 1;

                int currentStartIndex = 0;



                for (int j = 1; j < jagged[i].Length; j++)

                {

                    if (jagged[i][j] > jagged[i][j - 1])

                    {

                        currentLength++;



                        if (currentLength > maxLength)

                        {

                            maxLength = currentLength;

                            startIndex = currentStartIndex;

                        }

                    }

                    else

                    {

                        currentLength = 1;

                        currentStartIndex = j;

                    }

                }



                Console.WriteLine("Рядок {0}: довжина = {1}, початковий індекс = {2}", i, maxLength, startIndex);

            }



            // Завершення програми 

            Console.ReadLine();

        }

    }

}