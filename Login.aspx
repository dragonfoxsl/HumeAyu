<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Login.aspx.vb" Inherits="Login" Title="HumeAyu Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style5
        {
            height: 23px;
        }
        .style6
        {
        }
        .style7
        {
            height: 23px;
            width: 79px;
        }
        .style8
        {
            width: 167px;
        }
        .style9
        {
            height: 23px;
            width: 167px;
        }
        .style10
        {
            width: 529px;
        }
        .style11
        {
            height: 23px;
            width: 529px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width="100%" border="0" class="HomeBackground">
  <tr>
    <td class="style6" colspan="4">
        <asp:Image ID="ImgTitleLog" runat="server" 
            ImageUrl="~/Images/Title/Reg/Login.png" Height="55px" Width="358px"/>
      </td>
  </tr>
  <tr>
    <td class="style6">&nbsp;</td>
    <td class="style8">&nbsp;</td>
    <td class="style10">&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style6">&nbsp;</td>
    <td class="style8">UserName</td>
    <td class="style10">
        <asp:TextBox ID="txtUN" runat="server" Width="261px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorUN" runat="server" 
            ControlToValidate="txtUN" ErrorMessage="Username Can't be Blank">*</asp:RequiredFieldValidator>
      </td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style6" colspan="4">&nbsp;</td>
  </tr>
  <tr>
    <td class="style6">&nbsp;</td>
    <td class="style8">Password</td>
    <td class="style10">
        <asp:TextBox ID="txtPW" runat="server" Width="261px" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorPW" runat="server" 
            ControlToValidate="txtPW" ErrorMessage="Password Can't be Blank">*</asp:RequiredFieldValidator>
      </td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style6" colspan="4">&nbsp;</td>
  </tr>
  <tr>
    <td class="style7">&nbsp;</td>
    <td class="style9">User Type</td>
    <td class="style11">
        <asp:DropDownList ID="dpDwnType" runat="server" Height="20px" Width="261px">
            <asp:ListItem>===Select User Type====</asp:ListItem>
            <asp:ListItem>Doctor</asp:ListItem>
            <asp:ListItem>Patient</asp:ListItem>
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorUT" runat="server" 
            ControlToValidate="dpDwnType" ErrorMessage="User Type Can't be Blank">*</asp:RequiredFieldValidator>
      </td>
    <td class="style5"></td>
  </tr>
  <tr>
    <td class="style6">&nbsp;</td>
    <td class="style8">&nbsp;</td>
    <td class="style10">
        <asp:ValidationSummary ID="ValidationSummaryLogin" runat="server" Width="584px" 
            DisplayMode="List" ForeColor="Red" />
      </td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style6">&nbsp;</td>
    <td class="style8">&nbsp;</td>
    <td class="style10">
        <asp:Label ID="lblMsg" runat="server"></asp:Label>
      </td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style6">&nbsp;</td>
    <td class="style8">&nbsp;</td>
    <td class="style10">
        <asp:ImageButton ID="ImgbtnLogin" runat="server" Height="25px" 
            ImageUrl="~/Images/Buttons/Button_Reg/Loginmain.png" Width="102px" />
        <asp:ImageButton ID="ImgbtnClear" runat="server" Height="25px" 
            ImageUrl="~/Images/Buttons/Button_Comment/Clear.png" Width="102px" />
      </td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style6">&nbsp;</td>
    <td class="style8">&nbsp;</td>
    <td class="style10">&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style6">&nbsp;</td>
    <td class="style8">&nbsp;</td>
    <td class="style10">&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style6">&nbsp;</td>
    <td class="style8">&nbsp;</td>
    <td class="style10">&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style6">&nbsp;</td>
    <td class="style8">&nbsp;</td>
    <td class="style10">&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style6">&nbsp;</td>
    <td class="style8">&nbsp;</td>
    <td class="style10">&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style6">&nbsp;</td>
    <td class="style8">&nbsp;</td>
    <td class="style10">&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style6">&nbsp;</td>
    <td class="style8">&nbsp;</td>
    <td class="style10">&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style6">&nbsp;</td>
    <td class="style8">&nbsp;</td>
    <td class="style10">&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style6">&nbsp;</td>
    <td class="style8">&nbsp;</td>
    <td class="style10">&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
</table>
</asp:Content>

