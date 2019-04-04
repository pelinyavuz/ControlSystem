using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NursanModel.Model
{
    public class CopperStandarts
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string UrunKodu { get; set; }
        public float AnmaKesit { get; set; }
        public string Kesit { get; set; }
        public int TelSayisi { get; set; }
        public float Cap { get; set; }
        public float MinDirenc { get; set; }
        public float MaxDirenc { get; set; }
        public float MaxBukuluCap { get; set; }
        public float MinHatveBoy { get; set; }
        public float MaxHatveBoy { get; set; }
        public float BirimAgırlık { get; set; }
        public ICollection<CopperControl> CopperControl { get; set; }
    }
}
