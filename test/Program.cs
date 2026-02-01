#region ("Salam Dünya" və Ad çapı Tapşırıq: Ekrana "Salam" və istifadəçinin daxil etdiyi adı yazdırın.)
string helloWorld = "Salam Dunya! ";
string userName = "Mirhuseyn";
Console.WriteLine(helloWorld + userName);
#endregion

#region (İki ədədin cəmi Tapşırıq: İstifadəçidən iki ədəd alıb cəmini tapın.)
int ab = 100;
int ba = 200;
Console.WriteLine("iki ededinin cemi " + ab + ba);
#endregion

#region (Ədədin kvadratı Tapşırıq: Daxil edilən ədədin kvadratını hesablayın.)
int q = 2;
int squareNum = q * q;
Console.WriteLine(q + " ededinin kvadrati " + squareNum);
#endregion

#region (Düzbucaqlının sahəsi və perimetri. Tapşırıq: Eni və uzunluğu verilən düzbucaqlının sahəsini və perimetrini tapın.)
int sideOne = 6;
int sideSecond = 10;
int area = sideOne * sideSecond;
int perimetr = 2 * (sideOne + sideSecond);
Console.WriteLine("duzbucaqlinin sahesi " + area + ", perimetri ise " + perimetr);
#endregion

#region (Qalıqlı bölmə Tapşırıq: İki ədədin bölünməsindən alınan qalığı tapın.)
int numOne = 5;
int numSecond = 3;
int resudue = numOne % numSecond;
Console.WriteLine("Neticeden qalan qaliq " + resudue);
#endregion

#region (Selsi dəyərini Fahrenheit-ə çevirin)
float celci = 12f;
float faranheyt = celci * 1.8f + 32;
Console.WriteLine(faranheyt);
#endregion

#region (Ədədin son rəqəmi Tapşırıq: Daxil edilən ədədin son rəqəmini ekrana çıxarın.)
int oneNum = 230;
int endNum = oneNum % 10;
Console.WriteLine("Verilmis ededin son reqemi: " + endNum);
#endregion

#region (Artırma əməliyyatı Tapşırıq: Bir ədədi daxil edin və onu 1 vahid artırıb ekrana yazın (Post-increment).)
int value1 = 14;
int incrementValue = ++value1;
Console.WriteLine("ededin bir ustu: " + incrementValue);
#endregion

#region (Tək yoxsa Cüt? Tapşırıq: Ədədin tək və ya cüt olmasını yoxlayın.)
int number = 5;
if (number % 2 == 0)
{
    Console.WriteLine(number + " ededi cutdur");
}
else
    Console.WriteLine(number + " ededi tekdir");
#endregion

#region (Mənfi, Müsbət, Sıfır Tapşırıq: Ədədin işarəsini təyin edin.)
int numberU = -5;
if (numberU > 0)
{
    Console.WriteLine(numberU + " ededi musbetdir: +");
}
else if (numberU == 0)
{
    Console.WriteLine(" eded 0 a beraberdir");
}
else
    Console.WriteLine(numberU + " ededi menfidir; -");
#endregion

#region (Böyük olanı tap Tapşırıq: İki ədəd arasında ən böyüyünü tapın.)
int one = 20;
int second = 5;
int third = 10;
if (one > second)
{
    Console.WriteLine(one + " verilmis ededlerden en boyuyudur");
}
else
    Console.WriteLine(second + " ededi en boyukdur");
#endregion

#region (3 ədəd arasında maksimum Tapşırıq: Üç ədəd daxil edilir, ən böyüyünü tapın.)
if (one > second && one > third)
{
    Console.WriteLine(one + " ededi en boyukdur");
}
else if (one < second && second > third)
{
    Console.WriteLine(second + " ededi en boyukdur");
}
else
    Console.WriteLine(third + " ededi en boyukdur");
#endregion