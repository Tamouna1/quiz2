// See https://aka.ms/new-console-template for more information
//1

Console.WriteLine("Enter Number: ");
int number = Convert.ToInt32(Console.ReadLine());
int multiply = 0;
int sum = 0;
for (int i = 1; i<number; i++)
{
    Console.WriteLine(i);
    int[] myArray = new int[i];
    
    foreach (int x in myArray)
    {
        if(x % 2 == 1)
        {
            
            sum += x;
            Console.WriteLine(sum);
        }
        else
        {
            
            multiply *= x;
            Console.WriteLine(multiply);
        }
    }

}
//2
 static bool polindrome(string myString)
{
    string first = myString.Substring(0, myString.Length / 2);
    char[] arr = myString.ToCharArray();

    Array.Reverse(arr);

    string temp = new string(arr);
    string second = temp.Substring(0, temp.Length / 2);

    return first.Equals(second);
}
//3
int[] arr = new int[10];
int i;


Console.WriteLine("Input 10 elements :");
for (i = 0; i < 10; i++)
{
    Console.WriteLine("element - {0} : ", i);
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Elements in array:  ");
for (i = 0; i < 10; i++)
{
    Console.Write("{0}  ", arr[i]);
}

//4


public class FrequentNumbers
{
    private Int32[] numbers = { 5, 4, 3, 32, 6, 6, 3, 3, 2, 2, 31, 1, 32, 4, 3, 4, 5, 6 };

    public FrequentNumbers()
    {
        Dictionary<Int32, Int32> bucket = new Dictionary<Int32, Int32>();
        Int32 maxInt = Int32.MinValue;
        Int32 maxCount = 0;
        Int32 count;

        foreach (var i in numbers)
        {
            if (bucket.TryGetValue(i, out count))
            {
                count++;
                bucket[i] = count;
            }
            else
            {
                count = 1;
                bucket.Add(i, count);
            }

            if (count >= maxCount)
            {
                maxInt = i;
                maxCount = count;
            }

        }

        Console.WriteLine("{0},{1}", maxCount, maxInt);

    }
}

