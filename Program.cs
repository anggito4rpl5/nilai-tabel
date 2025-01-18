// See https://aka.ms/new-console-template for more information
Console.WriteLine("Masukkan nama kamu sayang = ");
Console.WriteLine("lebokno ");



String nama;
int umur;
nama= Console.ReadLine();

umur = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("SELAMAT DATANG " + nama);
Console.WriteLine("jek umur " +  umur  + " ae kakean polah");

if (umur <= 17)// 17
{
    Console.WriteLine("Kamu mencapai remaja");

}
else if (umur <= 24)// 24
{
    Console.WriteLine("Kamu sudah dewasa ");
}
else
{
    Console.WriteLine(" Kamu Menuju Masa pensiun ");
}
Console.WriteLine(" perhitungan Volume Balok ");
Console.WriteLine(" Masukkan Nilai Panjang ");
int p=Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Masukkan Nilai Lebar = ");
int l= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Masukkan Nilai Tinggi = ");
int t=Convert.ToInt32(Console.ReadLine());

int Luas = p * l * t;
Console.WriteLine("Nilai Luas Balok = " + Luas);


