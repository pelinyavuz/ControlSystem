using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NursanModel.Model
{
    public class Lot

    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int SuppliersId { get; set; }
        public string LotValue { get; set; }

        public virtual Suppliers Suppliers { get; set; }
        public ICollection<CopperControl> CopperControl { get; set; }
        public ICollection<PVCControl> PVPControl { get; set; }
    }
}
