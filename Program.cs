namespace SifrePin_Puk
{
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Hazırlayan AlpayCa");
                Console.WriteLine("Şifre Kontrol Programı... ");

            int reelPin = 1144, reelPuk = 11223344, pin,  yeniPin, puk,pukHak=10, 
                pinBloke = 3, pukBloke = 14, onayKodu = 0,
                musteriTemsilcisiOnayKodu = 0123456789;

                Console.Write("Lütfen Pin Kodunu Girin : ");
                pin = Convert.ToInt32(Console.ReadLine());

                while (pin != reelPin)
                {
                    for (int i = 0; i <= pinBloke; i++)
                    {
                        pinBloke--;
                        Console.Write("Hatalı Pin Girişi yaptınız : ");
                        Console.WriteLine("Kalan Hakkınız :  " + pinBloke);
                        Console.Write("Lütfen Pin Kodunu Girin : ");
                        pin = Convert.ToInt32(Console.ReadLine());

                        if (pin == reelPin) break;

                        if (i == pinBloke)
                    {
                        Console.WriteLine("Pin Kodunuz Bloke Oldu...");

                            for (int j = 9; j <= pukBloke; j--)
                            {
                                Console.Write("Lütfen Puk Kodunu Girin : ");
                                puk = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Kalan Hakkınız :  " + j);

                                if (j == 0)
                                {
                                    Console.WriteLine("Puk Kodunuz Bloke OLdu...\nLütfen Müşteri Hizmetleri İle İletişime Geçiniz.");
                                    Console.Write("Müşteri Temsilcisi Onay Kodu : ");
                                    onayKodu = Convert.ToInt32(Console.ReadLine());
                                    if (onayKodu != musteriTemsilcisiOnayKodu)
                                    {
                                        Console.WriteLine("Sistem Kilitlendi...");
                                        break;
                                    }
                                }
                                if (puk == reelPuk || onayKodu == musteriTemsilcisiOnayKodu)
                                {
                                    reelPin = 1144;
                                    Console.Write("Yeni pin Giriniz : ");
                                    reelPin = Convert.ToInt32(Console.ReadLine());
                                    break;
                                }
                            }
                        }
                    }
                    break;
                }
                Console.WriteLine("Açılıyor...");
            }
        }
}

               
