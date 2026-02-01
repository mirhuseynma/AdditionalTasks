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