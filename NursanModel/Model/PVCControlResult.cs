using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NursanModel.Model
{
    public class PVCControlResult
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int CapleId { get; set; }
        public bool PVCState { get; set; }


        public virtual Cable Cable { get; set; }
        public ICollection<PVCControl> PVPControl { get; set; }


    }
}
