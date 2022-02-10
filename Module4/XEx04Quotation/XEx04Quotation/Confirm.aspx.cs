using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using XEx04Quotation.SessionState;

namespace XEx04Quotation
{
    public partial class Confirm : System.Web.UI.Page
    {
        private Quotation _quotation;

        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            _quotation = Quotation.GetQuotation();

            lblSalesPrice.Text = _quotation.SalesPrice?.ToString("c");
            lblTotalPrice.Text = _quotation.TotalPrice?.ToString("c");
            lblDiscountAmount.Text = _quotation.DiscountAmount?.ToString("c");
        }

        protected void btnSendQuote_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                lblMessage.Text = $"Quotation sent to {txtName.Text} at {txtEmail.Text}";
                var quote = Quotation.GetQuotation();

                quote.ResetValues();
            }
        }
    }
}