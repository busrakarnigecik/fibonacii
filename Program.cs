using System;
using System.Linq;

class Program
{
    static int[] Fibonacci(int n)
    {
        if (n <= 0)
        {
            return new int[0];
        }
        int[] fibArray = new int[n];
        fibArray[0] = 0; // İlk Sayı
        if (n > 1)
        {
            fibArray[1] = 1;
        }
        // Fibonacci dizisini oluşturma
        for (int i = 2; i < n; i++)
        {
            fibArray[i] = fibArray[i - 1] + fibArray[i - 2];
        }

        return fibArray;
    }
    // Fibonacci serisinin ortalamasını hesaplama fonksiyonu
    static double OrtalamaHesapla(int derinlik)
    {
        int[] fibonacciSeries = Fibonacci(derinlik);
        if (fibonacciSeries.Length == 0)
        {
            Console.WriteLine("Derinlik sıfırdan büyük olmalı!");
            return 0;
        }

        double sum = fibonacciSeries.Sum(); // Fibonacci dizisinin toplamını alıyoruz
        return sum / fibonacciSeries.Length; // Ortalamayı hesaplıyoruz
    }

    // Ana fonksiyon
    static void Main()
    {
        Console.WriteLine("Fibonacci serisinin kaç elemanını hesaplamak istersiniz?");
        int derinlik;

        // Kullanıcıdan derinlik değerini alıyoruz
        if (int.TryParse(Console.ReadLine(), out derinlik))
        {
            if (derinlik <= 0)
            {
                Console.WriteLine("Derinlik sıfırdan büyük olmalı.");
                return;
            }

            // Ortalama hesaplanıyor
            double average = OrtalamaHesapla(derinlik);
            Console.WriteLine($"Fibonacci serisinin ilk {derinlik} elemanının ortalaması: {average}");
        }
        else
        {
            Console.WriteLine("Geçersiz bir sayı girdiniz. Lütfen geçerli bir sayı girin.");
        }
    }
}



