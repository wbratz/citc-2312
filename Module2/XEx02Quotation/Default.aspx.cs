using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XEx02Quotation
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {
                var discountAmount = int.Parse(Sales_Price_Textbox.Text) * (float.Parse(Discount_Percent_textbox.Text) / 100);
                Discount_Amount_Label.Text = discountAmount.ToString();
                Total_Price_Label.Text = (int.Parse(Sales_Price_Textbox.Text) - discountAmount).ToString();
            }
        }
    }
}