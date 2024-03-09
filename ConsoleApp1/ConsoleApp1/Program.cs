// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

int a = 0;

int b = 0;

int c = 0;

int[] arr = { 1, 2, 3, 4, 5 };
Console.WriteLine(GetAverage(arr));
Console.WriteLine(maxValue(arr));

static double GetAverage(int[] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        temp += arr[i];
    }

    return temp / arr.Length;
}

static int maxValue(int[] arr)
{
    int max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }

    return max;
}