using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ERPToolAPI.Models
{
    /// <summary>
    /// ERP仓库的信息
    /// </summary>
    public class ERPWhse
    {
        public string whse { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string country { get; set; }
        public string contact { get; set; }
        public string phone { get; set; }
        public string fax_num { get; set; }
        public byte? phy_inv_flg { get; set; }
        public string cycle_type { get; set; }
        public Int16? cycle_freq { get; set; }
        public byte? logifld { get; set; }
        public DateTime? datefld { get; set; }
        [NotMapped]
        public string addr1 { get; set; }
        [NotMapped]
        public string addr2 { get; set; }
        [NotMapped]
        public string addr3 { get; set; }
        [NotMapped]
        public string addr4 { get; set; }
        public byte? NoteExistsFlag { get; set; }
        public DateTime? RecordDate { get; set; }
        public System.Guid RowPointer { get; set; }
        public string charfld1 { get; set; }
        public string charfld2 { get; set; }
        public string charfld3 { get; set; }
        public decimal decifld1 { get; set; }
        public decimal decifld2 { get; set; }
        public decimal decifld3 { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public byte? InWorkflow { get; set; }
        public string process_ind { get; set; }
        public string trans_nat { get; set; }
        public string trans_nat_2 { get; set; }
        public string delterm { get; set; }
        public string transport { get; set; }
        public string tax_reg_num1 { get; set; }
        public byte? dedicated_inventory { get; set; }

    }
}
