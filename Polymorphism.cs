using System;

class Program
{
    public static void Main(string[] args)
    {
        Kare kare = new Kare();
        kare.Genislik = 5;
        kare.Yukseklik = 5;
        kare.AlanHesapla();

        Dikdortgen dikdortgen = new Dikdortgen();
        dikdortgen.KisaKenar = 4;
        dikdortgen.UzunKenar = 6;
        dikdortgen.AlanHesapla();

        DikUcgen dikUcgen = new DikUcgen();
        dikUcgen.Genislik1 = 3;
        dikUcgen.Yukseklik1 = 4;
        dikUcgen.AlanHesapla();
    }
}

public class BaseGeometrikSekil
{
    public virtual double AlanHesapla()
    {
        return 0;
    }
}

public class Dikdortgen : BaseGeometrikSekil
{
    public double KisaKenar { get; set; }
    public double UzunKenar { get; set; }
    public override double AlanHesapla()
    {
        double alan = KisaKenar * UzunKenar;
        Console.WriteLine("Dikdörtgeninizin alanı -> " + alan);
        return alan;
    }
}

public class Kare : BaseGeometrikSekil
{
    public double Genislik { get; set; }
    public double Yukseklik { get; set; }
    public override double AlanHesapla()
    {
        double alan1 = Genislik * Yukseklik;
        Console.WriteLine("Karenizin alanı -> " + alan1);
        return alan1;
    }
}

public class DikUcgen : BaseGeometrikSekil
{
    public double Genislik1 { get; set; }
    public double Yukseklik1 { get; set; }
    public override double AlanHesapla()
    {
        double alan2 = Genislik1 * Yukseklik1 / 2;
        Console.WriteLine("Dik üçgeninizin alanı -> " + alan2);
        return alan2;
    }
}
