<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="HomeUser.aspx.vb" Inherits="HomeUser" title="Home Page" %>

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
        .style5
        {
            width: 20px;
        }
        .style6
        {
            width: 137px;
        }
        .style8
        {
            width: 362px;
            height: 278px;
            position: absolute;
            top: 212px;
            left: 269px;
        }
        .style9
        {
            width: 792px;
            height: 328px;
        }
        .style10
        {
            width: 286px;
        }
        .style11
        {
            height: 328px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="HomeBackground">
  <table width="100%" border="0">
  <tr>
    <td rowspan="5" class="style5">&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td colspan="2">&nbsp;</td>
    <td class="style10">&nbsp;</td>
    <td colspan="2">&nbsp;</td>
    <td class="style6">&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td colspan="3" class="style11"></td>
    <td class="style9" colspan="3">&nbsp;&nbsp;
        <asp:Label 
            ID="lblDocMsg" runat="server" 
            style="position:absolute; top: 472px; left: 665px; color: #00CC00; font-weight: 700; width: 430px; text-align: center;"                  
            
            Text="Your Personalized Interface for Interacting with Doctors<br />and Manging Your Account"></asp:Label>
        <img alt="" class="style8" src="Images/HomeMain/family.jpg" /></td>
    <td colspan="3" class="style11"></td>
  </tr>
  <tr>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td colspan="2">&nbsp;</td>
    <td class="style10">&nbsp;</td>
    <td colspan="2">&nbsp;</td>
    <td class="style6">&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td colspan="9">
        <asp:Image ID="ImgFooter" runat="server" Height="52px" 
            ImageUrl="~/Images/Home/h1Footer.png" meta:resourcekey="ImgFooterResource1" 
            Width="904px" />
      </td>
  </tr>
  <tr>
    <td colspan="9">
        <asp:ImageButton ID="ImgbtnVConf" runat="server" 
            ImageUrl="~/Images/Home/VidConF.png" Height="125px" Width="227px" 
            meta:resourcekey="ImageButton1Resource1"/>
        <asp:ImageButton ID="ImgbtnEdit" runat="server" 
            ImageUrl="~/Images/Home/EditPro.png" Height="125px" Width="235px" 
            meta:resourcekey="ImageButton2Resource1"/>
        <asp:ImageButton ID="ImgbtnVidConfSchedule" runat="server" 
            ImageUrl="~/Images/Home/VidCon.png" Height="125px" Width="229px" 
            meta:resourcekey="ImageButton3Resource1"/>
        <asp:ImageButton ID="ImgbtnSchedule" runat="server" 
            ImageUrl="~/Images/Home/ChaSch.png" Height="125px" Width="214px" 
            meta:resourcekey="ImageButton4Resource1"/>
    </td>
  </tr>
  </table>
  </div>
</asp:Content>

