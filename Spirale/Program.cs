// Заполняем массив N x N по списрали числами от 1 до N в квадрате.
class Program
{
static void Main (string[] args)
{
Console.WriteLine("Ввдите число");
int n = Convert.ToInt32(Console.ReadLine());
int[,] myArray = new int [n,n];

int x = 0;
int y = 0;
int q = 1;
int povorot = 1;


while (q < n*n)
{
    while ( x < n)
    {
        myArray[y,x] = q;
        Console.Write(myArray[y,x] + "\t");
        q = q + 1;
        x = x + 1;      
    }
       Console.WriteLine();
    
    y = y + 1;
    while (y < n)
    {
        
        myArray[y,x] = q;
        Console.Write(myArray[y,x] + "\t");
        q++;
        y++;
    }    
    
    Console.WriteLine();
    x = n -2;
    while (x < 0)
    {
        myArray[y,x] = q;
        q++;
        x = x -1;
    }

    y = n-2;    
    while (y - povorot < 0)
    {
        myArray[y,x] = q;
        q++;
        y = y - 1;
    }

    n = n - 1;
    povorot++;
}

for ( y = 0; y < n-1; y++)
{
    for ( x=0; x < n-1; x++)
    {
    Console.Write(myArray[y,x] + "\t");
    }
    Console.WriteLine();
}
}
}
