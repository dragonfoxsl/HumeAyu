<%@ Page Title="View Channeling Schedule" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="ViewSchedule.aspx.vb" Inherits="ViewSchedule" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style5
        {
            width: 103px;
        }
        .style6
        {
            width: 251px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width="100%" border="0" class="HomeBackground">
  <tr>
    <td colspan="5" style="font-style:oblique; font-size:xx-large; font-family:Matura MT Script Capitals; color:Green">
    <asp:Label ID="lblTitle" runat="server" Text="View Scheduled Channeling Times"></asp:Label>
    </td>
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
    <td class="style6"></td>
    <td class="style5"  style="font-style:oblique; font-size:x-large; font-family:Matura MT Script Capitals; color:Green">
    <asp:Label ID="lblATime" runat="server" Text="Scheduled Times" Visible="false"></asp:Label>
      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style6">&nbsp;</td>
    <td class="style5">

      </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style6"></td>
    <td class="style5">
    <asp:GridView ID="gdviewATimes" runat="server" CellPadding="4" 
            Width="737px" AutoGenerateColumns="False" ForeColor="#333333" 
            GridLines="None" EnableModelValidation="True">
            <RowStyle BackColor="#EFF3FB" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="DID"  HeaderText="Doctor Name">
                <ItemStyle HorizontalAlign="Center" /></asp:BoundField>
                <asp:BoundField DataField="BDate"  HeaderText="Date">
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Time"  HeaderText="Time">
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Confirm"  HeaderText="Confirmed">
                <ItemStyle HorizontalAlign="Center" /></asp:BoundField>
            </Columns>
            </asp:GridView>
      </td>
    <td>
        &nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="style6">&nbsp;</td>
    <td class="style5"></td>
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

