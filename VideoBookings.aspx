<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="VideoBookings.aspx.vb" Inherits="VideoBookings" title="Video Bookings Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style5
        {
            background-color: Transparent;
        }
        .style6
        {
            background-color: Transparent;
            width: 123px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width="100%" border="0" class="HomeBackground">
  <tr>
    <td colspan="5">
        <asp:Image ID="ImgTitleDReg" runat="server" 
            ImageUrl="~/Images/Title/Reg/VidCoon.png" Height="55px" Width="416px" />
    </td>
  </tr>
  <tr>
    <td class="style5" colspan="2">
        <asp:Label ID="lblDID" runat="server" Visible="false"></asp:Label>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5" colspan="3">Doctor Name : 
        <asp:Label ID="lblDNme" runat="server" Text="" Width="300px"></asp:Label>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5" colspan="2">&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5" colspan="2">Send a Video Conferance Request and Obtain a Specific 
        Time by your Doctor....</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5" colspan="2">&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style6">Select Date</td>
    <td class="style5" valign="top">
        <asp:TextBox ID="txtVideoCDate" runat="server" Width="150px"></asp:TextBox>
        <asp:ImageButton ID="ImgbtnCal" runat="server" 
            ImageUrl="~/Images/Buttons/Button_Reg/Calender.png" Height="23px" 
            Width="25px" />
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style6">&nbsp;</td>
    <td class="style5">
        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" 
            BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" 
            DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" 
            ForeColor="#003399" Height="200px" Width="220px">
            <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
            <WeekendDayStyle BackColor="#CCCCFF" />
            <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
            <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
            <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" 
                Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
        </asp:Calendar>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style6">&nbsp;</td>
    <td class="style5">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="txtVideoCDate" ErrorMessage="Select a Appropriate Date"></asp:RequiredFieldValidator>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5" colspan="2">
        &nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style6">Select a Time</td>
    <td class="style5">
        <asp:DropDownList ID="dpdwnTime" runat="server" Width="200px">
            <asp:ListItem>--Select--</asp:ListItem>
            <asp:ListItem>10:00 am - 11:00 am</asp:ListItem>
            <asp:ListItem>11:00 am - 12:00 pm</asp:ListItem>
            <asp:ListItem>12:00 pm - 01:00 pm</asp:ListItem>
            <asp:ListItem>02:00 pm - 03:00 pm</asp:ListItem>
            <asp:ListItem>03:00 pm - 04:00 pm</asp:ListItem>
            <asp:ListItem>04:00 pm - 05:00 pm</asp:ListItem>
            <asp:ListItem>06:00 pm - 07:00 pm</asp:ListItem>
            <asp:ListItem>07:00 pm - 08:00 pm</asp:ListItem>
            <asp:ListItem>After 08:00 pm</asp:ListItem>
        </asp:DropDownList>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style6">&nbsp;</td>
    <td class="style5">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="dpdwnTime" ErrorMessage="Select an Suitable Time"></asp:RequiredFieldValidator>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style6">Payment Method</td>
    <td class="style5">
    <asp:DropDownList ID="dpdwnPay" runat="server" Width="200px">
        <asp:ListItem>Cash</asp:ListItem>
        <asp:ListItem>Cheaque</asp:ListItem>
        <asp:ListItem>By_Phone</asp:ListItem>
        <asp:ListItem>Credit_Card</asp:ListItem>
        </asp:DropDownList>
    </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style6">&nbsp;</td>
    <td class="style5">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
            ControlToValidate="dpdwnPay" ErrorMessage="Select a Suitable Payment Method"></asp:RequiredFieldValidator>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style6">&nbsp;</td>
    <td class="style5">
        &nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style6">&nbsp;</td>
    <td class="style5">
        <asp:ImageButton ID="ImgbtnSelect" runat="server" 
            ImageUrl="~/Images/Buttons/Doctor/Select.png" Width="122px" Height="26px" />
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5" colspan="2">&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5" colspan="2">&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style5" colspan="2">&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  </table>
</asp:Content>

