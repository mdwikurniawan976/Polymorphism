using System;

public class HelloWorld
{
    static public void Main()
    {
        familyhobi ak = new familyhobi();
        familyhobi ayah = new Ayah();
        familyhobi ibu = new Ibu();
        familyhobi kakak = new Kakak();
        familyhobi aku= new Aku();
       

        familydata ayahku = new familydata("Mulyo Pudjiadi", 56 , +6283834940562);
        familydata ibuku = new familydata("Nurin Rahmawati", 48 , +6283834940561);
        familydata kakaku = new familydata("Silvi Kurnia"  , 23 , +6289687548332);
        familydata akuu = new familydata("M Dwi Kurniawan",  16 , +6289687548332);
        Console.WriteLine("Data Ayah:\n" + ayahku.nama + "\n" + ayahku.umur + "\n" + ayahku.nohp);
        ayah.Hobi();
        Console.WriteLine("Data ibu:\n" + ibuku.nama + "\n" + ibuku.umur + "\n" + ibuku.nohp);
        ibu.Hobi();
        Console.WriteLine("Data Kakak:\n" + kakaku.nama + kakaku.umur + "\n" + kakaku.nohp);
        kakak.Hobi();
        Console.WriteLine("Data Ku :\n"+ akuu.nama + akuu.umur + "\n" + akuu.nohp); 
        aku.Hobi();
        


    }
    class familydata
    {
        public string nama;
        public int umur;
        public long nohp;

        public familydata(string Nama, int Umur, long Nohp)
        {
            nama = Nama;
            umur = Umur;
            nohp = Nohp;
        }



    }
    class familyhobi
    {
        public virtual void Hobi()
        {
            Console.WriteLine("Hobi");
        }
    }
    class Ayah : familyhobi
    {
        public override void Hobi()
        {
            Console.WriteLine("Melukis");
        }
    }
    class Ibu : familyhobi
    {
        public override void Hobi()
        {
            Console.WriteLine("Menjahit");
        }
    }
    class Kakak : familyhobi
    {
        public override void Hobi()
        {
            Console.WriteLine("Berenang");
        }
    }
    class Aku : familyhobi
    {
        public override void Hobi()
        {
            Console.WriteLine("Bermain Game");
        }
    }


}
