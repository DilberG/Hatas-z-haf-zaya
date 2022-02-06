using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Atama VE işlemli Atama Oparetörleri *****");
            // Atama VE işlemli Atama
            int x = 3;
            int y = 3;
            y = y+2;

            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y/=1;
            Console.WriteLine(y);
            x *=2;
            Console.WriteLine(x);

            Console.WriteLine("***** Mantıksal Oparetörler *****");
            //Mantıksal Oparatörler
            // ||, &&, !

            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted)
                Console.WriteLine("Perfect!");

            if(isSuccess || isCompleted)
                Console.WriteLine("Great!");

            if(isSuccess && !isCompleted)
                Console.WriteLine("Fine!");

            Console.WriteLine("***** İlişkisel Oparetörler *****");
            //İlişkisel Oparetörler
            // <, >, <=, >=, ==; !=

            int a = 3;
            int b = 4;
            bool sonuc = a<b;

            Console.WriteLine(sonuc);
            sonuc = a>b;
            Console.WriteLine(sonuc);
            sonuc = a>=b;
            Console.WriteLine(sonuc);
            sonuc = a<=b;
            Console.WriteLine(sonuc);
            sonuc = a==b;
            Console.WriteLine(sonuc);
            sonuc = a!=b;
            Console.WriteLine(sonuc);

            Console.WriteLine("***** Aritmetik Oparetörler *****");
            // /, *, +, -

            int sayı1 = 10;
            int sayı2 = 5;
            int sonuc1 = sayı1/sayı2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayı1*sayı2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayı1+sayı2;
            Console.WriteLine(sonuc1);
            sonuc1 =sayı1++;
            Console.WriteLine(sayı1);

            // % : mod alır
            int sonuc2 = 20%3;
            Console.WriteLine(sonuc2);
        }
    }
}
