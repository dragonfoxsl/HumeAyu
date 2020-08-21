<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="FinalReg.aspx.vb" Inherits="FinalReg" title="Registration Success" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style5
        {
        }
        .style6
        {
            width: 95px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width="100%" border="0" class="HomeBackground">
  <tr>
    <td class="style6">&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td colspan="4" style="font-style:oblique; font-size:xx-large; font-family:Matura MT Script Capitals; color:Green">
    Registration Successfull
    </td>
  </tr>
  <tr>
    <td class="style6">&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td colspan="4">Registration to HumeAyu.com is Successfull....<br />
        A Comfermation Email has been sent to your E-mail Account</td>
  </tr>
  <tr>
    <td class="style6">&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style6" style="color:Red">User Name :</td>
    <td style="color:Red">
        <asp:Label ID="lblUN" runat="server" Text="" Width="200px"></asp:Label>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style6" style="color:Red">Password :</td>
    <td style="color:Red">
        <asp:Label ID="lblPW" runat="server" Text="" Width="200px"></asp:Label>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style6">&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5" colspan="4">Please Login to HumeAyu.com Using the Specific User Name and Password..........</td>
  </tr>
  <tr>
    <td class="style6">&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style6">&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  </table>
</asp:Content>

