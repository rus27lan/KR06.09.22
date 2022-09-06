Console.WriteLine("Введите длинну массива: ");
int array = int.Parse(Console.ReadLine());
void ArrayPrintLen (int array)
{
    Console.WriteLine("Что нужно записать в массив: ");
    string [] arr = new string[array];
    int num = 0;
    while(num < arr.Length)
    {
        string text = Console.ReadLine();
        string count_num = text;
        arr[num] = count_num;
        num++;  
    }
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length <= 3) Console.Write($"{arr[i]} ");
    }
}
ArrayPrintLen(array);