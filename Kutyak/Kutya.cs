using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyak
{
    internal class Kutya
    {
        int id;
        string kutyaFajtaja;
        string kutyaNeve;
        int kutyaEletkora;
        string vizsgalatIdeje;

        public Kutya(int id, string kutyaFajtaja, string kutyaNeve, int kutyaEletkora, string vizsgalatIdeje)
        {
            this.id = id;
            this.kutyaFajtaja = kutyaFajtaja;
            this.kutyaNeve = kutyaNeve;
            this.kutyaEletkora = kutyaEletkora;
            this.vizsgalatIdeje = vizsgalatIdeje;
        }

        public int Id { get => id; set => id = value; }
        public string KutyaFajtaja { get => kutyaFajtaja; set => kutyaFajtaja = value; }
        public string KutyaNeve { get => kutyaNeve; set => kutyaNeve = value; }
        public int KutyaEletkora { get => kutyaEletkora; set => kutyaEletkora = value; }
        public string VizsgalatIdeje { get => vizsgalatIdeje; set => vizsgalatIdeje = value; }
    }
}
