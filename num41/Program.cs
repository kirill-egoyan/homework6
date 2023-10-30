int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());

    }
    return array;
}
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}
 void CountPositiveNum(int[] array)
{
   int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
       if(array[i] > 0)
       {
        count++;
       } 
    } 
    System.Console.WriteLine(count);
}
System.Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input array numbers: ");
int[] array = CreateRandomArray(size);
System.Console.Write("Введенный массив: ");
PrintArray(array);
System.Console.Write("Количество элементов больше нуля: ");
CountPositiveNum(array);
