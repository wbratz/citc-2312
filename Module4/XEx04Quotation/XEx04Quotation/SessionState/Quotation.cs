using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XEx04Quotation.SessionState
{
    public class Quotation
    {
        public decimal? SalesPrice { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? TotalPrice { get; set; }

        public static Quotation GetQuotation()
        {
            Quotation quotation = (Quotation)HttpContext.Current.Session["Quotation"];
            if (quotation == null)
            {
                HttpContext.Current.Session["Quotation"] = new Quotation();
            }

            return (Quotation)HttpContext.Current.Session["Quotation"];
        }

        public void ResetValues()
        {
            SalesPrice = null;
            DiscountAmount = null;
            TotalPrice = null;
        }
    }
}