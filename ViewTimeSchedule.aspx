<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ViewTimeSchedule.aspx.vb" Inherits="ViewTimeSchedule" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Time Schedule</title>
    <style type="text/css">
        .style1
        {
            height: 19px;
        }
        .style2
        {
            height: 19px;
            width: 57px;
        }
        .style3
        {
            width: 57px;
        }
        .style4
        {
            height: 19px;
            width: 221px;
        }
        .style5
        {
            width: 221px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table width="100%" border="0" cellspacing="0" cellpadding="0">
      <tr>
        <td colspan="5" align="center" valign="top">
            <asp:Label ID="lblTitle" runat="server" Text="Channeling Time Schedule" 
                Font-Bold="True" Font-Underline="True" Font-Size="XX-Large"></asp:Label>
          </td>
      </tr>
      <tr>
        <td class="style2"></td>
        <td class="style1"></td>
        <td class="style4"></td>
        <td class="style1"></td>
        <td class="style1"></td>
      </tr>
      <tr>
        <td class="style3">&nbsp;</td>
        <td align="left" valign="top">&nbsp;</td>
        <td class="style5">
        <asp:Label ID="lblMsg" runat="server" Text="Select Date : " Font-Bold="true" Font-Italic="true"></asp:Label>
            <asp:Label ID="lblDate" runat="server" Text="" Font-Bold="true"></asp:Label>
            <br />
            <asp:Calendar ID="calDate" runat="server" BackColor="White" 
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
        <td align="left" valign="top">
            <asp:Label ID="lblSpace" runat="server" Text="" Font-Bold="true" Visible="false"></asp:Label>
            <br />
            <asp:GridView ID="gvTimeSchedule" runat="server" AutoGenerateColumns="False" 
                OnPageIndexChanging="gvTimeSchedule_PageIndexChanging" 
                OnRowCommand="gvTimeSchedule_RowCommand" CellPadding="4" ForeColor="#333333" 
                GridLines="None" Width="612px">
                <RowStyle BackColor="#EFF3FB" />
                <Columns>
                    <asp:BoundField DataField="ChannelingTime" HeaderText="Channeling Time">
                    <ItemStyle HorizontalAlign="Center" /></asp:BoundField>
                    <asp:BoundField DataField="NoPatients" HeaderText="No of Patients">
                    <ItemStyle HorizontalAlign="Center"/></asp:BoundField>
                    <asp:TemplateField>
                    <ItemTemplate>
                    <asp:Button ID="cmdDel" runat="server" Text="Delete" CommandArgument='<%# Eval("SID") %>' CommandName="delete" />
                    </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <EditRowStyle BackColor="#2461BF" />
                <AlternatingRowStyle BackColor="White" />
            </asp:GridView>
            <asp:Label ID="lblDelMsg" runat="server" Text=""></asp:Label>
          </td>
        <td>&nbsp;</td>
      </tr>
      <tr>
        <td class="style3">&nbsp;</td>
        <td>&nbsp;</td>
        <td class="style5">&nbsp;</td>
        <td>
            &nbsp;</td>
        <td>&nbsp;</td>
      </tr>
      <tr>
        <td colspan="5" align="center">

        </td>
      </tr>
      <tr>
        <td class="style3">&nbsp;</td>
        <td>&nbsp;</td>
        <td class="style5">
            <asp:Button ID="btnBack" runat="server" Text="Back" />
          </td>
        <td>
            &nbsp;</td>
        <td>&nbsp;</td>
      </tr>
      <tr>
        <td colspan="5">
            &nbsp;</td>
      </tr>
      <tr>
        <td class="style3">&nbsp;</td>
        <td>&nbsp;</td>
        <td class="style5">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
      </tr>
      <tr>
        <td class="style3">&nbsp;</td>
        <td>&nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
      </tr>
    </table>
    </div>
    </form>
</body>
</html>
