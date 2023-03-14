// See https://aka.ms/new-console-template for more information

public class KodeBuah
{
    public enum Buah
    {
        Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, Kelapa, Jagung, Kurma, Durian, Anggur, Melon, Semangka
    }

    public static string getKodeBuah(Buah buah)
    {
        string[] kodeBuah = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00" };
        return kodeBuah[(int)buah];
    }
}

class PosisiKarakterGame
{
    enum State { Jongkok, Berdiri, Tengkurap, Terbang }
    static void Main(string[] args)
    {
        Console.WriteLine("Kode buah Blackberry adalah {0:s}\n", KodeBuah.getKodeBuah(KodeBuah.Buah.Blackberry));

        State state = State.Berdiri;
        string[] screen = { "Posisi Jongkok","Posisi Berdiri","Posisi Tengkurap","Posisi Terbang","Posisi landing","Posisi take off" };
        while (state != null)
        {
            Console.WriteLine(screen[(int)state]);
            Console.Write("Enter Command: ");
            string command = Console.ReadLine();
            switch (state)
            {
                case State.Berdiri:
                    if (command == "TombolW")
                    {
                        state = State.Terbang;
                        Console.WriteLine(screen[5]);
                    }else if (command == "TombolS")
                    {
                        state = State.Jongkok;
                    }
                    break;
                case State.Terbang:
                    if(command == "TombolS")
                    {
                        state = State.Berdiri;
                    }else if (command == "TombolX")
                    {
                        state = State.Jongkok;
                        Console.WriteLine(screen[4]);
                    }
                    break;
                case State.Jongkok:
                    if(command == "TombolW")
                    {
                        state = State.Berdiri;
                    }else if(command == "TombolS")
                    {
                        state = State.Tengkurap;
                    }
                    break;
                case State.Tengkurap:
                    if(command == "TombolW")
                    {
                        state = State.Jongkok;
                    }
                    break;
            }
        }
    }
}