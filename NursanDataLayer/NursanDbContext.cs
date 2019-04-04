using NursanModel.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NursanDataLayer
{
    public class NursanDbContext :DbContext
    {
        public NursanDbContext()
               : base("NursanKabloDatabase")
        {
        }

        public virtual DbSet<Cable> Cable { get; set; }
        public virtual DbSet<CopperControl> CopperControl { get; set; }
        public virtual DbSet<CopperEntry> CopperEntry { get; set; }
        public virtual DbSet<CopperStandarts> CopperStandarts { get; set; }
        public virtual DbSet<Lot> Lot { get; set; }
        public virtual DbSet<PVCControl> PVCControl { get; set; }
        public virtual DbSet<PVCControlResult> PVCControlResult { get; set; }
        public virtual DbSet<Suppliers> Suppliers { get; set; }







        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {


        }
    }
}
