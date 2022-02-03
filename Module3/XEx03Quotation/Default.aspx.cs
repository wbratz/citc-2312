using System;
using System.Web.UI;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            var discountAmount = float.Parse(Sales_Price_Textbox.Text) * (float.Parse(Discount_Percent_textbox.Text) / 100);
            Discount_Amount_Label.Text = discountAmount.ToString();
            Total_Price_Label.Text = (float.Parse(Sales_Price_Textbox.Text) - discountAmount).ToString();
        }
    }
}