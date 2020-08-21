<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Registration.aspx.vb" Inherits="Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .HomeBackground
        {
            background-image: url('Images/Background-Home.png');
        }
        .MenuBack
        {
            background-image: url('Images/Menu.png');
            background-position : center;
        }
        .BackHead
        {
            background-image: url('Images/Title/Title copy.png');
            background-position :center;
        }
        .style6
        {
            width: 4px;
        }
        .style8
        {
            height: 17px;
        }
        .style9
        {
            height: 406px;
        }
        .Position
        {
        	position:absolute;
            top: 336px;
            left: 478px;
            height: 155px;
            width: 209px;
        }
        .Position2
        {
        	position : absolute;
            top: 332px;
            left: 756px;
            height: 155px;
            width: 209px;
        }
        .Position3
        {
        	position : absolute;
            top: 415px;
            left: 599px;
        }
        .Position4
        {
        	position : absolute;
            top: 468px;
            left: 440px;
        }
        .Position5
        {
        	position : absolute;
            top: 468px;
            left: 722px;
            margin-top: 0px;
            margin-bottom: 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="HomeBackground">
&nbsp;<table width="100%" border="0">
  <tr>
    <td rowspan="7" class="style6">&nbsp;</td>
    <td colspan="7">&nbsp;</td>
  </tr>
  <tr>
    <td class="style8"></td>
    <td class="style8"></td>
    <td class="style8"></td>
    <td class="style8"></td>
    <td class="style8"></td>
    <td class="style8"></td>
    <td class="style8"></td>
  </tr>
  <tr>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td colspan="7" align="center" class="style9">
        <asp:ImageButton ID="ImgbtnDoc" runat="server" 
            ImageUrl="~/Images/Title/leaf2.png" CssClass="Position" />
        <asp:ImageButton ID="ImgbtnPa" runat="server" CssClass="Position2" 
            ImageUrl="~/Images/Title/leaf2.png" />
        <asp:Image ID="Image4" runat="server" CssClass="Position4" ImageUrl="~/Images/Title/Doctors.png"/>
        <asp:Image ID="Image1" runat="server" CssClass="Position5" ImageUrl="~/Images/Title/Patient.png"/>
      </td>
  </tr>
  <tr>
    <td>&nbsp;</td>
    <td colspan="5">&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td colspan="3">&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td colspan="7">&nbsp;</td>
  </tr>
</table>
</div>  
</asp:Content>

