using System.Text;

namespace Kutyak
{
    internal class Program
    {
        //public static List<string[]> kutyaNevek = new List<string[]>();
        public static Dictionary<int, string> kutyaNevek = new Dictionary<int, string>();
        public static Dictionary<int, string> kutyaFajtak = new Dictionary<int, string>();

        static void Main(string[] args)
        {
            Beolvasas("Kutyak", "kutyaNevek", "KutyaFajtak");
        }

        private static void Beolvasas(string kutyak, string Nevek, string Fajtak)
        {
            File.ReadAllLines(Nevek, Encoding.UTF8).ToList().ForEach(x => { kutyaNevek.Add(Convert.ToInt16(x.Split(" ")[0]), x.Split(" ")[1]); });
            File.ReadAllLines(Fajtak, Encoding.UTF8).ToList().ForEach(x => { kutyaFajtak.Add(Convert.ToInt16(x.Split(" ")[0]), x.Split(" ")[1]); });
        }
    }
}