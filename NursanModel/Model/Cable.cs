using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NursanModel.Model
{
    public class Cable
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string ProducerName { get; set; }
        public int Section { get; set; }
        public int ColorType { get; set; }
        public string MasterColor { get; set; }
        public string LineColor { get; set; }
        public string ControlCode { get; set; }
    }
}
