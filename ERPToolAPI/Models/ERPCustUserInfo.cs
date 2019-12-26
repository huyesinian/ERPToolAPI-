using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ERPToolAPI.Models
{
    /// <summary>
    /// 客服用户信息
    /// </summary>
    public class ERPCustUserInfo
    {
        
        public string cust_num { get; set; }
       
      
        public string slsmanid { get; set; }
        
        public string UserDesc { get; set; }
      
        public string description { get; set; }
       

    }
}
