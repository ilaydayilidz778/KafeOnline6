using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace KafeOnline6.Data
{
    public class Siparis
    {
        public int MasaNo { get; set; }
        public SiparisDurum SiparisDurum { get; set; } = SiparisDurum.Aktif;
        public  decimal OdenenTutar { get; set; }
        public DateTime AcilisZamani { get; set; } = DateTime.Now;
        public DateTime? KapanisZamani { get; set; } //nullable deger olarak tanımladık
        public List<SiparisDetay> SiparisDetaylar { get; set; } = new List<SiparisDetay>();
        public string ToplamTutarTL { get { return ToplamTutar().ToString("c2"); } } /*=> ToplamTutar().ToString("c2")*/
        public decimal ToplamTutar()
        {
            return SiparisDetaylar.Sum(sd => sd.Tutar());
        }
    }
}
