using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ERPToolAPI.Models
{
    /// <summary>
    /// 获取行号和主料号
    /// </summary>
    public class ERPJob
    {
        /// <summary>
        /// 主料号
        /// </summary>
        public string item { get; set; }


        public Int16 ord_line { get; set; }

        public string ord_num { get; set; }

    }
}
