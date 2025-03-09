using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_103022330026
{
    public enum Pintu { Terkunci, Terbuka }
    public enum Kegiatan { BukaPintu, KunciPintu }

    public class DoorMachine
    {
        private Pintu state;

        public DoorMachine()
        {
            state = Pintu.Terkunci;
        }

        public void UbahStatePintu(Kegiatan option)
        {
            switch (state)
            {
                case Pintu.Terkunci:
                    if (option == Kegiatan.BukaPintu)
                    {
                        Console.WriteLine("Pintu tidak terkunci");
                        state = Pintu.Terbuka;
                    }
                    else
                    {
                        Console.WriteLine("Pintu sudah terkunci");
                    }
                    break;

                case Pintu.Terbuka:
                    if (option == Kegiatan.KunciPintu)
                    {
                        Console.WriteLine("Pintu terkunci");
                        state = Pintu.Terkunci;
                    }
                    else
                    {
                        Console.WriteLine("Pintu sudah terbuka");
                    }
                    break;
            }
        }

        public void GetStatusPintu()
        {
            Console.WriteLine("Pintu: " + state);
        }
    }
}
