using System;

public class KodeBuah
{
    public enum Buah { Apel , Aprikot , Alpukat , Pisang ,
        Paprika , Blackberry , Ceri , Kelapa , Jagung ,
        Kurma , Durian , Anggur , Melon , Semangka };

    public static String getKodeBuah(Buah buah)
    {
        String[] kodeBuah = { "A00" , "B00", "C00", "D00", "E00", "F00", "H00",
            "I00", "J00", "K00", "L00", "M00", "N00", "O00", };

        return kodeBuah[(int) buah];
    }
}

public class main
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Masukkan nama buah yang ingin anda cari kodenya");
        Console.Write("Nama Buah: ");
        String inputBuah = Console.ReadLine();
        if (Enum.TryParse<KodeBuah.Buah>(inputBuah, true, out KodeBuah.Buah buah))
        {
            Console.WriteLine($"Kode buah: {KodeBuah.getKodeBuah(buah)}");
        }
        else
        {
            Console.WriteLine("Nama buah yang anda cari tidak terdaftar");
        }
    }
}