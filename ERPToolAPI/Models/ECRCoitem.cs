using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ERPToolAPI.Models
{
    /// <summary>
    /// 成品出货单用
    /// </summary>
    public class ECRCoitem
    {
        
        public string Item { get; set; }
        public Int16? Co_line { get; set; }
        public string Co_num { get; set; }
        public string Co_cust_num { get; set; }
        public string Description { get; set; }
        public decimal? Uf_Width { get; set; }
        public decimal? Uf_Length { get; set; }
        public decimal? Uf_Length2 { get; set; }
        public string Cust_item { get; set; }
        public decimal? Qty_ordered { get; set; }
        public DateTime? Due_date { get; set; }
        public DateTime? Projected_date { get; set; }
        public string U_m { get; set; }
        public string Uf_Sales_Item { get; set; }
        public decimal? Uf_Trade_Qty { get; set; }
        public string Uf_Trade_UM { get; set; }
    }
}
