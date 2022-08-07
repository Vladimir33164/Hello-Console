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

int IndexOf(int[] collection, int faind)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
       if(collection[index] == faind)
       {
            position = index;
            break;
       }
       index++; 
    }
    return position;
}

int[] array = new int[10]; //Сначала определили массив из 10 чисел

FillArray(array); //Вызвавли метод "FillArray", который заполнил нам этот массив
array[4] = 4;
array[6] = 4;

PrintArray(array); //И метод "PrintArray" нам его распечатал
Console.WriteLine();

int pos = IndexOf(array, 444);
Console.WriteLine(pos);
