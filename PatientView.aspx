<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="PatientView.aspx.vb" Inherits="PatientView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style5
        {
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="MyFont">
<table width="100%" border="0" class="HomeBackground">
  <tr>
    <td class="style5" colspan="2" style="font-size:xx-large; font-family:EuroRoman; font-style:normal; font-weight:bolder; color:Green" >
    Patient Details
    </td>
    <td colspan="2">
        &nbsp;</td>
  </tr>
  <tr>
    <td class="style5">
        &nbsp;</td>
    <td>
        &nbsp;</td>
    <td colspan="2">
        &nbsp;</td>
  </tr>
  <tr>
    <td class="style5">Patient ID</td>
    <td class="style11">
        <asp:TextBox ID="txtPID" runat="server" Visible="true"></asp:TextBox>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td class="style11">
        &nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">First Name</td>
    <td class="style11">
        <asp:TextBox ID="txtFNme" runat="server" Width="300px"></asp:TextBox>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td class="style11">
        &nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">Last Name</td>
    <td class="style11">
        <asp:TextBox ID="txtLNme" runat="server" Width="300px"></asp:TextBox>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td class="style11">
        &nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr valign="top">
    <td class="style5" valign="top">Address</td>
    <td valign="top" class="style11">
        <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine" Height="117px" 
            Width="298px"></asp:TextBox>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td class="style11">
        &nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">Email Address</td>
    <td class="style11">
        <asp:TextBox ID="txtEmail" runat="server" Width="300px"></asp:TextBox>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td class="style11">
        &nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">Contact No</td>
    <td class="style11">
        <asp:TextBox ID="txtTP" runat="server" Width="200px"></asp:TextBox>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td class="style11">
        &nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">Date of Birth</td>
    <td valign="bottom" class="style11">
        <asp:TextBox ID="txtDOB" runat="server" Width="200px"></asp:TextBox>
        &nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td class="style11">
        &nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">Date of Joined</td>
    <td class="style11">
        <asp:TextBox ID="txtDOJ" runat="server" Width="200px" ReadOnly="true"></asp:TextBox>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td class="style11">
        &nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td class="style11">
        &nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5" colspan="2">
        <asp:Label ID="lblUpdate" runat="server" Text="Video Conference Time" Visible="false"
        style="font-size:large; font-family:EuroRoman; font-style:normal; font-weight:bolder; color:Green"></asp:Label>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td class="style11">
        &nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">
        <asp:Label ID="lblTime" runat="server" Text="Time (hh:mm)" Visible="false"></asp:Label>
      </td>
    <td class="style11">
        <asp:TextBox ID="txtTime" runat="server" Visible="false"></asp:TextBox>
        <asp:DropDownList ID="dpdwnTime" runat="server" Visible="false">
            <asp:ListItem>am</asp:ListItem>
            <asp:ListItem>pm</asp:ListItem>
        </asp:DropDownList>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">
        <asp:Label ID="lblConfirm" runat="server" Text="Confirm" Visible="false"></asp:Label>
      </td>
    <td class="style11">
        <asp:CheckBox ID="chbConfirm" runat="server" Visible="false" Text=" "/>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5">&nbsp;</td>
    <td class="style11">
        &nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
    <tr>
    <td class="style5">&nbsp;</td>
    <td class="style11">
        <asp:ImageButton ID="ImgbtnSubmit" runat="server" Height="25px" 
            ImageUrl="~/Images/Buttons/Button_Comment/Send.png" Width="102px"  Visible="false"/>
        <asp:ImageButton ID="ImgbtnBack" runat="server" Height="25px"
            ImageUrl="~/Images/Buttons/Doctor/Back.png" Width="102px" Visible="false"/>
    </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
    <tr>
    <td class="style5">&nbsp;</td>
    <td class="style11">&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
    <tr>
    <td colspan="4">&nbsp;</td>
  </tr>
    </table>
</div>
</asp:Content>

