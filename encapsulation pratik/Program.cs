using System;

public class Araba
{
    public string Marka { get; set; }
    public string Model { get; set; }
    public string Renk { get; set; }

    private int _kapıSayısı;

    public int KapıSayısı
    {
        get { return _kapıSayısı; }
        set
        {
            if (value == 2 || value == 4)
            {
                _kapıSayısı = value;
            }
            else
            {
                Console.WriteLine("Uyarı: Kapı sayısı yalnızca 2 veya 4 olabilir. Kapı sayısı -1 olarak atanacaktır.");
                _kapıSayısı = -1;
            }
        }
    }

    public Araba(string marka, string model, string renk, int kapıSayısı)
    {
        Marka = marka;
        Model = model;
        Renk = renk;
        KapıSayısı = kapıSayısı;
    }

    public void ArabaBilgileriniYazdir()
    {
        Console.WriteLine($"Marka: {Marka}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Renk: {Renk}");
        Console.WriteLine($"Kapı Sayısı: {KapıSayısı}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Araba araba1 = new Araba("Volvo", "EX40", "Gri", 4);
        araba1.ArabaBilgileriniYazdir();

        Console.WriteLine();

        // Kapı sayısı geçersiz bir değer atayalım (örneğin 3)
        Araba araba2 = new Araba("Volvo", "EX40", "Gri", 3);
        araba2.ArabaBilgileriniYazdir();
    }
}
