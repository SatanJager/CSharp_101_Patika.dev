namespace _12_odev1;

class Program
{
    static void Main(string[] args)
    {
        //**1. Soru**
        /* Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın. */
        Console.WriteLine("1. Sorunun Çözümü:");

        Console.WriteLine("Lütfen pozitif bir sayı girin");
        int posNumber = int.Parse(Console.ReadLine());
        Console.WriteLine(posNumber + " Adet pozitif sayı giriniz");

        int[] numArr = new int[posNumber];
        for(int i=0; i < posNumber; i++)
        {
            Console.WriteLine((i+1) + ". sayıyı giriniz");
            numArr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Çift Sayılar:");
        foreach(int num in numArr)
        {
            if(num % 2 == 0)
            {
                Console.WriteLine(num);
            }
        }

        //**2. Soru**
        /* Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın. */
        Console.WriteLine("2. Sorunun Çözümü:");

        Console.WriteLine("Lütfen 2 adet pozitif sayı giriniz");
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine(n + " Adet pozitif sayı giriniz");
        int[] nArr = new int[n];
        for(int i=0; i < n; i++)
        {
            Console.WriteLine((i+1) + ". sayıyı giriniz");
            nArr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine(m + "'e eşit olan ve " + m + "'e kalansız bölünenler:");
        foreach(int num in nArr)
        {
            if(num == m || num % m == 0)
            {
                Console.WriteLine(num + " ");
            }
        }

        //**3. Soru**
        /* Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesini isteyin. Kullanıcının girmiş olduğu kelimeleri sondan başa doğru console'a yazdırın. */
        Console.WriteLine("3. Sorunun Çözümü:");

        Console.WriteLine("Lütfen pozitif bir sayı giriniz");
        int wordNum = int.Parse(Console.ReadLine());

        Console.WriteLine(wordNum + " Adet kelime giriniz");
        string[] wordArr = new string[wordNum];
        for(int i=0; i < wordNum; i++)
        {
            Console.WriteLine((i+1) + ". kelimeyi giriniz");
            wordArr[i] = Console.ReadLine();
        }

        Console.WriteLine("Kelimenin sondan başa doğru sıralanışı:");
        for(int i=wordNum-1; i >= 0; i--)
        {
            Console.WriteLine(wordArr[i]);
        }

        //**4. Soru**
        /* Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın. */
        Console.WriteLine("4. Sorunun Çözümü:");

        Console.WriteLine("Lütfen bir cümle yazınız");
        string sentence = Console.ReadLine();

        int letterCount = 0;
        foreach(char c in sentence)
        {
            if(c != ' ')
            {
                letterCount++;
            }
        }

        int wordCount = 0;
        bool inWord = false;
        foreach(char c in sentence)
        {
            if(c != ' ')
            {
                if(!inWord)
                {
                    wordCount++;
                    inWord = true;
                }
            }
            else
            {
                inWord = false;
            }
        }

        Console.WriteLine("Harf sayısı: " + letterCount);
        Console.WriteLine("Kelime sayısı: " + wordCount);


    }
}
