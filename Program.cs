// See https://aka.ms/new-console-template for more information
using tpmodul4_103022330026;

Console.WriteLine("Daftar Kelurahan");
Console.WriteLine("=================================");
Console.WriteLine("Kelurahan\t\tKode Pos");
Console.WriteLine("=================================");

foreach (KodePos.Kelurahan kel in Enum.GetValues(typeof(KodePos.Kelurahan)))
{
    String namaKelurahan = kel.ToString();
    Console.WriteLine($"{namaKelurahan,-16} | {KodePos.GetKodePos(kel)}");
}

DoorMachine pintu = new DoorMachine();
pintu.GetStatusPintu();

string input = "";
while (input.ToLower() != "keluar")
{
    Console.WriteLine("Perintah (BukaPintu/KunciPintu): ");
    input = Console.ReadLine();

    if (Enum.TryParse(input, out Kegiatan trigger))
    {
        pintu.UbahStatePintu(trigger);
        pintu.GetStatusPintu();
    }
    else
    {
        Console.WriteLine("Perintah tidak valid, coba lagi");
    }
}