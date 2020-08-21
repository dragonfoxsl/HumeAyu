<%@ Page Title="" Language="VB" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="false" CodeFile="AdminMain.aspx.vb" Inherits="Admin_AdminMain" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ImageButton ID="ImgbtnVal" runat="server" Height="47px" 
        ImageUrl="~/Images/Admin/docVal.png" Width="240px" /><br /><br />
    <asp:ImageButton ID="ImgbtnPlants" runat="server" Height="47px" 
        ImageUrl="~/Images/Admin/medPlants.png" Width="240px" /><br /><br />
    <asp:ImageButton ID="ImgbtnPay" runat="server" Height="47px" 
        ImageUrl="~/Images/Admin/pay.png" Width="240px" /><br /><br />
    <asp:ImageButton ID="ImgbtnAdd" runat="server" Height="47px" 
        ImageUrl="~/Images/Admin/add.png" Width="240px" /><br /><br />
    <br /><br />
</asp:Content>

