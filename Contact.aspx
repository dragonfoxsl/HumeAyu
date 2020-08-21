<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Contact.aspx.vb" Inherits="Contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .SmallTR1
        {
            width: 11px;
        }
        .SmallTR2
        {
            width: 148px;
        }
        .SmallTR3
        {
            width: 148px;
            height: 1px;
        }
        .SmallTR
        {
            height: 1px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="HomeBackground">
  <table width="100%" border="0">
  <tr>
    <td rowspan="11" class="SmallTR1">&nbsp;</td>
    <td colspan="7">
    <asp:Image ID="ImgTitleDReg" runat="server" 
            ImageUrl="~/Images/Title/Reg/Contact.png" Height="55px" Width="358px" />
    </td>
  </tr>
  <tr>
    <td class="SmallTR3"></td>
    <td class="SmallTR"></td>
    <td class="SmallTR"></td>
    <td class="SmallTR"></td>
    <td class="SmallTR"></td>
    <td class="SmallTR"></td>
    <td class="SmallTR"></td>
  </tr>
  <tr>
    <td class="SmallTR2">Name</td>
    <td>
        <asp:TextBox ID="txtCUser" runat="server" Width="390px"></asp:TextBox>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="SmallTR2">&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="SmallTR2">Email Address</td>
    <td>
        <asp:TextBox ID="txtCUEmail" runat="server" Width="390px"></asp:TextBox>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="SmallTR2">&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="SmallTR2" valign="top">Comments</td>
    <td>
        <asp:TextBox ID="txtComments" runat="server" Width="465px" TextMode="MultiLine" 
            Height="146px"></asp:TextBox>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="SmallTR2">&nbsp;</td>
    <td>
        <asp:Label ID="lblMsg" runat="server" Text="" Font-Bold="true"></asp:Label>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="SmallTR2">&nbsp;</td>
    <td>
        <asp:ImageButton ID="ImgbtnSend" runat="server" Height="25px" 
            ImageUrl="~/Images/Buttons/Button_Comment/Send.png" Width="102px" />
        <asp:ImageButton ID="ImgbtnClear" runat="server" 
            ImageUrl="~/Images/Buttons/Button_Comment/Clear.png" Height="25px" 
            Width="102px"/>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="SmallTR2">&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="SmallTR2">&nbsp;</td>
    <td>&nbsp;</td>
    <td colspan="5">&nbsp;</td>
  </tr>
  </table>
</div>  
</asp:Content>

