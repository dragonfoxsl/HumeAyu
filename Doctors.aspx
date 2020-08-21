<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Doctors.aspx.vb" Inherits="Doctors" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style5
        {
            width: 179px;
        }
        .style6
        {
        }
        .style7
        {
            width: 146px;
        }
        .style8
        {
            width: 677px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
<table width="100%" border="0" class="HomeBackground">
  <tr>
    <td colspan="4">
            <asp:Image ID="ImgTitleDReg" runat="server" 
            ImageUrl="~/Images/Title/Reg/DocDetails.png" Height="55px" Width="358px" />
    </td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td class="style7">&nbsp;</td>
    <td class="style8">
        <asp:Label ID="lblDID" runat="server" Text="" Visible="false"></asp:Label>
      </td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td align="center">
        &nbsp;</td>
    <td align="center">
        &nbsp;</td>
    <td align="left">
        <asp:Image ID="ImgDocImage" runat="server" Height="250px" Width="250px" />
      </td>
    <td align="center">
        &nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td class="style7">&nbsp;</td>
    <td class="style8">&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td class="style7">Doctor Name</td>
    <td class="style8">
        <asp:TextBox ID="txtDocNme" runat="server" Width="300px" ReadOnly="true" Enabled="false"></asp:TextBox>
      </td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td class="style7">&nbsp;</td>
    <td class="style8">&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td class="style7" valign="top">Qualifications</td>
    <td class="style8">
        <asp:TextBox ID="txtQuali" runat="server" Width="300px" Height="100px" ReadOnly="true" Enabled="false"></asp:TextBox>
      </td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td class="style7">&nbsp;</td>
    <td class="style8">&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5"></td>
    <td class="style7" valign="top">Experience</td>
    <td class="style8">
        <asp:TextBox ID="txtDocExp" runat="server" Width="300px" Height="100px" ReadOnly="true" Enabled="false"></asp:TextBox>
      </td>
    <td></td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td class="style7">&nbsp;</td>
    <td class="style8">&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td class="style7" valign="top">Specialization</td>
    <td class="style8">
        <asp:TextBox ID="txtDocSpe" runat="server" Width="300px" Height="100px" ReadOnly="true" Enabled="false"></asp:TextBox>
      </td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td class="style7">&nbsp;</td>
    <td class="style8">&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td style="font-style:oblique; font-size:xx-large; font-family:Blackadder ITC; color:Green" 
          class="style6" colspan="3" >Contact Details</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td class="style7">&nbsp;</td>
    <td class="style8">&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td class="style7">Email Address</td>
    <td class="style8">
        <asp:TextBox ID="txtDocEmail" runat="server" Width="300px" ReadOnly="true" Enabled="false"></asp:TextBox>
      </td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td class="style7">&nbsp;</td>
    <td class="style8">&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td class="style7">Contact Number</td>
    <td class="style8">
        <asp:TextBox ID="txtContactNo" runat="server" Width="300px" ReadOnly="true" Enabled="false"></asp:TextBox>
      </td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td class="style7">&nbsp;</td>
    <td class="style8">&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td class="style7" valign="top">Address</td>
    <td class="style8">
        <asp:TextBox ID="txtDocAdd" runat="server" Width="300px" Height="100px" ReadOnly="true" Enabled="false"></asp:TextBox>
      </td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td class="style7">&nbsp;</td>
    <td class="style8">&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td class="style7">&nbsp;</td>
    <td class="style8">
        <asp:ImageButton ID="ImgbtnChannel" runat="server" 
            ImageUrl="~/Images/Buttons/Doctor/Select.png" Height="30px" Width="135px"/>
        <asp:ImageButton ID="ImgbtnBack" runat="server" 
            ImageUrl="~/Images/Buttons/Doctor/Back.png" Height="30px" Width="135px"/>
      </td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td class="style7">&nbsp;</td>
    <td class="style8">&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td class="style7">&nbsp;</td>
    <td class="style8">
        <asp:ImageButton ID="ImgbtnVideo" runat="server" 
            ImageUrl="~/Images/Buttons/Doctor/VideoCnferance.png" Height="34px" 
            Width="264px"/>
      </td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td class="style7">&nbsp;</td>
    <td class="style8">&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
</table>
</div>
</asp:Content>

