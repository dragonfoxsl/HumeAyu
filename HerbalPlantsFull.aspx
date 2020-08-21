<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="HerbalPlantsFull.aspx.vb" Inherits="HerbalPlantsFull" title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style5
        {
        }
        .style6
        {
        }
        .style7
        {
            width: 652px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="HomeBackground">
<table width="100%" border="0">
  <tr>
    <td colspan="4" align="center">
        <asp:Image ID="myHeading2" runat="server" 
            ImageUrl="~/Images/Title/Herbal Plants/Medicine.png" Height="73px" 
            Width="420px" />
      </td>
  </tr>
  <tr>
    <td colspan="4">&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td colspan="2" align="center" style="font-size:larger">
        <asp:Label ID="lblPlantNme" runat="server"></asp:Label>
      </td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td class="style6">&nbsp;</td>
    <td class="style7">&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td class="style6">Plant Name</td>
    <td class="style7">
        <asp:Label ID="lblPNme" runat="server"></asp:Label>
      </td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td class="style6">&nbsp;</td>
    <td class="style7">&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td class="style6">Botnical Name</td>
    <td class="style7">
        <asp:Label ID="lblBNme" runat="server"></asp:Label>
      </td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td class="style6">&nbsp;</td>
    <td class="style7">&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td class="style6" valign="top">Description</td>
    <td class="style7" valign="top">
        <asp:TextBox ID="txtDescrip" runat="server" Height="135px" Width="500px" 
            ReadOnly="true" BorderStyle="None"></asp:TextBox>
      </td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td class="style6">&nbsp;</td>
    <td class="style7">&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5" colspan="4">&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td class="style6" colspan="2" align="center">
        <asp:Image ID="ImgPlant" runat="server" Height="250px" Width="250px"/>
      </td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td class="style6">&nbsp;</td>
    <td class="style7">&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td class="style6">&nbsp;</td>
    <td class="style7">&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td class="style6">&nbsp;</td>
    <td class="style7">&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td class="style6">&nbsp;</td>
    <td class="style7">&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5"></td>
    <td class="style6"></td>
    <td class="style7"></td>
    <td></td>
  </tr>
</table>
</div>
</asp:Content>

