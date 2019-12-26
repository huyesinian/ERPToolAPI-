using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ERPToolAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;

namespace ERPToolAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesTemporaryController : ControllerBase
    {
        public ERPToolContext _context;
        public HtmlRubbishCode _rubbishCode;
        public SalesTemporaryController(ERPToolContext context)
        {
            _rubbishCode = new HtmlRubbishCode(context);
            _context = context;
        }


        /// <summary>
        /// 获取退货信息
        /// </summary>
        /// <param name="cust_num"></param>
        /// <param name="item"></param>
        /// <param name="sDateTime"></param>
        /// <param name="eDateTime"></param>
        /// <param name="tNo"></param>
        /// <returns></returns>
        [HttpGet("GetSalesT")]
        public ActionResult<List<ERPSalesTemporary>> GetSalesT(string cust_num, string item, string sDateTime, string eDateTime, string tNo)
        {
            var resultT = _rubbishCode.GetSearchSlsInfo(cust_num, item, sDateTime, eDateTime, tNo);
            if (resultT == null)
            {
                return NotFound();
            }

            return resultT;
        }

        /// <summary>
        /// 根据用户名获取用户代码
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetCust_nums")]
        public ActionResult<List<string>> GetCust_nums(string userId)
        {
            var resultT = _rubbishCode.GetCust_User_Info();
            if (resultT == null)
            {
                return NotFound();
            }
            var Cust_nums = resultT.Where(x => x.slsmanid == userId).Select(x => x.cust_num).Distinct().ToList();
            if (Cust_nums == null)
            {
                return NotFound();
            }
            return Cust_nums;
        }

        /// <summary>
        /// 根据用户名获取客服信息
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetUserDescs")]
        public ActionResult<List<string>> GetUserDescs(string userId)
        {
            var resultT = _rubbishCode.GetCust_User_Info();
            if (resultT == null)
            {
                return NotFound();
            }
            var Cust_nums = resultT.Where(x => x.slsmanid == userId).Select(x => x.UserDesc).Distinct().ToList();
            if (Cust_nums == null)
            {
                return NotFound();
            }
            return Cust_nums;
        }

        /// <summary>
        /// 获取所有的用户代码和客服信息
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetCUI")]
        public ActionResult<List<ERPCustUserInfo>> GetCUI()
        {
            var resultT = _rubbishCode.GetCust_User_Info();
            if (resultT == null)
            {
                return NotFound();
            }
            return resultT;
        }

        /// <summary>
        /// 获取物料相关信息
        /// </summary>
        /// <param name="itemNo"></param>
        /// <returns></returns>
        [HttpGet("GetMaterial")]
        public ActionResult<List<string>> GetMaterial(string itemNo = null)
        {
            var resultT = _rubbishCode.GetMaterialList();
            var endResult = new List<string>();
            if (resultT == null)
            {
                return NotFound();
            }
            if (itemNo == null)
            {
                endResult = resultT.Select(x => x.item).Distinct().ToList();
                if (endResult == null)
                {
                    return NotFound();
                }
            }
            else
            {
                endResult = resultT.Where(x => x.item == itemNo).Select(x => x.description).Distinct().ToList();
                if (endResult == null)
                {
                    return NotFound();
                }
            }

            return endResult;
        }

        /// <summary>
        /// 获取物料编码集合
        /// </summary>
        /// <param name="itemNo"></param>
        /// <returns></returns>
        [HttpGet("GetMaterialList")]
        public ActionResult<List<string>> GetMaterialList(string itemNo)
        {
            var resultT = _rubbishCode.GetMaterialList();
            var endResult = resultT.Where(x => x.item.Contains(itemNo)).Select(x => x.item).Distinct().ToList();
            if (endResult == null)
            {
                return NotFound();
            }
            return endResult;
        }

        /// <summary>
        /// 查询SWR中物料信息
        /// </summary>
        /// <param name="itemNo"></param>
        /// <returns></returns>
        [HttpGet("GetSWRMaterial")]
        public ActionResult<List<ERPItem>> GetSWRMaterial(string itemNo)
        {
            var resultT = _rubbishCode.GetMaterialList();
            resultT = resultT.Where(x => x.item == itemNo).ToList();
            if (resultT == null)
            {
                return NotFound();
            }
            return resultT;
        }

        /// <summary>
        /// 查询物料库存信息
        /// </summary>
        /// <param name="item">物料</param>
        /// <param name="batch">批次</param>
        /// <param name="freightSpace">仓位</param>
        /// <returns></returns>
        [HttpGet("GetItemLot")]
        public ActionResult<List<ERPItemLot>> GetItemLot(string item = "", string batch = "", string freightSpace = "")
        {
            var resultT = _rubbishCode.GetERPItemLot(item, batch, freightSpace);
            if (resultT == null)
            {
                return NotFound();
            }
            return resultT;
        }

        /// <summary>
        /// 查询仓库信息
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetERPWhse")]
        public ActionResult<List<ERPWhse>> GetERPWhse()
        {
            var resultT = _rubbishCode.GetERPWhse();
            if (resultT == null)
            {
                return NotFound();
            }
            return resultT;
        }

        /// <summary>
        /// 查询供应商信息
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetERCVendor")]
        public ActionResult<List<ERCVendor>> GetERCVendor()
        {
            var resultT = _rubbishCode.GetERCVendor();
            if (resultT == null)
            {
                return NotFound();
            }
            return resultT;
        }

        /// <summary>
        /// 通过工单号获取订单号和行号,还有主料号
        /// </summary>
        /// <param name="no">工单号</param>
        /// <returns></returns>
        [HttpGet("GetERPJob")]
        public ActionResult<List<ERPJob>> GetERPJob(string no)
        {
            var resultT = _rubbishCode.GetERPJob(no);
            if (resultT == null)
            {
                return NotFound();
            }
            return resultT;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        [HttpGet("GetERPco")]
        public ActionResult<List<ERPco>> GetERPco(string num)
        {
            var resultT = _rubbishCode.GetERPco(num);
            if (resultT == null)
            {
                return NotFound();
            }
            return resultT;
        }

        /// <summary>
        /// 成品出货单需要
        /// </summary>
        /// <param name="oNo">订单号</param>
        /// <param name="lNo">行号</param>
        /// <returns></returns>
        [HttpGet("GetECRCoitem")]
        public ActionResult<List<ECRCoitem>> GetECRCoitem(string oNo, string lNo)
        {
            var resultT = _rubbishCode.GetERPCoitem(oNo, lNo);
            if (resultT == null)
            {
                return NotFound();
            }
            return resultT;
        }

        /// <summary>
        /// 成品出货单需要
        /// </summary>
        /// <param name="jNo">工单号</param>
        /// <param name="oNo">订单号</param>
        /// <param name="lNo">行号</param>
        /// <returns></returns>
        [HttpGet("GetERPLots")]
        public ActionResult<List<ERPLots>> GetERPLots(string jNo, string oNo, string lNo)
        {
            var resultT = _rubbishCode.GetERPLots(jNo,oNo, lNo);
            if (resultT == null)
            {
                return NotFound();
            }
            return resultT;
        }


        /// <summary>
        /// 通过客户编码和物料编码获取标准单位和辅助单位
        /// </summary>
        /// <param name="cc">客户编码</param>
        /// <param name="mc">物料编码</param>
        /// <returns></returns>
        [HttpGet("GetERPSelParams")]
        public ActionResult<List<ERPSelParam>> GetERPSelParams(string cc, string mc)
        {
            var resultT = _rubbishCode.GetERPSelParam(cc, mc);
            if (resultT == null)
            {
                return NotFound();
            }
            return resultT;
        }



        /// <summary>
        /// 获取销售料号对照表
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetSalesManages")]
        public ActionResult<List<string>> GetSalesManages(string type, string depart, string username)
        {
            var resultT = _rubbishCode.GetECRSalesManage(type, depart, username);
            if (resultT == null)
            {
                return NotFound();
            }
            var endResult = resultT.Select(x => x.SalesNo).ToList();
            return endResult;

        }

        /// <summary>
        /// 获取审核人员信息
        /// </summary>
        /// <param name="custNum"></param>
        /// <returns></returns>
        [HttpGet("GetERPSelManager")]
        public ActionResult<ERPSelManager> GetERPSelManager(string custNum)
        {
            var resultT = _rubbishCode.GetERPSelParam(custNum);
            if (resultT == null)
            {
                return NotFound();
            }
            return resultT;
        }





    }
}