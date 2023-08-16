// See https://aka.ms/new-console-template for more information


Kurs kurs = new Kurs();
kurs.KursAdi = "C#";
kurs.Egitmeni = "Ahsen";
kurs.IzlenmeOrani = 30;

Kurs kurs2 = new Kurs();
kurs2.KursAdi = "Java";
kurs2.Egitmeni = "Engin";
kurs2.IzlenmeOrani = 50;

Kurs kurs3 = new Kurs();
kurs3.KursAdi = "Python";
kurs3.Egitmeni = "Kerem";
kurs3.IzlenmeOrani = 100;

Kurs kurs4 = new Kurs();
kurs4.KursAdi = "C#";
kurs4.Egitmeni = "Ahsen";
kurs4.IzlenmeOrani = 30;

Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmeni + " %" + kurs.IzlenmeOrani);

Kurs[] kurslar = new Kurs[] {kurs, kurs2, kurs3, kurs4};

foreach (var course in kurslar)
{
    Console.WriteLine( course.KursAdi + " : " + course.Egitmeni + " %" + course.IzlenmeOrani);
}

class Kurs
{
    public string KursAdi { get; set; }
    public string Egitmeni { get; set; }
    public int IzlenmeOrani { get; set; }


}
