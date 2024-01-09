using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lakopark
{
    class Lakopark
    {
        readonly int lakoparkId;
        string lakoparkNeve;
        int utcakSzama;
        int telkekSzama;

        int[,] hazak;       //két dimenziós tömb - utca és telek érték alapján az emeletszámot adja vissza.

        public int LakoparkId { get => lakoparkId; }
        public string LakoparkNeve { get => lakoparkNeve; set => lakoparkNeve = value; }
        public int UtcakSzama { get => utcakSzama; set => utcakSzama = value; }
        public int TelkekSzama { get => telkekSzama; set => telkekSzama = value; }
        public int[,] Hazak { get => hazak; set => hazak = value; }


        public Lakopark(int lakoparkId, string lakoparkNeve, int utcakSzama, int telkekSzama)
        {
            this.lakoparkId = lakoparkId;
            LakoparkNeve = lakoparkNeve;
            UtcakSzama = utcakSzama;
            TelkekSzama = telkekSzama;
            this.hazak = new int[utcakSzama, telkekSzama];

        }

        internal void HazAdat(int utcaSzam, int hazSzam, int emelet)
        {
            this.hazak[utcaSzam - 1, hazSzam - 1] = emelet;
        }
    }
}
