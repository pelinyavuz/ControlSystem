using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NursanModel.Model
{
    public class PVCControl
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int LotId { get; set; }
        public int SuppliersId { get; set; }
        public int PVCQuantity { get; set; }
        public bool PVCControlResultId { get; set; }
        public bool PVCState { get; set; }

        public virtual Lot Lot { get; set; }
        public virtual PVCControlResult PVCControlResult { get; set; }
    }
}
