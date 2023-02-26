// Показать треугольник Паскаля
// Сделать вывод в виде равнобедренного треугольника
int st = 9;
int [,] Pascal = new int [st,st];
const int size =2;
void TreugolnikPascal()
{
    for (int i=0; i<st;i++)
    {
        Pascal[i,0] =1;
        Pascal[i,i] =1;
    }
    for (int i=2; i<st;i++)
    {
        for (int j=1; j<=i;j++)
        {
            Pascal[i,j] = Pascal[i-1,j-1]+Pascal[i-1,j];
        }  
    }
}
void PrintPascal()
{
    int col = size*st;
    for (int i=0; i<st;i++)
    {
        for (int j=0; j<=i;j++)
        {
            Console.SetCursorPosition(col,i+1);
            if (Pascal[i,j]!=0) Console.Write($"{Pascal[i,j],size}");
            col=col+size*2;
        }
        col=size*st-size*(i+1);
    }
}
TreugolnikPascal ();
PrintPascal ();