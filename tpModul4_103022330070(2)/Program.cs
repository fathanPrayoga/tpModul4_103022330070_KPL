using System;
using System.Collections.Generic;


public class KodePos
{
    private static Dictionary<string, int> tabelKodePos = new Dictionary<string, int>
    {
        {"Batununggal", 40266},
        {"A. Kujangsari", 40287},
        {"Mengger", 40267},
        {"Wates", 40256},
        {"Cijaura", 40287},
        {"Jatisari", 40286},
        {"Margasari", 40286},
        {"Sekejati", 40286},
        {"Kebonwaru", 40272},
        {"Maleer", 40274},
        {"Samoja", 40273}
    };

    
    public static int GetKodePos(string kelurahan)
    {
        if (tabelKodePos.TryGetValue(kelurahan, out int kodePos))
        {
            return kodePos;
        }
        return -1; 
    }
}


public enum DoorState
{
    Terkunci,
    Terbuka
}


public class DoorMachine
{
    private DoorState _state;

    public DoorMachine()
    {
        _state = DoorState.Terkunci; 
        Console.WriteLine("Pintu terkunci");
    }

    public void BukaPintu()
    {
        if (_state == DoorState.Terkunci)
        {
            _state = DoorState.Terbuka;
            Console.WriteLine("Pintu tidak terkunci");
        }
        else
        {
            Console.WriteLine("Pintu sudah terbuka");
        }
    }

    public void KunciPintu()
    {
        if (_state == DoorState.Terbuka)
        {
            _state = DoorState.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }
        else
        {
            Console.WriteLine("Pintu sudah terkunci");
        }
    }
}

class Program
{
    static void Main()
    {
        
        DoorMachine pintu = new DoorMachine();
        pintu.BukaPintu();
        pintu.KunciPintu();

        Console.WriteLine("\n=== Pencarian Kode Pos ===");

        
        while (true)
        {
            Console.Write("\nMasukkan nama kelurahan (atau ketik 'exit' untuk keluar): ");
            string kelurahan = Console.ReadLine();

            if (kelurahan.ToLower() == "exit")
            {
                Console.WriteLine("Terima kasih telah menggunakan program ini!");
                break;
            }

            
            int kodePos = KodePos.GetKodePos(kelurahan);

            
            if (kodePos != -1)
            {
                Console.WriteLine($"Kode pos {kelurahan}: {kodePos}");
            }
            else
            {
                Console.WriteLine("Kelurahan tidak ditemukan!");
            }
        }
    }
}
