string[] array = new string[] {"hello", "846", "55", "hi"};
string[] array2 = new string[array.Length];
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        array2[i] = array[i];
    }        
}
for (int i = 0; i < array2.Length; i++)
{
    Console.Write(array2[i]+ " ");
}