
// int[] array = { 5, 19, 50, 20, 16, 80, 50, 26, 56 };
// array[0] = 12;
//Console.WriteLine(array[0]); показать первый элемент
// int n = array.Length;
// int find = 50;
// int index = 0;
// while (index < n)
// {
//     if (array[index] == find)
//     {
//         Console.WriteLine(index);
//         break;
//     }
//     index++;
// }


/*
// void если нет return
void FillArray(int[] collection) //заполнить рандомно массив
{
    int len = collection.Length;
    int index = 0;
    while (index < len)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}


void PrintArray(int[] col) // напечатать заполненный массив
{
    int count = col.Length;
    int posis = 0;
    while (posis < count)
    {
        Console.Write(col[posis]);
        posis++;
    }
}


int IndexOf(int[] collec, int find)
{
    int count = collec.Length;
    int index = 0;
    int position = -1; // если число не встретится, то выводим -1

    while (index < count)
    {
        if (collec[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
int pos = IndexOf(array, 4); // ищим на каком индексе 4
Console.WriteLine();
Console.WriteLine(pos);

*/
