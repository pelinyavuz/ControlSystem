using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NursanModel.Model
{
    public class CopperControl
    {
         [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }
            public int LodId { get; set; }
            public int SuppliersId { get; set; }
            public int CopperEntryId { get; set; }
            public int CopperStandartId { get; set; }
            public bool CopperState { get; set; }
            public DateTime CopperDate { get; set; }

            public virtual Lot Lot { get; set; }
            public virtual Suppliers Suppliers { get; set; }
            public virtual CopperEntry CopperEntry { get; set; }
            public virtual CopperStandarts CopperStandarts { get; set; }
}
}
