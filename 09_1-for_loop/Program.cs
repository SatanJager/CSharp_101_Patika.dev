namespace _09_1_for_loop;

class Program
{
    static void Main(string[] args)
    {
        //For Loop ve Break Continue Ifadeleri
        // 1'den 10'a kadar olan sayıları yazdıran bir for döngüsü oluşturalım  
        // Ancak 4 sayısına gelindiğinde döngüyü sonlandırmak yerine o sayıyı atlayalım
        // ve devam edelim.
        // break ve continue ifadelerinin farkını gösterelim
        // break ifadesi döngüyü tamamen sonlandırır
        // continue ifadesi ise o anki döngüyü atlar ve bir sonraki adıma geçer
                
        
        for (int i = 1; i <= 10; i++)
        {
            if (i == 4)
            {
                //break; //Döngüyü tamamen sonlandırır
                continue; //O anki döngüyü atlar ve bir sonraki adıma geçer
            }
            Console.WriteLine(i);


        }





    }
}
