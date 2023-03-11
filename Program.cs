// See https://aka.ms/new-console-template for more information

public class AppDomainUnloadedException
{
    public enum Kelurahan {Batununggal, Kujangsari, Mengger, Wates, Cijaura, Jatisari, Margasari, Sekejari, Kebonwaru, Maleer, Samoja }
    
    public static int getKodePos(Kelurahan kelurahan)
    {
        int[] kode = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40272, 40274, 40273 };
        return kode[(int)kelurahan];
    }

    public static void Main(string[] args)
    {
        Kelurahan kelurahan = Kelurahan.Cijaura;
        int kodepos = getKodePos(kelurahan);
        Console.WriteLine("Kelurahan " + kelurahan + " kode pos 0" + kodepos);
    }
}
