/* Функция перебора элементов (строк) имеющегося массива. 
Формирования нового массива из строк, длина которых меньше или равна 3 символов. */

static string[] GetSortStrings(string[] array)  
{                                                 
    int count = 0;
    for (int i = 0; i < array.Length; i++) 
        if (array[i].Length <= 3)   
            count++;   

    string[] newArray = new string[count];  
    int j = 0; 
    for (int i = 0; i < array.Length; i++)   
        if (array[i].Length <= 3)  
        {                            
            newArray[j] = array[i];     
            j++;                                      
        }    
    return newArray;
}

// Функция печати массива
void printArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
        {
          Console.Write(array[i]);
          if (i < array.Length - 1)
            {
                Console.Write(", ");
            }
        }
    Console.WriteLine(" ]");
}

Console.WriteLine("Введите строки (символы, числа, слова) через пробел: ");
string[] array = Console.ReadLine()!.Split();
Console.WriteLine();
printArray(array);
Console.WriteLine();
string[] newArray = GetSortStrings(array);
printArray(newArray);
