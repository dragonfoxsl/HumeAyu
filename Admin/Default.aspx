<%@ Page Title="" Language="VB" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="Admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table width="100%" border="0" class="HomeBackground">
  <tr>
    <td class="style6" colspan="4" style="font-size:xx-large; font-family:Matura MT Script Capitals; font-style:oblique; color:Green">
            <asp:Label ID="lblAdmin" runat="server" Text="Administrator Login"></asp:Label>
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

