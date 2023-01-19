using static System.Console;
Clear();
//Напишите программу, реализующую метод, который формирует массив случайных целых чисел из 8 элементов и выводит их на экран.
int[] array =  initRandomArray();
PrintArray(array);



int[] initRandomArray()
{
    int[] res = new int[8];
for (int i = 0; i < res.Length; i++)
{
   Random ran = new Random();
   res[i] = ran.Next();
}
return res;
}



void PrintArray(int[] arr)
{
    int count = arr.Length;
    for (int i = 0; i <count; i++)
    {
        WriteLine($"{arr[i]} ");
    }
    WriteLine();
}