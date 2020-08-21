<%@ Page Title="" Language="VB" MasterPageFile="~/Start.master" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width="100%" border="0" class="BodyBackStart">
  <tr>
    <td>
    <div align="center">
    <asp:Image ID="ImgMain" runat="server" ImageUrl="~/Images/HumeAyu.png" 
        AlternateText="HumeAyu" Height="395px" Width="1154px" />
    </div>
    </td>
  </tr>
  <tr>
    <td>
    <div align="center">
    <asp:Image ID="ImgLoading" runat="server" ImageUrl="~/Animations/Loading.gif" 
        Height="55px" Width="59px" /><br />
    <asp:Label ID="lblLoading" runat="server" Text="Loading..." Font-Bold="true"></asp:Label><br />
    </div>
    </td>
  </tr>
  <tr>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td>
    <div align="center">
    <asp:ImageButton ID="ImgbtnEnter" runat="server" 
        ImageUrl="~/Images/Buttons/Enter.png" AlternateText="Enter" Height="40px" 
        Width="165px" />
    </div>
    </td>
  </tr>  
</table>
</asp:Content>

