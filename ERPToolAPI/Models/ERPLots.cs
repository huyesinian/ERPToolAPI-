using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ERPToolAPI.Models
{
    /// <summary>
    /// 成品需要的表
    /// </summary>
    public class ERPLots
    {
        /// <summary>
        /// 批次
        /// </summary>
        public string Lot { get; set; }
        public string Uf_Co_Num { get; set; }
        public Int16 Uf_Co_Line { get; set; }
        public string Item { get; set; }
    }
}
