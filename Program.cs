/* Задача 33: Задайте массив. Напишите программу, которая 
определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет -3; массив [6, 7, 19, 345, 3] -> да */

int[] array = new int[3]{1,2,3};
bool result = Contains(array, 3);
Console.WriteLine(result);
bool Contains(int[] array, int number) 
{
    for (i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            return true;
        }
        
    }
    return false;
}
