using System;

public class kodePos
{
    private static Dictionary<String, int> tabelKodePos = new Dictionary<String, int>
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

    public static int? GetKodePos(string kelurahan)
    {
        if (tabelKodePos.TryGetValue(kelurahan, out int kodePos))
        {
            return kodePos;
        }
        return null;
    }
}
