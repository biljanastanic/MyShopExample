<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShopPage.aspx.cs" Inherits="myShopNet.ShopPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="Style/style.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:scriptmanager ID="Scriptmanager1" runat="server"/>
    <div>
        <div>
            <div>
            <div class="shopList">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <Triggers >
                        <asp:AsyncPostBackTrigger ControlID="ShopListLB" />
                    </Triggers>
                    <ContentTemplate>
                        <asp:ListBox ID="ShopListLB" runat="server" AutoPostBack="True" CssClass="list"></asp:ListBox>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
           
           <div class="button">
                <div >
                    <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                        <ContentTemplate>
                            <asp:Button ID="AddBtn" runat="server" Text="-&gt;" onclick="AddBtn_Click" />
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>

                <div >
                    <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                        <ContentTemplate>
                            <asp:Button ID="RemoveBtn" runat="server" Text="&lt;-" 
                                onclick="RemoveBtn_Click" />
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
            </div>
            <div class="cartList">
                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                    <Triggers >
                        <asp:AsyncPostBackTrigger ControlID="CartListLB" />
                    </Triggers>
                    <ContentTemplate>
                        <asp:ListBox ID="CartListLB" runat="server" AutoPostBack="True" CssClass="list"></asp:ListBox>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>   
        </div>
        </div>
        <p>
        <div class="buyButton">
        <asp:UpdatePanel ID="UpdatePanel5" runat="server">
            <ContentTemplate>
                <asp:Button ID="BuyBtn" runat="server" Text="Buy" onclick="BuyBtn_Click" />
            </ContentTemplate>
        </asp:UpdatePanel>
        </p>
    </div>
    </div>
    </form>
</body>
</html>
