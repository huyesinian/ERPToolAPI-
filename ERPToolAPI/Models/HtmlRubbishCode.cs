using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using Microsoft.EntityFrameworkCore;

namespace ERPToolAPI.Models
{
    /// <summary>
    /// 垃圾查询方式存放处
    /// </summary>
    public class HtmlRubbishCode
    {
        public ERPToolContext _context;
        public HtmlRubbishCode(ERPToolContext context)
        {
            _context = context;
        }
        /// <summary>
        /// 根据客户编码查询退货单信息
        /// </summary>
        /// <param name="custno">客户编码</param>
        /// <param name="slsno">物料号</param>
        /// <param name="s1">开始时间</param>
        /// <param name="e1">结束时间</param>
        /// <param name="trans_num">处理号</param>
        /// <returns></returns>
        public List<ERPSalesTemporary> GetSearchSlsInfo(string custno = "", string slsno = "", string s1 = "", string e1 = "", string trans_num = "")
        {
            var sales = new List<ERPSalesTemporary>();
            var sql = "select * from  MeiXin.dbo.V_Matltran_Coi_lot a where 1=1 ";
            try
            {
                if (custno != null)
                {
                    sql += " and  a.cust_num='" + custno + "'";
                }
                if (slsno != null)
                {
                    sql += " and  item like '%" + slsno + "%'";
                }
                if (s1 != null)
                {
                    sql += " and  trans_date>='" + s1 + "'";
                }
                if (e1 != null)
                {
                    sql += " and  trans_date<='" + e1 + "'";
                }
                if (trans_num != null)
                {
                    sql += " and  trans_num like '%" + trans_num + "%'";
                }
                return sales = _context.ERPSalesTemporary.FromSqlRaw(sql).ToList();
            }
            catch (Exception ex)
            {
                return sales;
            }

        }

        /// <summary>
        /// 客服用户信息
        /// </summary>
        /// <param name="userid">用户ID</param>
        /// <returns></returns>
        public List<ERPCustUserInfo> GetCust_User_Info()
        {

            var sql = "select cust_num,slsmanid,UserDesc,description from  Meixin.dbo.V_Cust_User_Sls where slsmanid is not null";
            return _context.ERPCustUserInfo.FromSqlRaw(sql).ToList();

        }

        /// <summary>
        /// 获取物料信息集合
        /// </summary>
        /// <param name="itemNo"></param>
        /// <returns></returns>
        public List<ERPItem> GetMaterialList()
        {
            string sql = "select * from  MeiXin.dbo.item where stat='A'";
            return _context.ERPItem.FromSqlRaw(sql).ToList();
        }

        /// <summary>
        /// 获取销售料号对照表
        /// </summary>
        /// <param name="type">类型</param>
        /// <param name="depart">部门</param>
        /// <param name="username">用户名</param>
        /// <returns></returns>
        public List<ECRSalesManage> GetECRSalesManage(string type, string depart, string username)
        {
            string sql="";

            switch (type)
            {
                case "0":
                    sql = "select distinct(SalesNo)from MeiXin.dbo.SalesManage order by SalesNo";
                    break;
                case "1":
                    sql = " select distinct(SalesNo)from MeiXin.dbo.SalesManage where Depart = " + depart + " order by SalesNo";
                    break;
                case "2":
                    sql = "select distinct(SalesNo) from MeiXin.dbo.SalesManage where SalesApplicantPreo = " + username + " order by SalesNo";
                    break;
            }
            return _context.ECRSalesManage.FromSqlRaw(sql).ToList();
        }

        /// <summary>
        /// 获取库存信息
        /// </summary>
        /// <param name="item">物料</param>
        /// <param name="batch">批次</param>
        /// <param name="freightSpace">仓位</param>
        /// <returns></returns>
        public List<ERPItemLot> GetERPItemLot(string item = "", string batch = "", string freightSpace = "")
        {
            string sql = "select * from   MeiXin.dbo.View_ItemLotOA WHERE 1=1 and qty_on_hand>0.1";
            if (item.Length>0)
            {
                sql += " and  item like '%" + item + "%'";
            }
            if (batch.Length > 0)
            {
                sql += " and  lot='" + batch + "'";
            }
            if (freightSpace.Length > 0)
            {
                sql += " and  whse='" + freightSpace + "'";
            }
            return _context.ERPItemLot.FromSqlRaw(sql).ToList();
        }


