// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

int a = 0;

int b = 0;

int c = 0;

int[] arr = { 1, 2, 3, 4, 5 };
Console.WriteLine(GetAverage(arr));

static double GetAverage(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }

    return sum / arr.Length;
}