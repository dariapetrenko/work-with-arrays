/* В одновимірному масиві, що складається з дійсних елементів, обчислити кількість від’ємних елементів масиву; 
суму модулів елементів масиву, розташованих після мінімального за модулем елемента. */

using System; 

class Program

{

    static void Main()

    {

        Console.Write("Введіть розмір масиву: ");

        int n = int.Parse(Console.ReadLine());



        // Створення масиву та введення його елементів 

        double[] arr = new double[n];

        Console.WriteLine("Введіть елементи масиву:");

        for (int i = 0; i < n; i++)

        {

            Console.Write($"arr[{i}] = ");

            arr[i] = double.Parse(Console.ReadLine());

        }

        // Обчислення кількості від’ємних елементів масиву 

        int negCount = 0;

        for (int i = 0; i < n; i++)

        {

            if (arr[i] < 0)

            {

                negCount++;

            }

        }

        Console.WriteLine($"Кількість від'ємних елементів масиву: {negCount}");

        // Знаходження мінімального за модулем елемента масиву 

        double minAbs = Math.Abs(arr[0]);

        int minIndex = 0;

        for (int i = 1; i < n; i++)

        {

            double abs = Math.Abs(arr[i]);

            if (abs < minAbs)

            {

                minAbs = abs;

                minIndex = i;

            }

        }

        // Обчислення суми модулів елементів масиву, розташованих після мінімального за модулем елемента 

        double sumAfterMinAbs = 0;

        for (int i = minIndex + 1; i < n; i++)

        {

            sumAfterMinAbs += Math.Abs(arr[i]);

        }

        Console.WriteLine($"Сума модулів елементів масиву, розташованих після мінімального за модулем елемента: {sumAfterMinAbs}");
        Console.ReadLine();

    }

}