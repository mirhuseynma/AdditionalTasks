#region ededin quvveti
int num = 81;
int quvvet = 1;
int esas = 2;
int numclone = num;
while(quvvet < num)
{
    quvvet *= esas;  
}
 if (quvvet == num)
    {
        Console.WriteLine(num + " ededi " + esas + " ededinin quvvetidir");

    }
    else if(quvvet != num)
        Console.WriteLine(num + " ededi " + esas + " ededinin quvveti deyil");
#endregion