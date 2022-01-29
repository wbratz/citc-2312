<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="XEx02Quotation.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Price quotation</title>
    <style type="text/css">
        .auto-style1 {
            width: 193px;
        }
        .auto-style2 {
            width: 139px;
        }
        .auto-style3 {
            width: 139px;
            height: 29px;
        }
        .auto-style4 {
            width: 193px;
            height: 29px;
        }
        .auto-style5 {
            height: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Price quotation</h1>
        <table>
            <tr>
                <td class="auto-style2">
                    Sales price
                </td>
                <td class="auto-style1">
                    <asp:TextBox ID="Sales_Price_Textbox" runat="server" Font-Bold="True"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Sales_Price_Textbox" ErrorMessage="Required"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="Sales_Price_Textbox" ErrorMessage="Price must be within 10 - 1000" MaximumValue="1000" MinimumValue="10"></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style1"></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Discount percent</td>
                <td class="auto-style1">
                    <asp:TextBox ID="Discount_Percent_textbox" runat="server"></asp:TextBox>
                    <textbox/></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Discount_Percent_textbox" ErrorMessage="Required"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="Discount_Percent_textbox" ErrorMessage="Discount % must be within 10-50" MaximumValue="50" MinimumValue="10"></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Discount amount</td>
                <td class="auto-style1">
                    <asp:Label ID="Discount_Amount_Label" runat="server" Font-Bold="True"></asp:Label>
                </td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style1"></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style2">Total price</td>
                <td class="auto-style1">
                    <asp:Label ID="Total_Price_Label" runat="server" Font-Bold="True"></asp:Label>
                </td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style2">
                    &nbsp;</td>
                <td class="auto-style1"></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Calculate" />
                </td>
                <td class="auto-style4"></td>
                <td class="auto-style5"></td>
            </tr>
        </table>
    </form>
</body>
</html>
