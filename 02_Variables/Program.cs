using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değşkenler
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("***********Fiyat Listesi***********");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("------Elma birim Fiyatı: " + applePrice + " TL");
            //Console.WriteLine("------Portakal birim Fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("------Çilek birim Fiyatı: " + strawberryPrice + "T L");
            //Console.WriteLine("------Patates birim Fiyatı: " + potatoPrice + " TL");
            //Console.WriteLine("------Domates birim Fiyatı: " + tomatoPrice + " TL");

            //Console.WriteLine();
            //Console.WriteLine();


            //double appleGram , orangeGram,strawberryGram , potatoGram , tomatoGram ;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.758;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangePrice * orangeGram;
            //double strawberryTotalPrice = strawberryPrice * strawberryGram;
            //double potatoTotalPrice = potatoPrice * potatoGram;
            //double tomatoTotalPrice = tomatoPrice * tomatoGram;

            //Console.WriteLine("Elmanın Toplam Fiyatı " + appleTotalPrice);
            //Console.WriteLine("Portakalın Toplam Fiyatı " + orangeTotalPrice);
            //Console.WriteLine("Çileğin Toplam Fiyatı " + strawberryTotalPrice);
            //Console.WriteLine("Patatesin Toplam Fiyatı " + potatoTotalPrice);
            //Console.WriteLine("Domatesin Toplam Fiyatı " + tomatoTotalPrice);
            //Console.WriteLine("Toplam Tutar = " + (appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice));
            #endregion

            #region Char Değişkenler
            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri
            //Console.WriteLine("********C# Hava Yolları Yolcu Bilgisi*********");
            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge;

            //Console.Write("Yolcu adı: ");
            //passengerName = Console.ReadLine();
            //Console.Write("Yolcu soyadı: ");
            //passengerSurname = Console.ReadLine();
            //Console.Write("Yolcu ilçe bilgisi: ");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Yolcu şehir bilgisi: ");
            //passengerCity = Console.ReadLine();
            //Console.Write("Yolcu yaşı: ");
            //passengerAge = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("-------------------------");
            //Console.WriteLine(passengerName+" "+passengerSurname + " " + passengerCity + " " + passengerDistrict + " " + passengerAge);

            #endregion

            #region Klavyeden tam sayı ve dönüşümleri
            //int shoesPrice=1000, computerPrice=2000, chairPrice=5000, tvPrice=12000;
            //int shoesCount, computerCount, chairCount, tvCount;
            //Console.Write("Lütfen aldığınz ayakkab sayısını giriniz ");
            //shoesCount =int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınz bilgisayar sayısını giriniz ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınz sandalye sayısını giriniz ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınz televizyon sayısını giriniz ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount*shoesPrice + computerCount*computerPrice + chairCount*chairPrice + tvCount*tvPrice;
            //Console.WriteLine("Toplam ödemeniz gereken tutar= " + totalPrice);

            #endregion

            #region klavyeden ondalıklı sayı işlemleri
            //double exam1, exam2,exam3,result;
            //Console.Write("Birinci sınav notunu giriniz ");
            //exam1=double.Parse(Console.ReadLine());

            //Console.Write("İkinci sınav notunu giriniz ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Üçüncü sınav notunu giriniz ");
            //exam3 = double.Parse(Console.ReadLine());

            //result=(exam1+exam2 + exam3)/3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav ortlamanız= "+result);

            #endregion

            #region klavyeden karakter girişleri
            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz ");
            //gender =char.Parse(Console.ReadLine());
            //Console.WriteLine("Seçtiğiniz cinsiyet= "+gender);
            #endregion
            Console.Read();
        }
    }
}
