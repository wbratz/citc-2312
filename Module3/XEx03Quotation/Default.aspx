<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html class="control-label" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Price quotation</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/Site.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.4.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <main class="container">
            <h1 class="jumbotron">Price quotation</h1>
            <div class="form-group row">
                <span id="salesPriceLabel" class="col-3">Sales price</span>
                <asp:TextBox ID="Sales_Price_Textbox" CssClass="col-6 form-control bold" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Sales_Price_Textbox" ErrorMessage="Required"></asp:RequiredFieldValidator>
                <asp:RangeValidator ID="RangeValidator1" runat="server" Type="Double" Display="Dynamic" CssClass="text-danger" ControlToValidate="Sales_Price_Textbox" ErrorMessage="Price must be within 10 - 1000" MaximumValue="1000" MinimumValue="10"></asp:RangeValidator>
            </div>
            <div class="form-group row">
                <span id="discountPercentLabel" class="col-3">Discount percent</span>
                <asp:TextBox ID="Discount_Percent_textbox" CssClass="col-6 form-control bold" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Discount_Percent_textbox" ErrorMessage="Required"></asp:RequiredFieldValidator>
                <asp:RangeValidator ID="RangeValidator2" Type="Double" Display="Dynamic" runat="server" CssClass="text-danger" ControlToValidate="Discount_Percent_textbox" ErrorMessage="Discount % must be within 10-50" MaximumValue="50" MinimumValue="10"></asp:RangeValidator>
            </div>
            <div class="form-group row">
                <span id="discountAmount" class="col-3">Discount Amount</span>
                <asp:Label ID="Discount_Amount_Label" CssClass="col-6 bold" runat="server" Font-Bold="False"></asp:Label>
            </div>
            <div class="form-group row">
                <span id="totalPrice" class="col-3">Total Price</span>
                <asp:Label ID="Total_Price_Label" CssClass="col-6 bold" runat="server" Font-Bold="False"></asp:Label>
            </div>
            <div class="form-group row">
                <asp:Button ID="Button1" CssClass="col-3 offset-3 btn btn-primary" runat="server" OnClick="Button1_Click" Text="Calculate" />
            </div>


             
                    
                    
                    
        </main>
    </form>
</body>
</html>

