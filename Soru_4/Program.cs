using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //0 ile 100 arasında rastgele tutulan sayıyı tahmin edelim. Her tahminde kullanıcıyı yönlendirme amacıyla bilgilendirme mesajı verelim. (Daha büyük sayı giriniz veya daha küçük bir sayı giriniz). Sayıyı bulduğunuzda kaç tahminde bildiğini ekrana yazdırın. Tahmin işlemi tamamlandığında "Yeni oyuna başlamak istermisiniz?" diye soru sorsun. evet ise yeniden başlasın, hayır ise program sonlansın.
            Random rastgele = new Random();
            int rastgeleSayi = rastgele.Next(0, 100);
            int tahmin = 0;
            int tahminSayisi = 0;
            bool devam = true;
            while (devam)
            {
                tahminSayisi++;
                Console.Write("0 ile 100 arasında bir sayı tahmin ediniz: ");
                tahmin = Convert.ToInt32(Console.ReadLine());
                if (tahmin == rastgeleSayi)
                {
                    Console.WriteLine($"Tebrikler, {tahminSayisi}. tahminde bildiniz.");
                    Console.Write("Yeni oyuna başlamak istermisiniz? (Evet/Hayır): ");
                    string cevap = Console.ReadLine();
                    if (cevap.ToLower() == "evet")
                    {
                        rastgeleSayi = rastgele.Next(0, 100);
                        tahminSayisi = 0;
                    }
                    else
                    {
                        devam = false;
                    }
                }
                else if (tahmin < rastgeleSayi)
                {
                    Console.WriteLine("Daha büyük bir sayı giriniz.");
                }
                else
                {
                    Console.WriteLine("Daha küçük bir sayı giriniz.");
                }
            }
            Console.WriteLine("Program sonlandı.");
            Console.ReadKey();
        }
    }
}
