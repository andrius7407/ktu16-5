using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ktu16_5
{
    class Plaukikai
    {
        public string vardas;
        public string pavarde;
        public string salis;
        public string laikas;

        public Plaukikai(string vardas, string pavarde, string salis, string laikas)
        {
            this.vardas = vardas;
            this.pavarde = pavarde;
            this.salis = salis;
            this.laikas = laikas;
        }

        public static Plaukikai[] trumpinioKeitimasPavadinimu(Plaukikai[] plaukikai, Salys[] salys)
        {
            for(int i = 0; i < plaukikai.Length; i++)
            {
                string salis = plaukikai[i].salis;
                for(int j = 0; j < salys.Length; j++)
                {
                    if(salis == salys[j].santrumpa)
                    {
                        plaukikai[i].salis = salys[i].pavadinimas;
                        break;
                    }
                }
            }
            return plaukikai;
        }
        public static void spausdinimas(Plaukikai[] plaukikai)
        {
            using (System.IO.StreamWriter file =
             new System.IO.StreamWriter(@"C:\Users\Andrius\Documents\Visual Studio 2017\ktu\ktu16-5\ktu16-5\galutinis_sarasas.txt"))
            {
                foreach (Plaukikai plauk in plaukikai)
                {
                    file.WriteLine(plauk.vardas + "  " + plauk.pavarde + "  " + plauk.salis + "  " + plauk.laikas);
                }
            }
        }
    }
}
