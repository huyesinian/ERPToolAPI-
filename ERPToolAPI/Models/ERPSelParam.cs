using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ERPToolAPI.Models
{
    /// <summary>
    /// 个别参数
    /// </summary>
    public class ERPSelParam
    {
       
        /// <summary>
        /// 标准单位
        /// </summary>
        public string u_m { get; set; }

        /// <summary>
        /// 辅助单位
        /// </summary>
        public string Uf_Trade_UM { get; set; }


    }

    public class ERPSelManager
    {

        /// <summary>
        /// 审核人员
        /// </summary>
        public string manager { get; set; }


    }
}
