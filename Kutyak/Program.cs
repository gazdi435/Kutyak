using System.Text;

namespace Kutyak
{
    internal class Program
    {
        //public static List<string[]> kutyaNevek = new List<string[]>();
        public static Dictionary<int, string> kutyaNevek = new Dictionary<int, string>();
        public static Dictionary<int, string> kutyaFajtak = new Dictionary<int, string>();
        public static List<Kutya> kutyaLista = new List<Kutya>();

        static void Main(string[] args)
        {
            Beolvasas("Kutyak", "kutyaNevek", "KutyaFajtak");
            HanyKutyaNev(kutyaNevek);
            KutyakAtlgEletkora(kutyaLista);
        }

        private static void KutyakAtlgEletkora(List<Kutya> lista)
        {
            Console.WriteLine($"6. feladat: {lista.Average(x => x.KutyaEletkora)}");
        }

        private static void HanyKutyaNev(Dictionary<int, string> kutyaNevek)
        {
            Console.WriteLine($"3. feladat: {kutyaNevek.Count}");
        }

        private static void Beolvasas(string kutyakEleres, string Nevek, string Fajtak)
        {
            File.ReadAllLines(Nevek, Encoding.UTF8).ToList().ForEach(x => { kutyaNevek.Add(Convert.ToInt16(x.Split(";")[0]), x.Split(";")[1]); });
            File.ReadAllLines(Fajtak, Encoding.UTF8).ToList().ForEach(x => { kutyaFajtak.Add(Convert.ToInt16(x.Split(";")[0]), x.Split(";")[1]); });
            File.ReadAllLines(kutyakEleres, Encoding.UTF8).ToList().ForEach(x => { kutyaLista.Add(new Kutya(Convert.ToInt16(x.Split(";")[0]),kutyaFajtak[Convert.ToInt16(x.Split(";")[1])],
                kutyaNevek[Convert.ToInt16(x.Split(";")[2])], Convert.ToInt16(x.Split(";")[3]), x.Split(";")[4])); });
        }
    }
}