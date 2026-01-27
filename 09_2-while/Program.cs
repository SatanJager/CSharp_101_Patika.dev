namespace _09_2_while;

class Program
{
    static void Main(string[] args)
    {
        //While Döngüsü
        // Belirtilen bir koşul doğru olduğu sürece kod bloğunu tekrar tekrar çalıştırır.
        // Genellikle döngünün kaç kez çalışacağını önceden bilmediğimiz durumlarda kullanılır.
        // Koşul yanlış olduğunda döngü sona erer.
        // Döngü değişkeni genellikle döngü başlamadan önce tanımlanır ve döngü içinde güncellenir.
        // Sonsuz döngüden kaçınmak için döngü değişkeninin doğru şekilde güncellendiğinden emin olunmalıdır.
        // Örnek Kullanım:
        int sayac = 0; // Döngü değişkeni
        while (sayac < 5) // Koşul
        {
            Console.WriteLine("Merhaba Dünya!"); // Kod bloğu
            sayac++; // Döngü değişkenini güncelleme
        }       

        // Kullanıcıdan pozitif bir sayı alıp, bu sayıya kadar olan sayıların toplamını hesaplayan program
        Console.Write("Pozitif bir sayı girin: ");
        int sayi = int.Parse(Console.ReadLine());
        int toplam = 0;
        int sayac2 = 1;
        while (sayac2 <= sayi)
        {
            toplam += sayac2;
            sayac2++;
        }
        Console.WriteLine("Toplam: " + toplam);

        // Sonsuz Döngü Örneği (Dikkatli Kullanılmalı)
        /*while (true)
        {
            Console.WriteLine("Bu bir sonsuz döngüdür. Çıkmak için Ctrl + C tuşlarına basın.");
        }*/

        // Kullanıcıdan 'exit' komutu gelene kadar isim girmesini isteyen program
        string input = "";          
        while (input.ToLower() != "exit")
        {
            Console.Write("İsim girin (çıkmak için 'exit' yazın): ");
            input = Console.ReadLine();
            if (input.ToLower() != "exit")
            {
                Console.WriteLine("Merhaba, " + input + "!");
            }
        }

        // a'dan z'ye kadar olan harfleri yazdıran program
        char harf = 'a';
        while (harf <= 'z')
        {
            Console.Write(harf + " ");
            harf++;
        }


        Console.WriteLine("***** For Each Döngüsü *****");
        // For Each Döngüsü
        // Koleksiyonlar veya diziler üzerinde yineleme yapmak için kullanılır. 
        // Her bir öğe için kod bloğunu çalıştırır.
        // Koleksiyonun her bir öğesine tek tek erişim sağlar.
        // Döngü değişkeni, koleksiyondaki her bir öğeyi temsil eder.
        // Örnek Kullanım:
        string[] meyveler = { "Elma", "Muz", "Çilek", "Portakal" }; 
        foreach (string meyve in meyveler) // Koleksiyondaki her bir öğe için
        {
            Console.WriteLine(meyve); // Kod bloğu
        }

    }
}