        /// <summary>
        /// 获取仓库信息
        /// </summary>
        /// <returns></returns>
        public List<ERPWhse> GetERPWhse()
        {
            string sql = "select * from   MeiXin.dbo.whse";
            return _context.ERPWhse.FromSqlRaw(sql).ToList();
        }

        /// <summary>
        /// 获取供应商信息
        /// </summary>
        /// <returns></returns>
        public List<ERCVendor> GetERCVendor()
        {
            string sql = "select * from   MeiXin.dbo.Vendor ";
            return _context.ERCVendor.FromSqlRaw(sql).ToList();
        }

        /// <summary>
        /// 相关的料号信息
        /// </summary>
        /// <returns></returns>
        public List<ERPJob> GetERPJob(string no)
        {
            string sql = "select ord_line,ord_num,item from   MeiXin.dbo.job where job = '" + no + "'";
            return _context.ERPJob.FromSqlRaw(sql).ToList();
        }


        /// <summary>
        /// 获取订单号
        /// </summary>
        /// <param name="no"></param>
        /// <returns></returns>
        public List<ERPco> GetERPco(string no)
        {
            string sql = "select cust_po from   MeiXin.dbo.co where co_num='" + no + "'";
            return _context.ERPco.FromSqlRaw(sql).ToList();
        }

        /// <summary>
        /// 成品出货单使用1
        /// </summary>
        /// <param name="no"></param>
        /// <returns></returns>
        public List<ERPLots> GetERPLots(string jNo, string oNo, string lNo)
        {
            string sql = "select lot,Uf_Co_Num,Uf_Co_Line,item from   MeiXin.dbo.lot where Uf_Ref_Num='" + jNo + "' and Uf_Co_Num='" + oNo + "' and Uf_Co_Line=" + lNo + "";
            return _context.ERPLots.FromSqlRaw(sql).ToList();
        }

        /// <summary>
        /// 成品出货单使用2
        /// </summary>
        /// <param name="no"></param>
        /// <returns></returns>
        public List<ECRCoitem> GetERPCoitem(string oNo, string lNo)
        {
            string sql = "select * from   MeiXin.dbo.coitem where co_num='" + oNo + "' and co_line=" + lNo + "";
            return _context.ECRCoitem.FromSqlRaw(sql).ToList();
        }

        /// <summary>
        /// 通过客户编码和物料编码获取标准单位和辅助单位
        /// </summary>
        /// <param name="cc">客户编码</param>
        /// <param name="mc">物料编码</param>
        /// <returns></returns>
        public List<ERPSelParam> GetERPSelParam(string cc, string mc)
        {
            string sql = "select top 1 u_m,Uf_Trade_UM from  MeiXin.dbo.Itemcust left join  MeiXin.dbo.custaddr on itemcust.cust_num = custaddr.cust_num and len(custaddr.credit_hold_reason)<= 0 where Itemcust.item = '" + mc + "' and Itemcust.cust_num = '" + cc + "'";
            return _context.ERPSelParam.FromSqlRaw(sql).ToList();
        }


        /// <summary>
        ///  获取退货单节点1的审核人
        /// </summary>
        /// <param name="custNum"></param>
        /// <returns></returns>
        public ERPSelManager GetERPSelParam(string custNum)
        {
            string sql = "select v.manager from MeiXin.dbo.customer as c join Func_SalesReturnV as v on c.end_user_type=v.end_user_type where c.cust_num='" + custNum + "'";
            return _context.ERPSelManager.FromSqlRaw(sql).FirstOrDefault();
        }

    }
}
