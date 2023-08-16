namespace Donguler
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] kurslar = new string[] { "Java", "C#", "Algotritma" , "Python", "C++"};
            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");

            foreach (var kurs in kurslar)
            {
                Console.WriteLine( kurs );
            }

            Console.WriteLine("Sayfa Sonu-Footer");
        }
    }
}