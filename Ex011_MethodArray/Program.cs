int[] array = { 12, 241, 32, 41, 32, 644, 72, 81, 57 };

int n = array.Length;
int find = 32;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}