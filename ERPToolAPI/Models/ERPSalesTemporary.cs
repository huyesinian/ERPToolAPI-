using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ERPToolAPI.Models
{
    /// <summary>
    /// 查询客退信息
    /// </summary>
    public class ERPSalesTemporary
    {
        /// <summary>
        /// 类型
        /// </summary>
        [NotMapped]
        public string trans_type { get; set; }
        /// <summary>
        /// 处理号
        /// </summary>
        public decimal trans_num { get; set; }
        /// <summary>
        /// 处理日期
        /// </summary>
        public DateTime trans_date { get; set; }
        /// <summary>
        /// 物料
        /// </summary>
        public string item { get; set; }
        /// <summary>
        /// 主单位数量
        /// </summary>
        public decimal qty { get; set; }
        /// <summary>
        /// 订单号
        /// </summary>
        public string co_num { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ref_num { get; set; }

        /// <summary>
        /// 订单行
        /// </summary>
        public Nullable<Int16> co_line { get; set; }

        /// <summary>
        /// 仓库
        /// </summary>
        public string whse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string loc { get; set; }

        /// <summary>
        /// 批号
        /// </summary>
        public string lot { get; set; }

        /// <summary>
        /// 物料说明
        /// </summary>
        public string itmDsc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// 长
        /// </summary>
        public decimal? Uf_Length { get; set; }
        /// <summary>
        /// 宽
        /// </summary>
        public decimal? Uf_Width { get; set; }
        /// <summary>
        /// 片长
        /// </summary>
        public decimal? Uf_Length2 { get; set; }

        /// <summary>
        /// 客户
        /// </summary>
        public string cust_num { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Nullable<int> cust_seq { get; set; }

        /// <summary>
        /// 主单位
        /// </summary>
        public string u_m { get; set; }

        /// <summary>
        /// 结算单位
        /// </summary>
        public string Uf_Trade_UM { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal Uf_Trade_Qty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal qty_ordered { get; set; }

        /// <summary>
        /// 结算单位数量
        /// </summary>
        public decimal qtyCon { get; set; }


        /// <summary>
        /// 单价
        /// </summary>
        public Nullable<decimal> price { get; set; }

    }
}
