using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ERPToolAPI.Models
{
    /// <summary>
    /// 供应商信息
    /// </summary>
    public class ERCVendor
    {
       
        public string vend_num { get; set; }
        public string contact { get; set; }
        public string phone { get; set; }
        public string vend_type { get; set; }
        public string terms_code { get; set; }
        public string ship_code { get; set; }
        public string fob { get; set; }
        public byte? print_price { get; set; }
        public string stat { get; set; }
        public DateTime? last_purch { get; set; }
        public DateTime? last_paid { get; set; }
        public decimal? purch_ytd { get; set; }
        public decimal? purch_lst_yr { get; set; }
        public decimal? disc_ytd { get; set; }
        public decimal? disc_lst_yr { get; set; }
        public decimal? pay_ytd { get; set; }
        public string vend_remit { get; set; }
        public string whse { get; set; }
        public string charfld1 { get; set; }
        public string charfld2 { get; set; }
        public string charfld3 { get; set; }
        public decimal? decifld1 { get; set; }
        public decimal? decifld2 { get; set; }
        public decimal? decifld3 { get; set; }
        public byte? logifld { get; set; }
        public DateTime? datefld { get; set; }
        public string curr_code { get; set; }
        public string tax_reg_num1 { get; set; }
        public string bank_code { get; set; }
        public string pay_type { get; set; }
        public decimal? pay_lst_yr { get; set; }
        public byte? edi_vend { get; set; }
        public string branch_id { get; set; }
        public string trans_nat { get; set; }
        public string delterm { get; set; }
        public string process_ind { get; set; }
        public string tax_reg_num2 { get; set; }
        public string tax_code1 { get; set; }
        public string tax_code2 { get; set; }
        public string lang_code { get; set; }
        public string pur_acct { get; set; }
        public string pur_acct_unit1 { get; set; }
        public string pur_acct_unit2 { get; set; }
        public string pur_acct_unit3 { get; set; }
        public string pur_acct_unit4 { get; set; }
        public byte? lcr_reqd { get; set; }
        public string category { get; set; }
        public byte? NoteExistsFlag { get; set; }
        public DateTime? RecordDate { get; set; }
        public System.Guid RowPointer { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public byte? InWorkflow { get; set; }
        public string account { get; set; }
        public string account_name { get; set; }
        public string EFT_bank_num { get; set; }
        public byte? print_vat_on_po { get; set; }
        public string price_by { get; set; }
        public byte? include_tax_in_cost { get; set; }
        public string trans_nat_2 { get; set; }
        public byte? active_for_data_integration { get; set; }
        public decimal? vch_over_po_cost_tolerance { get; set; }
        public decimal? vch_under_po_cost_tolerance { get; set; }
        public decimal? pay_fiscal_ytd { get; set; }
        public decimal? pay_lst_fiscal_yr { get; set; }
        public int? transit { get; set; }
        public byte? supply_web_vendor { get; set; }
        public byte? request_acknowledgement { get; set; }
        public byte? synchronized_to_bus { get; set; }
        public byte? show_in_drop_down_list { get; set; }
        public string Uf_BankAccount { get; set; }
        public string Uf_BankAccountName { get; set; }
        public string Uf_BankNo { get; set; }

    }
}
