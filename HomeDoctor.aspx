<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="HomeDoctor.aspx.vb" Inherits="HomeDoctor" title="Home Page" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>

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
        .HomeFooter
        {
	        background-image: url('/Images/Home/h1Footer.png');
        }
        .style7
        {
            width: 3px;
        }
        .style8
        {
            width: 452px;
            height: 346px;
            float: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="HomeBackground">
  <table width="100%" border="0">
  <tr>
    <td rowspan="5" class="style7">&nbsp;</td>
    <td>&nbsp;</td>
    <td colspan="2">&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td colspan="2">&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td colspan="2">&nbsp;</td>
    <td colspan="5" style="text-align: center">
        <img alt="" class="style8" src="Images/HomeMain/doc.jpg" />
        <asp:Label ID="lblDocMsg" runat="server" 
            style="position:absolute; top: 479px; left: 703px; color: #00CC00; font-weight: 700;"                  
            Text="Your Personalized Interface for Interacting with Patients<br />and Manging Your Account"></asp:Label>
      </td>
    <td colspan="2">&nbsp;</td>
  </tr>
  <tr>
    <td>&nbsp;</td>
    <td colspan="2">&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td colspan="2">&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td colspan="9">
        <asp:Image ID="ImgFooter" runat="server" ImageUrl="~/Images/Home/h1Footer.png" 
            Width="904px" Height="52px" meta:resourcekey="ImgFooterResource1" />
      </td>
  </tr>
  <tr>
    <td colspan="9">
        <asp:ImageButton ID="ImgbtnVidCon" runat="server" 
            ImageUrl="~/Images/Home/VidConF.png" Height="125px" Width="227px" 
            meta:resourcekey="ImageButton1Resource1"/>
        <asp:ImageButton ID="ImgbtnEditDoc" runat="server" 
            ImageUrl="~/Images/Home/EditPro.png" Height="125px" Width="235px" 
            meta:resourcekey="ImageButton2Resource1"/>
        <asp:ImageButton ID="ImgbtnVidS" runat="server" 
            ImageUrl="~/Images/Home/VidCon.png" Height="125px" Width="229px" 
            meta:resourcekey="ImageButton3Resource1"/>
        <asp:ImageButton ID="ImgbtnShedule" runat="server" 
            ImageUrl="~/Images/Home/ChaSch.png" Height="125px" Width="214px" 
            meta:resourcekey="ImageButton4Resource1"/>
      </td>
  </tr>
  </table>
  </div>
</asp:Content>

