using System;
namespace String_Metotlar 
{
    class Program
    {
        static void Main(string[]args)
        {
          string degisken="Alper Saçmaözü ile kodluyoruz";
          string degisken2="alper Saçmaözü ile kodluyoruz";

          //length
          Console.WriteLine(degisken.Length);  //Kaç karakterden oluşur

          //ToUpper,ToLower
          Console.WriteLine(degisken.ToUpper());  //Büyük ahrf ile yaz
          Console.WriteLine(degisken.ToLower());  //Küçük harf ile yaz

          //Concat
          Console.WriteLine(string.Concat(degisken," Yuppi !")); //değişkenimiz ile birleştirme işlemi

          //Compare, CompareTo
           Console.WriteLine(degisken.CompareTo(degisken2));  //degiskenleri karşılaştırma yapar
           Console.WriteLine(String.Compare(degisken,degisken2,true));
           Console.WriteLine(String.Compare(degisken,degisken2,false)); //true-false büyük küçük harf duyarlılığı

           //Contains
           Console.WriteLine(degisken.Contains(degisken2)); //degiskenin içinde degisken2 var mı
           Console.WriteLine(degisken.EndsWith("kodluyoruz")); 
           Console.WriteLine(degisken.StartsWith("Hello"));

           //IndexOf
           Console.WriteLine(degisken.IndexOf("Saçmaözü"));
           Console.WriteLine(degisken.IndexOf("elma"));
           Console.WriteLine(degisken.LastIndexOf("u")); //Tersten aramaya başlar.

           //Insert
           Console.WriteLine(degisken.Insert(0,"MERHABA,")); //Başa merhaba yazdır.

           //PadLeft,PadRight
           Console.WriteLine(degisken+degisken2.PadLeft(50));  
           Console.WriteLine(degisken+degisken2.PadLeft(50,'*')); 
           Console.WriteLine(degisken.PadRight(50,'-')+degisken2.PadLeft(20,'*'));

           //Remove
           Console.WriteLine(degisken.Remove(10));
           Console.WriteLine(degisken.Remove(5,3));
           Console.WriteLine(degisken.Remove(0,1));

           //Replace 
           Console.WriteLine(degisken.Replace("kodluyoruz","YAZIYORUZ"));

           //Split
           Console.WriteLine(degisken.Split(' ')[1]);

           //Substring
           Console.WriteLine(degisken.Substring(4));
           Console.WriteLine(degisken.Substring(4,6));


          

        }
    }
}
