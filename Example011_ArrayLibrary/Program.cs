void FillArray(int[] collection) //название элемента "int[] collection"
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
      collection[index] = new Random().Next(1, 10);
      index++;
    }
}
void PrintArray(int[]col) //"void" позиция, если метод ничего не возвращает
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
int[] array = new int[10]; //Сначала определили массив из 10 чисел

FillArray(array); //Вызвавли метод "FillArray", который заполнил нам этот массив
PrintArray(array); //И метод "PrintArray" нам его распечатал
