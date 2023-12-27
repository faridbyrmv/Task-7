namespace ConsoleAppTask7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task - 1

            //while (true)
            //{
            //    Console.Write("Enter the value of c (type 'exit' to stop): ");
            //    string input = Console.ReadLine();

            //    if (input.ToLower() == "exit")
            //    {
            //        Console.WriteLine("Exiting the program.");
            //        break;
            //    }

            //    if (double.TryParse(input, out double c))
            //    {
            //        Console.Write("Enter the number of elements in the array: ");
            //        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            //        {
            //            double[] a = new double[n];

            //            // Input array elements
            //            for (int i = 0; i < n; i++)
            //            {
            //                Console.Write($"Enter element a[{i}]: ");
            //                if (double.TryParse(Console.ReadLine(), out double element))
            //                {
            //                    a[i] = element;
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Invalid input. Please enter a valid number.");
            //                    i--;
            //                }
            //            }

            //            // Print elements with |a[i]| < c
            //            Console.WriteLine($"Elements with |a[i]| < {c}:");
            //            for (int i = 0; i < n; i++)
            //            {
            //                if (Math.Abs(a[i]) < c)
            //                {
            //                    Console.WriteLine($"a[{i}] = {a[i]}");
            //                }
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid input for the number of elements. Please enter a positive integer.");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input for the value of c. Please enter a valid number or type 'exit' to stop.");
            //    }
            //}


            // Task - 2 

            //Console.Write("Enter the value of c: ");
            //if (double.TryParse(Console.ReadLine(), out double c))
            //{
            //    Console.Write("Enter the number of elements in the array: ");
            //    if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            //    {
            //        double[] a = new double[n];

            //        // Input array elements
            //        for (int i = 0; i < n; i++)
            //        {
            //            Console.Write($"Enter element a[{i}]: ");
            //            if (double.TryParse(Console.ReadLine(), out double element))
            //            {
            //                a[i] = element;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Invalid input. Please enter a valid number.");
            //                i--;
            //            }
            //        }

            //        // Calculate the average of elements with |a[i]| < c
            //        double sum = 0;
            //        int count = 0;

            //        for (int i = 0; i < n; i++)
            //        {
            //            if (Math.Abs(a[i]) < c)
            //            {
            //                sum += a[i];
            //                count++;
            //            }
            //        }

            //        if (count > 0)
            //        {
            //            double average = sum / count;
            //            Console.WriteLine($"Average of elements with |a[i]| < {c}: {average}");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"No elements found with |a[i]| < {c}");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input for the number of elements. Please enter a positive integer.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input for the value of c. Please enter a valid number.");
            //}


            // Task - 3

            //Console.Write("Enter the value of c: ");
            //if (double.TryParse(Console.ReadLine(), out double c))
            //{
            //    Console.Write("Enter the number of elements in the array: ");
            //    if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            //    {
            //        double[] a = new double[n];

            //        // Input array elements
            //        for (int i = 0; i < n; i++)
            //        {
            //            Console.Write($"Enter element a[{i}]: ");
            //            if (double.TryParse(Console.ReadLine(), out double element))
            //            {
            //                a[i] = element;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Invalid input. Please enter a valid number.");
            //                i--;
            //            }
            //        }

            //        // Calculate the average of elements with |a[i]| > c
            //        double sum = 0;
            //        int count = 0;

            //        for (int i = 0; i < n; i++)
            //        {
            //            if (Math.Abs(a[i]) > c)
            //            {
            //                sum += a[i];
            //                count++;
            //            }
            //        }

            //        if (count > 0)
            //        {
            //            double average = sum / count;
            //            Console.WriteLine($"Average of elements with |a[i]| > {c}: {average}");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"No elements found with |a[i]| > {c}");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input for the number of elements. Please enter a positive integer.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input for the value of c. Please enter a valid number.");
            //}


            //Task - 4

            //Console.Write("Enter the value of c: ");
            //if (double.TryParse(Console.ReadLine(), out double c))
            //{
            //    Console.Write("Enter the number of elements in the array: ");
            //    if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            //    {
            //        double[] a = new double[n];

            //        // Input array elements
            //        for (int i = 0; i < n; i++)
            //        {
            //            Console.Write($"Enter element a[{i}]: ");
            //            if (double.TryParse(Console.ReadLine(), out double element))
            //            {
            //                a[i] = element;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Invalid input. Please enter a valid number.");
            //                i--;
            //            }
            //        }

            //        // Filter elements with |a[i]| > c
            //        double[] filteredArray = new double[n];
            //        int count = 0;

            //        for (int i = 0; i < n; i++)
            //        {
            //            if (Math.Abs(a[i]) > c)
            //            {
            //                filteredArray[count++] = a[i];
            //            }
            //        }

            //        // Sort the filtered array in descending order
            //        Array.Sort(filteredArray, 0, count, Comparer<double>.Create((a, b) => b.CompareTo(a)));

            //        // Print the sorted array
            //        Console.WriteLine($"Elements with |a[i]| > {c} sorted in descending order:");
            //        for (int i = 0; i < count; i++)
            //        {
            //            Console.WriteLine(filteredArray[i]);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input for the number of elements. Please enter a positive integer.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input for the value of c. Please enter a valid number.");
            //}


            // Task - 5 

            //Console.Write("Enter the value of c: ");
            //if (double.TryParse(Console.ReadLine(), out double c))
            //{
            //    Console.Write("Enter the number of elements in the array: ");
            //    if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            //    {
            //        double[] a = new double[n];

            //        // Input array elements
            //        for (int i = 0; i < n; i++)
            //        {
            //            Console.Write($"Enter element a[{i}]: ");
            //            if (double.TryParse(Console.ReadLine(), out double element))
            //            {
            //                a[i] = element;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Invalid input. Please enter a valid number.");
            //                i--;
            //            }
            //        }

            //        // Find the maximum element with |a[i]| < c
            //        double maxElement = double.MinValue;

            //        for (int i = 0; i < n; i++)
            //        {
            //            if (Math.Abs(a[i]) < c && a[i] > maxElement)
            //            {
            //                maxElement = a[i];
            //            }
            //        }

            //        if (maxElement != double.MinValue)
            //        {
            //            Console.WriteLine($"Maximum element with |a[i]| < {c}: {maxElement}");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"No elements found with |a[i]| < {c}");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input for the number of elements. Please enter a positive integer.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input for the value of c. Please enter a valid number.");
            //}


            // Task - 6 

            ////Console.Write("Enter the size of the arrays: ");
            ////if (int.TryParse(Console.ReadLine(), out int size) && size > 0)
            ////{
            ////    int[] X = new int[size];
            ////    int[] Y = new int[size];

            ////    // Input array elements for Y
            ////    for (int i = 0; i < size; i++)
            ////    {
            ////        Console.Write($"Enter element Y[{i}]: ");
            ////        if (int.TryParse(Console.ReadLine(), out int element))
            ////        {
            ////            Y[i] = element;
            ////        }
            ////        else
            ////        {
            ////            Console.WriteLine("Invalid input. Please enter a valid integer.");
            ////            i--;
            ////        }
            ////    }

            ////    // Find X[i] such that X[i] = Y[i] ^ 2
            ////    int foundIndex = -1;
            ////    for (int i = 0; i < size; i++)
            ////    {
            ////        if (Y[i] == Y[i] * Y[i])
            ////        {
            ////            foundIndex = i;
            ////            break;
            ////        }
            ////    }

            ////    if (foundIndex != -1)
            ////    {
            ////        Console.WriteLine($"Found X[{foundIndex}] such that X[{foundIndex}] = Y[{foundIndex}] ^ 2");
            ////    }
            ////    else
            ////    {
            ////        Console.WriteLine("No such element found in X that satisfies the condition.");
            ////    }
            ////}
            ////else
            ////{
            ////    Console.WriteLine("Invalid input for the size of the arrays. Please enter a positive integer.");
            ////}
            ///


            // Task - 7 

            //Console.Write("Enter the number of elements in the array: ");
            //if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            //{
            //    double[] a = new double[n];

            //    // Input array elements
            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.Write($"Enter element a[{i}]: ");
            //        if (double.TryParse(Console.ReadLine(), out double element))
            //        {
            //            a[i] = element;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid input. Please enter a valid number.");
            //            i--;
            //        }
            //    }

            //    // Find the minimum and maximum elements
            //    double minElement = double.MaxValue;
            //    double maxElement = double.MinValue;

            //    for (int i = 0; i < n; i++)
            //    {
            //        if (a[i] < minElement)
            //        {
            //            minElement = a[i];
            //        }

            //        if (a[i] > maxElement)
            //        {
            //            maxElement = a[i];
            //        }
            //    }

            //    // Calculate the average of array elements
            //    double sum = 0;
            //    for (int i = 0; i < n; i++)
            //    {
            //        sum += a[i];
            //    }

            //    double average = sum / n;

            //    // Display the results
            //    Console.WriteLine($"Minimum Element: {minElement}");
            //    Console.WriteLine($"Maximum Element: {maxElement}");
            //    Console.WriteLine($"Difference between min and max: {maxElement - minElement}");
            //    Console.WriteLine($"Average of Elements: {average}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input for the number of elements. Please enter a positive integer.");
            //}


            // Task - 8 

            //    int size = 14;

            //    // İki adet 14 elemanlı dizi oluştur
            //    int[] array1 = new int[size];
            //    int[] array2 = new int[size];

            //    // İki diziyi doldur
            //    Console.WriteLine("Enter elements for the first array:");
            //    FillArray(array1);

            //    Console.WriteLine("Enter elements for the second array:");
            //    FillArray(array2);

            //    // İki diziyi çarp ve pozitif sonuçları topla
            //    int[] resultArray = MultiplyAndFilterPositive(array1, array2);

            //    // Elde edilen yeni diziyi ekrana yazdır
            //    Console.WriteLine("Result Array:");
            //    PrintArray(resultArray);
            //}

            //static void FillArray(int[] array)
            //{
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        Console.Write($"Enter element array[{i}]: ");
            //        if (int.TryParse(Console.ReadLine(), out int element))
            //        {
            //            array[i] = element;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid input. Please enter a valid integer.");
            //            i--;
            //        }
            //    }
            //}

            //static int[] MultiplyAndFilterPositive(int[] array1, int[] array2)
            //{
            //    int[] resultArray = new int[array1.Length];

            //    for (int i = 0; i < array1.Length; i++)
            //    {
            //        resultArray[i] = array1[i] * array2[i];

            //        // Sadece pozitif sonuçları kabul et
            //        if (resultArray[i] < 0)
            //        {
            //            resultArray[i] = 0;
            //        }
            //    }

            //    return resultArray;
            //}

            //static void PrintArray(int[] array)
            //{
            //    foreach (var element in array)
            //    {
            //        Console.Write($"{element} ");
            //    }
            //    Console.WriteLine();


            // Task - 9

            //    int size = 25;

            //    // 25 elemanlı bir dizi oluştur
            //    int[] originalArray = new int[size];

            //    // Diziyi doldur
            //    Console.WriteLine("Enter 25 elements for the array:");
            //    FillArray(originalArray);

            //    // İlk 8 elemanı karesine yükselt
            //    int[] squaredArray = SquareFirstEight(originalArray);

            //    // Geri kalan 17 elemanı 4'e böle
            //    int[] dividedByFourArray = DivideByFourRemainingSeventeen(originalArray);

            //    // Elde edilen iki yeni diziyi ekrana yazdır
            //    Console.WriteLine("Squared Array (First 8 elements squared):");
            //    PrintArray(squaredArray);

            //    Console.WriteLine("Divided by Four Array (Remaining 17 elements divided by 4):");
            //    PrintArray(dividedByFourArray);
            //}

            //static void FillArray(int[] array)
            //{
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        Console.Write($"Enter element array[{i}]: ");
            //        if (int.TryParse(Console.ReadLine(), out int element))
            //        {
            //            array[i] = element;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid input. Please enter a valid integer.");
            //            i--;
            //        }
            //    }
            //}

            //static int[] SquareFirstEight(int[] array)
            //{
            //    int[] resultArray = new int[array.Length];

            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        if (i < 8)
            //        {
            //            resultArray[i] = array[i] * array[i];
            //        }
            //        else
            //        {
            //            resultArray[i] = array[i];
            //        }
            //    }

            //    return resultArray;
            //}

            //static int[] DivideByFourRemainingSeventeen(int[] array)
            //{
            //    int[] resultArray = new int[array.Length];

            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        if (i >= 8)
            //        {
            //            resultArray[i] = array[i] / 4;
            //        }
            //        else
            //        {
            //            resultArray[i] = array[i];
            //        }
            //    }

            //    return resultArray;
            //}

            //static void PrintArray(int[] array)
            //{
            //    foreach (var element in array)
            //    {
            //        Console.Write($"{element} ");
            //    }
            //    Console.WriteLine();

            // Task - 10 


            //    Console.Write("Enter the number of elements in the array: ");
            //    if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            //    {
            //        int[] X = new int[n];

            //        // Diziyi doldur
            //        Console.WriteLine("Enter elements for the array:");
            //        for (int i = 0; i < n; i++)
            //        {
            //            Console.Write($"Enter element X[{i}]: ");
            //            if (int.TryParse(Console.ReadLine(), out int element))
            //            {
            //                X[i] = element;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Invalid input. Please enter a valid integer.");
            //                i--;
            //            }
            //        }

            //        // Negatif elemanların maksimumunu bul
            //        int maxNegativeElement = FindMaxNegativeElement(X);

            //        if (maxNegativeElement != int.MinValue)
            //        {
            //            Console.WriteLine($"Maximum negative element in the array: {maxNegativeElement}");
            //        }
            //        else
            //        {
            //            Console.WriteLine("No negative elements found in the array.");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input for the number of elements. Please enter a positive integer.");
            //    }
            //}

            //static int FindMaxNegativeElement(int[] array)
            //{
            //    int maxNegativeElement = int.MinValue;

            //    foreach (var element in array)
            //    {
            //        if (element < 0 && element > maxNegativeElement)
            //        {
            //            maxNegativeElement = element;
            //        }
            //    }

            //    return maxNegativeElement;


            // Task - 11 

            //    Console.Write("Enter the number of elements in the array: ");
            //    if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            //    {
            //        int[] X = new int[n];

            //        // Diziyi random sayılarla doldur
            //        Random random = new Random();
            //        for (int i = 0; i < n; i++)
            //        {
            //            X[i] = random.Next(0, 101);
            //        }

            //        // Diziyi azalan sıraya göre sırala
            //        Array.Sort(X);
            //        Array.Reverse(X);

            //        // Diziyi ekrana yazdır
            //        Console.WriteLine("Array elements in descending order:");
            //        PrintArray(X);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input for the number of elements. Please enter a positive integer.");
            //    }
            //}

            //static void PrintArray(int[] array)
            //{
            //    foreach (var element in array)
            //    {
            //        Console.Write($"{element} ");
            //    }
            //    Console.WriteLine();


            // Task - 12 

            int size = 20;

            // 20 elemanlı bir dizi oluştur
            int[] X = new int[size];

            // Diziyi doldur
            Console.WriteLine("Enter 20 elements for the array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter element X[{i}]: ");
                if (int.TryParse(Console.ReadLine(), out int element))
                {
                    X[i] = element;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    i--;
                }
            }

            // İlk yarının elemanlarının ortalamasını bul
            double firstHalfAverage = CalculateAverage(X, 0, size / 2);

            // İkinci yarının elemanlarının toplamını bul
            int secondHalfSum = CalculateSum(X, size / 2, size);

            // Sonuçları ekrana yazdır
            Console.WriteLine($"Average of the first half: {firstHalfAverage}");
            Console.WriteLine($"Sum of the second half: {secondHalfSum}");
        }

        static double CalculateAverage(int[] array, int start, int end)
        {
            double sum = 0;
            for (int i = start; i < end; i++)
            {
                sum += array[i];
            }

            return sum / (end - start);
        }

        static int CalculateSum(int[] array, int start, int end)
        {
            int sum = 0;
            for (int i = start; i < end; i++)
            {
                sum += array[i];
            }

            return sum;
        }
    }
}