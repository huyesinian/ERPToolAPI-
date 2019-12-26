using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ERPToolAPI.Models
{
    /// <summary>
    /// 物料库存
    /// </summary>
    public class ERPItemLot
    {
        public string lot { get; set; }
        public string loc { get; set; }
        public string item { get; set; }
        public string whse { get; set; }
        public byte NoteExistsFlag { get; set; }
        public System.Guid RowPointer { get; set; }
        public byte InWorkflow { get; set; }
        public string cert_num { get; set; }
        public decimal Uf_QtyCon { get; set; }
        public decimal Uf_Length { get; set; }
        public decimal Uf_Width { get; set; }
        public decimal Uf_Length2 { get; set; }
        public decimal Uf_UnitWeight { get; set; }
        public string Uf_Note { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string loc_description { get; set; }
        public string u_m { get; set; }
        public decimal qty_on_hand_sum { get; set; }
        public string issue_by { get; set; }
        public decimal qty_rsvd_co_sum { get; set; }
        public decimal qty_mrb_sum { get; set; }
        public byte serial_tracked { get; set; }
        public string cost_method { get; set; }
        public decimal qty_on_hand { get; set; }
        public decimal qty_rsvd { get; set; }
        public decimal unit_cost { get; set; }
        public decimal cost_qtyOnHand_sum { get; set; }
        public decimal matl_cost { get; set; }
        public decimal lbr_cost { get; set; }
        public decimal fovhd_cost { get; set; }
        public decimal vovhd_cost { get; set; }
        public decimal out_cost { get; set; }
        public decimal cost_sum { get; set; }
        public string cost_type { get; set; }
        public byte cnt_in_proc { get; set; }
        public byte phy_inv_flg { get; set; }
        public DateTime RecordDate { get; set; }

    }
}
